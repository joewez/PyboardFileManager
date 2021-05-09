using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyboardFileManager
{
    public class PyboardRoutines
    {
        public string COMM_PORT = "";
        public int BAUD_RATE = 115200;

        private string _python_exe = "python";
        private string _command_prefix = "";

        public PyboardRoutines()
        {
            string[] ports = SerialPort.GetPortNames();

            List<string> goodPorts = new List<string>();
            string exclusions = ConfigurationManager.AppSettings["CommPortExclusions"];
            string[] nums = exclusions.Split(',');
            foreach (string port in ports)
            {
                bool excluded = false;
                foreach (string portnum in nums)
                {
                    if (port == "COM" + portnum)
                    {
                        excluded = true;
                        break;
                    }
                }
                if (!excluded)
                    goodPorts.Add(port);
            }

            COMM_PORT = ConfigurationManager.AppSettings["CommPort"];
            if (!String.IsNullOrEmpty(COMM_PORT))
            {
                bool found = false;
                foreach (string port in goodPorts)
                {
                    if (port == COMM_PORT)
                        found = true;
                }
                if (!found)
                {
                    SelectComForm s = new SelectComForm();
                    ((ComboBox)s.Controls["cboPorts"]).Items.Clear();
                    foreach (string port in goodPorts.OrderBy(g => Convert.ToInt32(g.Substring(3))).ToArray())
                        ((ComboBox)s.Controls["cboPorts"]).Items.Add(port);
                    s.ShowDialog();
                    COMM_PORT = s.SELECTED_COMM_PORT;
                    s.Dispose();
                }
            }
            else
            {
                if (goodPorts.Count() == 1)
                    COMM_PORT = goodPorts[0];
                else
                {
                    SelectComForm s = new SelectComForm();
                    ((ComboBox)s.Controls["cboPorts"]).Items.Clear();
                    foreach (string port in goodPorts.OrderBy(g => Convert.ToInt32(g.Substring(3))).ToArray())
                        ((ComboBox)s.Controls["cboPorts"]).Items.Add(port);
                    s.ShowDialog();
                    COMM_PORT = s.SELECTED_COMM_PORT;
                    s.Dispose();
                }
            }

            string baudratestr = ConfigurationManager.AppSettings["BaudRate"];
            if (baudratestr != "")
                BAUD_RATE = Convert.ToInt32(baudratestr);

            _command_prefix = "pyboard.py -d " + COMM_PORT + " -b " + BAUD_RATE.ToString() + " ";

            string pythonexestr = ConfigurationManager.AppSettings["PythonExe"];
            if (pythonexestr != "")
                _python_exe = pythonexestr;
        }

        public List<string> GetDir(string path, string LB, string RB)
        {
            List<string> dir = new List<string>();

            string workingpath = path;
            if (path.StartsWith("/"))
                workingpath = workingpath.Substring(1);

            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.WorkingDirectory = Application.StartupPath;
            p.StartInfo.FileName = _python_exe;
            p.StartInfo.Arguments = _command_prefix + "-f ls \"" + workingpath + "\"";
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            List<string> folders = new List<string>();
            List<string> files = new List<string>();

            string[] entries = output.Replace("\r\n", "\t").Split('\t');
            foreach (string entry in entries.ToList())
            {
                if (entry != "" && !entry.StartsWith("ls"))
                {
                    string nugget = entry.Trim();
                    if (nugget.EndsWith("/"))
                    {
                        nugget = nugget.Substring(0, nugget.Length - 1);
                        folders.Add(nugget.Substring(nugget.IndexOf(' ') + 1));
                    }
                    else
                        files.Add(nugget.Substring(nugget.IndexOf(' ') + 1));
                }
            }

            foreach (string folder in folders.OrderBy(f => f).ToList())
                dir.Add(LB + folder + RB);
            foreach (string file in files.OrderBy(f => f).ToList())
                dir.Add(file);

            return dir;
        }

        private void pyboardExecute(string command)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.WorkingDirectory = Application.StartupPath;
            p.StartInfo.FileName = _python_exe;
            p.StartInfo.Arguments = _command_prefix + command;
            p.Start();
            string errors = p.StandardError.ReadToEnd();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
        }

        public void GetFile(string pybfile, string localfile)
        {
            pyboardExecute("-f cp :" + pybfile + " \"" + localfile + "\"");
        }

        public void PutFile(string localfile, string pybfile)
        {
            pyboardExecute("-f cp \"" + localfile + "\" :" + pybfile);
        }

        public void DeleteFile(string pybfile)
        {
            pyboardExecute("-f rm " + pybfile);
        }

        public void CreateDir(string NewDirectory)
        {
            pyboardExecute("-f mkdir " + NewDirectory);
        }

        public void DeleteDir(string DirectoryToDelete)
        {
            pyboardExecute("-f rmdir " + DirectoryToDelete);
        }

        public void MoveFile(string SrcFile, string DestFile)
        {
            string tmpFile = Path.GetTempFileName();
            GetFile(SrcFile, tmpFile);
            DeleteFile(SrcFile);
            PutFile(tmpFile, DestFile);
        }

    }
}

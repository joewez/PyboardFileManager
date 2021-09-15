using ScintillaNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyboardFileManager
{
    public partial class Viewer : Form
    {

        public Viewer(string filename)
        {
            InitializeComponent();

            string LF = "\n";
            string CRLF = "\r\n";
            if (File.Exists(filename))
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    string contents = sr.ReadToEnd();
                    scintilla1.Text = contents.Replace(CRLF, LF);
                    scintilla1.ReadOnly = true;
                }
                this.Text = Path.GetFileName(filename);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyboardFileManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PyboardRoutines PYB = new PyboardRoutines();
            while (PYB.COMM_PORT == "")
            {
                MessageBox.Show("Must select the COM port your device is on.");
                PYB = new PyboardRoutines();
            }

            if (PYB.COMM_PORT != "EXIT")
                Application.Run(new frmMain(PYB));
        }
    }
}

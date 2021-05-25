using System;
using System.Windows.Forms;

namespace PyboardFileManager
{
    public partial class SelectComForm : Form
    {
        public string SELECTED_COMM_PORT = "EXIT";
        public bool DTR_ENABLED = false;

        public SelectComForm()
        {
            InitializeComponent();
        }

        private void SelectCom_Load(object sender, EventArgs e)
        {
            //cboPorts.Items.Clear();
            //string[] ports = SerialPort.GetPortNames().OrderBy(s => Convert.ToInt32(s.Substring(3))).ToArray();
            //foreach (string port in ports)
            //    cboPorts.Items.Add(port);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SELECTED_COMM_PORT = cboPorts.Text;
            DTR_ENABLED = chkDTREnabled.Checked;
            this.Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            if (Height == 161)
            {
                Height = 497;
            }
            else if (Height == 497)
            {
                Height = 161;
            }
        }
    }
}

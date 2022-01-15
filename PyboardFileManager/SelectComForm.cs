using System;
using System.Configuration;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
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

        private void SelectComForm_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["DarkMode"].Trim().ToUpper().StartsWith("Y"))
            {
                this.BackColor = SystemColors.ControlDark;
            }
            else
            {
                this.BackColor = SystemColors.Control;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SELECTED_COMM_PORT = cboPorts.Text;
            DTR_ENABLED = chkDTREnabled.Checked;
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshCommPortList();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            tmrRotatePicture.Enabled = false;
            this.Close();
        }

        private void RefreshCommPortList()
        {
            cboPorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames().OrderBy(s => Convert.ToInt32(s.Substring(3))).ToArray();
            foreach (string port in ports)
                cboPorts.Items.Add(port);
        }

        private void tmrRotatePicture_Tick(object sender, EventArgs e)
        {
            if (picESP8266.Visible)
            {
                picESP8266.Visible = false;
                picSTMicro.Visible = true;
                picRP2040.Visible = false;
            } else if (picSTMicro.Visible)
            {
                picESP8266.Visible = false;
                picSTMicro.Visible = false;
                picRP2040.Visible = true;
            }
            else if (picRP2040.Visible)
            {
                picESP8266.Visible = true;
                picSTMicro.Visible = false;
                picRP2040.Visible = false;
            }
        }

    }
}

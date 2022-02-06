using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyboardFileManager
{
    public partial class GetInputForm : Form
    {
        public GetInputForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtInputBox.Text = "";
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GetInputForm_Activated(object sender, EventArgs e)
        {
            txtInputBox.Focus();
            txtInputBox.SelectAll();
        }
    }
}

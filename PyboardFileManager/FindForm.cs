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
    public partial class FindForm : Form
    {
        public FindForm(string Target)
        {
            InitializeComponent();
            txtTarget.Text = Target;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

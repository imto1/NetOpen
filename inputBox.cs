using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace netopen
{
    public partial class inputBox : Form
    {
        public string inputValue { get; set; }
        public inputBox()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.inputValue = txtInput.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.inputValue = "";
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

using System;
using System.Windows.Forms;

namespace netopen
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.logging = chkLog.Checked;
            Properties.Settings.Default.send_mail = chkRequest.Checked;
            Properties.Settings.Default.email = txtEmail.Text;
            Properties.Settings.Default.password = txtPassword.Text;
            Properties.Settings.Default.mail_subject = txtMailSubject.Text;
            Properties.Settings.Default.mail_body = txtMailBody.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            chkLog.Checked = Properties.Settings.Default.logging;
            chkRequest.Checked = Properties.Settings.Default.send_mail;
            txtEmail.Text = Properties.Settings.Default.email;
            txtPassword.Text = Properties.Settings.Default.password;
            txtMailSubject.Text = Properties.Settings.Default.mail_subject;
            txtMailBody.Text = Properties.Settings.Default.mail_body;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;  

namespace netopen
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            txtAddress.Focus();
        }

        private void backslash_check()
        {
            try
            {
                if (txtAddress.Text.Substring(0, 1) != @"\")
                {
                    txtAddress.Text = @"\\" + txtAddress.Text;
                    txtAddress.SelectionStart = txtAddress.TextLength;
                    txtAddress.ScrollToCaret();
                }
                else if (txtAddress.Text.Substring(1, 1) != @"\")
                {
                    txtAddress.Text = @"\" + txtAddress.Text;
                    txtAddress.SelectionStart = txtAddress.TextLength;
                    txtAddress.ScrollToCaret();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                //
            }
        }

        private void format_spgc()
        {
            if (txtAddress.Text.Length == 1)
                if (txtAddress.Text.Substring(0, 1).ToUpper() != "B")
                {
                    txtAddress.Text = "B" + txtAddress.Text;
                    txtAddress.SelectionStart = txtAddress.TextLength;
                    txtAddress.ScrollToCaret();
                }
            if (txtAddress.Text.Length == 3){
                {
                    txtAddress.Text += "-SPGC";
                    txtAddress.SelectionStart = txtAddress.TextLength;
                    txtAddress.ScrollToCaret();
                }
            }

        }

        private void format_assa()
        {
            if (txtAddress.Text.Length == 2)
            {
                txtAddress.Text += "P-ASSA";
                txtAddress.SelectionStart = txtAddress.TextLength;
                txtAddress.ScrollToCaret();
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (format1.Checked)
                format_spgc();
            else if(format2.Checked)
                format_assa();
        }

        private bool access_check(String path)
        {
            //get directory info
            DirectoryInfo realpath = new DirectoryInfo(path);
            try
            {
                //if GetDirectories works then is accessible
                realpath.GetDirectories();
                return true;
            }
            catch (Exception)
            {
                //if exception is not accesible
                return false;
            }
        }

        private bool pingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = new Ping();
            try
            {
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            return pingable;
        }

        private String dash_check(String path){
            String clearpath = path.Replace(@"\\", "");
            String netpath = clearpath;
            if (pingHost(netpath))
                return path;
            else if(netpath.Contains("-"))
            {
                netpath = netpath.Replace("-", "_");
                if (pingHost(netpath))
                    return (@"\\" + netpath);
            }
            else
            {
                netpath = netpath.Replace("_", "-");
                if (pingHost(netpath))
                    return (@"\\" + netpath);
            }
            throw new PathTooLongException();
        }

        private void openPath(string path, Color color, string message)
        {
            try
            {
                lblStatus.Text = path;
                lblMessage.ForeColor = lblStatus.ForeColor = color;
                lblMessage.Text = message;
                txtAddress.Text = "";
                txtAddress.Focus();
                process.StartInfo.FileName = "explorer";
                process.StartInfo.Arguments = path;
                process.Start();
            }
            catch (Exception e)
            {
                lblMessage.Text = e.Message;
                lblMessage.ForeColor = Color.Red;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text != null && txtAddress.Text != "")
            {
                backslash_check();
                String path = txtAddress.Text;

                try
                {
                    path = dash_check(path);

                    if (openD.Checked)
                        path += @"\D$\";
                    else if (openDCopy.Checked)
                        path += @"\D$\Copy";
                    else if (openDesktop.Checked)
                    {
                        using (inputBox input = new inputBox())
                        {
                            DialogResult result = input.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                string pid = input.inputValue;
                                path += @"\C$\";
                                if (Directory.Exists(path + @"Users"))
                                    path += @"Users\" + pid + @"\Desktop";
                                else
                                    path += @"Documents and Settings\" + pid + @"\Desktop";
                            }
                            else
                                throw new Exception("Operation cancelled by user.");
                        }
                    }

                    if (access_check(path))
                    {
                        openPath(path, Color.Green, "Successful!");
                    }
                    else if(openD.Checked)
                    {
                        path = path.Replace("D","E");
                        if (access_check(path))
                        {
                            openPath(path, Color.Olive, "Can't fing D: drive! Openning E: instead!");
                        }
                        else
                        {
                            lblStatus.Text = "Path not found!";
                            lblMessage.Text = "Check the address!";
                            lblMessage.ForeColor = lblStatus.ForeColor = Color.Red;
                        }
                    }
                    else if(openDCopy.Checked)
                    {
                        try
                        {
                            if (!Directory.Exists(path))
                                Directory.CreateDirectory(path);
                        }
                        catch
                        {
                            path = path.Replace("D", "E");
                            if (!Directory.Exists(path))
                                Directory.CreateDirectory(path);
                        }
                        finally
                        {
                            if (access_check(path))
                            {
                                openPath(path, Color.Olive, "Can't fing D: drive! Openning E: instead!");
                            }
                            else
                            {
                                lblStatus.Text = "Path not found!";
                                lblMessage.Text = "Check the address!";
                                lblMessage.ForeColor = lblStatus.ForeColor = Color.Red;
                            }
                        }
                    }
                    else
                    {
                        lblStatus.Text = "Path not found!";
                        lblMessage.Text = "Check the address!";
                        lblMessage.ForeColor = lblStatus.ForeColor = Color.Red;
                    }
                }
                catch (PathTooLongException)
                {
                    lblStatus.Text = "Unreacable!";
                    lblMessage.Text = "Remote computer is out of reach!";
                    lblMessage.ForeColor = lblStatus.ForeColor = Color.Red;
                }
                catch (Exception ex)
                {
                    lblMessage.Text = ex.Message;
                    lblMessage.ForeColor = Color.Red;
                }
            }
            else if (lblStatus.Text != null && lblStatus.Text != "" && access_check(lblStatus.Text))
            {
                String path = lblStatus.Text;
                txtAddress.Focus();
                process.StartInfo.FileName = "explorer";
                process.StartInfo.Arguments = path;
                process.Start();
            }
            else
            {
                lblStatus.Text = "Empty address!";
                lblMessage.Text = "Insert remote computer's address!";
                lblMessage.ForeColor = lblStatus.ForeColor = Color.Red;
            }
        }

        private void openDesktop_CheckedChanged(object sender, EventArgs e)
        {
            txtAddress.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            format1.Checked = true;
            openDCopy.Checked = true;
            lblStatus.Text = "Ready";
            lblMessage.Text = "";
            lblMessage.ForeColor = lblStatus.ForeColor = Color.Black;
            txtAddress.Focus();
        }

        private void format1_CheckedChanged(object sender, EventArgs e)
        {
            txtAddress.Focus();
        }

        private void format2_CheckedChanged(object sender, EventArgs e)
        {
            txtAddress.Focus();
        }

        private void format3_CheckedChanged(object sender, EventArgs e)
        {
            txtAddress.Focus();
        }

        private void openD_CheckedChanged(object sender, EventArgs e)
        {
            txtAddress.Focus();
        }

        private void openDCopy_CheckedChanged(object sender, EventArgs e)
        {
            txtAddress.Focus();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string[] version = Application.ProductVersion.ToString().Split('.');
            lblTitle.Text += " v" + version[0] + "." + version[1];
        }

        private void llblProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            process.StartInfo = new System.Diagnostics.ProcessStartInfo("https://www.instagram.com/s_vahid_h/");
            process.Start();
        }
    }
}

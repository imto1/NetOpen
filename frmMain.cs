using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;

namespace netopen
{
    public partial class frmMain : Form
    {
        int openCount = 0;
        String workTime = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() +
                DateTime.Now.Day.ToString();
        String userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        String userHome = "";
        String countFile = "";
        String logFile = "";
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Shown(object sender, EventArgs e) => txtAddress.Focus();

        private void frmMain_Load(object sender, EventArgs e)
        {
            string[] version = Application.ProductVersion.ToString().Split('.');
            lblTitle.Text += " v" + version[0] + "." + version[1] + "." + version[2];

            chkLog.Checked = Properties.Settings.Default.logging;
            int index = userName.LastIndexOf('\\') + 1;
            userName = userName.Substring(index, userName.Length - (index));
            userHome = @"c:\users\" + userName + @"\desktop\";
            countFile = userHome + workTime + "-count.log";
            if (File.Exists(countFile))
                openCount = Convert.ToInt32(File.ReadAllText(countFile));
            lblCount.Text = Convert.ToString(openCount);
            logFile = userHome + workTime + ".log";
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(chkLog.Checked)
                File.WriteAllText(countFile, Convert.ToString(openCount));
        }

        private void log(String text)
        {
            if (chkLog.Checked)
            {
                String now = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() +
                    DateTime.Now.Day.ToString();
                if (workTime != now)
                {
                    workTime = now;
                    openCount = 0;
                    logFile = userHome + workTime + ".log";
                }
                File.AppendAllText(logFile, text + "\n");
                lblCount.Text = Convert.ToString(++openCount);
                File.WriteAllText(countFile, Convert.ToString(openCount));
            }
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

        private void format_hq()
        {
            if (txtAddress.Text.Length == 1)
                if (txtAddress.Text.Substring(0, 1).ToUpper() != "H")
                {
                    txtAddress.Text = "HQ-5WST-" + txtAddress.Text;
                    txtAddress.SelectionStart = txtAddress.TextLength;
                    txtAddress.ScrollToCaret();
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
            if (txtAddress.Text.Length == 3)
            {
                txtAddress.Text += "-SPGC";
                txtAddress.SelectionStart = txtAddress.TextLength;
                txtAddress.ScrollToCaret();
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
            if (format0.Checked)
                format_hq();
            else if (format1.Checked)
                format_spgc();
            else if (format2.Checked)
                format_assa();
        }

        private bool access_check(String path)
        {
            DirectoryInfo realpath = new DirectoryInfo(path);
            try
            {
                realpath.GetDirectories();
                return true;
            }
            catch (Exception)
            {
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
            catch (PingException){}

            return pingable;
        }

        private String dash_check(String path)
        {
            String netpath = path.Replace(@"\\", "");
            
            if (pingHost(netpath))
                return path;
            else if (netpath.Contains("-") && !format0.Checked)
            {
                netpath = netpath.Replace("-", "_");
                if (pingHost(netpath))
                    return (@"\\" + netpath);
            }
            else if(netpath.Contains("_"))
            {
                netpath = netpath.Replace("_", "-");
                if (pingHost(netpath))
                    return (@"\\" + netpath);
            } else if (format0.Checked)
                return hq_check(path);

            throw new PathTooLongException();
        }

        private String hq_check(String path)
        {
            String netpath = path.Replace(@"\\", "");

            if (pingHost(netpath))
                return path;
            else
            {
                String[] pathPart = netpath.Split('-');
                if (!pathPart[2].Substring(0, 1).Equals("0"))
                {
                    int maskLen = 4 - pathPart[2].Length;
                    for (int i = 0; i < maskLen; i++)
                        pathPart[2] = "0" + pathPart[2];
                    netpath = pathPart[0] + "-" + pathPart[1] + "-" + pathPart[2];
                }
                else
                {
                    while(pathPart[2].Substring(0, 1).Equals("0"))
                        pathPart[2] = pathPart[2].Remove(0, 1);
                    netpath = pathPart[0] + "-" + pathPart[1] + "-" + pathPart[2];
                }

                if(pingHost(netpath))
                    return (@"\\" + netpath);
                else
                    return thq_check(netpath);
            }
        }

        private String thq_check(String path)
        {
            String netpath = path;
            if (!netpath.Substring(0, 1).ToUpper().Equals("T"))
                netpath = "T" + netpath;
            else
                throw new PathTooLongException();

            if (pingHost(netpath))
                return (@"\\" + netpath);
            else
            {
                String[] pathPart = netpath.Split('-');
                if (!pathPart[2].Substring(0, 1).Equals("0"))
                {
                    int maskLen = 4 - pathPart[2].Length;
                    for (int i = 0; i < maskLen; i++)
                        pathPart[2] = "0" + pathPart[2];
                    netpath = pathPart[0] + "-" + pathPart[1] + "-" + pathPart[2];
                    return (@"\\" + netpath);
                }
                else
                {
                    while (pathPart[2].Substring(0, 1).Equals("0"))
                        pathPart[2] = pathPart[2].Remove(0, 1);
                    netpath = pathPart[0] + "-" + pathPart[1] + "-" + pathPart[2];
                    return (@"\\" + netpath);
                }
                throw new PathTooLongException();
            }
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
                log(path);
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
                    else if (openD.Checked)
                    {
                        path = path.Replace("D", "E");
                        if (access_check(path))
                        {
                            openPath(path, Color.Olive, "Can't find D: drive! Openning E: instead!");
                        }
                        else
                        {
                            lblStatus.Text = "Path not found!";
                            lblMessage.Text = "Check the network address!";
                            lblMessage.ForeColor = lblStatus.ForeColor = Color.Red;
                        }
                    }
                    else if (openDCopy.Checked)
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
                                openPath(path, Color.Olive, "Can't find D: drive! Openning E: instead!");
                            }
                            else
                            {
                                lblStatus.Text = "Path not found!";
                                lblMessage.Text = "Check the network address!";
                                lblMessage.ForeColor = lblStatus.ForeColor = Color.Red;
                            }
                        }
                    }
                    else
                    {
                        lblStatus.Text = "Path not found!";
                        lblMessage.Text = "Check the network address!";
                        lblMessage.ForeColor = lblStatus.ForeColor = Color.Red;
                    }
                }
                catch (PathTooLongException)
                {
                    lblStatus.Text = "Unreacable!";
                    lblMessage.Text = "Pinging network address failed!";
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
                log(path);
            }
            else
            {
                lblStatus.Text = "Empty address!";
                lblMessage.Text = "Insert the network address!";
                lblMessage.ForeColor = lblStatus.ForeColor = Color.Red;
            }
        }

        private void openDesktop_CheckedChanged(object sender, EventArgs e) => txtAddress.Focus();

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

        private void format1_CheckedChanged(object sender, EventArgs e) => txtAddress.Focus();

        private void format2_CheckedChanged(object sender, EventArgs e) => txtAddress.Focus();

        private void format3_CheckedChanged(object sender, EventArgs e) => txtAddress.Focus();

        private void openD_CheckedChanged(object sender, EventArgs e) => txtAddress.Focus();

        private void openDCopy_CheckedChanged(object sender, EventArgs e) =>  txtAddress.Focus();

        private void PbIcon_Click(object sender, EventArgs e) => 
            MessageBox.Show("Author: S. Vahid Hosseini. s.vahid.h@pm.me", "About",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void Format0_CheckedChanged(object sender, EventArgs e) => txtAddress.Focus();

        private void chkLog_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.logging = chkLog.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
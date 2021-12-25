namespace netopen
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.format1 = new System.Windows.Forms.RadioButton();
            this.format2 = new System.Windows.Forms.RadioButton();
            this.format3 = new System.Windows.Forms.RadioButton();
            this.gbPath = new System.Windows.Forms.GroupBox();
            this.openDesktop = new System.Windows.Forms.RadioButton();
            this.openDCopy = new System.Windows.Forms.RadioButton();
            this.openD = new System.Windows.Forms.RadioButton();
            this.gbAF = new System.Windows.Forms.GroupBox();
            this.format0 = new System.Windows.Forms.RadioButton();
            this.lblAddress = new System.Windows.Forms.Label();
            this.process = new System.Diagnostics.Process();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.bpBar = new System.Windows.Forms.PictureBox();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.chkLog = new System.Windows.Forms.CheckBox();
            this.gbPath.SuspendLayout();
            this.gbAF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(69, 57);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(147, 22);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(222, 57);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(23, 23);
            this.btnOpen.TabIndex = 9;
            this.btnOpen.Text = "√";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(56, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(72, 20);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "NetOpen";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(56, 29);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(38, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Ready";
            // 
            // format1
            // 
            this.format1.AutoSize = true;
            this.format1.Checked = true;
            this.format1.Location = new System.Drawing.Point(6, 44);
            this.format1.Name = "format1";
            this.format1.Size = new System.Drawing.Size(92, 17);
            this.format1.TabIndex = 3;
            this.format1.TabStop = true;
            this.format1.Text = "&B??-SPGC????";
            this.format1.UseVisualStyleBackColor = true;
            this.format1.CheckedChanged += new System.EventHandler(this.format1_CheckedChanged);
            // 
            // format2
            // 
            this.format2.AutoSize = true;
            this.format2.Location = new System.Drawing.Point(6, 67);
            this.format2.Name = "format2";
            this.format2.Size = new System.Drawing.Size(87, 17);
            this.format2.TabIndex = 4;
            this.format2.Text = "0?&P-ASSA???";
            this.format2.UseVisualStyleBackColor = true;
            this.format2.CheckedChanged += new System.EventHandler(this.format2_CheckedChanged);
            // 
            // format3
            // 
            this.format3.AutoSize = true;
            this.format3.Location = new System.Drawing.Point(6, 90);
            this.format3.Name = "format3";
            this.format3.Size = new System.Drawing.Size(97, 17);
            this.format3.TabIndex = 5;
            this.format3.Text = "&Other formats";
            this.format3.UseVisualStyleBackColor = true;
            this.format3.CheckedChanged += new System.EventHandler(this.format3_CheckedChanged);
            // 
            // gbPath
            // 
            this.gbPath.Controls.Add(this.openDesktop);
            this.gbPath.Controls.Add(this.openDCopy);
            this.gbPath.Controls.Add(this.openD);
            this.gbPath.Location = new System.Drawing.Point(144, 104);
            this.gbPath.Name = "gbPath";
            this.gbPath.Size = new System.Drawing.Size(128, 92);
            this.gbPath.TabIndex = 12;
            this.gbPath.TabStop = false;
            this.gbPath.Text = "Open at";
            // 
            // openDesktop
            // 
            this.openDesktop.AutoSize = true;
            this.openDesktop.Location = new System.Drawing.Point(6, 67);
            this.openDesktop.Name = "openDesktop";
            this.openDesktop.Size = new System.Drawing.Size(68, 17);
            this.openDesktop.TabIndex = 8;
            this.openDesktop.Text = "Desk&top";
            this.openDesktop.UseVisualStyleBackColor = true;
            this.openDesktop.CheckedChanged += new System.EventHandler(this.openDesktop_CheckedChanged);
            // 
            // openDCopy
            // 
            this.openDCopy.AutoSize = true;
            this.openDCopy.Checked = true;
            this.openDCopy.Location = new System.Drawing.Point(6, 44);
            this.openDCopy.Name = "openDCopy";
            this.openDCopy.Size = new System.Drawing.Size(66, 17);
            this.openDCopy.TabIndex = 7;
            this.openDCopy.TabStop = true;
            this.openDCopy.Text = "D:\\&Copy";
            this.openDCopy.UseVisualStyleBackColor = true;
            this.openDCopy.CheckedChanged += new System.EventHandler(this.openDCopy_CheckedChanged);
            // 
            // openD
            // 
            this.openD.AutoSize = true;
            this.openD.Location = new System.Drawing.Point(6, 21);
            this.openD.Name = "openD";
            this.openD.Size = new System.Drawing.Size(40, 17);
            this.openD.TabIndex = 6;
            this.openD.Text = "&D:\\";
            this.openD.UseVisualStyleBackColor = true;
            this.openD.CheckedChanged += new System.EventHandler(this.openD_CheckedChanged);
            // 
            // gbAF
            // 
            this.gbAF.Controls.Add(this.format0);
            this.gbAF.Controls.Add(this.format1);
            this.gbAF.Controls.Add(this.format2);
            this.gbAF.Controls.Add(this.format3);
            this.gbAF.Location = new System.Drawing.Point(12, 104);
            this.gbAF.Name = "gbAF";
            this.gbAF.Size = new System.Drawing.Size(126, 115);
            this.gbAF.TabIndex = 11;
            this.gbAF.TabStop = false;
            this.gbAF.Text = "Address format";
            // 
            // format0
            // 
            this.format0.AutoSize = true;
            this.format0.Location = new System.Drawing.Point(6, 21);
            this.format0.Name = "format0";
            this.format0.Size = new System.Drawing.Size(98, 17);
            this.format0.TabIndex = 6;
            this.format0.Text = "&HQ-5WST-????";
            this.format0.UseVisualStyleBackColor = true;
            this.format0.CheckedChanged += new System.EventHandler(this.Format0_CheckedChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 60);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 13);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Address:";
            // 
            // process
            // 
            this.process.StartInfo.Domain = "";
            this.process.StartInfo.LoadUserProfile = false;
            this.process.StartInfo.Password = null;
            this.process.StartInfo.StandardErrorEncoding = null;
            this.process.StartInfo.StandardOutputEncoding = null;
            this.process.StartInfo.UserName = "";
            this.process.SynchronizingObject = this;
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(251, 57);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(23, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "←";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.SystemColors.Control;
            this.lblMessage.Location = new System.Drawing.Point(12, 88);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 17;
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.White;
            this.pbIcon.BackgroundImage = global::netopen.Properties.Resources.if_network_transmit_118952;
            this.pbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbIcon.Location = new System.Drawing.Point(0, 0);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(50, 50);
            this.pbIcon.TabIndex = 14;
            this.pbIcon.TabStop = false;
            this.pbIcon.Click += new System.EventHandler(this.PbIcon_Click);
            // 
            // bpBar
            // 
            this.bpBar.BackColor = System.Drawing.Color.Black;
            this.bpBar.Location = new System.Drawing.Point(0, 50);
            this.bpBar.Name = "bpBar";
            this.bpBar.Size = new System.Drawing.Size(300, 1);
            this.bpBar.TabIndex = 1;
            this.bpBar.TabStop = false;
            // 
            // pbHeader
            // 
            this.pbHeader.BackColor = System.Drawing.Color.White;
            this.pbHeader.Location = new System.Drawing.Point(0, 0);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(300, 50);
            this.pbHeader.TabIndex = 0;
            this.pbHeader.TabStop = false;
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(225, 199);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(49, 23);
            this.lblCount.TabIndex = 18;
            this.lblCount.Text = "0";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chkLog
            // 
            this.chkLog.AutoSize = true;
            this.chkLog.Checked = true;
            this.chkLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLog.Location = new System.Drawing.Point(145, 202);
            this.chkLog.Name = "chkLog";
            this.chkLog.Size = new System.Drawing.Size(74, 17);
            this.chkLog.TabIndex = 19;
            this.chkLog.Text = "Save logs";
            this.chkLog.UseVisualStyleBackColor = true;
            this.chkLog.CheckedChanged += new System.EventHandler(this.chkLog_CheckedChanged);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnOpen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(284, 231);
            this.Controls.Add(this.chkLog);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.gbAF);
            this.Controls.Add(this.gbPath);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.bpBar);
            this.Controls.Add(this.pbHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 270);
            this.MinimumSize = new System.Drawing.Size(280, 270);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetOpen";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.gbPath.ResumeLayout(false);
            this.gbPath.PerformLayout();
            this.gbAF.ResumeLayout(false);
            this.gbAF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHeader;
        private System.Windows.Forms.PictureBox bpBar;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton format1;
        private System.Windows.Forms.RadioButton format2;
        private System.Windows.Forms.RadioButton format3;
        private System.Windows.Forms.GroupBox gbPath;
        private System.Windows.Forms.RadioButton openD;
        private System.Windows.Forms.RadioButton openDCopy;
        private System.Windows.Forms.GroupBox gbAF;
        private System.Windows.Forms.RadioButton openDesktop;
        private System.Windows.Forms.Label lblAddress;
        private System.Diagnostics.Process process;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.RadioButton format0;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.CheckBox chkLog;
    }
}


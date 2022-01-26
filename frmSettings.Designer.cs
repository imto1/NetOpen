namespace netopen
{
    partial class frmSettings
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
            this.chkLog = new System.Windows.Forms.CheckBox();
            this.chkRequest = new System.Windows.Forms.CheckBox();
            this.gbRequest = new System.Windows.Forms.GroupBox();
            this.txtMailBody = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMailSubject = new System.Windows.Forms.TextBox();
            this.lblMailSubject = new System.Windows.Forms.Label();
            this.lblMailBody = new System.Windows.Forms.Label();
            this.gbRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkLog
            // 
            this.chkLog.AutoSize = true;
            this.chkLog.Location = new System.Drawing.Point(12, 12);
            this.chkLog.Name = "chkLog";
            this.chkLog.Size = new System.Drawing.Size(73, 17);
            this.chkLog.TabIndex = 20;
            this.chkLog.Text = "Save logs";
            this.chkLog.UseVisualStyleBackColor = true;
            // 
            // chkRequest
            // 
            this.chkRequest.AutoSize = true;
            this.chkRequest.Location = new System.Drawing.Point(6, 19);
            this.chkRequest.Name = "chkRequest";
            this.chkRequest.Size = new System.Drawing.Size(83, 17);
            this.chkRequest.TabIndex = 21;
            this.chkRequest.Text = "Add request";
            this.chkRequest.UseVisualStyleBackColor = true;
            // 
            // gbRequest
            // 
            this.gbRequest.Controls.Add(this.lblMailBody);
            this.gbRequest.Controls.Add(this.lblMailSubject);
            this.gbRequest.Controls.Add(this.txtMailSubject);
            this.gbRequest.Controls.Add(this.txtMailBody);
            this.gbRequest.Controls.Add(this.txtPassword);
            this.gbRequest.Controls.Add(this.txtEmail);
            this.gbRequest.Controls.Add(this.lblPassword);
            this.gbRequest.Controls.Add(this.lblEmail);
            this.gbRequest.Controls.Add(this.chkRequest);
            this.gbRequest.Location = new System.Drawing.Point(12, 35);
            this.gbRequest.Name = "gbRequest";
            this.gbRequest.Size = new System.Drawing.Size(260, 235);
            this.gbRequest.TabIndex = 22;
            this.gbRequest.TabStop = false;
            this.gbRequest.Text = "Servicedesk Request";
            // 
            // txtMailBody
            // 
            this.txtMailBody.Location = new System.Drawing.Point(6, 139);
            this.txtMailBody.Multiline = true;
            this.txtMailBody.Name = "txtMailBody";
            this.txtMailBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMailBody.Size = new System.Drawing.Size(248, 90);
            this.txtMailBody.TabIndex = 26;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(68, 69);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(186, 20);
            this.txtPassword.TabIndex = 25;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(68, 42);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 72);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 45);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "eMail:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 276);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 23;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(197, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMailSubject
            // 
            this.txtMailSubject.Location = new System.Drawing.Point(68, 95);
            this.txtMailSubject.Name = "txtMailSubject";
            this.txtMailSubject.Size = new System.Drawing.Size(186, 20);
            this.txtMailSubject.TabIndex = 27;
            // 
            // lblMailSubject
            // 
            this.lblMailSubject.AutoSize = true;
            this.lblMailSubject.Location = new System.Drawing.Point(6, 98);
            this.lblMailSubject.Name = "lblMailSubject";
            this.lblMailSubject.Size = new System.Drawing.Size(46, 13);
            this.lblMailSubject.TabIndex = 28;
            this.lblMailSubject.Text = "Subject:";
            // 
            // lblMailBody
            // 
            this.lblMailBody.AutoSize = true;
            this.lblMailBody.Location = new System.Drawing.Point(6, 123);
            this.lblMailBody.Name = "lblMailBody";
            this.lblMailBody.Size = new System.Drawing.Size(34, 13);
            this.lblMailBody.TabIndex = 29;
            this.lblMailBody.Text = "Body:";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbRequest);
            this.Controls.Add(this.chkLog);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 350);
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.gbRequest.ResumeLayout(false);
            this.gbRequest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkLog;
        private System.Windows.Forms.CheckBox chkRequest;
        private System.Windows.Forms.GroupBox gbRequest;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtMailBody;
        private System.Windows.Forms.Label lblMailBody;
        private System.Windows.Forms.Label lblMailSubject;
        private System.Windows.Forms.TextBox txtMailSubject;
    }
}
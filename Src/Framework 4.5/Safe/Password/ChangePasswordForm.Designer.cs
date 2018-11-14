namespace EdlinSoftware.Safe.Password
{
	partial class ChangePasswordForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblNewPrompt;
            System.Windows.Forms.Label lblPrompt;
            System.Windows.Forms.Label lblNewCopyPrompt;
            System.Windows.Forms.Label lblPasswordPrompt;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.tbNewPasswordCopy = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tbPasswordPrompt = new System.Windows.Forms.TextBox();
            lblNewPrompt = new System.Windows.Forms.Label();
            lblPrompt = new System.Windows.Forms.Label();
            lblNewCopyPrompt = new System.Windows.Forms.Label();
            lblPasswordPrompt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewPrompt
            // 
            lblNewPrompt.AutoSize = true;
            lblNewPrompt.Location = new System.Drawing.Point(12, 52);
            lblNewPrompt.Name = "lblNewPrompt";
            lblNewPrompt.Size = new System.Drawing.Size(182, 13);
            lblNewPrompt.TabIndex = 14;
            lblNewPrompt.Text = "Enter new password for your storage:";
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new System.Drawing.Point(12, 11);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new System.Drawing.Size(195, 13);
            lblPrompt.TabIndex = 10;
            lblPrompt.Text = "Enter current password for your storage:";
            // 
            // lblNewCopyPrompt
            // 
            lblNewCopyPrompt.AutoSize = true;
            lblNewCopyPrompt.Location = new System.Drawing.Point(12, 95);
            lblNewCopyPrompt.Name = "lblNewCopyPrompt";
            lblNewCopyPrompt.Size = new System.Drawing.Size(198, 13);
            lblNewCopyPrompt.TabIndex = 16;
            lblNewCopyPrompt.Text = "Re-enter new password for your storage:";
            // 
            // lblPasswordPrompt
            // 
            lblPasswordPrompt.AutoSize = true;
            lblPasswordPrompt.Location = new System.Drawing.Point(12, 141);
            lblPasswordPrompt.Name = "lblPasswordPrompt";
            lblPasswordPrompt.Size = new System.Drawing.Size(118, 13);
            lblPasswordPrompt.TabIndex = 17;
            lblPasswordPrompt.Text = "Enter password prompt:";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewPassword.Location = new System.Drawing.Point(12, 70);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '*';
            this.tbNewPassword.Size = new System.Drawing.Size(260, 20);
            this.tbNewPassword.TabIndex = 1;
            this.toolTip.SetToolTip(this.tbNewPassword, "Enter new password for your storage.");
            this.tbNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbNewPassword_Validating);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(131, 234);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(212, 234);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOldPassword.Location = new System.Drawing.Point(12, 27);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.PasswordChar = '*';
            this.tbOldPassword.Size = new System.Drawing.Size(260, 20);
            this.tbOldPassword.TabIndex = 0;
            this.toolTip.SetToolTip(this.tbOldPassword, "Enter current password for your storage.");
            this.tbOldPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbOldPassword_Validating);
            // 
            // tbNewPasswordCopy
            // 
            this.tbNewPasswordCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewPasswordCopy.Location = new System.Drawing.Point(12, 113);
            this.tbNewPasswordCopy.Name = "tbNewPasswordCopy";
            this.tbNewPasswordCopy.PasswordChar = '*';
            this.tbNewPasswordCopy.Size = new System.Drawing.Size(260, 20);
            this.tbNewPasswordCopy.TabIndex = 2;
            this.toolTip.SetToolTip(this.tbNewPasswordCopy, "Re-enter new password for your storage.");
            this.tbNewPasswordCopy.Validating += new System.ComponentModel.CancelEventHandler(this.tbNewPasswordCopy_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // tbPasswordPrompt
            // 
            this.tbPasswordPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPasswordPrompt.Location = new System.Drawing.Point(12, 157);
            this.tbPasswordPrompt.Multiline = true;
            this.tbPasswordPrompt.Name = "tbPasswordPrompt";
            this.tbPasswordPrompt.PasswordChar = '*';
            this.tbPasswordPrompt.Size = new System.Drawing.Size(260, 62);
            this.tbPasswordPrompt.TabIndex = 3;
            this.toolTip.SetToolTip(this.tbPasswordPrompt, "Password prompt.");
            // 
            // ChangePasswordForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(299, 269);
            this.Controls.Add(this.tbPasswordPrompt);
            this.Controls.Add(lblPasswordPrompt);
            this.Controls.Add(this.tbNewPasswordCopy);
            this.Controls.Add(lblNewCopyPrompt);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(lblNewPrompt);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbOldPassword);
            this.Controls.Add(lblPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePasswordForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change password...";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbNewPassword;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox tbOldPassword;
		private System.Windows.Forms.TextBox tbNewPasswordCopy;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox tbPasswordPrompt;
	}
}
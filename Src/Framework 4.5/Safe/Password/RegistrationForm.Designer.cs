namespace EdlinSoftware.Safe.Password
{
	partial class RegistrationForm
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
            System.Windows.Forms.Label lblPrompt;
            System.Windows.Forms.Label lblCopyPrompt;
            System.Windows.Forms.Label lblPasswordPrompt;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbPasswordCopy = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tbPasswordPrompt = new System.Windows.Forms.TextBox();
            lblPrompt = new System.Windows.Forms.Label();
            lblCopyPrompt = new System.Windows.Forms.Label();
            lblPasswordPrompt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new System.Drawing.Point(16, 14);
            lblPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new System.Drawing.Size(215, 17);
            lblPrompt.TabIndex = 4;
            lblPrompt.Text = "Enter password for your storage:";
            // 
            // lblCopyPrompt
            // 
            lblCopyPrompt.AutoSize = true;
            lblCopyPrompt.Location = new System.Drawing.Point(16, 64);
            lblCopyPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCopyPrompt.Name = "lblCopyPrompt";
            lblCopyPrompt.Size = new System.Drawing.Size(237, 17);
            lblCopyPrompt.TabIndex = 8;
            lblCopyPrompt.Text = "Re-enter password for your storage:";
            // 
            // lblPasswordPrompt
            // 
            lblPasswordPrompt.AutoSize = true;
            lblPasswordPrompt.Location = new System.Drawing.Point(16, 122);
            lblPasswordPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPasswordPrompt.Name = "lblPasswordPrompt";
            lblPasswordPrompt.Size = new System.Drawing.Size(158, 17);
            lblPasswordPrompt.TabIndex = 9;
            lblPasswordPrompt.Text = "Enter password prompt:";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(165, 245);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(273, 245);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Location = new System.Drawing.Point(16, 33);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(339, 22);
            this.tbPassword.TabIndex = 0;
            this.toolTip.SetToolTip(this.tbPassword, "Enter password for your storage.");
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // tbPasswordCopy
            // 
            this.tbPasswordCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPasswordCopy.Location = new System.Drawing.Point(16, 86);
            this.tbPasswordCopy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPasswordCopy.Name = "tbPasswordCopy";
            this.tbPasswordCopy.PasswordChar = '*';
            this.tbPasswordCopy.Size = new System.Drawing.Size(339, 22);
            this.tbPasswordCopy.TabIndex = 1;
            this.toolTip.SetToolTip(this.tbPasswordCopy, "Re-enter password for your storage.");
            this.tbPasswordCopy.Validating += new System.ComponentModel.CancelEventHandler(this.tbPasswordCopy_Validating);
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
            this.tbPasswordPrompt.Location = new System.Drawing.Point(16, 142);
            this.tbPasswordPrompt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPasswordPrompt.Multiline = true;
            this.tbPasswordPrompt.Name = "tbPasswordPrompt";
            this.tbPasswordPrompt.Size = new System.Drawing.Size(339, 85);
            this.tbPasswordPrompt.TabIndex = 2;
            this.toolTip.SetToolTip(this.tbPasswordPrompt, "Password prompt.");
            // 
            // RegistrationForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(389, 288);
            this.Controls.Add(this.tbPasswordPrompt);
            this.Controls.Add(lblPasswordPrompt);
            this.Controls.Add(this.tbPasswordCopy);
            this.Controls.Add(lblCopyPrompt);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(lblPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Storage creation...";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.TextBox tbPasswordCopy;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox tbPasswordPrompt;
	}
}
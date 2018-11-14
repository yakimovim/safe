namespace EdlinSoftware.Safe.SafeLib.DataFields
{
    partial class PasswordDataFieldControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbText = new System.Windows.Forms.TextBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.bCopy = new System.Windows.Forms.Button();
            this.bToggleView = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.Location = new System.Drawing.Point(30, 19);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(272, 20);
            this.tbText.TabIndex = 4;
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(3, 3);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(55, 13);
            this.lblLabel.TabIndex = 3;
            this.lblLabel.Text = "Enter text:";
            // 
            // bCopy
            // 
            this.bCopy.Image = global::EdlinSoftware.Safe.SafeLib.Properties.Resources.Copy;
            this.bCopy.Location = new System.Drawing.Point(5, 19);
            this.bCopy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(20, 20);
            this.bCopy.TabIndex = 5;
            this.toolTip.SetToolTip(this.bCopy, "Copy to clipboard");
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.OnCopy);
            // 
            // bToggleView
            // 
            this.bToggleView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bToggleView.Appearance = System.Windows.Forms.Appearance.Button;
            this.bToggleView.AutoSize = true;
            this.bToggleView.Image = global::EdlinSoftware.Safe.SafeLib.Properties.Resources.Eye;
            this.bToggleView.Location = new System.Drawing.Point(307, 17);
            this.bToggleView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bToggleView.Name = "bToggleView";
            this.bToggleView.Size = new System.Drawing.Size(24, 24);
            this.bToggleView.TabIndex = 6;
            this.toolTip.SetToolTip(this.bToggleView, "Show/hide password");
            this.bToggleView.UseVisualStyleBackColor = true;
            this.bToggleView.CheckedChanged += new System.EventHandler(this.OnPasswordVisibleChanged);
            // 
            // PasswordDataFieldControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bToggleView);
            this.Controls.Add(this.bCopy);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.lblLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PasswordDataFieldControl";
            this.Size = new System.Drawing.Size(339, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCopy;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.CheckBox bToggleView;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

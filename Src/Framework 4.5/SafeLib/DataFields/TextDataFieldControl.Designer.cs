namespace EdlinSoftware.Safe.SafeLib.DataFields
{
	partial class TextDataFieldControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.lblLabel = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.bCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(3, 3);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(55, 13);
            this.lblLabel.TabIndex = 0;
            this.lblLabel.Text = "Enter text:";
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.Location = new System.Drawing.Point(30, 19);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(301, 20);
            this.tbText.TabIndex = 1;
            // 
            // bCopy
            // 
            this.bCopy.Image = global::EdlinSoftware.Safe.SafeLib.Properties.Resources.Copy;
            this.bCopy.Location = new System.Drawing.Point(5, 19);
            this.bCopy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(20, 20);
            this.bCopy.TabIndex = 2;
            this.toolTip.SetToolTip(this.bCopy, "Copy to clipboard");
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.OnCopy);
            // 
            // TextDataFieldControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bCopy);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.lblLabel);
            this.Name = "TextDataFieldControl";
            this.Size = new System.Drawing.Size(339, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblLabel;
		private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button bCopy;
        private System.Windows.Forms.ToolTip toolTip;
	}
}

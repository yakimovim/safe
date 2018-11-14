namespace EdlinSoftware.Safe
{
	partial class FindForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindForm));
            this.lblFindPrompt = new System.Windows.Forms.Label();
            this.tbFindText = new System.Windows.Forms.TextBox();
            this.bFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFindPrompt
            // 
            this.lblFindPrompt.AutoSize = true;
            this.lblFindPrompt.Location = new System.Drawing.Point(12, 9);
            this.lblFindPrompt.Name = "lblFindPrompt";
            this.lblFindPrompt.Size = new System.Drawing.Size(87, 13);
            this.lblFindPrompt.TabIndex = 0;
            this.lblFindPrompt.Text = "Enter text to find:";
            // 
            // tbFindText
            // 
            this.tbFindText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFindText.Location = new System.Drawing.Point(105, 6);
            this.tbFindText.Name = "tbFindText";
            this.tbFindText.Size = new System.Drawing.Size(326, 20);
            this.tbFindText.TabIndex = 1;
            // 
            // bFind
            // 
            this.bFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bFind.Location = new System.Drawing.Point(356, 42);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(75, 23);
            this.bFind.TabIndex = 2;
            this.bFind.Text = "Find";
            this.bFind.UseVisualStyleBackColor = true;
            this.bFind.Click += new System.EventHandler(this.OnFind);
            // 
            // FindForm
            // 
            this.AcceptButton = this.bFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 77);
            this.Controls.Add(this.bFind);
            this.Controls.Add(this.tbFindText);
            this.Controls.Add(this.lblFindPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find text...";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblFindPrompt;
		private System.Windows.Forms.TextBox tbFindText;
		private System.Windows.Forms.Button bFind;
	}
}
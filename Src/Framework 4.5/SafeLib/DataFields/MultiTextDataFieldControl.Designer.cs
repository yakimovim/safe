namespace EdlinSoftware.Safe.SafeLib.DataFields
{
	partial class MultiTextDataFieldControl
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
			this.lblLabel = new System.Windows.Forms.Label();
			this.tbText = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblLabel
			// 
			this.lblLabel.AutoSize = true;
			this.lblLabel.Location = new System.Drawing.Point( 3, 3 );
			this.lblLabel.Name = "lblLabel";
			this.lblLabel.Size = new System.Drawing.Size( 55, 13 );
			this.lblLabel.TabIndex = 0;
			this.lblLabel.Text = "Enter text:";
			// 
			// tbText
			// 
			this.tbText.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
							| System.Windows.Forms.AnchorStyles.Left )
							| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.tbText.Location = new System.Drawing.Point( 6, 19 );
			this.tbText.Multiline = true;
			this.tbText.Name = "tbText";
			this.tbText.Size = new System.Drawing.Size( 312, 115 );
			this.tbText.TabIndex = 1;
			// 
			// MultiTextDataFieldControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add( this.tbText );
			this.Controls.Add( this.lblLabel );
			this.Name = "MultiTextDataFieldControl";
			this.Size = new System.Drawing.Size( 325, 141 );
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblLabel;
		private System.Windows.Forms.TextBox tbText;
	}
}

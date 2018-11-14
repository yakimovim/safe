namespace EdlinSoftware.Safe.SafeLib.DataFields
{
	partial class LabelTextControl
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
			System.Windows.Forms.Label lbl;
			this.tbLabelText = new System.Windows.Forms.TextBox();
			lbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl
			// 
			lbl.AutoSize = true;
			lbl.Location = new System.Drawing.Point( 3, 3 );
			lbl.Name = "lbl";
			lbl.Size = new System.Drawing.Size( 92, 13 );
			lbl.TabIndex = 0;
			lbl.Text = "Enter text of label:";
			// 
			// tbLabelText
			// 
			this.tbLabelText.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
							| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.tbLabelText.Location = new System.Drawing.Point( 6, 19 );
			this.tbLabelText.Name = "tbLabelText";
			this.tbLabelText.Size = new System.Drawing.Size( 251, 20 );
			this.tbLabelText.TabIndex = 1;
			// 
			// LabelTextControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add( this.tbLabelText );
			this.Controls.Add( lbl );
			this.Name = "LabelTextControl";
			this.Size = new System.Drawing.Size( 265, 45 );
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbLabelText;

	}
}

namespace EdlinSoftware.Safe
{
	partial class TopicForm
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
			System.Windows.Forms.Label lblName;
			System.Windows.Forms.Label lblDescription;
			System.Windows.Forms.Label lblImage;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( TopicForm ) );
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbDescription = new System.Windows.Forms.TextBox();
			this.pbImage = new System.Windows.Forms.PictureBox();
			this.bLoadImage = new System.Windows.Forms.Button();
			this.bClearImage = new System.Windows.Forms.Button();
			this.bCancel = new System.Windows.Forms.Button();
			this.bOk = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider( this.components );
			this.toolTip = new System.Windows.Forms.ToolTip( this.components );
			this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
			lblName = new System.Windows.Forms.Label();
			lblDescription = new System.Windows.Forms.Label();
			lblImage = new System.Windows.Forms.Label();
			( (System.ComponentModel.ISupportInitialize) ( this.pbImage ) ).BeginInit();
			( (System.ComponentModel.ISupportInitialize) ( this.errorProvider ) ).BeginInit();
			this.SuspendLayout();
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Location = new System.Drawing.Point( 12, 9 );
			lblName.Name = "lblName";
			lblName.Size = new System.Drawing.Size( 76, 13 );
			lblName.TabIndex = 0;
			lblName.Text = "Name of topic:";
			// 
			// lblDescription
			// 
			lblDescription.AutoSize = true;
			lblDescription.Location = new System.Drawing.Point( 12, 48 );
			lblDescription.Name = "lblDescription";
			lblDescription.Size = new System.Drawing.Size( 101, 13 );
			lblDescription.TabIndex = 2;
			lblDescription.Text = "Description of topic:";
			// 
			// lblImage
			// 
			lblImage.AutoSize = true;
			lblImage.Location = new System.Drawing.Point( 12, 142 );
			lblImage.Name = "lblImage";
			lblImage.Size = new System.Drawing.Size( 80, 13 );
			lblImage.TabIndex = 4;
			lblImage.Text = "Image for topic:";
			// 
			// tbName
			// 
			this.tbName.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
							| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.tbName.Location = new System.Drawing.Point( 12, 25 );
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size( 420, 20 );
			this.tbName.TabIndex = 0;
			this.toolTip.SetToolTip( this.tbName, "Enter the name of topic." );
			this.tbName.Validating += new System.ComponentModel.CancelEventHandler( this.tbName_Validating );
			// 
			// tbDescription
			// 
			this.tbDescription.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
							| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.tbDescription.Location = new System.Drawing.Point( 12, 64 );
			this.tbDescription.Multiline = true;
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.Size = new System.Drawing.Size( 420, 75 );
			this.tbDescription.TabIndex = 1;
			this.toolTip.SetToolTip( this.tbDescription, "Enter the description of topic." );
			this.tbDescription.Validating += new System.ComponentModel.CancelEventHandler( this.tbDescription_Validating );
			// 
			// pbImage
			// 
			this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbImage.Location = new System.Drawing.Point( 12, 158 );
			this.pbImage.Name = "pbImage";
			this.pbImage.Size = new System.Drawing.Size( 90, 90 );
			this.pbImage.TabIndex = 5;
			this.pbImage.TabStop = false;
			// 
			// bLoadImage
			// 
			this.bLoadImage.CausesValidation = false;
			this.bLoadImage.Location = new System.Drawing.Point( 117, 171 );
			this.bLoadImage.Name = "bLoadImage";
			this.bLoadImage.Size = new System.Drawing.Size( 75, 23 );
			this.bLoadImage.TabIndex = 2;
			this.bLoadImage.Text = "Load...";
			this.bLoadImage.UseVisualStyleBackColor = true;
			this.bLoadImage.Click += new System.EventHandler( this.bLoadImage_Click );
			// 
			// bClearImage
			// 
			this.bClearImage.CausesValidation = false;
			this.bClearImage.Location = new System.Drawing.Point( 117, 200 );
			this.bClearImage.Name = "bClearImage";
			this.bClearImage.Size = new System.Drawing.Size( 75, 23 );
			this.bClearImage.TabIndex = 3;
			this.bClearImage.Text = "Clear";
			this.bClearImage.UseVisualStyleBackColor = true;
			this.bClearImage.Click += new System.EventHandler( this.bClearImage_Click );
			// 
			// bCancel
			// 
			this.bCancel.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bCancel.Location = new System.Drawing.Point( 374, 270 );
			this.bCancel.Name = "bCancel";
			this.bCancel.Size = new System.Drawing.Size( 75, 23 );
			this.bCancel.TabIndex = 5;
			this.bCancel.Text = "Cancel";
			this.bCancel.UseVisualStyleBackColor = true;
			// 
			// bOk
			// 
			this.bOk.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.bOk.Location = new System.Drawing.Point( 293, 270 );
			this.bOk.Name = "bOk";
			this.bOk.Size = new System.Drawing.Size( 75, 23 );
			this.bOk.TabIndex = 4;
			this.bOk.Text = "Ok";
			this.bOk.UseVisualStyleBackColor = true;
			this.bOk.Click += new System.EventHandler( this.bOk_Click );
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// dlgOpenFile
			// 
			this.dlgOpenFile.Filter = "Images (*.jpg; *.bmp; *gif; *.png)|*.jpg; *.bmp; *gif; *.png";
			// 
			// TopicForm
			// 
			this.AcceptButton = this.bOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.CancelButton = this.bCancel;
			this.ClientSize = new System.Drawing.Size( 461, 305 );
			this.Controls.Add( this.bOk );
			this.Controls.Add( this.bCancel );
			this.Controls.Add( this.bClearImage );
			this.Controls.Add( this.bLoadImage );
			this.Controls.Add( this.pbImage );
			this.Controls.Add( lblImage );
			this.Controls.Add( this.tbDescription );
			this.Controls.Add( lblDescription );
			this.Controls.Add( this.tbName );
			this.Controls.Add( lblName );
			this.Icon = ( (System.Drawing.Icon) ( resources.GetObject( "$this.Icon" ) ) );
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size( 469, 339 );
			this.Name = "TopicForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Topic properties...";
			this.Load += new System.EventHandler( this.TopicForm_Load );
			( (System.ComponentModel.ISupportInitialize) ( this.pbImage ) ).EndInit();
			( (System.ComponentModel.ISupportInitialize) ( this.errorProvider ) ).EndInit();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbDescription;
		private System.Windows.Forms.PictureBox pbImage;
		private System.Windows.Forms.Button bLoadImage;
		private System.Windows.Forms.Button bClearImage;
		private System.Windows.Forms.Button bCancel;
		private System.Windows.Forms.Button bOk;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.OpenFileDialog dlgOpenFile;

	}
}
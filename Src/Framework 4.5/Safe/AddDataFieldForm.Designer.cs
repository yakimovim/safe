namespace EdlinSoftware.Safe
{
	partial class AddDataFieldForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDataFieldForm));
            this.bCancel = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.lvDataFields = new System.Windows.Forms.ListView();
            this.chDataFields = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilDataFields = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(481, 288);
            this.bCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(100, 28);
            this.bCancel.TabIndex = 0;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bOk
            // 
            this.bOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bOk.Location = new System.Drawing.Point(373, 288);
            this.bOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(100, 28);
            this.bOk.TabIndex = 1;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.OnOk);
            // 
            // lvDataFields
            // 
            this.lvDataFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDataFields.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDataFields});
            this.lvDataFields.HideSelection = false;
            this.lvDataFields.LargeImageList = this.ilDataFields;
            this.lvDataFields.Location = new System.Drawing.Point(3, 0);
            this.lvDataFields.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvDataFields.Name = "lvDataFields";
            this.lvDataFields.Size = new System.Drawing.Size(591, 277);
            this.lvDataFields.SmallImageList = this.ilDataFields;
            this.lvDataFields.TabIndex = 2;
            this.lvDataFields.UseCompatibleStateImageBehavior = false;
            this.lvDataFields.View = System.Windows.Forms.View.Details;
            // 
            // chDataFields
            // 
            this.chDataFields.Text = "Data fields";
            this.chDataFields.Width = 400;
            // 
            // ilDataFields
            // 
            this.ilDataFields.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilDataFields.ImageSize = new System.Drawing.Size(24, 24);
            this.ilDataFields.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // AddDataFieldForm
            // 
            this.AcceptButton = this.bOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(597, 327);
            this.Controls.Add(this.lvDataFields);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.bCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "AddDataFieldForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add data field...";
            this.Shown += new System.EventHandler(this.OnFormShown);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button bCancel;
		private System.Windows.Forms.Button bOk;
		private System.Windows.Forms.ListView lvDataFields;
		private System.Windows.Forms.ImageList ilDataFields;
		private System.Windows.Forms.ColumnHeader chDataFields;
	}
}
namespace EdlinSoftware.Safe
{
	partial class DataFieldsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( DataFieldsForm ) );
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.lvDataFields = new System.Windows.Forms.ListView();
			this.chDataFields = new System.Windows.Forms.ColumnHeader();
			this.ilFieldsImages = new System.Windows.Forms.ImageList( this.components );
			this.fieldsToolStrip = new System.Windows.Forms.ToolStrip();
			this.addFieldToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.deleteFieldToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.upToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.downToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.fieldsToolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainer
			// 
			this.toolStripContainer.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.Controls.Add( this.splitContainer );
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size( 485, 308 );
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.LeftToolStripPanelVisible = false;
			this.toolStripContainer.Location = new System.Drawing.Point( 0, 0 );
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.RightToolStripPanelVisible = false;
			this.toolStripContainer.Size = new System.Drawing.Size( 485, 333 );
			this.toolStripContainer.TabIndex = 0;
			this.toolStripContainer.Text = "toolStripContainer1";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.Controls.Add( this.fieldsToolStrip );
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point( 0, 0 );
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add( this.lvDataFields );
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.AutoScroll = true;
			this.splitContainer.Size = new System.Drawing.Size( 485, 308 );
			this.splitContainer.SplitterDistance = 161;
			this.splitContainer.TabIndex = 0;
			// 
			// lvDataFields
			// 
			this.lvDataFields.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.chDataFields} );
			this.lvDataFields.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvDataFields.FullRowSelect = true;
			this.lvDataFields.HideSelection = false;
			this.lvDataFields.LargeImageList = this.ilFieldsImages;
			this.lvDataFields.Location = new System.Drawing.Point( 0, 0 );
			this.lvDataFields.MultiSelect = false;
			this.lvDataFields.Name = "lvDataFields";
			this.lvDataFields.Size = new System.Drawing.Size( 161, 308 );
			this.lvDataFields.SmallImageList = this.ilFieldsImages;
			this.lvDataFields.TabIndex = 0;
			this.lvDataFields.UseCompatibleStateImageBehavior = false;
			this.lvDataFields.View = System.Windows.Forms.View.Details;
			this.lvDataFields.SelectedIndexChanged += new System.EventHandler( this.OnSelectedFieldChanged );
			// 
			// chDataFields
			// 
			this.chDataFields.Text = "Data fields";
			this.chDataFields.Width = 150;
			// 
			// ilFieldsImages
			// 
			this.ilFieldsImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ilFieldsImages.ImageSize = new System.Drawing.Size( 24, 24 );
			this.ilFieldsImages.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// fieldsToolStrip
			// 
			this.fieldsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.fieldsToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.addFieldToolStripButton,
            this.deleteFieldToolStripButton,
            this.toolStripSeparator4,
            this.upToolStripButton,
            this.downToolStripButton} );
			this.fieldsToolStrip.Location = new System.Drawing.Point( 3, 0 );
			this.fieldsToolStrip.Name = "fieldsToolStrip";
			this.fieldsToolStrip.Size = new System.Drawing.Size( 110, 25 );
			this.fieldsToolStrip.TabIndex = 3;
			// 
			// addFieldToolStripButton
			// 
			this.addFieldToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.addFieldToolStripButton.Image = global::EdlinSoftware.Safe.Properties.Resources.SubTopic;
			this.addFieldToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.addFieldToolStripButton.Name = "addFieldToolStripButton";
			this.addFieldToolStripButton.Size = new System.Drawing.Size( 23, 22 );
			this.addFieldToolStripButton.Text = "Add data field...";
			this.addFieldToolStripButton.Click += new System.EventHandler( this.OnAddField );
			// 
			// deleteFieldToolStripButton
			// 
			this.deleteFieldToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.deleteFieldToolStripButton.Image = global::EdlinSoftware.Safe.Properties.Resources.Delete;
			this.deleteFieldToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.deleteFieldToolStripButton.Name = "deleteFieldToolStripButton";
			this.deleteFieldToolStripButton.Size = new System.Drawing.Size( 23, 22 );
			this.deleteFieldToolStripButton.Text = "Delete data field...";
			this.deleteFieldToolStripButton.Click += new System.EventHandler( this.OnDelete );
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size( 6, 25 );
			// 
			// upToolStripButton
			// 
			this.upToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.upToolStripButton.Image = global::EdlinSoftware.Safe.Properties.Resources.Up;
			this.upToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.upToolStripButton.Name = "upToolStripButton";
			this.upToolStripButton.Size = new System.Drawing.Size( 23, 22 );
			this.upToolStripButton.Text = "Move data field up";
			this.upToolStripButton.Click += new System.EventHandler( this.OnMoveUp );
			// 
			// downToolStripButton
			// 
			this.downToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.downToolStripButton.Image = global::EdlinSoftware.Safe.Properties.Resources.Down;
			this.downToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.downToolStripButton.Name = "downToolStripButton";
			this.downToolStripButton.Size = new System.Drawing.Size( 23, 22 );
			this.downToolStripButton.Text = "Move data field down";
			this.downToolStripButton.Click += new System.EventHandler( this.OnMoveDown );
			// 
			// DataFieldsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 485, 333 );
			this.Controls.Add( this.toolStripContainer );
			this.Icon = ( (System.Drawing.Icon) ( resources.GetObject( "$this.Icon" ) ) );
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size( 493, 367 );
			this.Name = "DataFieldsForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Data fields...";
			this.Shown += new System.EventHandler( this.OnFormShown );
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.OnFormClosing );
			this.toolStripContainer.ContentPanel.ResumeLayout( false );
			this.toolStripContainer.TopToolStripPanel.ResumeLayout( false );
			this.toolStripContainer.TopToolStripPanel.PerformLayout();
			this.toolStripContainer.ResumeLayout( false );
			this.toolStripContainer.PerformLayout();
			this.splitContainer.Panel1.ResumeLayout( false );
			this.splitContainer.ResumeLayout( false );
			this.fieldsToolStrip.ResumeLayout( false );
			this.fieldsToolStrip.PerformLayout();
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.ToolStrip fieldsToolStrip;
		private System.Windows.Forms.ToolStripButton addFieldToolStripButton;
		private System.Windows.Forms.ToolStripButton deleteFieldToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton upToolStripButton;
		private System.Windows.Forms.ToolStripButton downToolStripButton;
		private System.Windows.Forms.ListView lvDataFields;
		private System.Windows.Forms.ImageList ilFieldsImages;
		private System.Windows.Forms.ColumnHeader chDataFields;
	}
}
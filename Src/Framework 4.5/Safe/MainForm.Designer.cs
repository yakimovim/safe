namespace EdlinSoftware.Safe
{
	partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tvTopics = new System.Windows.Forms.TreeView();
            this.topicsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAddTopLevelTopic = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddSubTopic = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeleteTopic = new System.Windows.Forms.ToolStripMenuItem();
            this.miProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.miSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.miMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.ilTopicsImages = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTopLevelTopicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSubtopicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTopicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.dataFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storageToolStrip = new System.Windows.Forms.ToolStrip();
            this.loginToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.changePasswordToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.topicsToolStrip = new System.Windows.Forms.ToolStrip();
            this.addTopicToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addSubtopicToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteTopicToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.propertiesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.moveUpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.moveDownToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.dataFieldsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.topicsContextMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.storageToolStrip.SuspendLayout();
            this.topicsToolStrip.SuspendLayout();
            this.trayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.splitContainer);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(697, 400);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(697, 449);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.menuStrip);
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.storageToolStrip);
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.topicsToolStrip);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tvTopics);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.AutoScroll = true;
            this.splitContainer.Size = new System.Drawing.Size(697, 400);
            this.splitContainer.SplitterDistance = 232;
            this.splitContainer.TabIndex = 0;
            // 
            // tvTopics
            // 
            this.tvTopics.AllowDrop = true;
            this.tvTopics.ContextMenuStrip = this.topicsContextMenu;
            this.tvTopics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvTopics.FullRowSelect = true;
            this.tvTopics.HideSelection = false;
            this.tvTopics.ImageIndex = 0;
            this.tvTopics.ImageList = this.ilTopicsImages;
            this.tvTopics.Location = new System.Drawing.Point(0, 0);
            this.tvTopics.Name = "tvTopics";
            this.tvTopics.SelectedImageIndex = 0;
            this.tvTopics.ShowNodeToolTips = true;
            this.tvTopics.Size = new System.Drawing.Size(232, 400);
            this.tvTopics.TabIndex = 0;
            this.tvTopics.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.OnBeforeTopicExpand);
            this.tvTopics.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.OnBeforeTopicSelect);
            this.tvTopics.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OnAfterTopicSelect);
            this.tvTopics.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDropTopic);
            this.tvTopics.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragTopicEnter);
            this.tvTopics.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDownOnTopic);
            // 
            // topicsContextMenu
            // 
            this.topicsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddTopLevelTopic,
            this.miAddSubTopic,
            this.miDeleteTopic,
            this.miProperties,
            this.miSeparator1,
            this.miMoveUp,
            this.miMoveDown});
            this.topicsContextMenu.Name = "topicsContextMenu";
            this.topicsContextMenu.Size = new System.Drawing.Size(184, 142);
            this.topicsContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.OnTopicContextMenuOpening);
            // 
            // miAddTopLevelTopic
            // 
            this.miAddTopLevelTopic.Image = global::EdlinSoftware.Safe.Properties.Resources.Topic;
            this.miAddTopLevelTopic.Name = "miAddTopLevelTopic";
            this.miAddTopLevelTopic.Size = new System.Drawing.Size(183, 22);
            this.miAddTopLevelTopic.Text = "Add top level topic...";
            this.miAddTopLevelTopic.ToolTipText = "Adds top level topic.";
            this.miAddTopLevelTopic.Click += new System.EventHandler(this.OnAddTopic);
            // 
            // miAddSubTopic
            // 
            this.miAddSubTopic.Image = global::EdlinSoftware.Safe.Properties.Resources.SubTopic;
            this.miAddSubTopic.Name = "miAddSubTopic";
            this.miAddSubTopic.Size = new System.Drawing.Size(183, 22);
            this.miAddSubTopic.Text = "Add subtopic...";
            this.miAddSubTopic.ToolTipText = "Adds subtopic of selected topic.";
            this.miAddSubTopic.Click += new System.EventHandler(this.OnAddSubTopic);
            // 
            // miDeleteTopic
            // 
            this.miDeleteTopic.Image = global::EdlinSoftware.Safe.Properties.Resources.Delete;
            this.miDeleteTopic.Name = "miDeleteTopic";
            this.miDeleteTopic.Size = new System.Drawing.Size(183, 22);
            this.miDeleteTopic.Text = "Delete topic...";
            this.miDeleteTopic.ToolTipText = "Deletes selected topic.";
            this.miDeleteTopic.Click += new System.EventHandler(this.OnDeleteTopic);
            // 
            // miProperties
            // 
            this.miProperties.Image = global::EdlinSoftware.Safe.Properties.Resources.TopicProperties;
            this.miProperties.Name = "miProperties";
            this.miProperties.Size = new System.Drawing.Size(183, 22);
            this.miProperties.Text = "Properties...";
            this.miProperties.ToolTipText = "Shows properties of selected topic.";
            this.miProperties.Click += new System.EventHandler(this.OnTopicProperties);
            // 
            // miSeparator1
            // 
            this.miSeparator1.Name = "miSeparator1";
            this.miSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // miMoveUp
            // 
            this.miMoveUp.Image = global::EdlinSoftware.Safe.Properties.Resources.Up;
            this.miMoveUp.Name = "miMoveUp";
            this.miMoveUp.Size = new System.Drawing.Size(183, 22);
            this.miMoveUp.Text = "Move up";
            this.miMoveUp.ToolTipText = "Moves selected topic up in the list.";
            this.miMoveUp.Click += new System.EventHandler(this.OnMoveTopicUp);
            // 
            // miMoveDown
            // 
            this.miMoveDown.Image = global::EdlinSoftware.Safe.Properties.Resources.Down;
            this.miMoveDown.Name = "miMoveDown";
            this.miMoveDown.Size = new System.Drawing.Size(183, 22);
            this.miMoveDown.Text = "Move down";
            this.miMoveDown.ToolTipText = "Moves selected topic down in the list.";
            this.miMoveDown.Click += new System.EventHandler(this.OnMoveTopicDown);
            // 
            // ilTopicsImages
            // 
            this.ilTopicsImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilTopicsImages.ImageSize = new System.Drawing.Size(48, 48);
            this.ilTopicsImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.topicsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(697, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loginStripMenuItem
            // 
            this.loginStripMenuItem.Image = global::EdlinSoftware.Safe.Properties.Resources.Login;
            this.loginStripMenuItem.Name = "loginStripMenuItem";
            this.loginStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.loginStripMenuItem.Text = "&Login...";
            this.loginStripMenuItem.Click += new System.EventHandler(this.OnLogin);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Enabled = false;
            this.changePasswordToolStripMenuItem.Image = global::EdlinSoftware.Safe.Properties.Resources.ChangePassword;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.changePasswordToolStripMenuItem.Text = "&Change password...";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.OnChangePassword);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Image = global::EdlinSoftware.Safe.Properties.Resources.Save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.saveToolStripMenuItem.Text = "Save storage";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.OnSave);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::EdlinSoftware.Safe.Properties.Resources.Exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExit);
            // 
            // topicsToolStripMenuItem
            // 
            this.topicsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTopLevelTopicToolStripMenuItem,
            this.addSubtopicToolStripMenuItem,
            this.deleteTopicToolStripMenuItem,
            this.propertiesToolStripMenuItem,
            this.toolStripSeparator3,
            this.moveUpToolStripMenuItem,
            this.moveDownToolStripMenuItem,
            this.toolStripSeparator6,
            this.dataFieldsToolStripMenuItem});
            this.topicsToolStripMenuItem.Enabled = false;
            this.topicsToolStripMenuItem.Name = "topicsToolStripMenuItem";
            this.topicsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.topicsToolStripMenuItem.Text = "&Topics";
            // 
            // addTopLevelTopicToolStripMenuItem
            // 
            this.addTopLevelTopicToolStripMenuItem.Image = global::EdlinSoftware.Safe.Properties.Resources.Topic;
            this.addTopLevelTopicToolStripMenuItem.Name = "addTopLevelTopicToolStripMenuItem";
            this.addTopLevelTopicToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.addTopLevelTopicToolStripMenuItem.Text = "Add &top level topic...";
            this.addTopLevelTopicToolStripMenuItem.Click += new System.EventHandler(this.OnAddTopic);
            // 
            // addSubtopicToolStripMenuItem
            // 
            this.addSubtopicToolStripMenuItem.Image = global::EdlinSoftware.Safe.Properties.Resources.SubTopic;
            this.addSubtopicToolStripMenuItem.Name = "addSubtopicToolStripMenuItem";
            this.addSubtopicToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.addSubtopicToolStripMenuItem.Text = "Add &subtopic...";
            this.addSubtopicToolStripMenuItem.Click += new System.EventHandler(this.OnAddSubTopic);
            // 
            // deleteTopicToolStripMenuItem
            // 
            this.deleteTopicToolStripMenuItem.Image = global::EdlinSoftware.Safe.Properties.Resources.Delete;
            this.deleteTopicToolStripMenuItem.Name = "deleteTopicToolStripMenuItem";
            this.deleteTopicToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.deleteTopicToolStripMenuItem.Text = "&Delete topic...";
            this.deleteTopicToolStripMenuItem.Click += new System.EventHandler(this.OnDeleteTopic);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Image = global::EdlinSoftware.Safe.Properties.Resources.TopicProperties;
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.propertiesToolStripMenuItem.Text = "&Properties...";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.OnTopicProperties);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(180, 6);
            // 
            // moveUpToolStripMenuItem
            // 
            this.moveUpToolStripMenuItem.Image = global::EdlinSoftware.Safe.Properties.Resources.Up;
            this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
            this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.moveUpToolStripMenuItem.Text = "Move up";
            this.moveUpToolStripMenuItem.Click += new System.EventHandler(this.OnMoveTopicUp);
            // 
            // moveDownToolStripMenuItem
            // 
            this.moveDownToolStripMenuItem.Image = global::EdlinSoftware.Safe.Properties.Resources.Down;
            this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
            this.moveDownToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.moveDownToolStripMenuItem.Text = "Move down";
            this.moveDownToolStripMenuItem.Click += new System.EventHandler(this.OnMoveTopicDown);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(180, 6);
            // 
            // dataFieldsToolStripMenuItem
            // 
            this.dataFieldsToolStripMenuItem.Image = global::EdlinSoftware.Safe.Properties.Resources.DataFields;
            this.dataFieldsToolStripMenuItem.Name = "dataFieldsToolStripMenuItem";
            this.dataFieldsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.dataFieldsToolStripMenuItem.Text = "Data fields...";
            this.dataFieldsToolStripMenuItem.Click += new System.EventHandler(this.OnDataFields);
            // 
            // storageToolStrip
            // 
            this.storageToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.storageToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripButton,
            this.toolStripSeparator2,
            this.changePasswordToolStripButton,
            this.saveToolStripButton});
            this.storageToolStrip.Location = new System.Drawing.Point(3, 24);
            this.storageToolStrip.Name = "storageToolStrip";
            this.storageToolStrip.Size = new System.Drawing.Size(87, 25);
            this.storageToolStrip.TabIndex = 1;
            // 
            // loginToolStripButton
            // 
            this.loginToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loginToolStripButton.Image = global::EdlinSoftware.Safe.Properties.Resources.Login;
            this.loginToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loginToolStripButton.Name = "loginToolStripButton";
            this.loginToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.loginToolStripButton.Text = "Login...";
            this.loginToolStripButton.Click += new System.EventHandler(this.OnLogin);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // changePasswordToolStripButton
            // 
            this.changePasswordToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.changePasswordToolStripButton.Enabled = false;
            this.changePasswordToolStripButton.Image = global::EdlinSoftware.Safe.Properties.Resources.ChangePassword;
            this.changePasswordToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.changePasswordToolStripButton.Name = "changePasswordToolStripButton";
            this.changePasswordToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.changePasswordToolStripButton.Text = "Change password...";
            this.changePasswordToolStripButton.Click += new System.EventHandler(this.OnChangePassword);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Enabled = false;
            this.saveToolStripButton.Image = global::EdlinSoftware.Safe.Properties.Resources.Save;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "Save storage";
            this.saveToolStripButton.Click += new System.EventHandler(this.OnSave);
            // 
            // topicsToolStrip
            // 
            this.topicsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.topicsToolStrip.Enabled = false;
            this.topicsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTopicToolStripButton,
            this.addSubtopicToolStripButton,
            this.deleteTopicToolStripButton,
            this.propertiesToolStripButton,
            this.toolStripSeparator4,
            this.moveUpToolStripButton,
            this.moveDownToolStripButton,
            this.toolStripSeparator5,
            this.dataFieldsToolStripButton,
            this.toolStripSeparator7,
            this.findToolStripButton});
            this.topicsToolStrip.Location = new System.Drawing.Point(90, 24);
            this.topicsToolStrip.Name = "topicsToolStrip";
            this.topicsToolStrip.Size = new System.Drawing.Size(214, 25);
            this.topicsToolStrip.TabIndex = 2;
            // 
            // addTopicToolStripButton
            // 
            this.addTopicToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addTopicToolStripButton.Image = global::EdlinSoftware.Safe.Properties.Resources.Topic;
            this.addTopicToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addTopicToolStripButton.Name = "addTopicToolStripButton";
            this.addTopicToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.addTopicToolStripButton.Text = "Add top level topic...";
            this.addTopicToolStripButton.Click += new System.EventHandler(this.OnAddTopic);
            // 
            // addSubtopicToolStripButton
            // 
            this.addSubtopicToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addSubtopicToolStripButton.Image = global::EdlinSoftware.Safe.Properties.Resources.SubTopic;
            this.addSubtopicToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addSubtopicToolStripButton.Name = "addSubtopicToolStripButton";
            this.addSubtopicToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.addSubtopicToolStripButton.Text = "Add subtopic...";
            this.addSubtopicToolStripButton.Click += new System.EventHandler(this.OnAddSubTopic);
            // 
            // deleteTopicToolStripButton
            // 
            this.deleteTopicToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteTopicToolStripButton.Image = global::EdlinSoftware.Safe.Properties.Resources.Delete;
            this.deleteTopicToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteTopicToolStripButton.Name = "deleteTopicToolStripButton";
            this.deleteTopicToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.deleteTopicToolStripButton.Text = "Delete topic...";
            this.deleteTopicToolStripButton.Click += new System.EventHandler(this.OnDeleteTopic);
            // 
            // propertiesToolStripButton
            // 
            this.propertiesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.propertiesToolStripButton.Image = global::EdlinSoftware.Safe.Properties.Resources.TopicProperties;
            this.propertiesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.propertiesToolStripButton.Name = "propertiesToolStripButton";
            this.propertiesToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.propertiesToolStripButton.Text = "Topic properties...";
            this.propertiesToolStripButton.Click += new System.EventHandler(this.OnTopicProperties);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // moveUpToolStripButton
            // 
            this.moveUpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveUpToolStripButton.Image = global::EdlinSoftware.Safe.Properties.Resources.Up;
            this.moveUpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moveUpToolStripButton.Name = "moveUpToolStripButton";
            this.moveUpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.moveUpToolStripButton.Text = "Move topic up";
            this.moveUpToolStripButton.Click += new System.EventHandler(this.OnMoveTopicUp);
            // 
            // moveDownToolStripButton
            // 
            this.moveDownToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveDownToolStripButton.Image = global::EdlinSoftware.Safe.Properties.Resources.Down;
            this.moveDownToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moveDownToolStripButton.Name = "moveDownToolStripButton";
            this.moveDownToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.moveDownToolStripButton.Text = "Move topic down";
            this.moveDownToolStripButton.Click += new System.EventHandler(this.OnMoveTopicDown);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // dataFieldsToolStripButton
            // 
            this.dataFieldsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dataFieldsToolStripButton.Image = global::EdlinSoftware.Safe.Properties.Resources.DataFields;
            this.dataFieldsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dataFieldsToolStripButton.Name = "dataFieldsToolStripButton";
            this.dataFieldsToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.dataFieldsToolStripButton.Text = "Data fields...";
            this.dataFieldsToolStripButton.Click += new System.EventHandler(this.OnDataFields);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // findToolStripButton
            // 
            this.findToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.findToolStripButton.Image = global::EdlinSoftware.Safe.Properties.Resources.Find;
            this.findToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findToolStripButton.Name = "findToolStripButton";
            this.findToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.findToolStripButton.Text = "Find...";
            this.findToolStripButton.Click += new System.EventHandler(this.OnFind);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.trayMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Safe";
            this.notifyIcon.Visible = true;
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(104, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::EdlinSoftware.Safe.Properties.Resources.Up;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OnOpen);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Image = global::EdlinSoftware.Safe.Properties.Resources.Exit;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.quitToolStripMenuItem.Text = "Exit";
            this.quitToolStripMenuItem.ToolTipText = "Exit Safe application";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.OnExit);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 449);
            this.Controls.Add(this.toolStripContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Safe application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Shown += new System.EventHandler(this.OnFormShown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Resize += new System.EventHandler(this.OnResize);
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.topicsContextMenu.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.storageToolStrip.ResumeLayout(false);
            this.storageToolStrip.PerformLayout();
            this.topicsToolStrip.ResumeLayout(false);
            this.topicsToolStrip.PerformLayout();
            this.trayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loginStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStrip storageToolStrip;
		private System.Windows.Forms.ToolStripButton loginToolStripButton;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.TreeView tvTopics;
		private System.Windows.Forms.ToolStripMenuItem topicsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addTopLevelTopicToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addSubtopicToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton changePasswordToolStripButton;
		private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton saveToolStripButton;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ImageList ilTopicsImages;
		private System.Windows.Forms.ToolStrip topicsToolStrip;
		private System.Windows.Forms.ToolStripButton addTopicToolStripButton;
		private System.Windows.Forms.ToolStripButton addSubtopicToolStripButton;
		private System.Windows.Forms.ToolStripMenuItem deleteTopicToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton deleteTopicToolStripButton;
		private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton propertiesToolStripButton;
		private System.Windows.Forms.ToolStripButton moveUpToolStripButton;
		private System.Windows.Forms.ToolStripButton moveDownToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton dataFieldsToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem dataFieldsToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip trayMenu;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripButton findToolStripButton;
        private System.Windows.Forms.ContextMenuStrip topicsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem miAddTopLevelTopic;
        private System.Windows.Forms.ToolStripMenuItem miAddSubTopic;
        private System.Windows.Forms.ToolStripMenuItem miDeleteTopic;
        private System.Windows.Forms.ToolStripMenuItem miProperties;
        private System.Windows.Forms.ToolStripSeparator miSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miMoveUp;
        private System.Windows.Forms.ToolStripMenuItem miMoveDown;
	}
}
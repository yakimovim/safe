using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EdlinSoftware.Safe.Password;
using EdlinSoftware.Safe.Properties;
using EdlinSoftware.Safe.SafeLib;

namespace EdlinSoftware.Safe
{
    /// <summary>
    /// Main form of Safe application.
    /// </summary>
    public partial class MainForm : Form
    {
        [DebuggerStepThrough]
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles first showing of form.
        /// </summary>
        private void OnFormShown(object sender, EventArgs e)
        {
            if (!PrepareUserStorage())
                Close();

            Login();
        }

        /// <summary>
        /// Handles form closing.
        /// </summary>
        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTopicData();

            if ((Globals.UserStorage != null) && Globals.UserStorage.IsOpened)
                Globals.UserStorage.Save();
        }

        /// <summary>
        /// Handles form resizing.
        /// </summary>
        private void OnResize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            { Hide(); }
        }

        /// <summary>
        /// Handles key press to open find dialod.
        /// </summary>
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (Globals.UserStorage.IsOpened)
            {
                if (e.Control && (e.KeyCode == Keys.F))
                {
                    OnFind(this, EventArgs.Empty);
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// Logins in user storage.
        /// </summary>
        private void OnLogin(object sender, EventArgs e)
        {
            Login();
        }

        /// <summary>
        /// Changes password of current storage.
        /// </summary>
        private void OnChangePassword(object sender, EventArgs e)
        {
            ChangePassword();
        }

        /// <summary>
        /// Adds top level topic.
        /// </summary>
        private void OnAddTopic(object sender, EventArgs e)
        {
            var frm = new TopicForm();
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                Debug.Assert(frm.Topic != null, "Topic must exist.");

                Globals.UserStorage.Topics.Add(frm.Topic);

                TreeNode node = GetTopicNode(frm.Topic);

                tvTopics.Nodes.Add(node);
            }
        }

        /// <summary>
        /// Adds subtopic.
        /// </summary>
        private void OnAddSubTopic(object sender, EventArgs e)
        {
            if (tvTopics.SelectedNode == null)
                return;

            var frm = new TopicForm();
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                Debug.Assert(frm.Topic != null, "Topic must exist.");

                Debug.Assert(tvTopics.SelectedNode.Tag is Topic, "Every node must be connected with topic.");
                var parentTopic = (Topic)tvTopics.SelectedNode.Tag;

                parentTopic.SubTopics.Add(frm.Topic);

                TreeNode node = GetTopicNode(frm.Topic);

                tvTopics.SelectedNode.Nodes.Add(node);
            }
        }

        /// <summary>
        /// Changes properties of topic.
        /// </summary>
        private void OnTopicProperties(object sender, EventArgs e)
        {
            if (tvTopics.SelectedNode == null)
                return;

            Debug.Assert(tvTopics.SelectedNode.Tag is Topic, "Every node must be connected with topic.");

            var frm = new TopicForm {Topic = (Topic) tvTopics.SelectedNode.Tag};
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                Debug.Assert(frm.Topic != null, "Topic must exist.");

                tvTopics.SelectedNode.Text = frm.Topic.Name;
                tvTopics.SelectedNode.ToolTipText = frm.Topic.Description;

                if (frm.Topic.Image != null)
                {
                    ilTopicsImages.Images.Add(frm.Topic.Image);
                    tvTopics.SelectedNode.ImageIndex = ilTopicsImages.Images.Count - 1;
                    tvTopics.SelectedNode.SelectedImageIndex = ilTopicsImages.Images.Count - 1;
                }
                else
                {
                    tvTopics.SelectedNode.ImageIndex = 0;
                }
            }
        }

        /// <summary>
        /// Deletes subtopic.
        /// </summary>
        private void OnDeleteTopic(object sender, EventArgs e)
        {
            if (tvTopics.SelectedNode == null)
                return;

            DialogResult res = MessageBox.Show(
                this,
                Resources.TopicDeleteConfirmation,
                Resources.Confirmation,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (res != DialogResult.Yes)
                return;

            Debug.Assert(tvTopics.SelectedNode.Tag is Topic, "Every node must be connected with topic.");
            var topic = (Topic)tvTopics.SelectedNode.Tag;

            if (tvTopics.SelectedNode.Parent == null)
            {
                Debug.Assert(Globals.UserStorage != null, "User storage can't be null.");
                Globals.UserStorage.Topics.Remove(topic);
                tvTopics.Nodes.Remove(tvTopics.SelectedNode);
            }
            else
            {
                Debug.Assert(tvTopics.SelectedNode.Parent.Tag is Topic, "Every node must be connected with topic.");
                var parentTopic = (Topic)tvTopics.SelectedNode.Parent.Tag;
                parentTopic.SubTopics.Remove(topic);
                tvTopics.SelectedNode.Parent.Nodes.Remove(tvTopics.SelectedNode);
            }
        }

        /// <summary>
        /// Moves topic up.
        /// </summary>
        private void OnMoveTopicUp(object sender, EventArgs e)
        {
            if (tvTopics.SelectedNode == null)
                return;

            TreeNode node = tvTopics.SelectedNode;

            int index;

            if (tvTopics.SelectedNode.Parent == null)
            {
                index = tvTopics.Nodes.IndexOf(node);
                if (index > 0)
                {
                    tvTopics.Nodes.RemoveAt(index);
                    tvTopics.Nodes.Insert(index - 1, node);
                    Globals.UserStorage.Topics.Move(index, index - 1);
                }
            }
            else
            {
                TreeNode parentNode = tvTopics.SelectedNode.Parent;

                Debug.Assert(parentNode.Tag is Topic, "Every node must be connected with topic.");
                var parentTopic = (Topic)parentNode.Tag;

                index = parentNode.Nodes.IndexOf(node);
                if (index > 0)
                {
                    parentNode.Nodes.RemoveAt(index);
                    parentNode.Nodes.Insert(index - 1, node);
                    parentTopic.SubTopics.Move(index, index - 1);
                }
            }

            tvTopics.SelectedNode = node;
        }

        /// <summary>
        /// Moves topic down.
        /// </summary>
        private void OnMoveTopicDown(object sender, EventArgs e)
        {
            if (tvTopics.SelectedNode == null)
                return;

            TreeNode node = tvTopics.SelectedNode;

            int index;

            if (tvTopics.SelectedNode.Parent == null)
            {
                index = tvTopics.Nodes.IndexOf(node);
                if (index < tvTopics.Nodes.Count - 1)
                {
                    tvTopics.Nodes.RemoveAt(index);
                    tvTopics.Nodes.Insert(index + 1, node);
                    Globals.UserStorage.Topics.Move(index, index + 1);
                }
            }
            else
            {
                TreeNode parentNode = tvTopics.SelectedNode.Parent;

                Debug.Assert(parentNode.Tag is Topic, "Every node must be connected with topic.");
                var parentTopic = (Topic)parentNode.Tag;

                index = parentNode.Nodes.IndexOf(node);
                if (index < parentNode.Nodes.Count - 1)
                {
                    parentNode.Nodes.RemoveAt(index);
                    parentNode.Nodes.Insert(index + 1, node);
                    parentTopic.SubTopics.Move(index, index + 1);
                }
            }

            tvTopics.SelectedNode = node;
        }

        /// <summary>
        /// Shows form with properties of data fields.
        /// </summary>
        private void OnDataFields(object sender, EventArgs e)
        {
            if (tvTopics.SelectedNode == null)
                return;

            var frm = new DataFieldsForm();
            Debug.Assert(tvTopics.SelectedNode.Tag is Topic, "Every node must be connected with topic.");
            frm.Topic = (Topic)tvTopics.SelectedNode.Tag;
            frm.ShowDialog(this);
            ShowDataFields(frm.Topic);
        }

        /// <summary>
        /// Handles topic selection.
        /// </summary>
        private void OnAfterTopicSelect(object sender, TreeViewEventArgs e)
        {
            Debug.Assert(e.Node.Tag is Topic, "Every node must be connected with topic.");
            ShowDataFields((Topic)e.Node.Tag);

            SetOperationsState();
        }

        /// <summary>
        /// Handles deselecting of topic.
        /// </summary>
        private void OnBeforeTopicSelect(object sender, TreeViewCancelEventArgs e)
        {
            SaveTopicData();
        }

        /// <summary>
        /// Handles mouse down on topics tree.
        /// </summary>
        private void OnMouseDownOnTopic(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && ModifierKeys == Keys.Shift)
            {
                TreeNode selNode = tvTopics.GetNodeAt(new Point(e.X, e.Y));
                if (selNode != null)
                {
                    tvTopics.SelectedNode = selNode;
                    DoDragDrop(selNode, DragDropEffects.Move);
                }
            }
        }

        /// <summary>
        /// Handles Drag-n-drop operation.
        /// </summary>
        private void OnDragTopicEnter(object sender, DragEventArgs e)
        { e.Effect = DragDropEffects.Move; }

        /// <summary>
        /// Handles Drag-n-drop operation finishing.
        /// </summary>
        private void OnDragDropTopic(object sender, DragEventArgs e)
        {
            try
            {
                var moveNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
                if (moveNode == null)
                { return; }

                Debug.Assert(moveNode.Tag is Topic, "Every node must be connected with topic.");
                var moveTopic = (Topic)moveNode.Tag;

                // Get collection where moving topic is.
                TopicsList sourceCollection;
                if (moveNode.Parent == null)
                    sourceCollection = Globals.UserStorage.Topics;
                else
                {
                    Debug.Assert(moveNode.Parent.Tag is Topic, "Every node must be connected with topic.");
                    sourceCollection = ((Topic)moveNode.Parent.Tag).SubTopics;
                }

                Topic targetTopic;
                TreeNode targetNode = tvTopics.GetNodeAt(tvTopics.PointToClient(new Point(e.X, e.Y)));
                if (targetNode == null)
                {
                    // Move to the top level.
                    targetTopic = null;
                }
                else
                {
                    // Do not move to its own successors.
                    TreeNode parentNode = targetNode;
                    while (parentNode != null)
                    {
                        if (moveNode == parentNode)
                            return;
                        parentNode = parentNode.Parent;
                    }

                    Debug.Assert(targetNode.Tag is Topic, "Every node must be connected with topic.");
                    targetTopic = (Topic)targetNode.Tag;
                }

                if (moveNode.Parent != null)
                    moveNode.Parent.Nodes.Remove(moveNode);
                else
                    tvTopics.Nodes.Remove(moveNode);

                if (targetNode != null)
                { targetNode.Nodes.Add(moveNode); }
                else
                { tvTopics.Nodes.Add(moveNode); }

                // Remove moving topic from source collection.
                sourceCollection.Remove(moveTopic);

                // Insert moving topic into new collection.
                if (targetTopic != null)
                    targetTopic.SubTopics.Add(moveTopic);
                else
                    Globals.UserStorage.Topics.Add(moveTopic);
            }
            catch
            { }
        }

        /// <summary>
        /// Handles opening of context menu of topics tree.
        /// </summary>
        private void OnTopicContextMenuOpening(object sender, CancelEventArgs e)
        {
            Point pt = tvTopics.PointToClient(MousePosition);
            TreeNode contextMenuNode = tvTopics.GetNodeAt(pt);
            if (contextMenuNode == null)
            {
                miAddSubTopic.Enabled = false;
                miDeleteTopic.Enabled = false;
                miProperties.Enabled = false;
                miMoveUp.Enabled = false;
                miMoveDown.Enabled = false;
            }
            else
            {
                miAddSubTopic.Enabled = true;
                miDeleteTopic.Enabled = true;
                miProperties.Enabled = true;
                miMoveUp.Enabled = contextMenuNode.PrevNode != null;
                miMoveDown.Enabled = contextMenuNode.NextNode != null;
                tvTopics.SelectedNode = contextMenuNode;
            }
        }

        /// <summary>
        /// Closes form.
        /// </summary>
        private void OnExit(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Saves user storage.
        /// </summary>
        private void OnSave(object sender, EventArgs e)
        {
            Debug.Assert(Globals.UserStorage != null, "User storage can't be null.");

            Globals.UserStorage.Save();
        }

        /// <summary>
        /// Handles restoring form from system tray.
        /// </summary>
        private void OnOpen(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// Opens form for finding topics.
        /// </summary>
        private void OnFind(object sender, EventArgs e)
        {
            var frm = new FindForm();
            frm.ShowDialog(this);
        }

        /// <summary>
        /// Saves user data for topic.
        /// </summary>
        private void SaveTopicData()
        {
            if (tvTopics.SelectedNode != null)
            {
                Debug.Assert(tvTopics.SelectedNode.Tag is Topic, "Every node must be connected with topic.");

                var topic = (Topic)tvTopics.SelectedNode.Tag;
                foreach (IDataField dataField in topic.Fields)
                {
                    dataField.SaveData();
                }
            }
        }

        /// <summary>
        /// Shows topics in current user storage.
        /// </summary>
        private void ShowTopics()
        {
            Debug.Assert(Globals.UserStorage != null, "User storage can't be null.");

            ilTopicsImages.Images.Clear();
            ilTopicsImages.Images.Add(Resources.SubTopic);

            ShowTopics(tvTopics.Nodes, Globals.UserStorage.Topics);
        }

        /// <summary>
        /// Shows topics as nodes collection.
        /// </summary>
        /// <param name="nodes">Nodes collection.</param>
        /// <param name="topics">Topics.</param>
        private void ShowTopics(TreeNodeCollection nodes, IEnumerable<Topic> topics)
        {
            if (nodes == null)
                throw new ArgumentNullException("nodes");

            try
            {
                tvTopics.BeginUpdate();

                if (topics == null)
                    return;

                nodes.Clear();

                foreach (Topic topic in topics)
                {
                    TreeNode node = GetTopicNode(topic);

                    if (topic.SubTopics != null && topic.SubTopics.Count > 0)
                    {
                        node.Nodes.Add(new TreeNode("Fake node"));
                    }

                    nodes.Add(node);
                }
            }
            finally
            {
                tvTopics.EndUpdate();
            }

        }

        /// <summary>
        /// Shows data fields for given topic.
        /// </summary>
        /// <param name="topic">Topic.</param>
        private void ShowDataFields(Topic topic)
        {
            splitContainer.Panel2.Controls.Clear();

            if (topic == null)
                return;

            for (int i = topic.Fields.Count - 1; i >= 0; i--)
            {
                IDataField dataField = topic.Fields[i];
                if (dataField.FieldControl != null)
                {
                    dataField.FieldControl.Dock = DockStyle.Top;
                    splitContainer.Panel2.Controls.Add(dataField.FieldControl);
                    dataField.FieldControl.TabIndex = i;
                }
            }
        }

        /// <summary>
        /// Opens user storage.
        /// </summary>
        /// <returns>True if user storage is ready; otherwise, false.</returns>
        private bool PrepareUserStorage()
        {
            if (!PrepareGlogalStorage())
            { return false; }

            UserStorageStatus userStorageStatus =
                GlobalStorage.GetUserStorageStatus();

            if (userStorageStatus == UserStorageStatus.NoAccess)
            {
                MessageBox.Show(
                    this,
                    Resources.NoAccessToCurrentStorage,
                    Resources.Error,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return false;
            }

            if (userStorageStatus == UserStorageStatus.Absent)
            { GlobalStorage.CreateUserStorageDirectory(); }

            if (GlobalStorage.GetUserStorageStatus() != UserStorageStatus.Ready)
            {
                MessageBox.Show(
                    this,
                    Resources.CantCreateUserStorage,
                    Resources.Error,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return false;
            }

            UserStorage userStorage;
            try
            {
                userStorage = GlobalStorage.GetUserStorage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    string.Format(Resources.CantGetUserStorageObject + Environment.NewLine + "Reason: {0}", ex),
                    Resources.Error,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return false;
            }

            if (userStorage == null)
            {
                MessageBox.Show(
                    this,
                    Resources.CantGetUserStorageObject,
                    Resources.Error,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return false;
            }

            Globals.UserStorage = userStorage;
            return true;
        }

        /// <summary>
        /// Prepares global storage.
        /// </summary>
        /// <returns>True if global storage is ready; otherwise, false.</returns>
        private bool PrepareGlogalStorage()
        {
            GlobalStorageStatus globalStorageStatus =
                GlobalStorage.GetGlobalStorageStatus();

            if (globalStorageStatus == GlobalStorageStatus.NoAccess)
            {
                MessageBox.Show(
                    this,
                    Resources.NoAccessToGlobalStorage,
                    Resources.Error,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return false;
            }

            if (globalStorageStatus == GlobalStorageStatus.Absent)
            { GlobalStorage.CreateGlobalStorage(); }

            if (GlobalStorage.GetGlobalStorageStatus() != GlobalStorageStatus.Ready)
            {
                MessageBox.Show(
                    this,
                    Resources.CantCreateGlobalStorage,
                    Resources.Error,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return false;
            }
            
            return true;
        }

        /// <summary>
        /// Logins to user storage.
        /// </summary>
        private void Login()
        {
            Debug.Assert(Globals.UserStorage != null, "User storage can't be null.");

            if (File.Exists(Globals.UserStorage.StorageFilePath))
            {
                Globals.UserStorage.GetPublicInfo();

                var frm = new LoginForm {PasswordPrompt = Globals.UserStorage.PasswordPrompt};
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    Globals.UserStorage.Open(frm.Password);
                    if (!Globals.UserStorage.IsOpened)
                    {
                        MessageBox.Show(
                            this,
                            Resources.WrongPassword,
                            Resources.Error,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                var frm = new RegistrationForm();
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    Globals.UserStorage.Open(frm.Password);
                    Globals.UserStorage.PasswordPrompt = frm.PasswordPrompt;
                    if (!Globals.UserStorage.IsOpened)
                    {
                        MessageBox.Show(
                            this,
                            Resources.CantCreateUserStorageWithThisPassword,
                            Resources.Error,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }

            if (Globals.UserStorage.IsOpened)
            {
                EnableStorageControls(true);

                ShowTopics();

                SetOperationsState();
            }
        }

        /// <summary>
        /// Enables/disables controls for opened storage.
        /// </summary>
        /// <param name="enable">Enable controls.</param>
        private void EnableStorageControls(bool enable)
        {
            loginStripMenuItem.Enabled = !enable;
            loginToolStripButton.Enabled = !enable;

            changePasswordToolStripButton.Enabled = enable;
            changePasswordToolStripMenuItem.Enabled = enable;

            saveToolStripButton.Enabled = enable;
            saveToolStripMenuItem.Enabled = enable;

            topicsToolStripMenuItem.Enabled = enable;

            topicsToolStrip.Enabled = enable;
        }

        /// <summary>
        /// Changes current password.
        /// </summary>
        private void ChangePassword()
        {
            Debug.Assert(Globals.UserStorage != null, "User storage can't be null.");

            var frm = new ChangePasswordForm {PasswordPrompt = Globals.UserStorage.PasswordPrompt};
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    Globals.UserStorage.ChangePassword(frm.OldPassword, frm.NewPassword);
                    Globals.UserStorage.PasswordPrompt = frm.PasswordPrompt;
                    MessageBox.Show(
                        this,
                        Resources.PasswordWasChanged,
                        Resources.Information,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
                catch (WrongPasswordException)
                {
                    MessageBox.Show(
                        this,
                        Resources.IncorrectPassword,
                        Resources.Error,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show(
                        this,
                        Resources.PasswordCantBeNullOrEmpty,
                        Resources.Error,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
        }

        /// <summary>
        /// Creates tree node for topic.
        /// </summary>
        /// <param name="topic">Topic.</param>
        /// <returns>Tree node for topic.</returns>
        private TreeNode GetTopicNode(Topic topic)
        {
            if (topic == null)
                throw new ArgumentNullException("topic");

            var node = new TreeNode {Text = topic.Name, ToolTipText = topic.Description, Tag = topic};

            if (topic.Image != null)
            {
                ilTopicsImages.Images.Add(topic.Image);
                node.ImageIndex = ilTopicsImages.Images.Count - 1;
                node.SelectedImageIndex = ilTopicsImages.Images.Count - 1;
            }
            else
            {
                node.ImageIndex = 0;
                node.SelectedImageIndex = 0;
            }

            return node;
        }

        /// <summary>
        /// Shows selected topic.
        /// </summary>
        /// <param name="foundTopic">Topic to show.</param>
        /// <exception cref="ArgumentNullException">Topic is null.</exception>
        /// <exception cref="InvalidOperationException">There is no node for topic.</exception>
        public void ShowTopic(Topic foundTopic)
        {
            if (foundTopic == null)
                throw new ArgumentNullException("foundTopic");

            var sequenceOfTopics = GetParentTopics(foundTopic);

            var nodes = tvTopics.Nodes;

            foreach (var topic in sequenceOfTopics)
            {
                var currentTopic = topic;

                var topicNode = nodes.OfType<TreeNode>().First(n => (Topic)n.Tag == currentTopic);

                if (currentTopic == foundTopic)
                {
                    tvTopics.SelectedNode = topicNode;
                }
                else
                {
                    topicNode.Expand();
                    nodes = topicNode.Nodes;
                }
            }
        }

        /// <summary>
        /// Gets list of parent topics for given topic in order.
        /// </summary>
        /// <param name="topic">Topic.</param>
        /// <returns>List of parent topics.</returns>
        private IEnumerable<Topic> GetParentTopics(Topic topic)
        {
            var parentTopics = new LinkedList<Topic>();

            while (topic != null)
            {
                parentTopics.AddFirst(topic);
                topic = topic.ParentList.ParentTopic;
            }

            return parentTopics;
        }

        /// <summary>
        /// Sets state of all operations for topics.
        /// </summary>
        private void SetOperationsState()
        {
            if (tvTopics.SelectedNode == null)
            {
                propertiesToolStripMenuItem.Enabled = false;
                propertiesToolStripButton.Enabled = false;
                deleteTopicToolStripMenuItem.Enabled = false;
                deleteTopicToolStripButton.Enabled = false;
                moveDownToolStripMenuItem.Enabled = false;
                moveDownToolStripButton.Enabled = false;
                moveUpToolStripMenuItem.Enabled = false;
                moveUpToolStripButton.Enabled = false;
                addSubtopicToolStripMenuItem.Enabled = false;
                addSubtopicToolStripButton.Enabled = false;
                dataFieldsToolStripMenuItem.Enabled = false;
                dataFieldsToolStripButton.Enabled = false;
            }
            else
            {
                propertiesToolStripMenuItem.Enabled = true;
                propertiesToolStripButton.Enabled = true;
                deleteTopicToolStripMenuItem.Enabled = true;
                deleteTopicToolStripButton.Enabled = true;
                moveDownToolStripMenuItem.Enabled = tvTopics.SelectedNode.NextNode != null;
                moveDownToolStripButton.Enabled = tvTopics.SelectedNode.NextNode != null;
                moveUpToolStripMenuItem.Enabled = tvTopics.SelectedNode.PrevNode != null;
                moveUpToolStripButton.Enabled = tvTopics.SelectedNode.PrevNode != null;
                addSubtopicToolStripMenuItem.Enabled = true;
                addSubtopicToolStripButton.Enabled = true;
                dataFieldsToolStripMenuItem.Enabled = true;
                dataFieldsToolStripButton.Enabled = true;
            }
        }

        /// <summary>
        /// Handles expanding of node.
        /// </summary>
        private void OnBeforeTopicExpand(object sender, TreeViewCancelEventArgs e)
        {
            var expandingNode = e.Node;

            if(HasFakeNode(expandingNode.Nodes) == false)
            { return; }

            var topic = (Topic) expandingNode.Tag;

            ShowTopics(expandingNode.Nodes, topic.SubTopics);
        }

        /// <summary>
        /// Checks that collection of nodes contains fake node which represents that real nodes are not loaded.
        /// </summary>
        /// <param name="nodes">Nodes.</param>
        /// <returns>True if there is fake node. False, otherwise.</returns>
        private bool HasFakeNode(TreeNodeCollection nodes)
        {
            return nodes.OfType<TreeNode>().Any(n => n.Tag == null);
        }
    }
}
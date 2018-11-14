using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using EdlinSoftware.Safe.SafeLib;

namespace EdlinSoftware.Safe
{
    /// <summary>
    /// Form of topic properties.
    /// </summary>
    public partial class TopicForm : Form
    {
        /// <summary>
        /// Topic to modify.
        /// </summary>
        public Topic Topic { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        [DebuggerStepThrough]
        public TopicForm()
        {
            InitializeComponent();
        }

        private void bClearImage_Click(object sender, EventArgs e)
        {
            pbImage.Image = null;
            pbImage.Refresh();
        }

        private void bLoadImage_Click(object sender, EventArgs e)
        {
            if (dlgOpenFile.ShowDialog(this) == DialogResult.OK)
            {
                pbImage.Image = Image.FromFile(dlgOpenFile.FileName);
                pbImage.Refresh();
            }
        }

        private void TopicForm_Load(object sender, EventArgs e)
        {
            tbName.Text = (Topic == null) ? string.Empty : Topic.Name;
            tbDescription.Text = (Topic == null) ? string.Empty : Topic.Description;
            pbImage.Image = (Topic == null) ? null : Topic.Image;
            pbImage.Refresh();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            if (Topic == null)
                Topic = new Topic();

            Topic.Name = tbName.Text;
            Topic.Description = tbDescription.Text;
            Topic.Image = pbImage.Image;

            DialogResult = DialogResult.OK;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                errorProvider.SetError(tbName, toolTip.GetToolTip(tbName));
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void tbDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbDescription.Text))
            {
                errorProvider.SetError(tbDescription, toolTip.GetToolTip(tbDescription));
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbDescription, null);
                e.Cancel = false;
            }
        }
    }
}
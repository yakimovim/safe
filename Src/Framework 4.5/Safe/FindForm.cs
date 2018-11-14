using System;
using System.Diagnostics;
using System.Windows.Forms;
using EdlinSoftware.Safe.Properties;
using EdlinSoftware.Safe.SafeLib;

namespace EdlinSoftware.Safe
{
	/// <summary>
	/// Form for finding text in topics.
	/// </summary>
	public partial class FindForm : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public FindForm()
        {
            InitializeComponent();
        }

        /// <summary>
		/// Finds topic with selected text.
		/// </summary>
		private void OnFind(object sender, EventArgs e)
        {
            Topic foundTopic = string.Compare(Searcher.LastText, tbFindText.Text, StringComparison.InvariantCultureIgnoreCase) == 0 
                ? Searcher.SearchNext() 
                : Searcher.Search(Globals.UserStorage.Topics, tbFindText.Text);

            if (foundTopic == null)
			{
				MessageBox.Show(this,
					Resources.NoTopicFound,
					Resources.NoTopicCaption,
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);
			}
			else
			{
				Debug.Assert(Owner != null);
				Debug.Assert(Owner is MainForm);

				var mainForm = (MainForm)Owner;
				mainForm.ShowTopic(foundTopic);
			}
        }

	    /// <summary>
        /// Handles closing of form by escape pressing.
        /// </summary>
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
                e.Handled = true;
            }
        }
    }
}

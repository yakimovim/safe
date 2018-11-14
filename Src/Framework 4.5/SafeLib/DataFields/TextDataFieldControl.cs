using System.Diagnostics;
using System.Windows.Forms;

namespace EdlinSoftware.Safe.SafeLib.DataFields
{
	/// <summary>
	/// Control for entering user text data.
	/// </summary>
	public partial class TextDataFieldControl : UserControl
	{
		/// <summary>
		/// Prompt label.
		/// </summary>
		public string Label
		{
			[DebuggerStepThrough]
			get { return lblLabel.Text; }
			[DebuggerStepThrough]
			set { lblLabel.Text = value; }
		}

		/// <summary>
		/// User text data.
		/// </summary>
		public string Data
		{
			[DebuggerStepThrough]
			get { return tbText.Text;  }
			[DebuggerStepThrough]
			set { tbText.Text = value; }
		}

        /// <summary>
		/// Constructor.
		/// </summary>
		[DebuggerStepThrough]
		public TextDataFieldControl()
		{
			InitializeComponent();
		}

        /// <summary>
        /// Handles click on copy to clipboard button.
        /// </summary>
        private void OnCopy(object sender, System.EventArgs e)
        {
            tbText.SelectAll();
            tbText.Copy();
            tbText.DeselectAll();
        }
	}
}

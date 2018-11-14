using System.Diagnostics;
using System.Windows.Forms;

namespace EdlinSoftware.Safe.SafeLib.DataFields
{
	/// <summary>
	/// Control for entering text of label.
	/// </summary>
	public partial class LabelTextControl : UserControl
	{
		/// <summary>
		/// Text for label.
		/// </summary>
		public string LabelText
		{
			[DebuggerStepThrough]
			get { return tbLabelText.Text; }
			[DebuggerStepThrough]
			set { tbLabelText.Text = value; }
		}

        /// <summary>
		/// Constructor.
		/// </summary>
		[DebuggerStepThrough]
		public LabelTextControl()
		{
			InitializeComponent();
		}
	}
}

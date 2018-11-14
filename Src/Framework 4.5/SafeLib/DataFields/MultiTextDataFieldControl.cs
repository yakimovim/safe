using System.Diagnostics;
using System.Windows.Forms;

namespace EdlinSoftware.Safe.SafeLib.DataFields
{
	/// <summary>
	/// Control for entering user multiline text data.
	/// </summary>
	public partial class MultiTextDataFieldControl : UserControl
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
		public MultiTextDataFieldControl()
		{
			InitializeComponent();
		}
	}
}

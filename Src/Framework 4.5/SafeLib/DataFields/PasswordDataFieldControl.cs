using System.Diagnostics;
using System.Windows.Forms;

namespace EdlinSoftware.Safe.SafeLib.DataFields
{
    /// <summary>
    /// Control for entering passwords.
    /// </summary>
    public partial class PasswordDataFieldControl : UserControl
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
        /// Password.
        /// </summary>
        public string Password
        {
            [DebuggerStepThrough]
            get { return tbText.Text; }
            [DebuggerStepThrough]
            set { tbText.Text = value; }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        [DebuggerStepThrough]
        public PasswordDataFieldControl()
        {
            InitializeComponent();

            tbText.UseSystemPasswordChar = true;
        }

        /// <summary>
        /// Handles click on copy to clipboard button.
        /// </summary>
        private void OnCopy(object sender, System.EventArgs e)
        {
            var inHidePasswordMode = tbText.UseSystemPasswordChar;

            if (inHidePasswordMode)
            { tbText.UseSystemPasswordChar = false; }

            tbText.SelectAll();
            tbText.Copy();
            tbText.DeselectAll();

            if (inHidePasswordMode)
            { tbText.UseSystemPasswordChar = true; }
        }

        /// <summary>
        /// Handles click on toggle password visibility.
        /// </summary>
        private void OnPasswordVisibleChanged(object sender, System.EventArgs e)
        {
            tbText.UseSystemPasswordChar = !tbText.UseSystemPasswordChar;
        }
    }
}

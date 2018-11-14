using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using EdlinSoftware.Safe.Properties;

namespace EdlinSoftware.Safe.Password
{
	/// <summary>
	/// Form for login in user storage.
	/// </summary>
	public partial class LoginForm : Form
	{
		/// <summary>
		/// Password for user storage.
		/// </summary>
		public string Password
		{
			[DebuggerStepThrough]
			get { return tbPassword.Text; }
		}

        /// <summary>
        /// Password prompt for user storage.
        /// </summary>
        public string PasswordPrompt 
        {
            [DebuggerStepThrough]
            get { return tbPasswordPrompt.Text; }
            [DebuggerStepThrough]
            set { tbPasswordPrompt.Text = value; }
        }

        /// <summary>
		/// Constructor.
		/// </summary>
		[DebuggerStepThrough]
		public LoginForm()
		{
			InitializeComponent();

            ActiveControl = tbPassword;
		}

        /// <summary>
		/// Closes form.
		/// </summary>
		private void btnOk_Click( object sender, EventArgs e )
		{
			if( !ValidateChildren() )
				return;

			DialogResult = DialogResult.OK;
		}

		/// <summary>
		/// Validates pasword box.
		/// </summary>
		private void tbPassword_Validating( object sender, CancelEventArgs e )
		{
			if( string.IsNullOrEmpty( tbPassword.Text ) )
			{
				errorProvider.SetError( tbPassword, toolTip.GetToolTip( tbPassword ) );
				e.Cancel = true;
			}
			else
			{
				errorProvider.SetError( tbPassword, null );
				e.Cancel = false;
			}
		}

        private void llShowPrompt_Click(object sender, EventArgs e)
        {
            if (tbPasswordPrompt.Visible)
            {
                tbPasswordPrompt.Visible = false;
                llShowPrompt.Text = Resources.ShowPasswordPrompt;
            }
            else
            {
                tbPasswordPrompt.Visible = true;
                llShowPrompt.Text = Resources.HidePasswordPrompt;
            }
        }
 	}
}
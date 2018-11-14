using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace EdlinSoftware.Safe.Password
{
	/// <summary>
	/// Form for entering password for new storage.
	/// </summary>
	public partial class RegistrationForm : Form
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
        }

        /// <summary>
		/// Constructor.
		/// </summary>
		[DebuggerStepThrough]
		public RegistrationForm()
		{
			InitializeComponent();
		}

        /// <summary>
		/// Validates password box.
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

		/// <summary>
		/// Validates password copy box.
		/// </summary>
		private void tbPasswordCopy_Validating( object sender, CancelEventArgs e )
		{
			if( string.IsNullOrEmpty( tbPasswordCopy.Text ) )
			{
				errorProvider.SetError( tbPasswordCopy, toolTip.GetToolTip( tbPasswordCopy ) );
				e.Cancel = true;
			}
			else
			{
				if( tbPasswordCopy.Text != tbPassword.Text )
				{
					errorProvider.SetError( tbPasswordCopy, "Passwords in both fields must be the same." );
					e.Cancel = true;
				}
				else
				{
					errorProvider.SetError( tbPassword, null );
					e.Cancel = false;
				}
			}
		}

		/// <summary>
		/// Closes form.
		/// </summary>
		private void btnOk_Click( object sender, EventArgs e )
		{
			if( !ValidateChildren())
				return;

			DialogResult = DialogResult.OK;
		}
	}
}
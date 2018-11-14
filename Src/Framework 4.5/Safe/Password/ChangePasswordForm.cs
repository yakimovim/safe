using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace EdlinSoftware.Safe.Password
{
	/// <summary>
	/// Form for changing password.
	/// </summary>
	public partial class ChangePasswordForm : Form
	{
		#region Properties
		/// <summary>
		/// Old password for user storage.
		/// </summary>
		public string OldPassword
		{
			[DebuggerStepThrough]
			get { return tbOldPassword.Text; }
		}

		/// <summary>
		/// New password for user storage.
		/// </summary>
		public string NewPassword
		{
			[DebuggerStepThrough]
			get { return tbNewPassword.Text; }
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
        #endregion

		#region Constructors
		/// <summary>
		/// Constructor.
		/// </summary>
		[DebuggerStepThrough]
		public ChangePasswordForm()
		{
			InitializeComponent();
		}
		#endregion

		#region Event handlers

		#region Validation

		private void tbOldPassword_Validating( object sender, CancelEventArgs e )
		{
			if( string.IsNullOrEmpty( tbOldPassword.Text ) )
			{
				errorProvider.SetError( tbOldPassword, toolTip.GetToolTip( tbOldPassword ) );
				e.Cancel = true;
			}
			else
			{
				errorProvider.SetError( tbOldPassword, null );
				e.Cancel = false;
			}
		}

		private void tbNewPassword_Validating( object sender, CancelEventArgs e )
		{
			if( string.IsNullOrEmpty( tbNewPassword.Text ) )
			{
				errorProvider.SetError( tbNewPassword, toolTip.GetToolTip( tbNewPassword ) );
				e.Cancel = true;
			}
			else
			{
				errorProvider.SetError( tbNewPassword, null );
				e.Cancel = false;
			}
		}

		private void tbNewPasswordCopy_Validating( object sender, CancelEventArgs e )
		{
			if( string.IsNullOrEmpty( tbNewPasswordCopy.Text ) )
			{
				errorProvider.SetError( tbNewPasswordCopy, toolTip.GetToolTip( tbNewPasswordCopy ) );
				e.Cancel = true;
			}
			else
			{
				if( tbNewPasswordCopy.Text != tbNewPassword.Text )
				{
					errorProvider.SetError( tbNewPasswordCopy, "New passwords in both fields must be the same." );
					e.Cancel = true;
				}
				else
				{
					errorProvider.SetError( tbNewPasswordCopy, null );
					e.Cancel = false;
				}
			}
		}
		#endregion

		private void btnOk_Click( object sender, EventArgs e )
		{
			if( !ValidateChildren() )
				return;

			DialogResult = DialogResult.OK;
		}

		#endregion
	}
}
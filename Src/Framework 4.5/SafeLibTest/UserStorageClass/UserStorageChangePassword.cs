using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using NUnit.Framework;
using EdlinSoftware.Safe.SafeLib;

namespace EdlinSoftware.Safe.SafeLibTest.UserStorageClass
{
	[TestFixture]
	public class UserStorageChangePassword : UserStorageBaseTest
	{
		[DebuggerBrowsable( DebuggerBrowsableState.Never )]
		private readonly string password = "SomePassword";

		[SetUp]
		public override void SetUp()
		{
			base.SetUp();

			if( File.Exists( UserStorageObject.StorageFilePath ) )
				File.Delete( UserStorageObject.StorageFilePath );

			UserStorageObject.Open( password );
			UserStorageObject.Save();
		}

		[TearDown]
		public void TearDown()
		{
			if( File.Exists( UserStorageObject.StorageFilePath ) )
				File.Delete( UserStorageObject.StorageFilePath );
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void ChangePassword_NullNewPassword()
		{
			UserStorageObject.ChangePassword( password, null );
		}

		[Test]
		[ExpectedException( typeof( ArgumentNullException ) )]
		public void ChangePassword_EmptyNewPassword()
		{
			UserStorageObject.ChangePassword( password, string.Empty );
		}

		[Test]
		[ExpectedException( typeof( WrongPasswordException ) )]
		public void ChangePassword_IncorrectOldPassword()
		{
			UserStorageObject.ChangePassword( "BBB", "AAA" );
		}

		[Test]
		public void ChangePassword_Correct()
		{
			UserStorageObject.ChangePassword( password, "1" );
			UserStorageObject.Save();

			Assert.IsTrue( UserStorageObject.Open( "1" ) );
			Assert.IsFalse( UserStorageObject.Open( password ) );
		}
	}
}

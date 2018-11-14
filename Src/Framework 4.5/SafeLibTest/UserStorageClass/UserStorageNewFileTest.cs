using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using EdlinSoftware.Safe.SafeLib;
using NUnit.Framework;

namespace EdlinSoftware.Safe.SafeLibTest.UserStorageClass
{
	/// <summary>
	/// Class for testing opening and saving capabilities of UserStorage class.
	/// </summary>
	[TestFixture]
	public class UserStorageNewFileTest : UserStorageBaseTest
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
		}

		[Test]
		public void StorageFileIsntCreated()
		{
			Assert.IsFalse( File.Exists( UserStorageObject.StorageFilePath ) );
		}

		[Test]
		public void IsOpened_True()
		{
			Assert.IsTrue( UserStorageObject.IsOpened );
		}

        [Test]
        public void Version_Last()
        {
            Assert.AreEqual(UserStorage.LastVersion, UserStorageObject.Version);
        }

        [Test]
        public void PasswordPrompt_Correct()
        {
            Assert.AreEqual(string.Empty, UserStorageObject.PasswordPrompt);
        }
        
        [Test]
		public void Topics_NotNull()
		{
			Assert.IsNotNull( UserStorageObject.Topics );
		}
	}
}

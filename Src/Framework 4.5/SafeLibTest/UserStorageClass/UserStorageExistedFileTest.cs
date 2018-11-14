using System.Diagnostics;
using System.IO;
using EdlinSoftware.Safe.SafeLib;
using NUnit.Framework;

namespace EdlinSoftware.Safe.SafeLibTest.UserStorageClass
{
	[TestFixture]
	public class UserStorageExistedFileTest : UserStorageBaseTest
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
			UserStorageObject.Topics.Add( new Topic() );
            UserStorageObject.PasswordPrompt = "My prompt.";
			UserStorageObject.Save();
		}

		[TearDown]
		public void TearDown()
		{
			if( File.Exists( UserStorageObject.StorageFilePath ) )
				File.Delete( UserStorageObject.StorageFilePath );
		}

		[Test]
		public void StorageFileIsCreated()
		{
			Assert.IsTrue( File.Exists( UserStorageObject.StorageFilePath ) );
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
            Assert.AreEqual("My prompt.", UserStorageObject.PasswordPrompt);
        }

		[Test]
		public void Topics_NotNull()
		{
			Assert.IsNotNull( UserStorageObject.Topics );
		}

		[Test]
		public void Open_True()
		{
			Assert.IsTrue( UserStorageObject.Open( password ) );
			Assert.IsTrue( UserStorageObject.IsOpened );
			Assert.IsNotNull( UserStorageObject.Topics );
			Assert.AreEqual( 1, UserStorageObject.Topics.Count );
		}

		[Test]
		public void Open_False()
		{
			Assert.IsFalse( UserStorageObject.Open( "Some wrong password." ) );
			Assert.IsFalse( UserStorageObject.IsOpened );
			Assert.IsNull( UserStorageObject.Topics );
		}
	}
}

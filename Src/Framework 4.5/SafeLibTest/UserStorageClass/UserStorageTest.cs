using System;
using System.IO;
using NUnit.Framework;
using EdlinSoftware.Safe.SafeLib;

namespace EdlinSoftware.Safe.SafeLibTest.UserStorageClass
{
	/// <summary>
	/// Class for testing UserStorage class.
	/// </summary>
	[TestFixture]
	public class UserStorageTest : UserStorageBaseTest
	{
		[Test]
		public void NotNull()
		{
			Assert.IsNotNull( UserStorageObject );
		}

		[Test]
		public void StorageFilePath()
		{
			Assert.AreEqual( Utils.GetAbsentPathFinder().GetUserStorageDirectory() + @"\storage.dat", UserStorageObject.StorageFilePath );
		}

		[Test]
		public void IsOpen_False()
		{
			Assert.IsFalse( UserStorageObject.IsOpened );
		}

		[Test]
		public void Topics_Null()
		{
			Assert.IsNull( UserStorageObject.Topics );
		}

		[Test]
		public void Open_New()
		{
			if( File.Exists( UserStorageObject.StorageFilePath ))
				File.Delete( UserStorageObject.StorageFilePath );

			Assert.IsTrue( UserStorageObject.Open( "SomePassword" ) );
			Assert.IsTrue( UserStorageObject.IsOpened );
			Assert.IsNotNull( UserStorageObject.Topics );
		}

		[Test]
		[ExpectedException( typeof( InvalidOperationException ) )]
		public void Save_Exception()
		{
			UserStorageObject.Save();
		}
	}
}

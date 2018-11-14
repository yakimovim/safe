using System;
using System.IO;
using System.Security.Principal;
using EdlinSoftware.Safe.SafeLib;
using NUnit.Framework;

namespace EdlinSoftware.Safe.SafeLibTest.GlobalStorageClass
{
	[TestFixture]
	public class UserStorageTest : BaseTest
	{
		private static void SetUserStoragePath( IPathFinder pathFinder )
		{
			GlobalStorage.PathFinder = pathFinder;
		}

		[Test]
		public void GetUserStorageDirectory()
		{
			Assert.AreEqual( Utils.PathFinder.GetUserStorageDirectory(), GlobalStorage.GetUserStorageDirectory() );
		}

		[Test]
		public void GetUserStorageStatus_Absent()
		{
			SetUserStoragePath( Utils.GetAbsentPathFinder() );
			Assert.AreEqual( UserStorageStatus.Absent, GlobalStorage.GetUserStorageStatus() );
		}

		[Test]
		public void GetUserStorageStatus_NoAccess()
		{
			SetUserStoragePath( Utils.GetNoAccessPathFinder() );
			Assert.AreEqual( UserStorageStatus.NoAccess, GlobalStorage.GetUserStorageStatus() );
		}

		[Test]
		public void GetUserStorageStatus_Ready()
		{
			SetUserStoragePath(Utils.GetAbsentPathFinder());

			string userStorageDir = GlobalStorage.GetUserStorageDirectory();

			GlobalStorage.CreateUserStorageDirectory();

			Assert.AreEqual(UserStorageStatus.Ready, GlobalStorage.GetUserStorageStatus());

			Directory.Delete(userStorageDir);
		}

		[Test]
		public void CreateUserStorageDirectory()
		{
			SetUserStoragePath(Utils.GetAbsentPathFinder());

			string userStorageDir = GlobalStorage.GetUserStorageDirectory();

			Assert.AreEqual( UserStorageStatus.Absent, GlobalStorage.GetUserStorageStatus() );
			GlobalStorage.CreateUserStorageDirectory();
			Assert.AreEqual( UserStorageStatus.Ready, GlobalStorage.GetUserStorageStatus() );

			Directory.Delete( userStorageDir );
		}

		[Test]
		public void GetUserStorate_AbsentPath()
		{
			SetUserStoragePath( Utils.GetAbsentPathFinder() );
			try
			{
				GlobalStorage.GetUserStorage();
				Assert.Fail();
			}
			catch( UserStorageCreationException usce )
			{
				Assert.AreEqual( UserStorageStatus.Absent, usce.ErrorReason );
			}
			catch
			{ Assert.Fail(); }
		}

		[Test]
		public void GetUserStorage_NoAccess()
		{
			SetUserStoragePath( Utils.GetNoAccessPathFinder() );
			try
			{
				GlobalStorage.GetUserStorage();
				Assert.Fail();
			}
			catch( UserStorageCreationException usce )
			{
				Assert.AreEqual( UserStorageStatus.NoAccess, usce.ErrorReason );
			}
			catch
			{ Assert.Fail(); }
		}

		[Test]
		public void GetUserStorage()
		{
			SetUserStoragePath(Utils.GetAbsentPathFinder());

			string userStorageDir = GlobalStorage.GetUserStorageDirectory();

			GlobalStorage.CreateUserStorageDirectory();

			UserStorage us = GlobalStorage.GetUserStorage();
			Assert.IsNotNull( us );

			Directory.Delete(userStorageDir);
		}
	}
}
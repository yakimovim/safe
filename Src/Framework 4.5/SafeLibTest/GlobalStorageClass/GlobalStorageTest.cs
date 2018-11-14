using System.IO;
using EdlinSoftware.Safe.SafeLib;
using NUnit.Framework;

namespace EdlinSoftware.Safe.SafeLibTest.GlobalStorageClass
{
	[TestFixture]
	public class GlobalStorageTest : BaseTest
	{
		private void SetGlobalStoragePath(IPathFinder pathFinder)
		{
			GlobalStorage.PathFinder = pathFinder;
		}

		[Test]
		public void GetGlobalStorageDirectory()
		{
			Assert.AreEqual( Utils.PathFinder.GetGlobalStorageDirectory(), GlobalStorage.GetGlobalStorageDirectory() );
		}

		[Test]
		public void GetGlobalStorageStatus_Absent()
		{
			SetGlobalStoragePath( Utils.GetAbsentPathFinder() );
			Assert.AreEqual( GlobalStorageStatus.Absent, GlobalStorage.GetGlobalStorageStatus() );
		}

		[Test]
		public void GetGlobalStorageStatus_NoAccess()
		{
			SetGlobalStoragePath( Utils.GetNoAccessPathFinder() );
			Assert.AreEqual( GlobalStorageStatus.NoAccess, GlobalStorage.GetGlobalStorageStatus() );
		}

		[Test]
		public void GetGlobalStorageStatus_Ready()
		{
			Assert.AreEqual( GlobalStorageStatus.Ready, GlobalStorage.GetGlobalStorageStatus() );
		}

		[Test]
		public void CreateGlobalStorage()
		{
			SetGlobalStoragePath( Utils.GetAbsentPathFinder() );

			string tempStoragePath = Utils.GetAbsentPathFinder().GetGlobalStorageDirectory();

			GlobalStorage.CreateGlobalStorage();

			Assert.IsTrue( Directory.Exists( tempStoragePath ) );
			Directory.Delete( tempStoragePath );
			Assert.IsFalse( Directory.Exists( tempStoragePath ) );
		}
	}
}
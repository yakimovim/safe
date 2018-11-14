using System.Diagnostics;
using EdlinSoftware.Safe.SafeLib;
using NUnit.Framework;
using System.IO;

namespace EdlinSoftware.Safe.SafeLibTest.UserStorageClass
{
	public abstract class UserStorageBaseTest : BaseTest
	{
		[DebuggerBrowsable( DebuggerBrowsableState.Never )]
		private UserStorage m_UserStorage;

		/// <summary>
		/// Object of user storage.
		/// </summary>
		public UserStorage UserStorageObject
		{
			[DebuggerStepThrough]
			get { return m_UserStorage; }
		}

		[TestFixtureSetUp]
		public virtual void FixtureSetUp()
		{
			GlobalStorage.PathFinder = Utils.GetAbsentPathFinder();

			GlobalStorage.CreateUserStorageDirectory();
		}

		[SetUp]
		public override void SetUp()
		{
			m_UserStorage = GlobalStorage.GetUserStorage();
		}

		[TestFixtureTearDown]
		public virtual void FixtureTearDown()
		{
			string path = GlobalStorage.GetUserStorageDirectory();

			Directory.Delete(path, true);
		}

	}
}

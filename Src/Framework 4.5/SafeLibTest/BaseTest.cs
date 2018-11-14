using EdlinSoftware.Safe.SafeLib;
using NUnit.Framework;

namespace EdlinSoftware.Safe.SafeLibTest
{
	/// <summary>
	/// Abstract class for testing.
	/// </summary>
	public abstract class BaseTest
	{
		[SetUp]
		public virtual void SetUp()
		{
			GlobalStorage.PathFinder = Utils.PathFinder;
		}
	}
}

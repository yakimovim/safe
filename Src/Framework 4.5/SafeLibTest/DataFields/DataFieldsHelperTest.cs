using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using EdlinSoftware.Safe.SafeLib;

namespace EdlinSoftware.Safe.SafeLibTest.DataFields
{
	[TestFixture]
	public class DataFieldsHelperTest
	{
		[Test]
		public void GetDifferentDataFields()
		{
			IDataField[] fields = DataFieldsHelper.GetDifferentDataFields();
			Assert.IsNotNull( fields );
			Assert.Greater( fields.Length, 0 );
		}
	}
}

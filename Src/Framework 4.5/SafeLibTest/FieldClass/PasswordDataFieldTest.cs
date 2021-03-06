﻿using EdlinSoftware.Safe.SafeLib.DataFields;
using NUnit.Framework;

namespace EdlinSoftware.Safe.SafeLibTest.FieldClass
{
	/// <summary>
	/// Class for testing PasswordDataField class.
	/// </summary>
	[TestFixture]
	public class PasswordDataFieldTest
	{
		private PasswordDataField m_Field = new PasswordDataField();

		[Test]
		public void Name_Ok()
		{
			Assert.AreEqual("Password field (Password:)", m_Field.Name);
		}

		[Test]
		public void Image_NotNull()
		{
			Assert.IsNotNull(m_Field.Image);
		}

		[Test]
		public void FieldControl_TypeCheck()
		{
			Assert.IsInstanceOf<PasswordDataFieldControl>(m_Field.FieldControl);
		}

		[Test]
		public void PropertiesControl_TypeCheck()
		{
			Assert.IsInstanceOf<LabelTextControl>(m_Field.PropertiesControl);
		}
	}
}

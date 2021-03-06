﻿using EdlinSoftware.Safe.SafeLib.DataFields;
using NUnit.Framework;

namespace EdlinSoftware.Safe.SafeLibTest.FieldClass
{
	/// <summary>
	/// Class for testing URLlDataField class.
	/// </summary>
	[TestFixture]
	public class URLDataFieldTest
	{
		private URLDataField m_Field = new URLDataField();

		[Test]
		public void Name_Ok()
		{
			Assert.AreEqual("Text field (URL:)", m_Field.Name);
		}

		[Test]
		public void Image_NotNull()
		{
			Assert.IsNotNull(m_Field.Image);
		}

		[Test]
		public void FieldControl_TypeCheck()
		{
			Assert.IsInstanceOf<TextDataFieldControl>(m_Field.FieldControl);
		}

		[Test]
		public void PropertiesControl_TypeCheck()
		{
			Assert.IsInstanceOf<LabelTextControl>(m_Field.PropertiesControl);
		}
	}
}

using EdlinSoftware.Safe.SafeLib.DataFields;
using NUnit.Framework;

namespace EdlinSoftware.Safe.SafeLibTest.FieldClass
{
	/// <summary>
	/// Class for testing EMailDataField class.
	/// </summary>
	[TestFixture]
	public class EMailDataFieldTest
	{
		private EMailDataField m_Field = new EMailDataField();

		[Test]
		public void Name_Ok()
		{
			Assert.AreEqual("Text field (EMail:)", m_Field.Name);
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

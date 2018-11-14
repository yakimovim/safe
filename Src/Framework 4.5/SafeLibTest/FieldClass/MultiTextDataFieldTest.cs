using EdlinSoftware.Safe.SafeLib.DataFields;
using NUnit.Framework;

namespace EdlinSoftware.Safe.SafeLibTest.FieldClass
{
	/// <summary>
	/// Class for testing MultiTextDataField class.
	/// </summary>
	[TestFixture]
	public class MultiTextDataFieldTest
	{
		private MultiTextDataField m_Field = new MultiTextDataField();

		[Test]
		public void Name_Ok()
		{
			Assert.AreEqual("Multiline text field", m_Field.Name);
		}

		[Test]
		public void Image_NotNull()
		{
			Assert.IsNotNull(m_Field.Image);
		}

		[Test]
		public void FieldControl_TypeCheck()
		{
			Assert.IsInstanceOf<MultiTextDataFieldControl>(m_Field.FieldControl);
		}

		[Test]
		public void PropertiesControl_TypeCheck()
		{
			Assert.IsInstanceOf<LabelTextControl>(m_Field.PropertiesControl);
		}
	}
}

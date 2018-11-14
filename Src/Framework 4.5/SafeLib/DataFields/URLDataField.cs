using System;
using System.Runtime.Serialization;

namespace EdlinSoftware.Safe.SafeLib.DataFields
{
	/// <summary>
	/// Data field for URL.
	/// </summary>
	[Serializable]
	public class URLDataField : TextDataField
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		public URLDataField() : base()
		{
			m_Label = "URL:";
			m_PropertiesControl.LabelText = m_Label;
			m_FieldControl.Label = m_Label;
		}

		/// <summary>
		/// Deserialization constructor.
		/// </summary>
		/// <param name="context">The destination (see <see cref="T:System.Runtime.Serialization.StreamingContext"></see>) for this serialization. </param>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> to populate with data. </param>
		public URLDataField( SerializationInfo info, StreamingContext context ) : base( info, context )
		{}
	}
}

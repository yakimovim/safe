using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Serialization;
using System.Windows.Forms;
using EdlinSoftware.Safe.SafeLib.Properties;

namespace EdlinSoftware.Safe.SafeLib.DataFields
{
	/// <summary>
	/// Data field with multiline text box.
	/// </summary>
	[Serializable]
	public class MultiTextDataField : IDataField
	{
		#region Fields
		/// <summary>
		/// Name of data field.
		/// </summary>
		[DebuggerBrowsable( DebuggerBrowsableState.Never )]
		protected readonly string m_Name = "Multiline text field";
		/// <summary>
		/// Control for entering user information.
		/// </summary>
		[DebuggerBrowsable( DebuggerBrowsableState.Never )]
		protected readonly MultiTextDataFieldControl m_FieldControl = new MultiTextDataFieldControl();
		/// <summary>
		/// Control for setting data field properties.
		/// </summary>
		[DebuggerBrowsable( DebuggerBrowsableState.Never )]
		protected readonly LabelTextControl m_PropertiesControl = new LabelTextControl();
		/// <summary>
		/// User text.
		/// </summary>
		protected string m_Text;
		/// <summary>
		/// Prompt for user text.
		/// </summary>
		protected string m_Label;
		#endregion

		#region IDataField Members

		/// <summary>
		/// Parent list of fields.
		/// </summary>
		public FieldsList ParentList { get; set; }

		/// <summary>
		/// Name of data field.
		/// </summary>
		public string Name
		{
			[DebuggerStepThrough]
			get
			{
				if( string.IsNullOrEmpty( m_Label ) )
					return m_Name;
				else
					return m_Name + " (" + m_Label + ")";
			}
		}

		/// <summary>
		/// Image of data field.
		/// </summary>
		public virtual Image Image
		{
			[DebuggerStepThrough]
			get { return Resources.MultiTextDataField; }
		}

		/// <summary>
		/// Control for storing user data.
		/// </summary>
		public Control FieldControl
		{
			[DebuggerStepThrough]
			get { return m_FieldControl; }
		}

		/// <summary>
		/// Control for editing properties of field control.
		/// </summary>
		public Control PropertiesControl
		{
			[DebuggerStepThrough]
			get { return m_PropertiesControl; }
		}

		/// <summary>
		/// Saves data from field control.
		/// </summary>
		[DebuggerStepThrough]
		public void SaveData()
		{
			m_Text = m_FieldControl.Data;
		}

		/// <summary>
		/// Saves properties from properties control.
		/// </summary>
		[DebuggerStepThrough]
		public void SaveProperties()
		{
			m_Label = m_PropertiesControl.LabelText;
			m_FieldControl.Label = m_Label;
		}

		/// <summary>
		/// Does this field contain given text.
		/// </summary>
		/// <param name="text">Text to search.</param>
		/// <returns>True if field contains given text; false, otherwise.</returns>
		/// <exception cref="ArgumentNullException">Text is null or empty.</exception>
		public bool ContainsText(string text)
		{
			if (string.IsNullOrEmpty(text))
				throw new ArgumentNullException("text");

			if (string.IsNullOrEmpty(m_Text))
				return false;

			return (m_Text.IndexOf(text, StringComparison.CurrentCultureIgnoreCase) != -1);
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Constructor.
		/// </summary>
		[DebuggerStepThrough]
		public MultiTextDataField()
		{}

		/// <summary>
		/// Deserialization constructor.
		/// </summary>
		/// <param name="context">The destination (see <see cref="T:System.Runtime.Serialization.StreamingContext"></see>) for this serialization. </param>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> to populate with data. </param>
		public MultiTextDataField( SerializationInfo info, StreamingContext context )
		{
			m_Label = info.GetString( "Label" );

			m_FieldControl.Label = m_Label;
			m_PropertiesControl.LabelText = m_Label;

			m_Text = info.GetString( "Data" );

			m_FieldControl.Data = m_Text;
		}
		#endregion

		#region ISerializable Members

		///<summary>
		///Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> with the data needed to serialize the target object.
		///</summary>
		///
		///<param name="context">The destination (see <see cref="T:System.Runtime.Serialization.StreamingContext"></see>) for this serialization. </param>
		///<param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> to populate with data. </param>
		///<exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		public void GetObjectData( SerializationInfo info, StreamingContext context )
		{
			info.AddValue( "Label", m_Label );
			info.AddValue( "Data", m_Text );
		}

		#endregion
	}
}

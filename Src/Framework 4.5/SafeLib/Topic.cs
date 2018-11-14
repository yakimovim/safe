using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Serialization;

namespace EdlinSoftware.Safe.SafeLib
{
	/// <summary>
	/// Class of topic.
	/// </summary>
	[Serializable]
	public class Topic : ISerializable
	{
		[DebuggerBrowsable( DebuggerBrowsableState.Never )]
		private readonly TopicsList m_SubTopics = new TopicsList();
		[DebuggerBrowsable( DebuggerBrowsableState.Never )]
		private readonly FieldsList m_DataFields = new FieldsList();
		[DebuggerBrowsable( DebuggerBrowsableState.Never )]
		private string m_Name;
		[DebuggerBrowsable( DebuggerBrowsableState.Never )]
		private string m_Description;
		[DebuggerBrowsable( DebuggerBrowsableState.Never )]
		private Image m_Image;

        /// <summary>
		/// List of subtopics.
		/// </summary>
		public TopicsList SubTopics
		{
			[DebuggerStepThrough]
			get { return m_SubTopics; }
		}

		/// <summary>
		/// List of data fields.
		/// </summary>
		public FieldsList Fields
		{
			[DebuggerStepThrough]
			get { return m_DataFields; }
		}

		/// <summary>
		/// Name of topic.
		/// </summary>
		public string Name
		{
			[DebuggerStepThrough]
			get { return m_Name ?? string.Empty; }
			[DebuggerStepThrough]
			set { m_Name = value; }
		}

		/// <summary>
		/// Description of topic.
		/// </summary>
		public string Description
		{
			[DebuggerStepThrough]
			get { return m_Description ?? string.Empty; }
			[DebuggerStepThrough]
			set { m_Description = value; }
		}

		/// <summary>
		/// Image of topic.
		/// </summary>
		public Image Image
		{
			[DebuggerStepThrough]
			get { return m_Image; }
			[DebuggerStepThrough]
			set { m_Image = value; }
		}

		/// <summary>
		/// List of topics where this topic is.
		/// </summary>
		public TopicsList ParentList { get; set; }

        /// <summary>
		/// Constructor.
		/// </summary>
		[DebuggerStepThrough]
		public Topic()
		{ }

		/// <summary>
		/// Deserialization constructor.
		/// </summary>
		/// <param name="context">The destination (see <see cref="T:System.Runtime.Serialization.StreamingContext"></see>) for this serialization. </param>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> to populate with data. </param>
		protected Topic( SerializationInfo info, StreamingContext context )
		{
			m_SubTopics = (TopicsList) info.GetValue( "SubTopics", typeof( TopicsList ) );
			m_SubTopics.ParentTopic = this;
			m_DataFields = (FieldsList) info.GetValue( "Fields", typeof( FieldsList ) );
			m_DataFields.ParentTopic = this;
			m_Name = info.GetString( "Name" );
			m_Description = info.GetString( "Description" );
			m_Image = (Image) info.GetValue( "Image", typeof( Image ) );
		}

		///<summary>
		///Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> with the data needed to serialize the target object.
		///</summary>
		///
		///<param name="context">The destination (see <see cref="T:System.Runtime.Serialization.StreamingContext"></see>) for this serialization. </param>
		///<param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> to populate with data. </param>
		///<exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		public void GetObjectData( SerializationInfo info, StreamingContext context )
		{
			info.AddValue( "SubTopics", SubTopics, typeof( TopicsList ) );
			info.AddValue( "Fields", Fields, typeof( FieldsList ) );
			info.AddValue( "Name", Name );
			info.AddValue( "Description", Description );
			info.AddValue( "Image", Image, typeof( Image ) );
		}
	}
}

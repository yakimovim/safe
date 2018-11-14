using EdlinSoftware.Safe.SafeLib;
using EdlinSoftware.Safe.SafeLibTest.Properties;
using NUnit.Framework;

namespace EdlinSoftware.Safe.SafeLibTest.TopicClass
{
	/// <summary>
	/// Class for testing Topic class.
	/// </summary>
	[TestFixture]
	public class TopicTest
	{
		private Topic m_Topic;
		private Topic m_SubTopic;

		[SetUp]
		public void SetUp()
		{
			m_Topic = new Topic();

			m_Topic.Name = "Topic name";
			m_Topic.Description = "Topic description";
			m_Topic.Image = Resources.TestIcon.ToBitmap();

			m_Topic.ParentList = new TopicsList();

			m_SubTopic = new Topic();
			m_Topic.SubTopics.Add( m_SubTopic );
		}

		[Test]
		public void Name()
		{
			Assert.AreEqual( "Topic name", m_Topic.Name );
		}

		[Test]
		public void Description()
		{
			Assert.AreEqual( "Topic description", m_Topic.Description );
		}

		[Test]
		public void Icon()
		{
			Assert.IsNotNull( m_Topic.Image );
		}

		[Test]
		public void SubTopics_NotNull()
		{
			Assert.IsNotNull( m_Topic.SubTopics );
		}

		[Test]
		public void SubTopics_Content()
		{
			Assert.AreEqual( 1, m_Topic.SubTopics.Count );
			Assert.AreSame( m_SubTopic, m_Topic.SubTopics[ 0 ] );
		}

		[Test]
		public void Fields_NotNull()
		{
			Assert.IsNotNull( m_Topic.Fields );
		}

		[Test]
		public void Fields_Content()
		{
			Assert.AreEqual( 0, m_Topic.Fields.Count );
		}

		[Test]
		public void ParentList_NotNull()
		{
			Assert.IsNotNull(m_Topic.ParentList);
		}
	}
}

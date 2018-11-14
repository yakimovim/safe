using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using EdlinSoftware.Safe.SafeLib;

namespace EdlinSoftware.Safe.SafeLibTest
{
	/// <summary>
	/// Class for testing of Searcher.
	/// </summary>
	[TestFixture]
	public class SearcherTest
	{
		private TopicsList m_List;

		[SetUp]
		public void SetUp()
		{
			m_List = new TopicsList();

			Topic t1 = new Topic();
			t1.Name = "t1";
			t1.Description = "Topic d1";
			m_List.Add(t1);

			TestDataField f = new TestDataField();
			t1.Fields.Add(f);

			Topic t11 = new Topic();
			t11.Name = "t11";
			t11.Description = "Topic d11";
			t1.SubTopics.Add(t11);

			Topic t12 = new Topic();
			t12.Name = "t12";
			t12.Description = "Topic d12";
			t1.SubTopics.Add(t12);

			Topic t2 = new Topic();
			t2.Name = "t2";
			t2.Description = "Topic d2";
			m_List.Add(t2);

			Topic t21 = new Topic();
			t21.Name = "t21";
			t21.Description = "Topic d21";
			t2.SubTopics.Add(t21);

			Topic t22 = new Topic();
			t22.Name = "t22";
			t22.Description = "Topic d22";
			t2.SubTopics.Add(t22);
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void Searcher_Search_NullString_ArgumentNullException()
		{
			Searcher.Search(m_List, null);
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void Searcher_Search_EmptyString_ArgumentNullException()
		{
			Searcher.Search(m_List, string.Empty);
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void Searcher_Search_NullList_ArgumentNullException()
		{
			Searcher.Search(null, "Some text");
		}

		[Test]
		public void Searcher_Search_AbsentString_Null()
		{
			Assert.IsNull(Searcher.Search(m_List, "Absent string"));
		}

		[Test]
		public void Searcher_Search_ExistedInNameString_Topic()
		{
			Assert.AreSame(m_List[0], Searcher.Search(m_List, "t1"));
		}

		[Test]
		public void Searcher_Search_ExistedInDescriptionString_Topic()
		{
			Assert.AreSame(m_List[0], Searcher.Search(m_List, "d1"));
		}

		[Test]
		public void Searcher_Search_ExistedInFieldString_Topic()
		{
			Assert.AreSame(m_List[0], Searcher.Search(m_List, "f"));
		}

		[Test]
		public void Searcher_Search_ExistedInSubtopicNameString_Topic()
		{
			Assert.AreSame(m_List[0].SubTopics[0], Searcher.Search(m_List, "t11"));
		}

		[Test]
		public void Searcher_Search_ExistedInSubtopicDescriptionString_Topic()
		{
			Assert.AreSame(m_List[0].SubTopics[0], Searcher.Search(m_List, "d11"));
		}

		[Test]
		public void Searcher_SearchNext_Null()
		{
			Assert.AreSame(m_List[0].SubTopics[0], Searcher.Search(m_List, "t11"));
			Assert.IsNull(Searcher.SearchNext());
		}

		[Test]
		public void Searcher_SearchNext_Topic()
		{
			Assert.AreSame(m_List[0], Searcher.Search(m_List, "t1"));
			Assert.AreSame(m_List[0].SubTopics[0], Searcher.SearchNext());
		}

		[Test]
		public void Searcher_SearchNext_Sequence()
		{
			Assert.AreSame(m_List[0], Searcher.Search(m_List, "t1"));
			Assert.AreSame(m_List[0].SubTopics[0], Searcher.SearchNext());
			Assert.AreSame(m_List[0].SubTopics[1], Searcher.SearchNext());
			Assert.IsNull(Searcher.SearchNext());
			Assert.AreSame(m_List[0], Searcher.SearchNext());
		}

		[Test]
		public void Searcher_SearchNext_LargeSequence()
		{
			Assert.AreSame(m_List[0], Searcher.Search(m_List, "Topic"));

			for (int i = 0; i < 5; i++)
			{
				Assert.IsNotNull(Searcher.SearchNext());
			}

			Assert.IsNull(Searcher.SearchNext());
	
			Assert.AreSame(m_List[0], Searcher.SearchNext());
		}

		[Test]
		public void Searcher_SearchNext_InTheSame()
		{
			Assert.AreSame(m_List[1].SubTopics[1], Searcher.Search(m_List, "22"));

			Assert.IsNull(Searcher.SearchNext());
			Assert.AreSame(m_List[1].SubTopics[1], Searcher.SearchNext());
		}
	}

	internal class TestDataField : IDataField
	{
		#region IDataField Members

		public FieldsList ParentList
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public System.Drawing.Image Image
		{
			get;
			set;
		}

		public System.Windows.Forms.Control FieldControl
		{
			get { throw new NotImplementedException(); }
		}

		public System.Windows.Forms.Control PropertiesControl
		{
			get { throw new NotImplementedException(); }
		}

		public void SaveData()
		{
			throw new NotImplementedException();
		}

		public void SaveProperties()
		{
			throw new NotImplementedException();
		}

		public bool ContainsText(string text)
		{
			return "f1".IndexOf(text, StringComparison.CurrentCultureIgnoreCase) != -1;
		}

		#endregion

		#region ISerializable Members

		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}

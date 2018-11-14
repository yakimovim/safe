using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using EdlinSoftware.Safe.SafeLib;

namespace EdlinSoftware.Safe.SafeLibTest.TopicClass
{
	/// <summary>
	/// Class for testing TopicsList class.
	/// </summary>
	[TestFixture]
	public class TopicsListTest
	{
		private TopicsList m_List;
		private Topic m_Item;

		[SetUp]
		public void SetUp()
		{
			m_Item = new Topic();
			m_List = new TopicsList();
		}

		[Test]
		public void Constructor_Parent()
		{
			m_List = new TopicsList(m_Item);
			Assert.AreSame(m_Item, m_List.ParentTopic);
		}

		[Test]
		public void IndexOf_NotExists()
		{
			Assert.AreEqual(-1, m_List.IndexOf(m_Item));
		}

		[Test]
		public void IndexOf_Exists()
		{
			m_List.Add(m_Item);
			Assert.AreEqual(0, m_List.IndexOf(m_Item));
		}

		[Test]
		public void Insert_Ok()
		{
			m_List.Insert(0, m_Item);
			Assert.AreEqual(0, m_List.IndexOf(m_Item));
			Assert.AreSame(m_List, m_Item.ParentList);
		}

		[Test]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void Insert_RangeException()
		{
			m_List.Insert(1, m_Item);
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void Insert_NullException()
		{
			m_List.Insert(0, null);
		}

		[Test]
		public void RemoveAt_Ok()
		{
			m_List.Add(m_Item);
			Assert.AreSame(m_List, m_Item.ParentList);
			m_List.RemoveAt(0);
			Assert.AreEqual(-1, m_List.IndexOf(m_Item));
			Assert.IsNull(m_Item.ParentList);
		}

		[Test]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void RemoveAt_RangeException()
		{
			m_List.RemoveAt(10);
		}

		[Test]
		public void Indexer_Get_Ok()
		{
			m_List.Add(m_Item);
			var item = m_List[0];
			Assert.AreSame(m_Item, item);
		}

		[Test]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void Indexer_Get_RangeException()
		{
			var item = m_List[10];
		}

		[Test]
		public void Indexer_Set_Ok()
		{
			m_List.Add(m_Item);
			m_List[0] = m_Item;
			Assert.AreEqual(0, m_List.IndexOf(m_Item));
			Assert.AreSame(m_List, m_Item.ParentList);
		}

		[Test]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void Indexer_Set_RangeException()
		{
			m_List[10] = m_Item;
		}

		[Test]
		public void Add_Ok()
		{
			m_List.Add(m_Item);
			Assert.AreEqual(0, m_List.IndexOf(m_Item));
			Assert.AreSame(m_List, m_Item.ParentList);
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void Add_NullException()
		{
			m_List.Add(null);
		}

		[Test]
		public void Clear_Ok()
		{
			m_List.Add(m_Item);
			Assert.AreEqual(0, m_List.IndexOf(m_Item));
			m_List.Clear();
			Assert.AreEqual(-1, m_List.IndexOf(m_Item));
			Assert.IsNull(m_Item.ParentList);
		}

		[Test]
		public void Contains_True()
		{
			m_List.Add(m_Item);
			Assert.IsTrue(m_List.Contains(m_Item));
		}

		[Test]
		public void Contains_False()
		{
			Assert.IsFalse(m_List.Contains(m_Item));
		}

		[Test]
		public void CopyTo_Ok()
		{
			m_List.Add(m_Item);
			Topic[] arr = new Topic[m_List.Count];
			m_List.CopyTo(arr, 0);
			Assert.AreSame(m_Item, arr[0]);
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void CopyTo_NullException()
		{
			m_List.CopyTo(null, 0);
		}

		[Test]
		public void Remove_True()
		{
			m_List.Add(m_Item);
			Assert.IsTrue(m_List.Remove(m_Item));
			Assert.IsNull(m_Item.ParentList);
		}

		[Test]
		public void Remove_False()
		{
			Assert.IsFalse(m_List.Remove(m_Item));
		}

		[Test]
		public void Count_Zero()
		{
			Assert.AreEqual(0, m_List.Count);
		}

		[Test]
		public void Count_One()
		{
			m_List.Add(m_Item);
			Assert.AreEqual(1, m_List.Count);
		}

		[Test]
		public void GetEnumerator_NoItems()
		{
			Assert.IsFalse(m_List.GetEnumerator().MoveNext());
		}

		[Test]
		public void GetEnumerator_ItemsExists()
		{
			m_List.Add(m_Item);
			Assert.IsTrue(m_List.GetEnumerator().MoveNext());
		}

		[Test]
		public void Move_Ok()
		{
			m_List.Add(m_Item);
			m_List.Add(new Topic());

			m_List.Move(0, 1);
			Assert.AreEqual(1, m_List.IndexOf(m_Item));
		}

		[Test]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void Move_RangeException()
		{
			m_List.Add(m_Item);

			m_List.Move(0, 1);
		}
	}
}

using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace EdlinSoftware.Safe.SafeLib
{
    /// <summary>
    /// List of topic fields.
    /// </summary>
    [Serializable]
    public class FieldsList : Collection<IDataField>, ISerializable
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        [DebuggerStepThrough]
        public FieldsList()
            : this(null)
        { }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="parentTopic">Parent topic.</param>
        [DebuggerStepThrough]
        public FieldsList(Topic parentTopic)
        {
            ParentTopic = parentTopic;
        }

        /// <summary>
        /// Deserialization constructor.
        /// </summary>
        public FieldsList(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                return;

            // Get count of data fields
            int count = info.GetInt32("Count");

            // Get data fields
            for (int i = 0; i < count; i++)
            { Add((IDataField)info.GetValue(string.Format("DataField {0}", i), typeof(IDataField))); }
        }

        /// <summary>
        /// Parent topic.
        /// </summary>
        public Topic ParentTopic { get; set; }

        ///<summary>
        ///Inserts an item to the <see cref="T:System.Collections.Generic.IList`1"></see> at the specified index.
        ///</summary>
        ///
        ///<param name="item">The object to insert into the <see cref="T:System.Collections.Generic.IList`1"></see>.</param>
        ///<param name="index">The zero-based index at which item should be inserted.</param>
        ///<exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.IList`1"></see> is read-only.</exception>
        ///<exception cref="T:System.ArgumentOutOfRangeException">index is not a valid index in the <see cref="T:System.Collections.Generic.IList`1"></see>.</exception>
        [DebuggerStepThrough]
        protected override void InsertItem(int index, IDataField item)
        {
            if (item == null) throw new ArgumentNullException("item");

            base.InsertItem(index, item);
            item.ParentList = this;
        }

        ///<summary>
        ///Removes the <see cref="T:System.Collections.Generic.IList`1"></see> item at the specified index.
        ///</summary>
        ///
        ///<param name="index">The zero-based index of the item to remove.</param>
        ///<exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.IList`1"></see> is read-only.</exception>
        ///<exception cref="T:System.ArgumentOutOfRangeException">index is not a valid index in the <see cref="T:System.Collections.Generic.IList`1"></see>.</exception>
        [DebuggerStepThrough]
        protected override void RemoveItem(int index)
        {
            IDataField field = this[index];

            base.RemoveItem(index);

            field.ParentList = null;
        }

        /// <summary>
        /// Sets value of item at given index.
        /// </summary>
        /// <param name="index">The zero-based index of the item to set.</param>
        /// <param name="item">Item to set.</param>
        [DebuggerStepThrough]
        protected override void SetItem(int index, IDataField item)
        {
            if (item == null) throw new ArgumentNullException("item");
            base.SetItem(index, item);
            item.ParentList = this;
        }

        ///<summary>
        ///Removes all items from the <see cref="T:System.Collections.Generic.ICollection`1"></see>.
        ///</summary>
        ///
        ///<exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.ICollection`1"></see> is read-only. </exception>
        [DebuggerStepThrough]
        protected override void ClearItems()
        {
            foreach (IDataField field in this)
            { field.ParentList = null; }

            base.ClearItems();
        }

        /// <summary>
        /// Moves data field from one place to another.
        /// </summary>
        /// <param name="from">Initial place of data field.</param>
        /// <param name="to">Final place of data field.</param>
        /// <exception cref="ArgumentOutOfRangeException">Positions are out of range.</exception>
        public void Move(int from, int to)
        {
            if ((from < 0) || (from >= Count))
                throw new ArgumentOutOfRangeException("from");
            if ((to < 0) || (to >= Count))
                throw new ArgumentOutOfRangeException("to");

            IDataField dataField = this[from];
            RemoveAt(from);
            Insert(to, dataField);
        }

        ///<summary>
        ///Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> with the data needed to serialize the target object.
        ///</summary>
        ///
        ///<param name="context">The destination (see <see cref="T:System.Runtime.Serialization.StreamingContext"></see>) for this serialization. </param>
        ///<param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> to populate with data. </param>
        ///<exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Store count.
            info.AddValue("Count", Count);

            // Store data fields.
            for (int i = 0; i < Count; i++)
            { info.AddValue(string.Format("DataField {0}", i), this[i], typeof(IDataField)); }
        }
    }
}

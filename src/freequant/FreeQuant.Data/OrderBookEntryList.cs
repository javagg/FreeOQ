using System;
using System.Collections;

namespace FreeQuant.Data
{
    public class OrderBookEntryList : ICollection
    {
        private ArrayList entries;

        public bool IsSynchronized
        {
            get
            {
                return this.entries.IsSynchronized;
            }
        }

        public int Count
        {
            get
            {
                return this.entries.Count;
            }
        }

        public object SyncRoot
        {
            get
            {
                return this.entries.SyncRoot;
            }
        }

        public OrderBookEntry this[int index]
        {
            get
            {
                return this.entries[index] as OrderBookEntry;
            }
        }

        public void CopyTo(Array array, int index)
        {
            this.entries.CopyTo(array, index);
        }

        public IEnumerator GetEnumerator()
        {
            return this.entries.GetEnumerator();
        }

        internal OrderBookEntryList()
        {
            this.entries = ArrayList.Synchronized(new ArrayList());
        }

        internal void Clear()
        {
            this.entries.Clear();
        }

        internal void Insert(int index, OrderBookEntry entry)
        {
            this.entries.Insert(index, entry);
        }

        internal void RemoveAt(int index)
        {
            this.entries.RemoveAt(index);
        }
    }
}

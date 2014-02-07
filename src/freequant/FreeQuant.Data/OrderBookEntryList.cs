using System;
using System.Collections;

namespace FreeQuant.Data
{
	public class OrderBookEntryList : ICollection
	{
		private ArrayList orders;

		public bool IsSynchronized
		{
			get
			{
				return this.orders.IsSynchronized;
			}
		}

		public int Count
		{
			get
			{
				return this.orders.Count;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this.orders.SyncRoot;
			}
		}

		public OrderBookEntry this[int index]
		{
			get
			{
				return this.orders[index] as OrderBookEntry;
			}
		}

		public void CopyTo(Array array, int index)
		{
			this.orders.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.orders.GetEnumerator();
		}

		internal OrderBookEntryList()
		{
			this.orders = ArrayList.Synchronized(new ArrayList());
		}

		internal void Clear()
		{
			this.orders.Clear();
		}

		internal void Insert(int index, OrderBookEntry entry)
		{
			this.orders.Insert(index, entry);
		}

		internal void RemoveAt(int index)
		{
			this.orders.RemoveAt(index);
		}
	}
}

using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace FreeQuant.Data
{
	public class OrderBookEventArgs : EventArgs
	{
		public MDSide Side { get; set; }
		public MDOperation Operation { get; set; }
		public int Position { get; set; }

		public OrderBookEventArgs(MDSide size, MDOperation operation, int position)
		{
			this.Side = size;
			this.Operation = operation;
			this.Position = position;
		}
	}

	public delegate void OrderBookEventHandler(object sender, OrderBookEventArgs args);

	public class OrderBookEntry
	{
		public DateTime DateTime { get; set; }
		public double Price { get; set; }
		public int Size { get; set; }

		public OrderBookEntry(DateTime dateTime, double price, int size)
		{
			this.DateTime = dateTime;
			this.Price = price;
			this.Size = size;
		}
	}

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

		internal OrderBookEntryList()
		{
			this.orders = ArrayList.Synchronized(new ArrayList());
		}

		public void CopyTo(Array array, int index)
		{
			this.orders.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.orders.GetEnumerator();
		}

		internal void Clear()
		{
			this.orders.Clear();
		}

		internal void Insert([In] int index, [In] OrderBookEntry entry)
		{
			this.orders.Insert(index, entry);
		}

		internal void RemoveAt([In] int index)
		{
			this.orders.RemoveAt(index);
		}
	}
}

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Data
{
	public class OrderBookEventArgs : EventArgs
	{
		public MDSide Side { get; set; }

		public MDOperation Operation { get; set; }

		public int Position { get; set; }
	}

	public delegate void OrderBookEventHandler(object sender,OrderBookEventArgs args);

	public class OrderBookEntry
	{
		public DateTime DateTime { get; set; }

		public double Price { get; set; }

		public int Size { get; set; }
	}

	public class OrderBookEntryList : ICollection, IEnumerable
	{
		private ArrayList sOM5e8lcm;

		public bool IsSynchronized
		{
			get
			{
				return this.sOM5e8lcm.IsSynchronized;
			}
		}

		public int Count
		{
			get
			{
				return this.sOM5e8lcm.Count;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this.sOM5e8lcm.SyncRoot;
			}
		}

		public OrderBookEntry this [int index]
		{
			get
			{
				return this.sOM5e8lcm[index] as OrderBookEntry;
			}
		}

		internal OrderBookEntryList()
		{

			this.sOM5e8lcm = ArrayList.Synchronized(new ArrayList());
		}

		public void CopyTo(Array array, int index)
		{
			this.sOM5e8lcm.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.sOM5e8lcm.GetEnumerator();
		}

		internal void EeBM3flam()
		{
			this.sOM5e8lcm.Clear();
		}

		internal void H7WIwp9Mh([In] int obj0, [In] OrderBookEntry obj1)
		{
			this.sOM5e8lcm.Insert(obj0, (object)obj1);
		}

		internal void EpiQxWKO6([In] int obj0)
		{
			this.sOM5e8lcm.RemoveAt(obj0);
		}
	}
}

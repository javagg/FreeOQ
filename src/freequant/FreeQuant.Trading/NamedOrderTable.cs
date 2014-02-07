using FreeQuant.Execution;
using System;
using System.Collections;

namespace FreeQuant.Trading
{
	public class NamedOrderTable : ICollection
	{
		private Hashtable orders;

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

		public SingleOrder this[string name]
		{
			get
			{
				return this.orders[name] as SingleOrder;
			}
		}

		internal NamedOrderTable() : base()
		{
			this.orders = new Hashtable();
		}

		public void CopyTo(Array array, int index)
		{
			this.orders.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.orders.Values.GetEnumerator();
		}

		internal void vxbiSOygU5(string name, SingleOrder order)
		{
			this.orders[name] = order;
		}
	}
}

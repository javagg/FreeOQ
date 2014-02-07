using FreeQuant.Execution;
using FreeQuant.Instruments;
using System;
using System.Collections;

namespace FreeQuant.Trading
{
	public class OrderTable : ICollection
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

		public NamedOrderTable this[Instrument instrument]
		{
			get
			{
				if (!this.orders.ContainsKey(instrument))
					this.orders.Add(instrument, new NamedOrderTable());
				return this.orders[instrument] as NamedOrderTable;
			}
		}

		public SingleOrder this[Instrument instrument, string name]
		{
			get
			{
				return (this.orders[instrument] as NamedOrderTable)[name];
			}
		}

		public OrderTable() : base()
		{
			this.orders = new Hashtable();
		}

		public void CopyTo(Array array, int index)
		{
			this.orders.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			ArrayList arrayList = new ArrayList();
			foreach (DictionaryEntry dictionaryEntry1 in this.orders)
			{
				foreach (DictionaryEntry dictionaryEntry2 in (IEnumerable) dictionaryEntry1.Value)
					arrayList.Add(dictionaryEntry2.Value);
			}
			return arrayList.GetEnumerator();
		}

		public void Add(Instrument instrument, string name, SingleOrder order)
		{
			NamedOrderTable namedOrderTable;
			if (this.orders.ContainsKey(instrument))
			{
				namedOrderTable = this.orders[instrument] as NamedOrderTable;
			}
			else
			{
				namedOrderTable = new NamedOrderTable();
				this.orders.Add(instrument, namedOrderTable);
			}
			namedOrderTable.vxbiSOygU5(name, order);
		}

		public void Clear()
		{
			this.orders.Clear();
		}
	}
}

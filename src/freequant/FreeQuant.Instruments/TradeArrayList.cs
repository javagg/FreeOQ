using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.Collections;

namespace FreeQuant.Instruments
{
	public class TradeArrayList : ICollection
	{
        private Hashtable arrayList; 

		public bool IsSynchronized
		{
			get
			{
				return this.arrayList.IsSynchronized;
			}
		}

		public int Count
		{
			get
			{
				return this.arrayList.Count;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this.arrayList.SyncRoot;
			}
		}

		public TradeArray this[Instrument instrument]
		{
			get
			{
                TradeArray tradeArray = this.arrayList[instrument] as TradeArray;
				if (tradeArray == null)
				{
					tradeArray = new TradeArray();
					this.arrayList.Add(instrument, tradeArray);
				}
				return tradeArray;
			}
		}

		public TradeArrayList()
		{
			this.arrayList = new Hashtable();
		}

		public void CopyTo(Array array, int index)
		{
			this.arrayList.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.arrayList.GetEnumerator();
		}

		public void Clear(bool dataOnly)
		{
			if (dataOnly)
			{
				foreach (DataArray dataArray in (IEnumerable)this.arrayList.Values)
					dataArray.Clear();
			}
			else
				this.arrayList.Clear();
		}
	}
}

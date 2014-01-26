using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.Collections;

namespace FreeQuant.Instruments
{
	public class TradeArrayList : ICollection
	{
		private Hashtable trades;

		public bool IsSynchronized
		{
			get
			{
				return this.trades.IsSynchronized;
			}
		}

		public int Count
		{
			get
			{
				return this.trades.Count;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this.trades.SyncRoot;
			}
		}

		public TradeArray this [Instrument instrument]
		{
			get
			{
				TradeArray tradeArray = this.trades[(object)instrument] as TradeArray;
				if (tradeArray == null)
				{
					tradeArray = new TradeArray();
					this.trades.Add((object)instrument, (object)tradeArray);
				}
				return tradeArray;
			}
		}

		public TradeArrayList()
		{
			this.trades = new Hashtable();
		}

		public void CopyTo(Array array, int index)
		{
			this.trades.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return (IEnumerator)this.trades.GetEnumerator();
		}

		public void Clear(bool dataOnly)
		{
			if (dataOnly)
			{
				foreach (DataArray dataArray in (IEnumerable) this.trades.Values)
					dataArray.Clear();
			}
			else
				this.trades.Clear();
		}
	}
}

using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
	public class QuoteArrayList : ICollection, IEnumerable
	{
		private Hashtable quotes;

		public bool IsSynchronized
		{
			get
			{
				return this.quotes.IsSynchronized;
			}
		}

		public int Count
		{
			get
			{
				return this.quotes.Count;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this.quotes.SyncRoot;
			}
		}

		public QuoteArray this [Instrument instrument]
		{
			get
			{
				QuoteArray quoteArray = this.quotes[(object)instrument] as QuoteArray;
				if (quoteArray == null)
				{
					quoteArray = new QuoteArray();
					this.quotes.Add((object)instrument, (object)quoteArray);
				}
				return quoteArray;
			}
		}

		public QuoteArrayList()
		{
			this.quotes = new Hashtable();
		}

		public void CopyTo(Array array, int index)
		{
			this.quotes.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return (IEnumerator)this.quotes.GetEnumerator();
		}

		public void Clear(bool dataOnly)
		{
			if (dataOnly)
			{
				foreach (DataArray dataArray in (IEnumerable) this.quotes.Values)
					dataArray.Clear();
			}
			else
				this.quotes.Clear();
		}
	}
}

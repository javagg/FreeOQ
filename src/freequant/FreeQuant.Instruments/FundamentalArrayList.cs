using FreeQuant.Data;
using FreeQuant.FIXData;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
	public class FundamentalArrayList : ICollection, IEnumerable
	{
		private Hashtable fundamentals;

		public bool IsSynchronized
		{
			get
			{
				return this.fundamentals.IsSynchronized;
			}
		}

		public int Count
		{
			get
			{
				return this.fundamentals.Count; 
			}
		}

		public object SyncRoot
		{
			get
			{
				return this.fundamentals.SyncRoot;
			}
		}

		public FundamentalArray this [Instrument instrument]
		{
			get
			{
				FundamentalArray fundamentalArray = this.fundamentals[(object)instrument] as FundamentalArray;
				if (fundamentalArray == null)
				{
					fundamentalArray = new FundamentalArray();
					this.fundamentals.Add((object)instrument, (object)fundamentalArray);
				}
				return fundamentalArray;
			}
		}

		public FundamentalArrayList()
		{
			this.fundamentals = new Hashtable();
		}

		public void CopyTo(Array array, int index)
		{
			this.fundamentals.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return (IEnumerator)this.fundamentals.GetEnumerator();
		}

		public void Clear(bool dataOnly)
		{
			if (dataOnly)
			{
				foreach (DataArray dataArray in (IEnumerable) this.fundamentals.Values)
					dataArray.Clear();
			}
			else
				this.fundamentals.Clear();
		}
	}
}

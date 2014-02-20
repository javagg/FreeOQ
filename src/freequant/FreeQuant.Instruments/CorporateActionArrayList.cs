using FreeQuant.Data;
using FreeQuant.FIXData;
using System;
using System.Collections;

namespace FreeQuant.Instruments
{
	public class CorporateActionArrayList : ICollection, IEnumerable
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

		public CorporateActionArray this[Instrument instrument]
		{
			get
			{
				CorporateActionArray corporateActionArray = this.arrayList[instrument] as CorporateActionArray;
				if (corporateActionArray == null)
				{
					corporateActionArray = new CorporateActionArray();
					this.arrayList.Add(instrument, corporateActionArray);
				}
				return corporateActionArray;
			}
		}

		public CorporateActionArrayList()
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
				foreach (DataArray dataArray in this.arrayList.Values)
					dataArray.Clear();
			}
			else
				this.arrayList.Clear();
		}
	}
}

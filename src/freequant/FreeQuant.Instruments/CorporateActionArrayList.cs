using FreeQuant.Data;
using FreeQuant.FIXData;
using System;
using System.Collections;

namespace FreeQuant.Instruments
{
	public class CorporateActionArrayList : ICollection, IEnumerable
	{
		private Hashtable corporateActions;

		public bool IsSynchronized
		{
			get
			{
				return this.corporateActions.IsSynchronized;
			}
		}

		public int Count
		{
			get
			{
				return this.corporateActions.Count;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this.corporateActions.SyncRoot;
			}
		}

		public CorporateActionArray this [Instrument instrument]
		{
			get
			{
				CorporateActionArray corporateActionArray = this.corporateActions[(object)instrument] as CorporateActionArray;
				if (corporateActionArray == null)
				{
					corporateActionArray = new CorporateActionArray();
					this.corporateActions.Add((object)instrument, (object)corporateActionArray);
				}
				return corporateActionArray;
			}
		}

		public CorporateActionArrayList()
		{
			this.corporateActions = new Hashtable();
		}

		public void CopyTo(Array array, int index)
		{
			this.corporateActions.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return (IEnumerator)this.corporateActions.GetEnumerator();
		}

		public void Clear(bool dataOnly)
		{
			if (dataOnly)
			{
				foreach (DataArray dataArray in (IEnumerable) this.corporateActions.Values)
					dataArray.Clear();
			}
			else
				this.corporateActions.Clear();
		}
	}
}

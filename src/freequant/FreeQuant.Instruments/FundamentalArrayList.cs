using FreeQuant.Data;
using FreeQuant.FIXData;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
    public class FundamentalArrayList : ICollection, IEnumerable
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

        public FundamentalArray this [Instrument instrument]
        {
            get
            {
                FundamentalArray fundamentalArray = this.arrayList[instrument] as FundamentalArray;
                if (fundamentalArray == null)
                {
                    fundamentalArray = new FundamentalArray();
                    this.arrayList.Add(instrument, fundamentalArray);
                }
                return fundamentalArray;
            }
        }

        public FundamentalArrayList()
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

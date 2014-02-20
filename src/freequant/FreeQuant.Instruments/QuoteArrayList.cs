using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.Collections;

namespace FreeQuant.Instruments
{
    public class QuoteArrayList : ICollection
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

        public QuoteArray this [Instrument instrument]
        {
            get
            {
                QuoteArray quoteArray = this.arrayList[instrument] as QuoteArray;
                if (quoteArray == null)
                {
                    quoteArray = new QuoteArray();
                    this.arrayList.Add(instrument, quoteArray);
                }
                return quoteArray;
            }
        }

        public QuoteArrayList()
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

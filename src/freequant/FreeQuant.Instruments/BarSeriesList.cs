using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.Collections;

namespace FreeQuant.Instruments
{
    public class BarSeriesList : ICollection
    {
        private const long DEFAULT_BARISZE = 86400;
        private const BarType DEFAULT_BARTYPE = BarType.Time;
        private Hashtable list;
        private Hashtable listByIntrument;
        private BarType barType;
        private long barSize;
        private bool MSDWvxa7A1;

        public bool IsSynchronized
        {
            get
            {
                return this.list.IsSynchronized;
            }
        }

        public int Count
        {
            get
            {
                return this.list.Count;
            }
        }

        public object SyncRoot
        {
            get
            {
                return this.list.SyncRoot;
            }
        }

        public BarSeries this [Instrument instrument, BarType barType, long barSize]
        {
            get
            {
                if (this.MSDWvxa7A1)
                {
                    Hashtable hashtable = this.JqsWcXm11r(instrument, barType);
                    BarSeries barSeries = hashtable[barSize] as BarSeries;
                    if (barSeries == null)
                    {
                        barSeries = new BarSeries(string.Format("{0}-{1}-{2}", instrument.Symbol, barType, barSize));
                        hashtable.Add(barSize, barSeries);
                        if (this.BarSeriesAdded != null)
                            this.BarSeriesAdded(this, new BarSeriesEventArgs(barSeries, instrument));
                    }
                    return barSeries;
                }
                else
                {
                    this.barType = barType;
                    this.barSize = barSize;
                    Hashtable hashtable = new Hashtable(this.listByIntrument);
                    foreach (DictionaryEntry entry in this.listByIntrument)
                    {
                        Instrument instrument1 = entry.Key as Instrument;
                        BarSeries barSeries = entry.Value as BarSeries;
                        barSeries.Name = string.Format("{0}", instrument1.Symbol, barType, barSize);
                        this.JqsWcXm11r(instrument1, barType).Add(barSize, barSeries);
                    }
                    this.listByIntrument.Clear();
                    this.MSDWvxa7A1 = true;
                    BarSeries barSeries1 = this[instrument, barType, barSize];
                    foreach (DictionaryEntry dictionaryEntry in hashtable)
                    {
                        if (this.BarSeriesRenamed != null)
                            this.BarSeriesRenamed(this, new BarSeriesEventArgs(dictionaryEntry.Value as BarSeries, dictionaryEntry.Key as Instrument));
                    }
                    return barSeries1;
                }
            }
        }

        public BarSeries this [Instrument instrument]
        {
            get
            {
                if (this.MSDWvxa7A1)
                {
                    return this[instrument, this.barType, this.barSize];
                }

                BarSeries barSeries = this.listByIntrument[instrument] as BarSeries;
                if (barSeries == null)
                {
                    barSeries = new BarSeries(instrument.Symbol);
                    this.listByIntrument.Add(instrument, barSeries);
                    if (this.BarSeriesAdded != null)
                    {
                        this.BarSeriesAdded(this, new BarSeriesEventArgs(barSeries, instrument));
                    }
                }
                return barSeries;
            }
        }

        public event BarSeriesEventHandler BarSeriesAdded;
        public event BarSeriesEventHandler BarSeriesRenamed;

        internal BarSeriesList()
        {
            this.list = new Hashtable();
            this.listByIntrument = new Hashtable();
            this.barType = DEFAULT_BARTYPE;
            this.barSize = DEFAULT_BARISZE;
            this.MSDWvxa7A1 = false;
        }

        public void CopyTo(Array array, int index)
        {
            this.list.CopyTo(array, index);
        }

        public IEnumerator GetEnumerator()
        {
            Hashtable hashtable = new Hashtable();
            foreach (DictionaryEntry dictionaryEntry1 in this.list)
            {
                Instrument instrument = dictionaryEntry1.Key as Instrument;
                ArrayList arrayList = hashtable[instrument] as ArrayList;
                if (arrayList == null)
                {
                    arrayList = new ArrayList();
                    hashtable.Add(instrument, arrayList);
                }
                foreach (DictionaryEntry dictionaryEntry2 in (IEnumerable)dictionaryEntry1.Value)
                {
                    foreach (DictionaryEntry dictionaryEntry3 in (IEnumerable)dictionaryEntry2.Value)
                        arrayList.Add(dictionaryEntry3.Value);
                }
            }
            foreach (DictionaryEntry dictionaryEntry in this.listByIntrument)
            {
                Instrument instrument = dictionaryEntry.Key as Instrument;
                ArrayList arrayList = hashtable[instrument] as ArrayList;
                if (arrayList == null)
                {
                    arrayList = new ArrayList();
                    hashtable.Add(instrument, arrayList);
                }
                arrayList.Add(dictionaryEntry.Value);
            }
            return hashtable.GetEnumerator();
        }

        internal void Clear()
        {
            this.list.Clear();
            this.listByIntrument.Clear();
            this.MSDWvxa7A1 = false;
        }

        internal void Add(Instrument instrument, Bar bar)
        {
            this[instrument, bar.BarType, bar.Size].Add(bar);
        }

        private Hashtable JqsWcXm11r(Instrument instrument, BarType barType)
        {
            Hashtable hashtable1 = this.list[instrument] as Hashtable;
            if (hashtable1 == null)
            {
                hashtable1 = new Hashtable();
                this.list.Add(instrument, hashtable1);
            }
            Hashtable hashtable2 = hashtable1[barType] as Hashtable;
            if (hashtable2 == null)
            {
                hashtable2 = new Hashtable();
                hashtable1.Add(barType, hashtable2);
            }
            return hashtable2;
        }
    }
}

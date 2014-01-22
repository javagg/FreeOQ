using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Instruments
{
  public class BarSeriesList : ICollection, IEnumerable
  {
    private Hashtable a0SWypH8TX;
    private Hashtable ET8WqOYmDx;
    private BarType o4gWf6UiaB;
    private long MrWWpP4XKI;
    private bool MSDWvxa7A1;

    public bool IsSynchronized
    {
        get
      {
        return this.a0SWypH8TX.IsSynchronized;
      }
    }

    public int Count
    {
        get
      {
        return this.a0SWypH8TX.Count;
      }
    }

    public object SyncRoot
    {
       get
      {
        return this.a0SWypH8TX.SyncRoot;
      }
    }

    public BarSeries this[Instrument instrument, BarType barType, long barSize]
    {
       get
      {
        if (this.MSDWvxa7A1)
        {
          Hashtable hashtable = this.JqsWcXm11r(instrument, barType);
          BarSeries barSeries = hashtable[(object) barSize] as BarSeries;
          if (barSeries == null)
          {
						barSeries = new BarSeries(string.Format("ddd", instrument.Symbol, barType, barSize));
            hashtable.Add((object) barSize, (object) barSeries);
//            if (this.ojGWVrrEwl != null)
//              this.ojGWVrrEwl((object) this, new BarSeriesEventArgs(barSeries, instrument));
          }
          return barSeries;
        }
        else
        {
          this.o4gWf6UiaB = barType;
          this.MrWWpP4XKI = barSize;
          Hashtable hashtable = new Hashtable((IDictionary) this.ET8WqOYmDx);
          foreach (DictionaryEntry dictionaryEntry in this.ET8WqOYmDx)
          {
            Instrument instrument1 = dictionaryEntry.Key as Instrument;
            BarSeries barSeries = dictionaryEntry.Value as BarSeries;
						barSeries.Name = string.Format("{0}", (object) instrument1.Symbol, (object) barType, (object) barSize);
            this.JqsWcXm11r(instrument1, barType).Add((object) barSize, (object) barSeries);
          }
          this.ET8WqOYmDx.Clear();
          this.MSDWvxa7A1 = true;
          BarSeries barSeries1 = this[instrument, barType, barSize];
          foreach (DictionaryEntry dictionaryEntry in hashtable)
          {
//            if (this.BiWWFq4eYA != null)
//              this.BiWWFq4eYA((object) this, new BarSeriesEventArgs(dictionaryEntry.Value as BarSeries, dictionaryEntry.Key as Instrument));
          }
          return barSeries1;
        }
      }
    }

    public BarSeries this[Instrument instrument]
    {
       get
      {
        if (this.MSDWvxa7A1)
          return this[instrument, this.o4gWf6UiaB, this.MrWWpP4XKI];
        BarSeries barSeries = this.ET8WqOYmDx[(object) instrument] as BarSeries;
        if (barSeries == null)
        {
          barSeries = new BarSeries(instrument.Symbol);
          this.ET8WqOYmDx.Add((object) instrument, (object) barSeries);
//          if (this.ojGWVrrEwl != null)
//            this.ojGWVrrEwl((object) this, new BarSeriesEventArgs(barSeries, instrument));
        }
        return barSeries;
      }
    }

    public event BarSeriesEventHandler BarSeriesAdded;

    public event BarSeriesEventHandler BarSeriesRenamed;

    
    internal BarSeriesList()
    {
      this.a0SWypH8TX = new Hashtable();
      this.ET8WqOYmDx = new Hashtable();
      this.o4gWf6UiaB = BarType.Time;
      this.MrWWpP4XKI = 86400L;
      this.MSDWvxa7A1 = false;
    }

    
    public void CopyTo(Array array, int index)
    {
      this.a0SWypH8TX.CopyTo(array, index);
    }

    
    public IEnumerator GetEnumerator()
    {
      Hashtable hashtable = new Hashtable();
      foreach (DictionaryEntry dictionaryEntry1 in this.a0SWypH8TX)
      {
        Instrument instrument = dictionaryEntry1.Key as Instrument;
        ArrayList arrayList = hashtable[(object) instrument] as ArrayList;
        if (arrayList == null)
        {
          arrayList = new ArrayList();
          hashtable.Add((object) instrument, (object) arrayList);
        }
        foreach (DictionaryEntry dictionaryEntry2 in (IEnumerable) dictionaryEntry1.Value)
        {
          foreach (DictionaryEntry dictionaryEntry3 in (IEnumerable) dictionaryEntry2.Value)
            arrayList.Add(dictionaryEntry3.Value);
        }
      }
      foreach (DictionaryEntry dictionaryEntry in this.ET8WqOYmDx)
      {
        Instrument instrument = dictionaryEntry.Key as Instrument;
        ArrayList arrayList = hashtable[(object) instrument] as ArrayList;
        if (arrayList == null)
        {
          arrayList = new ArrayList();
          hashtable.Add((object) instrument, (object) arrayList);
        }
        arrayList.Add(dictionaryEntry.Value);
      }
      return (IEnumerator) hashtable.GetEnumerator();
    }

    
    internal void oohW0girCj()
    {
      this.a0SWypH8TX.Clear();
      this.ET8WqOYmDx.Clear();
      this.MSDWvxa7A1 = false;
    }

    
    internal void J4qWHe7JIm([In] Instrument obj0, [In] Bar obj1)
    {
      this[obj0, obj1.BarType, obj1.Size].Add(obj1);
    }

    
    private Hashtable JqsWcXm11r([In] Instrument obj0, [In] BarType obj1)
    {
      Hashtable hashtable1 = this.a0SWypH8TX[(object) obj0] as Hashtable;
      if (hashtable1 == null)
      {
        hashtable1 = new Hashtable();
        this.a0SWypH8TX.Add((object) obj0, (object) hashtable1);
      }
      Hashtable hashtable2 = hashtable1[(object) obj1] as Hashtable;
      if (hashtable2 == null)
      {
        hashtable2 = new Hashtable();
        hashtable1.Add((object) obj1, (object) hashtable2);
      }
      return hashtable2;
    }
  }
}

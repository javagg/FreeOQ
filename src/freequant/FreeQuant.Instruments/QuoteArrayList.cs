// Type: SmartQuant.Instruments.QuoteArrayList
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
  public class QuoteArrayList : ICollection, IEnumerable
  {
    private Hashtable sC4spJbwVJ;

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.sC4spJbwVJ.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.sC4spJbwVJ.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.sC4spJbwVJ.SyncRoot;
      }
    }

    public QuoteArray this[Instrument instrument]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        QuoteArray quoteArray = this.sC4spJbwVJ[(object) instrument] as QuoteArray;
        if (quoteArray == null)
        {
          quoteArray = new QuoteArray();
          this.sC4spJbwVJ.Add((object) instrument, (object) quoteArray);
        }
        return quoteArray;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuoteArrayList()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.sC4spJbwVJ = new Hashtable();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.sC4spJbwVJ.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this.sC4spJbwVJ.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear(bool dataOnly)
    {
      if (dataOnly)
      {
        foreach (DataArray dataArray in (IEnumerable) this.sC4spJbwVJ.Values)
          dataArray.Clear();
      }
      else
        this.sC4spJbwVJ.Clear();
    }
  }
}

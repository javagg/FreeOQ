// Type: SmartQuant.Instruments.TradeArrayList
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using SmartQuant.Data;
using SmartQuant.Series;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.Instruments
{
  public class TradeArrayList : ICollection, IEnumerable
  {
    private Hashtable aUGESG8XWj;

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aUGESG8XWj.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aUGESG8XWj.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aUGESG8XWj.SyncRoot;
      }
    }

    public TradeArray this[Instrument instrument]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        TradeArray tradeArray = this.aUGESG8XWj[(object) instrument] as TradeArray;
        if (tradeArray == null)
        {
          tradeArray = new TradeArray();
          this.aUGESG8XWj.Add((object) instrument, (object) tradeArray);
        }
        return tradeArray;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TradeArrayList()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.aUGESG8XWj = new Hashtable();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.aUGESG8XWj.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this.aUGESG8XWj.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear(bool dataOnly)
    {
      if (dataOnly)
      {
        foreach (DataArray dataArray in (IEnumerable) this.aUGESG8XWj.Values)
          dataArray.Clear();
      }
      else
        this.aUGESG8XWj.Clear();
    }
  }
}

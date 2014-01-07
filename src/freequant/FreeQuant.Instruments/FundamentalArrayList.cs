// Type: SmartQuant.Instruments.FundamentalArrayList
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using SmartQuant.Data;
using SmartQuant.FIXData;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
  public class FundamentalArrayList : ICollection, IEnumerable
  {
    private Hashtable z1V6Kxy6x9;

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.z1V6Kxy6x9.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.z1V6Kxy6x9.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.z1V6Kxy6x9.SyncRoot;
      }
    }

    public FundamentalArray this[Instrument instrument]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        FundamentalArray fundamentalArray = this.z1V6Kxy6x9[(object) instrument] as FundamentalArray;
        if (fundamentalArray == null)
        {
          fundamentalArray = new FundamentalArray();
          this.z1V6Kxy6x9.Add((object) instrument, (object) fundamentalArray);
        }
        return fundamentalArray;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FundamentalArrayList()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.z1V6Kxy6x9 = new Hashtable();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.z1V6Kxy6x9.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this.z1V6Kxy6x9.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear(bool dataOnly)
    {
      if (dataOnly)
      {
        foreach (DataArray dataArray in (IEnumerable) this.z1V6Kxy6x9.Values)
          dataArray.Clear();
      }
      else
        this.z1V6Kxy6x9.Clear();
    }
  }
}

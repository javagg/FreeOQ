// Type: SmartQuant.Instruments.CorporateActionArrayList
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
  public class CorporateActionArrayList : ICollection, IEnumerable
  {
    private Hashtable VWeEGJUkBk;

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.VWeEGJUkBk.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.VWeEGJUkBk.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.VWeEGJUkBk.SyncRoot;
      }
    }

    public CorporateActionArray this[Instrument instrument]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        CorporateActionArray corporateActionArray = this.VWeEGJUkBk[(object) instrument] as CorporateActionArray;
        if (corporateActionArray == null)
        {
          corporateActionArray = new CorporateActionArray();
          this.VWeEGJUkBk.Add((object) instrument, (object) corporateActionArray);
        }
        return corporateActionArray;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CorporateActionArrayList()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.VWeEGJUkBk = new Hashtable();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.VWeEGJUkBk.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this.VWeEGJUkBk.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear(bool dataOnly)
    {
      if (dataOnly)
      {
        foreach (DataArray dataArray in (IEnumerable) this.VWeEGJUkBk.Values)
          dataArray.Clear();
      }
      else
        this.VWeEGJUkBk.Clear();
    }
  }
}

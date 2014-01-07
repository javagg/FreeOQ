// Type: SmartQuant.Instruments.CurrencyList
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using VFUvY5knK01pUIalDo;

namespace FreeQuant.Instruments
{
  public class CurrencyList : IEnumerable
  {
    private SortedList u8YEidR9Sv;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.u8YEidR9Sv.Count;
      }
    }

    public Currency this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.u8YEidR9Sv.GetByIndex(index) as Currency;
      }
    }

    public Currency this[string code]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.u8YEidR9Sv[(object) code] as Currency;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CurrencyList()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.u8YEidR9Sv = new SortedList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(Currency currency)
    {
      if (this.u8YEidR9Sv.Contains((object) currency.Code))
        throw new ApplicationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(9682) + currency.Code);
      this.u8YEidR9Sv.Add((object) currency.Code, (object) currency);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(Currency currency)
    {
      this.u8YEidR9Sv.Remove((object) currency.Code);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAt(int index)
    {
      this.Remove(this[index]);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.u8YEidR9Sv.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(string code)
    {
      return this.u8YEidR9Sv.Contains((object) code);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(Currency currency)
    {
      return this.u8YEidR9Sv.ContainsValue((object) currency);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.u8YEidR9Sv.Values.GetEnumerator();
    }
  }
}

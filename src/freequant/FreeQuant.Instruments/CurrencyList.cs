using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
  public class CurrencyList : IEnumerable
  {
    private SortedList u8YEidR9Sv;

    public int Count
    {
       get
      {
        return this.u8YEidR9Sv.Count;
      }
    }

    public Currency this[int index]
    {
      get
      {
        return this.u8YEidR9Sv.GetByIndex(index) as Currency;
      }
    }

    public Currency this[string code]
    {
      get
      {
        return this.u8YEidR9Sv[(object) code] as Currency;
      }
    }

    public CurrencyList()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.u8YEidR9Sv = new SortedList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    public void Add(Currency currency)
    {
      if (this.u8YEidR9Sv.Contains((object) currency.Code))
        throw new ApplicationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(9682) + currency.Code);
      this.u8YEidR9Sv.Add((object) currency.Code, (object) currency);
    }

    public void Remove(Currency currency)
    {
      this.u8YEidR9Sv.Remove((object) currency.Code);
    }

    public void RemoveAt(int index)
    {
      this.Remove(this[index]);
    }

    public void Clear()
    {
      this.u8YEidR9Sv.Clear();
    }

    public bool Contains(string code)
    {
      return this.u8YEidR9Sv.Contains((object) code);
    }

    public bool Contains(Currency currency)
    {
      return this.u8YEidR9Sv.ContainsValue((object) currency);
    }

    public IEnumerator GetEnumerator()
    {
      return this.u8YEidR9Sv.Values.GetEnumerator();
    }
  }
}

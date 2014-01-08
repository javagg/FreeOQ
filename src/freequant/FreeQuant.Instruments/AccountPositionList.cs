using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
  public class AccountPositionList : IEnumerable
  {
    private SortedList e6HEudGaD6;

    public int Count
    {
       get
      {
        return this.e6HEudGaD6.Count;
      }
    }

    public AccountPosition this[int index]
    {
      get
      {
        return this.e6HEudGaD6.GetByIndex(index) as AccountPosition;
      }
    }

    public AccountPosition this[Currency currency]
    {
       get
      {
        return this.e6HEudGaD6[(object) currency.Code] as AccountPosition;
      }
    }

   
    public AccountPositionList()
    {
      this.e6HEudGaD6 = new SortedList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(AccountPosition position)
    {
      if (this.e6HEudGaD6.Contains((object) position.Currency.Code))
        throw new ApplicationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(6402) + (object) position.Currency);
      this.e6HEudGaD6.Add((object) position.Currency.Code, (object) position);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(AccountPosition position)
    {
      this.e6HEudGaD6.Remove((object) position.Currency.Code);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAt(int index)
    {
      this.e6HEudGaD6.RemoveAt(index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.e6HEudGaD6.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(Currency currency)
    {
      return this.e6HEudGaD6.Contains((object) currency.Code);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(AccountPosition position)
    {
      return this.e6HEudGaD6.ContainsValue((object) position);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.e6HEudGaD6.Values.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      string str = "";
      foreach (AccountPosition accountPosition in (IEnumerable) this.e6HEudGaD6.Values)
        str = str + accountPosition.ToString() + Environment.NewLine;
      return str;
    }
  }
}

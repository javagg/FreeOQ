using System;
using System.Collections;

namespace FreeQuant.Instruments
{
  public class AccountPositionList : IEnumerable
  {
		private SortedList positions; 

    public int Count
    {
       get
      {
        return this.positions.Count;
      }
    }

    public AccountPosition this[int index]
    {
      get
      {
        return this.positions.GetByIndex(index) as AccountPosition;
      }
    }

    public AccountPosition this[Currency currency]
    {
       get
      {
        return this.positions[(object) currency.Code] as AccountPosition;
      }
    }

   
    public AccountPositionList()
    {
      this.positions = new SortedList();
    }


    public void Add(AccountPosition position)
    {
      if (this.positions.Contains((object) position.Currency.Code))
        throw new ApplicationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(6402) + (object) position.Currency);
      this.positions.Add((object) position.Currency.Code, (object) position);
    }


    public void Remove(AccountPosition position)
    {
      this.positions.Remove((object) position.Currency.Code);
    }

    public void RemoveAt(int index)
    {
      this.positions.RemoveAt(index);
    }


    public void Clear()
    {
      this.positions.Clear();
    }


    public bool Contains(Currency currency)
    {
      return this.positions.Contains((object) currency.Code);
    }

    public bool Contains(AccountPosition position)
    {
      return this.positions.ContainsValue((object) position);
    }

    public IEnumerator GetEnumerator()
    {
      return this.positions.Values.GetEnumerator();
    }


    public override string ToString()
    {
      string str = "";
      foreach (AccountPosition accountPosition in (IEnumerable) this.positions.Values)
        str = str + accountPosition.ToString() + Environment.NewLine;
      return str;
    }
  }
}

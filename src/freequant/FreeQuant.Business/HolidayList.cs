using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Business
{
  public class HolidayList : IEnumerable
  {
    private SortedList pn3aaRDhM;
    private Hashtable PNnh8wNVF;

    public int Count
    {
      get
      {
        return this.pn3aaRDhM.Count;
      }
    }

    public Holiday this[int index]
    {
      get
      {
        return this.pn3aaRDhM.GetByIndex(index) as Holiday;
      }
    }

    public Holiday this[DateTime date]
    {
      get
      {
        return this.pn3aaRDhM[date] as Holiday;
      }
    }

    public HolidayList()
    {
      this.pn3aaRDhM = new SortedList();
      this.PNnh8wNVF = new Hashtable();
    }

    public void Add(Holiday holiday)
    {
      if (this.pn3aaRDhM.Contains(holiday.Date))
				throw new ApplicationException("" + holiday.Date);
      this.pn3aaRDhM.Add(holiday.Date, holiday);
    }

    public void Remove(Holiday holiday)
    {
      this.pn3aaRDhM.Remove(holiday.Date);
    }

    public void RemoveAt(int index)
    {
      this.Remove(this[index]);
    }

    public void Clear()
    {
      this.pn3aaRDhM.Clear();
    }

    public bool Contains(DateTime date)
    {
      return this.pn3aaRDhM.Contains(date);
    }

    public bool Contains(Holiday holiday)
    {
      return this.pn3aaRDhM.ContainsValue(holiday);
    }

    public IEnumerator GetEnumerator()
    {
      return this.pn3aaRDhM.Values.GetEnumerator();
    }
  }
}

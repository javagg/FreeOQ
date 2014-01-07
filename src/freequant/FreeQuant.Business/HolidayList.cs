// Type: SmartQuant.Business.HolidayList
// Assembly: SmartQuant.Business, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 8728B172-6D66-401A-ACE9-1E591C9804EB
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Business.dll

using cfqaSvEETJWaosaRFK;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using VQ9v10m5lBQXWUX1qW;

namespace SmartQuant.Business
{
  public class HolidayList : IEnumerable
  {
    private SortedList pn3aaRDhM;
    private Hashtable PNnh8wNVF;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.pn3aaRDhM.Count;
      }
    }

    public Holiday this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.pn3aaRDhM.GetByIndex(index) as Holiday;
      }
    }

    public Holiday this[DateTime date]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.pn3aaRDhM[(object) date] as Holiday;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HolidayList()
    {
      daSFLBUgUxHG6jMMC5.S0BNF3rzWBODw();
      this.pn3aaRDhM = new SortedList();
      this.PNnh8wNVF = new Hashtable();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(Holiday holiday)
    {
      if (this.pn3aaRDhM.Contains((object) holiday.Date))
        throw new ApplicationException(Bp1OJhHwbtYbnWGfIR.LusDYddli(0) + (object) holiday.Date);
      this.pn3aaRDhM.Add((object) holiday.Date, (object) holiday);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(Holiday holiday)
    {
      this.pn3aaRDhM.Remove((object) holiday.Date);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAt(int index)
    {
      this.Remove(this[index]);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.pn3aaRDhM.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(DateTime date)
    {
      return this.pn3aaRDhM.Contains((object) date);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(Holiday holiday)
    {
      return this.pn3aaRDhM.ContainsValue((object) holiday);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.pn3aaRDhM.Values.GetEnumerator();
    }
  }
}

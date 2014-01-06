// Type: SmartQuant.Simulation.OrderEntryList
// Assembly: SmartQuant.Simulation, Version=1.0.5036.28353, Culture=neutral, PublicKeyToken=null
// MVID: 7CFB1E94-1672-436F-90C9-C8B7893A5618
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Simulation.dll

using ao4bquRNmB4R1dmGd7;
using CJ5Xsgeg9JvhJUnvO3D;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;

namespace SmartQuant.Simulation
{
  [Editor(typeof (PoNb77rWV1athRPm6K), typeof (UITypeEditor))]
  public class OrderEntryList : ICollection, IEnumerable
  {
    private SortedList<DateTime, List<OrderEntry>> h8JysE0Edj;
    private List<OrderEntry> ET2yt9EkNR;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ET2yt9EkNR.Count;
      }
    }

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return false;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (object) null;
      }
    }

    public OrderEntry[] this[DateTime datetime]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        List<OrderEntry> list;
        if (this.h8JysE0Edj.TryGetValue(datetime, out list))
          return list.ToArray();
        else
          return new OrderEntry[0];
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal OrderEntryList()
    {
      eekpcgzPjZLOyP2Ysv.eyppkuTzDkifX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.h8JysE0Edj = new SortedList<DateTime, List<OrderEntry>>();
      this.ET2yt9EkNR = new List<OrderEntry>();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.ET2yt9EkNR.ToArray().CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this.ET2yt9EkNR.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.h8JysE0Edj.Clear();
      this.ii5yMUmqog();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrderEntry[] GetByIndex(int index)
    {
      return this[this.h8JysE0Edj.Keys[0]];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(OrderEntry entry)
    {
      List<OrderEntry> list;
      if (!this.h8JysE0Edj.TryGetValue(entry.DateTime, out list))
      {
        list = new List<OrderEntry>();
        this.h8JysE0Edj.Add(entry.DateTime, list);
      }
      list.Add(entry);
      this.ii5yMUmqog();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ii5yMUmqog()
    {
      this.ET2yt9EkNR.Clear();
      foreach (List<OrderEntry> list in (IEnumerable<List<OrderEntry>>) this.h8JysE0Edj.Values)
      {
        foreach (OrderEntry orderEntry in list)
          this.ET2yt9EkNR.Add(orderEntry);
      }
    }
  }
}

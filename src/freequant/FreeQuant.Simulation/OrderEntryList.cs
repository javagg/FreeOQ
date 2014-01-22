using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;

namespace FreeQuant.Simulation
{
//  [Editor(typeof (PoNb77rWV1athRPm6K), typeof (UITypeEditor))]
  public class OrderEntryList : ICollection, IEnumerable
  {
    private SortedList<DateTime, List<OrderEntry>> h8JysE0Edj;
    private List<OrderEntry> ET2yt9EkNR;

    public int Count
    {
       get
      {
        return this.ET2yt9EkNR.Count;
      }
    }

    public bool IsSynchronized
    {
       get
      {
        return false;
      }
    }

    public object SyncRoot
    {
       get
      {
        return (object) null;
      }
    }

    public OrderEntry[] this[DateTime datetime]
    {
       get
      {
        List<OrderEntry> list;
        if (this.h8JysE0Edj.TryGetValue(datetime, out list))
          return list.ToArray();
        else
          return new OrderEntry[0];
      }
    }

    
    internal OrderEntryList()
    {
      this.h8JysE0Edj = new SortedList<DateTime, List<OrderEntry>>();
      this.ET2yt9EkNR = new List<OrderEntry>();
    }

    
    public void CopyTo(Array array, int index)
    {
      this.ET2yt9EkNR.ToArray().CopyTo(array, index);
    }

    
    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this.ET2yt9EkNR.GetEnumerator();
    }

    
    public void Clear()
    {
      this.h8JysE0Edj.Clear();
      this.ii5yMUmqog();
    }

    
    public OrderEntry[] GetByIndex(int index)
    {
      return this[this.h8JysE0Edj.Keys[0]];
    }

    
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

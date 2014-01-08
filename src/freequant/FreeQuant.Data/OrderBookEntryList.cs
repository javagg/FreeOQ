using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Data
{
  public class OrderBookEntryList : ICollection, IEnumerable
  {
    private ArrayList sOM5e8lcm;

    public bool IsSynchronized
    {
       get
      {
        return this.sOM5e8lcm.IsSynchronized;
      }
    }

    public int Count
    {
       get
      {
        return this.sOM5e8lcm.Count;
      }
    }

    public object SyncRoot
    {
       get
      {
        return this.sOM5e8lcm.SyncRoot;
      }
    }

    public OrderBookEntry this[int index]
    {
       get
      {
        return this.sOM5e8lcm[index] as OrderBookEntry;
      }
    }

    
    internal OrderBookEntryList()
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.sOM5e8lcm = ArrayList.Synchronized(new ArrayList());
    }

    
    public void CopyTo(Array array, int index)
    {
      this.sOM5e8lcm.CopyTo(array, index);
    }

    
    public IEnumerator GetEnumerator()
    {
      return this.sOM5e8lcm.GetEnumerator();
    }

    internal void EeBM3flam()
    {
      this.sOM5e8lcm.Clear();
    }

    internal void H7WIwp9Mh([In] int obj0, [In] OrderBookEntry obj1)
    {
      this.sOM5e8lcm.Insert(obj0, (object) obj1);
    }

    internal void EpiQxWKO6([In] int obj0)
    {
      this.sOM5e8lcm.RemoveAt(obj0);
    }
  }
}

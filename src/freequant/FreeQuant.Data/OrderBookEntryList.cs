// Type: SmartQuant.Data.OrderBookEntryList
// Assembly: SmartQuant.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=844f265c18b031f9
// MVID: FAB3F3C9-6D4A-4391-AE43-0CE5E1C624DD
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Data.dll

using RadDBE9P5I945u5gCE;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SmartQuant.Data
{
  public class OrderBookEntryList : ICollection, IEnumerable
  {
    private ArrayList sOM5e8lcm;

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.sOM5e8lcm.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.sOM5e8lcm.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.sOM5e8lcm.SyncRoot;
      }
    }

    public OrderBookEntry this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.sOM5e8lcm[index] as OrderBookEntry;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal OrderBookEntryList()
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.sOM5e8lcm = ArrayList.Synchronized(new ArrayList());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.sOM5e8lcm.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.sOM5e8lcm.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void EeBM3flam()
    {
      this.sOM5e8lcm.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void H7WIwp9Mh([In] int obj0, [In] OrderBookEntry obj1)
    {
      this.sOM5e8lcm.Insert(obj0, (object) obj1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void EpiQxWKO6([In] int obj0)
    {
      this.sOM5e8lcm.RemoveAt(obj0);
    }
  }
}

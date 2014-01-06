// Type: SmartQuant.Testing.RoundTrips.RoundTripArray
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using Byqm85MNrFBe6JPJlI;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.RoundTrips
{
  public class RoundTripArray : ICollection, IEnumerable
  {
    protected ArrayList array;

    public RoundTrip this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.array[index] as RoundTrip;
      }
    }

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.array.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.array.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.array.SyncRoot;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RoundTripArray(ArrayList array)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.array = array;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RoundTripArray()
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.array = new ArrayList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(RoundTrip roundTrip)
    {
      return this.array.Contains((object) roundTrip);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.array.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(RoundTrip roundTrip)
    {
      this.array.Add((object) roundTrip);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      array.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.array.GetEnumerator();
    }
  }
}

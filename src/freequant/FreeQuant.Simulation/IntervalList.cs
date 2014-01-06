// Type: SmartQuant.Simulation.IntervalList
// Assembly: SmartQuant.Simulation, Version=1.0.5036.28353, Culture=neutral, PublicKeyToken=null
// MVID: 7CFB1E94-1672-436F-90C9-C8B7893A5618
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Simulation.dll

using CJ5Xsgeg9JvhJUnvO3D;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.Simulation
{
  public class IntervalList : IList, ICollection, IEnumerable
  {
    private ArrayList WFYFuI1Oa1;

    public bool IsReadOnly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WFYFuI1Oa1.IsReadOnly;
      }
    }

    public bool IsFixedSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WFYFuI1Oa1.IsFixedSize;
      }
    }

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WFYFuI1Oa1.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WFYFuI1Oa1.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WFYFuI1Oa1.SyncRoot;
      }
    }

    public Interval this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WFYFuI1Oa1[index] as Interval;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntervalList()
    {
      eekpcgzPjZLOyP2Ysv.eyppkuTzDkifX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.WFYFuI1Oa1 = new ArrayList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    object IList.get_Item(int index)
    {
      return this.WFYFuI1Oa1[index];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IList.set_Item(int index, object value)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAt(int index)
    {
      this.WFYFuI1Oa1.RemoveAt(index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IList.Insert(int index, object value)
    {
      this.WFYFuI1Oa1.Insert(index, value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IList.Remove(object value)
    {
      this.WFYFuI1Oa1.Remove(value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    bool IList.Contains(object value)
    {
      return this.WFYFuI1Oa1.Contains(value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.WFYFuI1Oa1.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    int IList.IndexOf(object value)
    {
      return this.WFYFuI1Oa1.IndexOf(value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    int IList.Add(object value)
    {
      return this.WFYFuI1Oa1.Add(value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.WFYFuI1Oa1.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.WFYFuI1Oa1.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(Interval interval)
    {
      this.WFYFuI1Oa1.Remove((object) interval);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(Interval interval)
    {
      return this.WFYFuI1Oa1.Contains((object) interval);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int IndexOf(Interval interval)
    {
      return this.WFYFuI1Oa1.IndexOf((object) interval);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int Add(Interval interval)
    {
      return this.WFYFuI1Oa1.Add((object) interval);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int Add(DateTime begin, DateTime end)
    {
      return this.Add(new Interval(begin, end));
    }
  }
}

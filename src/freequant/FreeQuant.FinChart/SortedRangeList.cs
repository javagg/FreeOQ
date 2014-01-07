// Type: SmartQuant.FinChart.SortedRangeList
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using yHueqhRH1sS5jNKgDq;

namespace SmartQuant.FinChart
{
  public class SortedRangeList : ICollection, IEnumerable
  {
    private SortedList Pi4ysxbjJV;

    public ArrayList this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Pi4ysxbjJV.GetByIndex(index) as ArrayList;
      }
    }

    public ArrayList this[DateTime dateTime]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Pi4ysxbjJV[(object) dateTime] as ArrayList;
      }
    }

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Pi4ysxbjJV.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Pi4ysxbjJV.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Pi4ysxbjJV.SyncRoot;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SortedRangeList()
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Pi4ysxbjJV = new SortedList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SortedRangeList(bool right)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Pi4ysxbjJV = new SortedList();
      right = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(IDateDrawable item)
    {
      if (this.Pi4ysxbjJV.ContainsKey((object) item.DateTime))
        (this.Pi4ysxbjJV[(object) item.DateTime] as ArrayList).Add((object) item);
      else
        this.Pi4ysxbjJV.Add((object) item.DateTime, (object) new ArrayList()
        {
          (object) item
        });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.Pi4ysxbjJV.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetNextIndex(DateTime dateTime)
    {
      if (this.Pi4ysxbjJV.ContainsKey((object) dateTime))
        return this.Pi4ysxbjJV.IndexOfKey((object) dateTime);
      this.Pi4ysxbjJV.Add((object) dateTime, (object) null);
      int num = this.Pi4ysxbjJV.IndexOfKey((object) dateTime);
      this.Pi4ysxbjJV.Remove((object) dateTime);
      if (num == this.Pi4ysxbjJV.Count)
        return -1;
      else
        return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetPrevIndex(DateTime dateTime)
    {
      if (this.Pi4ysxbjJV.ContainsKey((object) dateTime))
        return this.Pi4ysxbjJV.IndexOfKey((object) dateTime);
      this.Pi4ysxbjJV.Add((object) dateTime, (object) null);
      int num = this.Pi4ysxbjJV.IndexOfKey((object) dateTime);
      this.Pi4ysxbjJV.Remove((object) dateTime);
      if (num == 0)
        return -1;
      else
        return num - 1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTime GetDateTime(int index)
    {
      return (DateTime) this.Pi4ysxbjJV.GetKey(index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(DateTime dateTime)
    {
      return this.Pi4ysxbjJV.ContainsKey((object) dateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.Pi4ysxbjJV.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.Pi4ysxbjJV.Values.GetEnumerator();
    }
  }
}

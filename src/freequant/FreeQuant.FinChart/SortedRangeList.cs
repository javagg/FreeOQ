using System;
using System.Collections;

namespace FreeQuant.FinChart
{
  public class SortedRangeList : ICollection, IEnumerable
  {
    private SortedList Pi4ysxbjJV;

    public ArrayList this[int index]
    {
       get
      {
        return this.Pi4ysxbjJV.GetByIndex(index) as ArrayList;
      }
    }

    public ArrayList this[DateTime dateTime]
    {
       get
      {
        return this.Pi4ysxbjJV[(object) dateTime] as ArrayList;
      }
    }

    public bool IsSynchronized
    {
       get
      {
        return this.Pi4ysxbjJV.IsSynchronized;
      }
    }

    public int Count
    {
       get
      {
        return this.Pi4ysxbjJV.Count;
      }
    }

    public object SyncRoot
    {
       get
      {
        return this.Pi4ysxbjJV.SyncRoot;
      }
    }

    
    public SortedRangeList()
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Pi4ysxbjJV = new SortedList();
    }

    
    public SortedRangeList(bool right)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Pi4ysxbjJV = new SortedList();
      right = true;
    }

    
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

    
    public void Clear()
    {
      this.Pi4ysxbjJV.Clear();
    }

    
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

    
    public DateTime GetDateTime(int index)
    {
      return (DateTime) this.Pi4ysxbjJV.GetKey(index);
    }

    
    public bool Contains(DateTime dateTime)
    {
      return this.Pi4ysxbjJV.ContainsKey((object) dateTime);
    }

    
    public void CopyTo(Array array, int index)
    {
      this.Pi4ysxbjJV.CopyTo(array, index);
    }

    
    public IEnumerator GetEnumerator()
    {
      return this.Pi4ysxbjJV.Values.GetEnumerator();
    }
  }
}

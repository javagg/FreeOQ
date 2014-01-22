using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Simulation
{
  public class IntervalList : IList, ICollection, IEnumerable
  {
    private ArrayList WFYFuI1Oa1;

    public bool IsReadOnly
    {
       get
      {
        return this.WFYFuI1Oa1.IsReadOnly;
      }
    }

    public bool IsFixedSize
    {
       get
      {
        return this.WFYFuI1Oa1.IsFixedSize;
      }
    }

    public bool IsSynchronized
    {
       get
      {
        return this.WFYFuI1Oa1.IsSynchronized;
      }
    }

    public int Count
    {
       get
      {
        return this.WFYFuI1Oa1.Count;
      }
    }

    public object SyncRoot
    {
       get
      {
        return this.WFYFuI1Oa1.SyncRoot;
      }
    }

		public object this[int index]
    {
       get
      {
        return this.WFYFuI1Oa1[index];
      }
			set
			{
				this.WFYFuI1Oa1[index] = value;
			}
    }

    
    public IntervalList()
    {
      this.WFYFuI1Oa1 = new ArrayList();
    }

    
//    object IList.get_Item(int index)
//    {
//      return this.WFYFuI1Oa1[index];
//    }
//
//    
//    void IList.set_Item(int index, object value)
//    {
//    }

    
    public void RemoveAt(int index)
    {
      this.WFYFuI1Oa1.RemoveAt(index);
    }

    
    void IList.Insert(int index, object value)
    {
      this.WFYFuI1Oa1.Insert(index, value);
    }

    
    void IList.Remove(object value)
    {
      this.WFYFuI1Oa1.Remove(value);
    }

    
    bool IList.Contains(object value)
    {
      return this.WFYFuI1Oa1.Contains(value);
    }

    
    public void Clear()
    {
      this.WFYFuI1Oa1.Clear();
    }

    
    int IList.IndexOf(object value)
    {
      return this.WFYFuI1Oa1.IndexOf(value);
    }

    
    int IList.Add(object value)
    {
      return this.WFYFuI1Oa1.Add(value);
    }

    
    public void CopyTo(Array array, int index)
    {
      this.WFYFuI1Oa1.CopyTo(array, index);
    }

    
    public IEnumerator GetEnumerator()
    {
      return this.WFYFuI1Oa1.GetEnumerator();
    }

    
    public void Remove(Interval interval)
    {
      this.WFYFuI1Oa1.Remove((object) interval);
    }

    
    public bool Contains(Interval interval)
    {
      return this.WFYFuI1Oa1.Contains((object) interval);
    }

    
    public int IndexOf(Interval interval)
    {
      return this.WFYFuI1Oa1.IndexOf((object) interval);
    }

    
    public int Add(Interval interval)
    {
      return this.WFYFuI1Oa1.Add((object) interval);
    }

    
    public int Add(DateTime begin, DateTime end)
    {
      return this.Add(new Interval(begin, end));
    }
  }
}

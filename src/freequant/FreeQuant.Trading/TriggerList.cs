
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class TriggerList : ICollection, IEnumerable
  {
    private ArrayList aBBpZAhsY6;

    public bool IsSynchronized
    {
       get
      {
        return this.aBBpZAhsY6.IsSynchronized;
      }
    }

    public int Count
    {
       get
      {
        return this.aBBpZAhsY6.Count;
      }
    }

    public object SyncRoot
    {
       get
      {
        return this.aBBpZAhsY6.SyncRoot;
      }
    }

    
		public TriggerList():base()
    {
      this.aBBpZAhsY6 = new ArrayList();
    }

    
    public void CopyTo(Array array, int index)
    {
      this.aBBpZAhsY6.CopyTo(array, index);
    }

    
    public IEnumerator GetEnumerator()
    {
      return this.aBBpZAhsY6.GetEnumerator();
    }

    
    public void Add(Trigger trigger)
    {
      this.aBBpZAhsY6.Add((object) trigger);
    }

    
    public void Clear()
    {
      this.aBBpZAhsY6.Clear();
    }
  }
}

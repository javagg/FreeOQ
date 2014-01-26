
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class SignalList : ICollection, IEnumerable
  {
    private ArrayList mOPje6CaVf;

    public bool IsSynchronized
    {
       get
      {
        return this.mOPje6CaVf.IsSynchronized;
      }
    }

    public int Count
    {
       get
      {
        return this.mOPje6CaVf.Count;
      }
    }

    public object SyncRoot
    {
       get
      {
        return this.mOPje6CaVf.SyncRoot;
      }
    }

    public Signal this[int index]
    {
       get
      {
        return this.mOPje6CaVf[index] as Signal;
      }
    }

    
		public SignalList():base()
    {
      this.mOPje6CaVf = new ArrayList();
    }

    
    public void CopyTo(Array array, int index)
    {
      this.mOPje6CaVf.CopyTo(array, index);
    }

    
    public IEnumerator GetEnumerator()
    {
      return this.mOPje6CaVf.GetEnumerator();
    }

    
    public void Clear()
    {
      this.mOPje6CaVf.Clear();
    }

    
    public void Add(Signal signal)
    {
      this.mOPje6CaVf.Add((object) signal);
    }
  }
}

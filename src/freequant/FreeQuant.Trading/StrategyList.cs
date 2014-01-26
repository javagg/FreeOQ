
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Trading
{
  public class StrategyList : ICollection, IEnumerable
  {
    private SortedList mTZpGjqLyG;

    public bool IsSynchronized
    {
       get
      {
        return this.mTZpGjqLyG.IsSynchronized;
      }
    }

    public object SyncRoot
    {
       get
      {
        return this.mTZpGjqLyG.SyncRoot;
      }
    }

    public int Count
    {
       get
      {
        return this.mTZpGjqLyG.Count;
      }
    }

    public StrategyBase this[string name]
    {
       get
      {
        return this.mTZpGjqLyG[(object) name] as StrategyBase;
      }
    }

    
		internal StrategyList():base()
    {
      this.mTZpGjqLyG = new SortedList();
    }

    
    public void CopyTo(Array array, int index)
    {
      this.mTZpGjqLyG.CopyTo(array, index);
    }

    
    public IEnumerator GetEnumerator()
    {
      return this.mTZpGjqLyG.Values.GetEnumerator();
    }

    
    internal void sHVpbkHDLx([In] StrategyBase obj0)
    {
      if (this.mTZpGjqLyG.Contains((object) obj0.Name))
        throw new ApplicationException( obj0.Name);
      this.mTZpGjqLyG.Add((object) obj0.Name, (object) obj0);
    }

    
    internal void Sg6pybMZlM([In] StrategyBase obj0)
    {
      this.mTZpGjqLyG.Remove((object) obj0.Name);
    }

    
    public bool Contains(string name)
    {
      return this.mTZpGjqLyG.ContainsKey((object) name);
    }
  }
}

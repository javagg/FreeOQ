
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class StopList : ICollection, IEnumerable
  {
    private ArrayList qA2WAo3yMW;

    public bool IsSynchronized
    {
      get
      {
        return this.qA2WAo3yMW.IsSynchronized;
      }
    }

    public int Count
    {
      get
      {
        return this.qA2WAo3yMW.Count;
      }
    }

    public object SyncRoot
    {
      get
      {
        return this.qA2WAo3yMW.SyncRoot;
      }
    }

    public IStop this[int index]
    {
      get
      {
        return this.qA2WAo3yMW[index] as IStop;
      }
    }

   
    public StopList()
    {

      this.qA2WAo3yMW = new ArrayList();
    }

   
    public void CopyTo(Array array, int index)
    {
      this.qA2WAo3yMW.CopyTo(array, index);
    }

   
    public IEnumerator GetEnumerator()
    {
      return this.qA2WAo3yMW.GetEnumerator();
    }

   
    public void Add(IStop stop)
    {
      this.Add(stop, true);
    }

   
    public void Add(IStop stop, bool sort)
    {
      this.qA2WAo3yMW.Add((object) stop);
    }

   
    public void Remove(IStop stop)
    {
      this.qA2WAo3yMW.Remove((object) stop);
    }

   
    public void RemoveAt(int index)
    {
      this.qA2WAo3yMW.RemoveAt(index);
    }

   
    public void Clear()
    {
      this.qA2WAo3yMW.Clear();
    }

   
    public bool Contains(IStop stop)
    {
      return this.qA2WAo3yMW.Contains((object) stop);
    }

   
    public void Sort()
    {
      this.qA2WAo3yMW.Sort();
    }
  }
}

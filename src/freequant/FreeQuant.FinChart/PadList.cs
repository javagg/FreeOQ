using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FinChart
{
  [Serializable]
  public class PadList : IList, ICollection, IEnumerable
  {
    private ArrayList VogJtCTLfO;

    public bool IsReadOnly
    {
       get
      {
        return this.VogJtCTLfO.IsReadOnly;
      }
    }

    public bool IsFixedSize
    {
       get
      {
        return this.VogJtCTLfO.IsFixedSize;
      }
    }

    public bool IsSynchronized
    {
       get
      {
        return this.VogJtCTLfO.IsSynchronized;
      }
    }

    public int Count
    {
       get
      {
        return this.VogJtCTLfO.Count;
      }
    }

    public object SyncRoot
    {
       get
      {
        return this.VogJtCTLfO.SyncRoot;
      }
    }

    public Pad this[int index]
    {
       get
      {
        return this.VogJtCTLfO[index] as Pad;
      }
    }

    
    public PadList()
    {
      this.VogJtCTLfO = new ArrayList();
    }

    
    object IList.get_Item(int index)
    {
      return (object) this[index];
    }

    
    void IList.set_Item(int index, object value)
    {
    }

    
    public void RemoveAt(int index)
    {
      this.VogJtCTLfO.RemoveAt(index);
    }

    
    void IList.Insert(int index, object value)
    {
    }

    
    void IList.Remove(object value)
    {
      this.Remove(value as Pad);
    }

    
    bool IList.Contains(object value)
    {
      return this.VogJtCTLfO.Contains(value);
    }

    
    public void Clear()
    {
      this.VogJtCTLfO.Clear();
    }

    
    int IList.IndexOf(object value)
    {
      return this.IndexOf(value as Pad);
    }

    
    int IList.Add(object value)
    {
      return this.Add(value as Pad);
    }

    
    public void CopyTo(Array array, int index)
    {
      this.VogJtCTLfO.CopyTo(array, index);
    }

    
    public IEnumerator GetEnumerator()
    {
      return this.VogJtCTLfO.GetEnumerator();
    }

    
    public int Add(Pad pad)
    {
      return this.VogJtCTLfO.Add((object) pad);
    }

    
    public void Remove(Pad pad)
    {
      this.VogJtCTLfO.Remove((object) pad);
    }

    
    public void Insert(int index, Pad pad)
    {
      this.VogJtCTLfO.Insert(index, (object) pad);
    }

    
    public int IndexOf(Pad pad)
    {
      return this.VogJtCTLfO.IndexOf((object) pad);
    }
  }
}

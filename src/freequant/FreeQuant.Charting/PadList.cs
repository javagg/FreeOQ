using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting
{
  [Serializable]
  public class PadList : IList, ICollection, IEnumerable
  {
    private ArrayList WTQm1qtT9;

    public bool IsReadOnly
    {
       get
      {
        return this.WTQm1qtT9.IsReadOnly;
      }
    }

    public bool IsFixedSize
    {
       get
      {
        return this.WTQm1qtT9.IsFixedSize;
      }
    }

    public bool IsSynchronized
    {
       get
      {
        return this.WTQm1qtT9.IsSynchronized;
      }
    }

    public int Count
    {
       get
      {
        return this.WTQm1qtT9.Count;
      }
    }

    public object SyncRoot
    {
       get
      {
        return this.WTQm1qtT9.SyncRoot;
      }
    }

//    public Pad this[int index]
//    {
//       get
//      {
//        return this.WTQm1qtT9[index] as Pad;
//      }
//    }

	public object this[int index]
	{
		get
		{
			return this.WTQm1qtT9[index];
		}
	}
    public PadList():base()
    {

      this.WTQm1qtT9 = new ArrayList();

    }

    
//    object IList.get_Item(int index)
//    {
//      return (object) this[index];
//    }
//
//    
//    void IList.set_Item(int index, object value)
//    {
//    }

    
    public void RemoveAt(int index)
    {
      this.WTQm1qtT9.RemoveAt(index);
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
      return this.WTQm1qtT9.Contains(value);
    }

    
    public void Clear()
    {
      this.WTQm1qtT9.Clear();
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
      this.WTQm1qtT9.CopyTo(array, index);
    }

    
    public IEnumerator GetEnumerator()
    {
      return this.WTQm1qtT9.GetEnumerator();
    }

    
    public int Add(Pad pad)
    {
      return this.WTQm1qtT9.Add((object) pad);
    }

    
    public void Remove(Pad pad)
    {
      this.WTQm1qtT9.Remove((object) pad);
    }

    
    public int IndexOf(Pad pad)
    {
      return this.WTQm1qtT9.IndexOf((object) pad);
    }
  }
}

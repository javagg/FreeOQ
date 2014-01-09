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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WTQm1qtT9.IsReadOnly;
      }
    }

    public bool IsFixedSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WTQm1qtT9.IsFixedSize;
      }
    }

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WTQm1qtT9.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WTQm1qtT9.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WTQm1qtT9.SyncRoot;
      }
    }

    public Pad this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WTQm1qtT9[index] as Pad;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PadList():base()
    {

      this.WTQm1qtT9 = new ArrayList();

    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    object IList.get_Item(int index)
    {
      return (object) this[index];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IList.set_Item(int index, object value)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAt(int index)
    {
      this.WTQm1qtT9.RemoveAt(index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IList.Insert(int index, object value)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IList.Remove(object value)
    {
      this.Remove(value as Pad);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    bool IList.Contains(object value)
    {
      return this.WTQm1qtT9.Contains(value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.WTQm1qtT9.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    int IList.IndexOf(object value)
    {
      return this.IndexOf(value as Pad);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    int IList.Add(object value)
    {
      return this.Add(value as Pad);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.WTQm1qtT9.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.WTQm1qtT9.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int Add(Pad pad)
    {
      return this.WTQm1qtT9.Add((object) pad);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(Pad pad)
    {
      this.WTQm1qtT9.Remove((object) pad);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int IndexOf(Pad pad)
    {
      return this.WTQm1qtT9.IndexOf((object) pad);
    }
  }
}

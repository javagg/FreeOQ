// Type: SmartQuant.FinChart.PadList
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using yHueqhRH1sS5jNKgDq;

namespace SmartQuant.FinChart
{
  [Serializable]
  public class PadList : IList, ICollection, IEnumerable
  {
    private ArrayList VogJtCTLfO;

    public bool IsReadOnly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.VogJtCTLfO.IsReadOnly;
      }
    }

    public bool IsFixedSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.VogJtCTLfO.IsFixedSize;
      }
    }

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.VogJtCTLfO.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.VogJtCTLfO.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.VogJtCTLfO.SyncRoot;
      }
    }

    public Pad this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.VogJtCTLfO[index] as Pad;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PadList()
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.VogJtCTLfO = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
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
      this.VogJtCTLfO.RemoveAt(index);
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
      return this.VogJtCTLfO.Contains(value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.VogJtCTLfO.Clear();
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
      this.VogJtCTLfO.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.VogJtCTLfO.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int Add(Pad pad)
    {
      return this.VogJtCTLfO.Add((object) pad);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(Pad pad)
    {
      this.VogJtCTLfO.Remove((object) pad);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Insert(int index, Pad pad)
    {
      this.VogJtCTLfO.Insert(index, (object) pad);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int IndexOf(Pad pad)
    {
      return this.VogJtCTLfO.IndexOf((object) pad);
    }
  }
}

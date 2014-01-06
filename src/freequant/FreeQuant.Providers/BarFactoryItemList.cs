// Type: SmartQuant.Providers.BarFactoryItemList
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using dW79p7NPlS6ZxObcx3;
using SmartQuant.Data;
using SmartQuant.Providers.Design;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;

namespace SmartQuant.Providers
{
  [Editor(typeof (BarFactoryItemListEditor), typeof (UITypeEditor))]
  public class BarFactoryItemList : IList, ICollection, IEnumerable
  {
    private ArrayList QCxg5sFndH;

    public bool IsReadOnly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.QCxg5sFndH.IsReadOnly;
      }
    }

    public bool IsFixedSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.QCxg5sFndH.IsFixedSize;
      }
    }

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.QCxg5sFndH.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.QCxg5sFndH.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.QCxg5sFndH.SyncRoot;
      }
    }

    public BarFactoryItem this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.QCxg5sFndH[index] as BarFactoryItem;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BarFactoryItemList()
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.QCxg5sFndH = new ArrayList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    object IList.get_Item(int index)
    {
      return (object) this[index];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IList.set_Item(int index, object value)
    {
      throw new NotSupportedException();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAt(int index)
    {
      this.QCxg5sFndH.RemoveAt(index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Insert(int index, object value)
    {
      this.QCxg5sFndH.Insert(index, value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(object value)
    {
      this.QCxg5sFndH.Remove(value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(object value)
    {
      return this.QCxg5sFndH.Contains(value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.QCxg5sFndH.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int IndexOf(object value)
    {
      return this.QCxg5sFndH.IndexOf(value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    int IList.Add(object value)
    {
      return this.Add(value as BarFactoryItem);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.QCxg5sFndH.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.QCxg5sFndH.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int Add(BarFactoryItem item)
    {
      this.QCxg5sFndH.Add((object) item);
      this.QCxg5sFndH.Sort();
      return this.QCxg5sFndH.IndexOf((object) item);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int Add(BarType barType, long barSize, bool enabled)
    {
      return this.Add(new BarFactoryItem(barType, barSize, enabled));
    }
  }
}

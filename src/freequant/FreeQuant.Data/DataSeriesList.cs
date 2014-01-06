// Type: SmartQuant.Data.DataSeriesList
// Assembly: SmartQuant.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=844f265c18b031f9
// MVID: FAB3F3C9-6D4A-4391-AE43-0CE5E1C624DD
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Data.dll

using RadDBE9P5I945u5gCE;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.Data
{
  public class DataSeriesList : IList, ICollection, IEnumerable
  {
    private ArrayList z1ZSqbavM;

    public bool IsReadOnly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.z1ZSqbavM.IsReadOnly;
      }
    }

    public bool IsFixedSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.z1ZSqbavM.IsFixedSize;
      }
    }

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.z1ZSqbavM.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.z1ZSqbavM.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.z1ZSqbavM.SyncRoot;
      }
    }

    public IDataSeries this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.z1ZSqbavM[index] as IDataSeries;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.z1ZSqbavM[index] = (object) value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DataSeriesList()
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.z1ZSqbavM = new ArrayList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    object IList.get_Item(int index)
    {
      return (object) this[index];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IList.set_Item(int index, object value)
    {
      this[index] = value as IDataSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAt(int index)
    {
      this.z1ZSqbavM.RemoveAt(index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IList.Insert(int index, object value)
    {
      this.Insert(index, value as IDataSeries);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IList.Remove(object value)
    {
      this.Remove(value as IDataSeries);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    bool IList.Contains(object value)
    {
      return this.Contains(value as IDataSeries);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.z1ZSqbavM.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    int IList.IndexOf(object value)
    {
      return this.IndexOf(value as IDataSeries);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    int IList.Add(object value)
    {
      return this.Add(value as IDataSeries);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.z1ZSqbavM.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.z1ZSqbavM.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Insert(int index, IDataSeries series)
    {
      this.z1ZSqbavM.Insert(index, (object) series);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(IDataSeries series)
    {
      this.z1ZSqbavM.Remove((object) series);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(IDataSeries series)
    {
      return this.z1ZSqbavM.Contains((object) series);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int IndexOf(IDataSeries series)
    {
      return this.z1ZSqbavM.IndexOf((object) series);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int Add(IDataSeries series)
    {
      return this.z1ZSqbavM.Add((object) series);
    }
  }
}

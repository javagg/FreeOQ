using System;
using System.Collections;

namespace FreeQuant.Data
{
  public class DataSeriesList : IList, ICollection, IEnumerable
  {
    private ArrayList z1ZSqbavM;

    public bool IsReadOnly
    {
       get
      {
        return this.z1ZSqbavM.IsReadOnly;
      }
    }

    public bool IsFixedSize
    {
     get
      {
        return this.z1ZSqbavM.IsFixedSize;
      }
    }

    public bool IsSynchronized
    {
       get
      {
        return this.z1ZSqbavM.IsSynchronized;
      }
    }

    public int Count
    {
       get
      {
        return this.z1ZSqbavM.Count;
      }
    }

    public object SyncRoot
    {
       get
      {
        return this.z1ZSqbavM.SyncRoot;
      }
    }

    public IDataSeries this[int index]
    {
       get
      {
        return this.z1ZSqbavM[index] as IDataSeries;
      }
       set
      {
        this.z1ZSqbavM[index] = (object) value;
      }
    }

    public DataSeriesList()
    {
      this.z1ZSqbavM = new ArrayList();
    }

    object IList.get_Item(int index)
    {
      return (object) this[index];
    }

    void IList.set_Item(int index, object value)
    {
      this[index] = value as IDataSeries;
    }

    public void RemoveAt(int index)
    {
      this.z1ZSqbavM.RemoveAt(index);
    }

    void IList.Insert(int index, object value)
    {
      this.Insert(index, value as IDataSeries);
    }

    void IList.Remove(object value)
    {
      this.Remove(value as IDataSeries);
    }

    bool IList.Contains(object value)
    {
      return this.Contains(value as IDataSeries);
    }

    public void Clear()
    {
      this.z1ZSqbavM.Clear();
    }

    int IList.IndexOf(object value)
    {
      return this.IndexOf(value as IDataSeries);
    }

    
    int IList.Add(object value)
    {
      return this.Add(value as IDataSeries);
    }

    public void CopyTo(Array array, int index)
    {
      this.z1ZSqbavM.CopyTo(array, index);
    }

    public IEnumerator GetEnumerator()
    {
      return this.z1ZSqbavM.GetEnumerator();
    }

    public void Insert(int index, IDataSeries series)
    {
      this.z1ZSqbavM.Insert(index, (object) series);
    }

    public void Remove(IDataSeries series)
    {
      this.z1ZSqbavM.Remove((object) series);
    }

    public bool Contains(IDataSeries series)
    {
      return this.z1ZSqbavM.Contains((object) series);
    }

    public int IndexOf(IDataSeries series)
    {
      return this.z1ZSqbavM.IndexOf((object) series);
    }

    public int Add(IDataSeries series)
    {
      return this.z1ZSqbavM.Add((object) series);
    }
  }
}

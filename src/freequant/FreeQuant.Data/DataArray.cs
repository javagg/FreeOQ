// Type: SmartQuant.Data.DataArray
// Assembly: SmartQuant.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=844f265c18b031f9
// MVID: FAB3F3C9-6D4A-4391-AE43-0CE5E1C624DD
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Data.dll

using RadDBE9P5I945u5gCE;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.Data
{
  public class DataArray : IEnumerable
  {
    protected int fStopRecurant;
    protected double fDivisor;
    protected ArrayList fList;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fList.Count;
      }
    }

    public IDataObject this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fList[index] as IDataObject;
      }
    }

    public DateTime FirstDateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.Count != 0)
          return this[0].DateTime;
        else
          return new DateTime(0L);
      }
    }

    public DateTime LastDateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.Count != 0)
          return this[this.Count - 1].DateTime;
        else
          return new DateTime(0L);
      }
    }

    public event EventHandler Cleared;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DataArray()
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      this.fStopRecurant = 25;
      this.fDivisor = 10.0;
      this.fList = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(IDataObject obj)
    {
      this.fList.Add((object) obj);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Insert(int index, IDataObject obj)
    {
      this.fList.Insert(index, (object) obj);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(IDataObject obj)
    {
      this.fList.Remove((object) obj);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAt(int index)
    {
      this.fList.RemoveAt(index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.fList.Clear();
      this.mo2dMTHCA();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(IDataObject obj)
    {
      return this.fList.Contains((object) obj);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.fList.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetIndex(DateTime datetime)
    {
      if (this.Count == 0)
        return -1;
      DateTime dateTime1 = this[0].DateTime;
      DateTime dateTime2 = this[this.Count - 1].DateTime;
      if (dateTime1 > datetime || dateTime2 < datetime)
        return -1;
      else
        return this.GetIndex(datetime, 0, this.Count - 1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetIndex(DateTime datetime, int index1, int index2)
    {
      long ticks1 = this[index1].DateTime.Ticks;
      long ticks2 = this[index2].DateTime.Ticks;
      long ticks3 = datetime.Ticks;
      int index3 = ticks2 == ticks1 ? (index1 + index2) / 2 : (int) ((long) index1 + (long) (index2 - index1) * ((ticks3 - ticks1) / (ticks2 - ticks1)));
      if (this[index3].DateTime == datetime)
        return index3;
      if (index2 - index3 < this.fStopRecurant || index3 - index1 < this.fStopRecurant)
      {
        for (int index4 = index2; index4 >= index1; --index4)
        {
          if (this[index4].DateTime < datetime)
            return index4;
        }
        return -1;
      }
      else
      {
        int num = (int) ((double) (index2 - index1) / this.fDivisor);
        int index4 = Math.Max(index1, index3 - num);
        if (this[index4].DateTime > datetime)
          return this.GetIndex(datetime, index1, index4);
        int index5 = Math.Min(index2, index3 + num);
        if (this[index5].DateTime < datetime)
          return this.GetIndex(datetime, index5, index2);
        else
          return this.GetIndex(datetime, index4, index5);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void mo2dMTHCA()
    {
      if (this.ICNEq7Q0q == null)
        return;
      this.ICNEq7Q0q((object) this, EventArgs.Empty);
    }
  }
}

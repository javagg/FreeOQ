// Type: SmartQuant.Data.MemorySeries`1
// Assembly: SmartQuant.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=844f265c18b031f9
// MVID: FAB3F3C9-6D4A-4391-AE43-0CE5E1C624DD
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Data.dll

using oL6nXjcX2wYBRbhX2q;
using RadDBE9P5I945u5gCE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SmartQuant.Data
{
  public class MemorySeries<TValue> : IDataSeries, IEnumerable
  {
    private string vdBytHTTf;
    private string qkTg3VC1k;
    private SortedList<DateTime, TValue> jy6GVFJfR;

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.vdBytHTTf;
      }
    }

    public string Description
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.qkTg3VC1k;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.qkTg3VC1k = value;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.jy6GVFJfR.Count;
      }
    }

    public object this[DateTime datetime]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (object) this.jy6GVFJfR[datetime];
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.jy6GVFJfR[datetime] = (TValue) value;
      }
    }

    public object this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (object) this.jy6GVFJfR.Values[index];
      }
    }

    public DateTime FirstDateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.jy6GVFJfR.Keys[0];
      }
    }

    public DateTime LastDateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.jy6GVFJfR.Keys[this.jy6GVFJfR.Count - 1];
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MemorySeries(string name, string description)
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.vdBytHTTf = name;
      this.qkTg3VC1k = description;
      this.jy6GVFJfR = new SortedList<DateTime, TValue>();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MemorySeries(string name)
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      this.\u002Ector(name, "");
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MemorySeries()
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      this.\u002Ector(SgtGY0EZpHQ7maRIwn.MEKJ4a3Ol(884));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(DateTime datetime, object obj)
    {
      this.jy6GVFJfR[datetime] = (TValue) obj;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update(DateTime datetime, object obj)
    {
      this.Add(datetime, obj);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update(int index, object obj)
    {
      this.Update(this.jy6GVFJfR.Keys[index], obj);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(DateTime datetime)
    {
      return this.jy6GVFJfR.ContainsKey(datetime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int IndexOf(DateTime datetime)
    {
      return this.jy6GVFJfR.IndexOfKey(datetime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int IndexOf(DateTime datetime, SearchOption option)
    {
      int index = 0;
      int num1 = 0;
      int num2 = this.jy6GVFJfR.Count - 1;
      bool flag = true;
      while (flag)
      {
        if (num2 < num1)
          return -1;
        index = (num1 + num2) / 2;
        switch (option)
        {
          case SearchOption.Prev:
            if (this.jy6GVFJfR.Keys[index] <= datetime && (index == this.jy6GVFJfR.Count - 1 || this.jy6GVFJfR.Keys[index + 1] > datetime))
            {
              flag = false;
              continue;
            }
            else if (this.jy6GVFJfR.Keys[index] > datetime)
            {
              num2 = index - 1;
              continue;
            }
            else
            {
              num1 = index + 1;
              continue;
            }
          case SearchOption.Exact:
            if (this.jy6GVFJfR.Keys[index] == datetime)
            {
              flag = false;
              continue;
            }
            else if (this.jy6GVFJfR.Keys[index] > datetime)
            {
              num2 = index - 1;
              continue;
            }
            else if (this.jy6GVFJfR.Keys[index] < datetime)
            {
              num1 = index + 1;
              continue;
            }
            else
              continue;
          case SearchOption.Next:
            if (this.jy6GVFJfR.Keys[index] >= datetime && (index == 0 || this.jy6GVFJfR.Keys[index - 1] < datetime))
            {
              flag = false;
              continue;
            }
            else if (this.jy6GVFJfR.Keys[index] < datetime)
            {
              num1 = index + 1;
              continue;
            }
            else
            {
              num2 = index - 1;
              continue;
            }
          default:
            continue;
        }
      }
      return index;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTime DateTimeAt(int index)
    {
      return this.jy6GVFJfR.Keys[index];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(DateTime datetime)
    {
      this.jy6GVFJfR.Remove(datetime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAt(int index)
    {
      this.jy6GVFJfR.RemoveAt(index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.jy6GVFJfR.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Flush()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this.jy6GVFJfR.Values.GetEnumerator();
    }
  }
}

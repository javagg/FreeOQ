// Type: SmartQuant.Trading.StopList
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading
{
  public class StopList : ICollection, IEnumerable
  {
    private ArrayList qA2WAo3yMW;

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.qA2WAo3yMW.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.qA2WAo3yMW.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.qA2WAo3yMW.SyncRoot;
      }
    }

    public IStop this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.qA2WAo3yMW[index] as IStop;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopList()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.qA2WAo3yMW = new ArrayList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.qA2WAo3yMW.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.qA2WAo3yMW.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(IStop stop)
    {
      this.Add(stop, true);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(IStop stop, bool sort)
    {
      this.qA2WAo3yMW.Add((object) stop);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(IStop stop)
    {
      this.qA2WAo3yMW.Remove((object) stop);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAt(int index)
    {
      this.qA2WAo3yMW.RemoveAt(index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.qA2WAo3yMW.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(IStop stop)
    {
      return this.qA2WAo3yMW.Contains((object) stop);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Sort()
    {
      this.qA2WAo3yMW.Sort();
    }
  }
}

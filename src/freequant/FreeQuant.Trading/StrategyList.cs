// Type: SmartQuant.Trading.StrategyList
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SlN8f6pWyHStvuMgWbM;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SmartQuant.Trading
{
  public class StrategyList : ICollection, IEnumerable
  {
    private SortedList mTZpGjqLyG;

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.mTZpGjqLyG.IsSynchronized;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.mTZpGjqLyG.SyncRoot;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.mTZpGjqLyG.Count;
      }
    }

    public StrategyBase this[string name]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.mTZpGjqLyG[(object) name] as StrategyBase;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal StrategyList()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.mTZpGjqLyG = new SortedList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.mTZpGjqLyG.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.mTZpGjqLyG.Values.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void sHVpbkHDLx([In] StrategyBase obj0)
    {
      if (this.mTZpGjqLyG.Contains((object) obj0.Name))
        throw new ApplicationException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(2884) + obj0.Name);
      this.mTZpGjqLyG.Add((object) obj0.Name, (object) obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void Sg6pybMZlM([In] StrategyBase obj0)
    {
      this.mTZpGjqLyG.Remove((object) obj0.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(string name)
    {
      return this.mTZpGjqLyG.ContainsKey((object) name);
    }
  }
}

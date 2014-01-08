
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class SignalList : ICollection, IEnumerable
  {
    private ArrayList mOPje6CaVf;

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.mOPje6CaVf.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.mOPje6CaVf.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.mOPje6CaVf.SyncRoot;
      }
    }

    public Signal this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.mOPje6CaVf[index] as Signal;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SignalList()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.mOPje6CaVf = new ArrayList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.mOPje6CaVf.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.mOPje6CaVf.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.mOPje6CaVf.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(Signal signal)
    {
      this.mOPje6CaVf.Add((object) signal);
    }
  }
}

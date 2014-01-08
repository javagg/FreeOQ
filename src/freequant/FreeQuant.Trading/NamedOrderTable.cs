
using FreeQuant.Execution;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Trading
{
  public class NamedOrderTable : ICollection, IEnumerable
  {
    private Hashtable EryiTEvSaf;

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.EryiTEvSaf.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.EryiTEvSaf.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.EryiTEvSaf.SyncRoot;
      }
    }

    public SingleOrder this[string name]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.EryiTEvSaf[(object) name] as SingleOrder;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal NamedOrderTable()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.EryiTEvSaf = new Hashtable();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.EryiTEvSaf.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.EryiTEvSaf.Values.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void vxbiSOygU5([In] string obj0, [In] SingleOrder obj1)
    {
      this.EryiTEvSaf[(object) obj0] = (object) obj1;
    }
  }
}

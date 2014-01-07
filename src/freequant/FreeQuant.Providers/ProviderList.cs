using dW79p7NPlS6ZxObcx3;
using Obgh2s3A3GOOarwj6c;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Providers
{
  public class ProviderList : ICollection, IEnumerable
  {
    private SortedList ABRggRZgo;
    private SortedList VCcLtMAKC;

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ABRggRZgo.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ABRggRZgo.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ABRggRZgo.SyncRoot;
      }
    }

    public IProvider this[string name]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ABRggRZgo[(object) name] as IProvider;
      }
    }

    public IProvider this[byte id]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.VCcLtMAKC[(object) id] as IProvider;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProviderList()
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.ABRggRZgo = new SortedList();
      this.VCcLtMAKC = new SortedList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator IProvider[](ProviderList list)
    {
      return new ArrayList(list.ABRggRZgo.Values).ToArray(typeof (IProvider)) as IProvider[];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.ABRggRZgo.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.ABRggRZgo.Values.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void HH8tS7bFw([In] IProvider obj0)
    {
      if (this.ABRggRZgo.ContainsKey((object) obj0.Name))
        throw new ArgumentException(GojrKtfk5NMi1fou68.a17L2Y7Wnd(0) + obj0.Name);
      if (this.VCcLtMAKC.Contains((object) obj0.Id))
        throw new ArgumentException(GojrKtfk5NMi1fou68.a17L2Y7Wnd(142) + (object) obj0.Id);
      this.ABRggRZgo.Add((object) obj0.Name, (object) obj0);
      this.VCcLtMAKC.Add((object) obj0.Id, (object) obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(string name)
    {
      return this.ABRggRZgo.ContainsKey((object) name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(byte id)
    {
      return this.VCcLtMAKC.ContainsKey((object) id);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(IProvider provider)
    {
      return this.ABRggRZgo.ContainsValue((object) provider);
    }
  }
}

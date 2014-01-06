// Type: SmartQuant.Providers.ProviderErrorCollection
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using dW79p7NPlS6ZxObcx3;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SmartQuant.Providers
{
  public class ProviderErrorCollection : ICollection, IEnumerable
  {
    private ArrayList PdaSRQc7R;

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.PdaSRQc7R.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.PdaSRQc7R.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.PdaSRQc7R.SyncRoot;
      }
    }

    public ProviderError this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.PdaSRQc7R[index] as ProviderError;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ProviderErrorCollection()
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.PdaSRQc7R = new ArrayList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.PdaSRQc7R.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.PdaSRQc7R.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void VruWdmvdd([In] ProviderError obj0)
    {
      this.PdaSRQc7R.Add((object) obj0);
    }
  }
}

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Providers
{
  public class ProviderErrorCollection : ICollection, IEnumerable
  {
    private ArrayList PdaSRQc7R;

    public bool IsSynchronized
    {
       get
      {
        return this.PdaSRQc7R.IsSynchronized;
      }
    }

    public int Count
    {
       get
      {
        return this.PdaSRQc7R.Count;
      }
    }

    public object SyncRoot
    {
       get
      {
        return this.PdaSRQc7R.SyncRoot;
      }
    }

    public ProviderError this[int index]
    {
       get
      {
        return this.PdaSRQc7R[index] as ProviderError;
      }
    }

    
    internal ProviderErrorCollection()
    {
      this.PdaSRQc7R = new ArrayList();
    }

    
    public void CopyTo(Array array, int index)
    {
      this.PdaSRQc7R.CopyTo(array, index);
    }

    
    public IEnumerator GetEnumerator()
    {
      return this.PdaSRQc7R.GetEnumerator();
    }

    
    internal void VruWdmvdd([In] ProviderError obj0)
    {
      this.PdaSRQc7R.Add((object) obj0);
    }
  }
}

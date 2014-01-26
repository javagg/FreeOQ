
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
       get
      {
        return this.EryiTEvSaf.IsSynchronized;
      }
    }

    public int Count
    {
       get
      {
        return this.EryiTEvSaf.Count;
      }
    }

    public object SyncRoot
    {
       get
      {
        return this.EryiTEvSaf.SyncRoot;
      }
    }

    public SingleOrder this[string name]
    {
       get
      {
        return this.EryiTEvSaf[(object) name] as SingleOrder;
      }
    }

    
		internal NamedOrderTable():base()
    {
      this.EryiTEvSaf = new Hashtable();
    }

    
    public void CopyTo(Array array, int index)
    {
      this.EryiTEvSaf.CopyTo(array, index);
    }

    
    public IEnumerator GetEnumerator()
    {
      return this.EryiTEvSaf.Values.GetEnumerator();
    }

    
    internal void vxbiSOygU5([In] string obj0, [In] SingleOrder obj1)
    {
      this.EryiTEvSaf[(object) obj0] = (object) obj1;
    }
  }
}

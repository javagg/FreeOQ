using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Execution
{
  public class SellSideOrderList : ICollection, IEnumerable
  {
		private Dictionary<string, SingleOrder> iX0Aocoro; 
		private List<SingleOrder> YCZoPZ1j9; 

    public int Count
    {
       get
      {
        return this.YCZoPZ1j9.Count;
      }
    }

    public bool IsSynchronized
    {
       get
      {
        return false;
      }
    }

    public object SyncRoot
    {
       get
      {
        return (object) null;
      }
    }

    public SingleOrder this[string orderID]
    {
       get
      {
        SingleOrder singleOrder;
        if (this.iX0Aocoro.TryGetValue(orderID, out singleOrder))
          return singleOrder;
        else
          return (SingleOrder) null;
      }
    }

    public SingleOrder this[int index]
    {
       get
      {
        return this.YCZoPZ1j9[index];
      }
    }

    
		internal SellSideOrderList():base()
    {
      this.iX0Aocoro = new Dictionary<string, SingleOrder>();
      this.YCZoPZ1j9 = new List<SingleOrder>();
    }

    
    public void CopyTo(Array array, int index)
    {
      this.YCZoPZ1j9.ToArray().CopyTo(array, index);
    }

    
    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this.YCZoPZ1j9.GetEnumerator();
    }

    
    internal void HKElmrgRF()
    {
      this.iX0Aocoro.Clear();
      this.YCZoPZ1j9.Clear();
    }

    
    internal void YKsdCTvel([In] SingleOrder obj0)
    {
      this.iX0Aocoro.Add(obj0.OrderID, obj0);
      this.YCZoPZ1j9.Add(obj0);
    }

    
    internal void rkS4wTRRF([In] int obj0)
    {
      this.iX0Aocoro.Remove(this.YCZoPZ1j9[obj0].OrderID);
      this.YCZoPZ1j9.RemoveAt(obj0);
    }
  }
}

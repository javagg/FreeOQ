using FreeQuant.FIX;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Execution
{
  public class OrderList : FIXGroupList
  {
    private Hashtable oOnEP6eEB;

    public IOrder this[int index]
    {
      get
      {
        return base[index] as IOrder;
      }
    }

    public IOrder this[string orderId]
    {
      get
      {
        return this.oOnEP6eEB[(object) orderId] as IOrder;
      }
    }

   
		public OrderList():base()
    {
      this.oOnEP6eEB = new Hashtable();
    }

   
    public IOrder GetById(int id)
    {
      return base.GetById(id) as IOrder;
    }

   
    public void Add(IOrder order)
    {
      this.oOnEP6eEB.Add((object) order.ClOrdID, (object) order);
      base.Add(order as FIXGroup);
    }

   
    public void Remove(IOrder order)
    {
      this.oOnEP6eEB.Remove((object) order.ClOrdID);
      base.Remove(order as FIXGroup);
    }

   
    public override void Clear()
    {
      this.oOnEP6eEB.Clear();
      base.Clear();
    }
  }
}

// Type: SmartQuant.Execution.OrderList
// Assembly: SmartQuant.Execution, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: 444CC37E-F17B-4ED8-9FD1-FAF0B8C26A05
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Execution.dll

using RZ1j9O1DCcsDf19ge6;
using SmartQuant.FIX;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.Execution
{
  public class OrderList : FIXGroupList
  {
    private Hashtable oOnEP6eEB;

    public IOrder this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return base[index] as IOrder;
      }
    }

    public IOrder this[string orderId]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.oOnEP6eEB[(object) orderId] as IOrder;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrderList()
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.oOnEP6eEB = new Hashtable();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IOrder GetById(int id)
    {
      return base.GetById(id) as IOrder;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(IOrder order)
    {
      this.oOnEP6eEB.Add((object) order.ClOrdID, (object) order);
      base.Add(order as FIXGroup);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(IOrder order)
    {
      this.oOnEP6eEB.Remove((object) order.ClOrdID);
      base.Remove(order as FIXGroup);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Clear()
    {
      this.oOnEP6eEB.Clear();
      base.Clear();
    }
  }
}

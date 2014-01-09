using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class OrderCancelRejectEventArgs : EventArgs
  {
    private NewOrderSingle q7HQ2ja0mq;
    private OrderCancelReject UJYQc8UigN;

    public NewOrderSingle Order
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.q7HQ2ja0mq;
      }
    }

    public OrderCancelReject OrderCancelReject
    {
     get
      {
        return this.UJYQc8UigN;
      }
    }

    public OrderCancelRejectEventArgs(NewOrderSingle order, OrderCancelReject reject) :base()
    {
      this.q7HQ2ja0mq = order;
      this.UJYQc8UigN = reject;
    }

    public OrderCancelRejectEventArgs(OrderCancelReject reject): this((NewOrderSingle) null, reject)
    {
    }
  }
}

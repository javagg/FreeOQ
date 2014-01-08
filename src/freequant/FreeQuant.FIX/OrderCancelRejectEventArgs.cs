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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.UJYQc8UigN;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrderCancelRejectEventArgs(NewOrderSingle order, OrderCancelReject reject)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.q7HQ2ja0mq = order;
      this.UJYQc8UigN = reject;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrderCancelRejectEventArgs(OrderCancelReject reject)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      this.\u002Ector((NewOrderSingle) null, reject);
    }
  }
}

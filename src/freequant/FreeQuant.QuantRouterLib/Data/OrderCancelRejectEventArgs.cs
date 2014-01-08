using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Data
{
  public class OrderCancelRejectEventArgs : EventArgs
  {
    public OrderCancelReject OrderCancelReject { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public OrderCancelRejectEventArgs(OrderCancelReject orderCancelReject)
    {
      this.OrderCancelReject = orderCancelReject;
    }
  }
}

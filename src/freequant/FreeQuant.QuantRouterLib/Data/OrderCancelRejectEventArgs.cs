using System;

namespace FreeQuant.QuantRouterLib.Data
{
    public class OrderCancelRejectEventArgs : EventArgs
    {
        public OrderCancelReject OrderCancelReject { get; private set; }

        public OrderCancelRejectEventArgs(OrderCancelReject orderCancelReject)
        {
            this.OrderCancelReject = orderCancelReject;
        }
    }
}

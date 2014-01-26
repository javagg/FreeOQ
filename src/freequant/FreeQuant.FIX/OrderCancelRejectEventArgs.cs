using System;

namespace FreeQuant.FIX
{
	public class OrderCancelRejectEventArgs : EventArgs
	{
		public NewOrderSingle Order { get; private set; }
		public OrderCancelReject OrderCancelReject { get; private set; }

		public OrderCancelRejectEventArgs(NewOrderSingle order, OrderCancelReject reject) : base()
		{
			this.Order = order;
			this.OrderCancelReject = reject;
		}

		public OrderCancelRejectEventArgs(OrderCancelReject reject) : this(null, reject)
		{
		}
	}
}

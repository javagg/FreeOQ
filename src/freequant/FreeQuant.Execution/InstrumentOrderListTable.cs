using FreeQuant.FIX;

namespace FreeQuant.Execution
{
	public class InstrumentOrderListTable
	{
		private OrderList allOrders;
		private OrderList newOrders;
		private OrderList pendingOrders;
		private OrderList cancelledOrders;
		private OrderList rejectedOrders;
		private OrderList filledOrders;

		public OrderList All
		{
			get
			{
				return this.allOrders; 
			}
		}

		public OrderList New
		{
			get
			{
				if (this.newOrders == null)
					this.newOrders = this.GetOrderList(OrdStatus.New);
				return this.newOrders;
			}
		}

		public OrderList Pending
		{
			get
			{
				if (this.pendingOrders == null)
					this.pendingOrders = this.GetOrderList(OrdStatus.PendingNew);
				return this.pendingOrders;
			}
		}

		public OrderList Cancelled
		{
			get
			{
				if (this.cancelledOrders == null)
					this.cancelledOrders = this.GetOrderList(OrdStatus.Cancelled);
				return this.cancelledOrders;
			}
		}

		public OrderList Rejected
		{
			get
			{
				if (this.rejectedOrders == null)
					this.rejectedOrders = this.GetOrderList(OrdStatus.Rejected);
				return this.rejectedOrders;
			}
		}

		public OrderList Filled
		{
			get
			{
				if (this.filledOrders == null)
					this.filledOrders = this.GetOrderList(OrdStatus.Filled);
				return this.filledOrders;
			}
		}

		public int Count
		{
			get
			{
				return this.allOrders.Count;
			}
		}

		public InstrumentOrderListTable()
		{
			this.allOrders = new OrderList();
		}

		public virtual void Clear()
		{
			this.allOrders.Clear();
			this.newOrders = null;
			this.pendingOrders = null;
			this.cancelledOrders = null;
			this.rejectedOrders = null;
			this.filledOrders = null;
		}

		public virtual void Add(SingleOrder order)
		{
			this.allOrders.Add(order);
			this.newOrders = null;
			this.pendingOrders = null;
			this.cancelledOrders = null;
			this.rejectedOrders = null;
			this.filledOrders = null;
		}

		public virtual void Remove(SingleOrder order)
		{
			this.allOrders.Remove(order);
			this.newOrders = null;
			this.pendingOrders = null;
			this.cancelledOrders = null;
			this.rejectedOrders = null;
			this.filledOrders = null;
		}

		public virtual void Update(SingleOrder order)
		{
			this.newOrders = null;
			this.pendingOrders = null;
			this.cancelledOrders = null;
			this.rejectedOrders = null;
			this.filledOrders = null;
		}

		public OrderList GetOrderList(OrdStatus ordStatus)
		{
			OrderList orderList = new OrderList();
			foreach (SingleOrder singleOrder in this.allOrders)
			{
				if (singleOrder.OrdStatus == ordStatus)
					orderList.Add(singleOrder);
			}
			return orderList;
		}
	}
}

using FreeQuant.FIX;
using System.Collections;

namespace FreeQuant.Execution
{
	public class OrderList : FIXGroupList
	{
		private Hashtable orders;

		public new IOrder this[int index]
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
				return this.orders[orderId] as IOrder;
			}
		}

		public OrderList() : base()
		{
			this.orders = new Hashtable();
		}

		public new IOrder GetById(int id)
		{
			return base.GetById(id) as IOrder;
		}

		public void Add(IOrder order)
		{
			this.orders.Add(order.ClOrdID, order);
			base.Add(order as FIXGroup);
		}

		public void Remove(IOrder order)
		{
			this.orders.Remove(order.ClOrdID);
			base.Remove(order as FIXGroup);
		}

		public override void Clear()
		{
			this.orders.Clear();
			base.Clear();
		}
	}
}

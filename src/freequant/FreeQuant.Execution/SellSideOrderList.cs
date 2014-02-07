using System;
using System.Collections;
using System.Collections.Generic;

namespace FreeQuant.Execution
{
	public class SellSideOrderList : ICollection
	{
		private Dictionary<string, SingleOrder> ordersById;
		private List<SingleOrder> ordersByIndex; 

		public int Count
		{
			get
			{
				return this.ordersByIndex.Count;
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
				return null;
			}
		}

		public SingleOrder this[string orderID]
		{
			get
			{
				SingleOrder order;
				if (this.ordersById.TryGetValue(orderID, out order))
				{
					return order;
				}
				return null;
			}
		}

		public SingleOrder this[int index]
		{
			get
			{
				return this.ordersByIndex[index];
			}
		}

		internal SellSideOrderList() : base()
		{
			this.ordersById = new Dictionary<string, SingleOrder>();
			this.ordersByIndex = new List<SingleOrder>();
		}

		public void CopyTo(Array array, int index)
		{
			this.ordersByIndex.ToArray().CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.ordersByIndex.GetEnumerator();
		}

		internal void Clear()
		{
			this.ordersById.Clear();
			this.ordersByIndex.Clear();
		}

		internal void Add(SingleOrder order)
		{
			this.ordersById.Add(order.OrderID, order);
			this.ordersByIndex.Add(order);
		}

		internal void Remove(int index)
		{
			this.ordersById.Remove(this.ordersByIndex[index].OrderID);
			this.ordersByIndex.RemoveAt(index);
		}
	}
}

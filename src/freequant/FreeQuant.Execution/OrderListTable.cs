using FreeQuant.FIX;
using System.Collections;

namespace FreeQuant.Execution
{
	public class OrderListTable : InstrumentOrderListTable
	{
		private Hashtable orders;

		public InstrumentOrderListTable this[IFIXInstrument instrument]
		{
			get
			{
				InstrumentOrderListTable table = this.orders[instrument] as InstrumentOrderListTable;
				if (table == null)
				{
					table = new InstrumentOrderListTable();
					this.orders.Add(instrument, table);
				}
				return table;
			}
		}

		public OrderListTable() : base()
		{
			this.orders = new Hashtable();
		}

		public override void Clear()
		{
			base.Clear();
			this.orders.Clear();
		}

		public override void Add(SingleOrder order)
		{
			base.Add(order);
			this[order.Instrument].Add(order);
		}

		public override void Remove(SingleOrder order)
		{
			base.Remove(order);
			this[order.Instrument].Remove(order);
		}

		public override void Update(SingleOrder order)
		{
			base.Update(order);
			this[order.Instrument].Update(order);
		}
	}
}

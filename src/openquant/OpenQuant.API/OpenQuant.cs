using OpenQuant.ObjectMap;
using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using System;

namespace OpenQuant.API
{
	/// <summary>
	/// OpenQuant class
	/// </summary>
	public class OpenQuant
	{
		private static InstrumentList instruments = new InstrumentList();
		private static OrderList orders = new OrderList();
		private static BarSeriesList bars = new BarSeriesList();
	
		/// <summary>
		/// Initializes a new instance of this class
		/// </summary>
		public OpenQuant()
		{
		}

		/// <summary>
		///  Gets Instruments
		/// </summary>
		public static InstrumentList Instruments
		{
			get
			{
				return OpenQuant.instruments;
			}
		}

		/// <summary>
		/// Gets Orders
		/// </summary>
		public static OrderList Orders
		{
			get
			{
				return OpenQuant.orders;
			}
		}

		/// <summary>
		/// Gets Bars
		/// </summary>
		public static BarSeriesList Bars
		{
			get
			{
				return OpenQuant.bars;
			}
		}

		/// <summary>
		/// Enables partial transactions
		/// If EnablePartialTransactions is set to true - each order partial fill 
		/// leads to creations of a new transaction that is added to the portfolio. 
		/// In contrast to situation when EnablePartialTransactions is set to false, 
		/// in this case new transaction is created and added to the portfolio 
		/// only when an order is done (completely filled or partially filled 
		/// and cancelled). 
		/// </summary>
		public static bool EnablePartialTransactions
		{
			get
			{
				return OrderManager.EnablePartialTransactions;
			}
			set
			{
				OrderManager.EnablePartialTransactions = value;
			}
		}

		public static void Init()
		{
			FreeQuant.Instruments.Currency.Converter = new DefaultCurrencyConverter();
			
            foreach (FreeQuant.Instruments.Instrument fq_instrument in FreeQuant.Instruments.InstrumentManager.Instruments)
				OpenQuant.AddInstrument(fq_instrument);

            FreeQuant.Instruments.InstrumentManager.InstrumentAdded += (e) =>
            {
                OpenQuant.AddInstrument(e.Instrument);
            };

            FreeQuant.Instruments.InstrumentManager.InstrumentRemoved += (e) =>
            {
                OpenQuant.RemoveInstrument(e.Instrument);
            };

            foreach (FreeQuant.Instruments.Portfolio sq_portfolio in PortfolioManager.Portfolios)
				OpenQuant.AddPortfolio(sq_portfolio);
			
            PortfolioManager.PortfolioAdded += (e) =>
            {
                OpenQuant.AddPortfolio(e.Portfolio);
            };

			OpenQuant.InitOrders();
            OrderManager.NewOrder += (e) =>
            {
                Order order;
                if (Map.FQ_OQ_Order.ContainsKey(e.Order))
                {
                    order = Map.FQ_OQ_Order[e.Order] as Order;
                }
                else
                {
                    order = new Order(e.Order);
                    Map.OQ_FQ_Order[order] = e.Order;
                    Map.FQ_OQ_Order[e.Order] = order;
                }
                OpenQuant.orders.Add(order);
            };

            OrderManager.OrderRemoved += (e) =>
            {
                Order order = Map.FQ_OQ_Order[e.Order] as Order;
                OpenQuant.orders.Remove(order);
                Map.FQ_OQ_Order.Remove(e.Order);
                Map.OQ_FQ_Order.Remove(order);
            };

            OrderManager.OrderListUpdated += (sender, e) =>
            {
                OpenQuant.orders.Clear();
                Map.OQ_FQ_Order.Clear();
                Map.FQ_OQ_Order.Clear();
                foreach (SingleOrder order1 in OrderManager.Orders.All)
                {
                    Order order2 = new Order(order1);
                    OpenQuant.orders.Add(order2);
                    Map.OQ_FQ_Order[order2] = order1;
                    Map.FQ_OQ_Order[order1] = order2;
                }
            };
		}

		private static void InitOrders()
		{
			foreach (SingleOrder order in OrderManager.Orders.All)
			{
				Order wrapper = Order.CreateWrapper(order);
				OpenQuant.orders.Add(wrapper);
				Map.OQ_FQ_Order[wrapper] = order;
				Map.FQ_OQ_Order[order] = wrapper;
			}
		}

//		private static void SQ_OrderManager_OrderListUpdated(object sender, EventArgs e)
//		{
//			OpenQuant.orders.Clear();
//			Map.OQ_FQ_Order.Clear();
//			Map.FQ_OQ_Order.Clear();
//			foreach (SingleOrder order1 in (FIXGroupList) ((InstrumentOrderListTable) OrderManager.Orders).All)
//			{
//				Order order2 = new Order(order1);
//				OpenQuant.orders.Add(order2);
//				Map.OQ_FQ_Order[order2] = order1;
//				Map.FQ_OQ_Order[order1] = order2;
//			}
//		}

        private static void AddInstrument(FreeQuant.Instruments.Instrument fq_instrument)
		{
			Instrument instrument = new Instrument(fq_instrument);
			OpenQuant.instruments.Add(fq_instrument.Symbol, instrument);
			Map.OQ_FQ_Instrument[instrument] = fq_instrument;
			Map.FQ_OQ_Instrument[fq_instrument] = instrument;
		}

        private static void RemoveInstrument(FreeQuant.Instruments.Instrument fq_instrument)
		{
			OpenQuant.instruments.Remove(fq_instrument.Symbol);
			Instrument instrument = Map.FQ_OQ_Instrument[fq_instrument] as Instrument;
			Map.OQ_FQ_Instrument.Remove(instrument);
			Map.FQ_OQ_Instrument.Remove(fq_instrument);
		}

		private static void AddPortfolio(FreeQuant.Instruments.Portfolio sq_portfolio)
		{
			Portfolio portfolio = new Portfolio(sq_portfolio);
			Map.OQ_FQ_Portfolio[portfolio] = sq_portfolio;
			Map.FQ_OQ_Portfolio[sq_portfolio] = portfolio;
		}
	}
}
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
			FreeQuant.Instruments.Currency.Converter = (ICurrencyConverter)new DefaultCurrencyConverter();
			foreach (FreeQuant.Instruments.Instrument sq_instrument in (FIXGroupList) FreeQuant.Instruments.InstrumentManager.Instruments)
				OpenQuant.AddInstrument(sq_instrument);
			FreeQuant.Instruments.InstrumentManager.InstrumentAdded += new InstrumentEventHandler(OpenQuant.SQInstrumentManager_InstrumentAdded);
			FreeQuant.Instruments.InstrumentManager.InstrumentRemoved += new InstrumentEventHandler(OpenQuant.SQInstrumentManager_InstrumentRemoved);
			foreach (FreeQuant.Instruments.Portfolio sq_portfolio in PortfolioManager.Portfolios)
				OpenQuant.AddPortfolio(sq_portfolio);
//			PortfolioManager.PortfolioAdded += new PortfolioEventHandler(OpenQuant.FQ_PortfolioManager_PortfolioAdded);
//			OpenQuant.InitOrders();
//			// ISSUE: method pointer
//			OrderManager.NewOrder += new OrderEventHandler(null, __methodptr(FQ_OrderManager_NewOrder));
//			// ISSUE: method pointer
//			OrderManager.OrderRemoved += new OrderEventHandler(null, __methodptr(FQ_OrderManager_OrderRemoved));
//			OrderManager.OrderListUpdated += new EventHandler(OpenQuant.FQ_OrderManager_OrderListUpdated);
		}

		private static void InitOrders()
		{
			foreach (SingleOrder order in (FIXGroupList) ((InstrumentOrderListTable) OrderManager.Orders).All)
			{
				Order wrapper = Order.CreateWrapper(order);
				OpenQuant.orders.Add(wrapper);
				Map.OQ_SQ_Order[wrapper] = order;
				Map.SQ_OQ_Order[order] = wrapper;
			}
		}

		private static void SQ_OrderManager_OrderListUpdated(object sender, EventArgs e)
		{
			OpenQuant.orders.Clear();
			Map.OQ_SQ_Order.Clear();
			Map.SQ_OQ_Order.Clear();
			foreach (SingleOrder order1 in (FIXGroupList) ((InstrumentOrderListTable) OrderManager.Orders).All)
			{
				Order order2 = new Order(order1);
				OpenQuant.orders.Add(order2);
				Map.OQ_SQ_Order[order2] = order1;
				Map.SQ_OQ_Order[order1] = order2;
			}
		}

		private static void SQ_OrderManager_NewOrder(OrderEventArgs e)
		{
			Order order;
			if (Map.SQ_OQ_Order.ContainsKey(e.Order))
			{
				order = Map.SQ_OQ_Order[e.Order] as Order;
			}
			else
			{
				order = new Order(e.Order);
				Map.OQ_SQ_Order[order] = e.Order;
				Map.SQ_OQ_Order[e.Order] = order;
			}
			OpenQuant.orders.Add(order);
		}

		private static void SQ_OrderManager_OrderRemoved(OrderEventArgs e)
		{
			Order order = Map.SQ_OQ_Order[e.Order] as Order;
			OpenQuant.orders.Remove(order);
			Map.SQ_OQ_Order.Remove(e.Order);
			Map.OQ_SQ_Order.Remove(order);
		}

		private static void SQInstrumentManager_InstrumentAdded(InstrumentEventArgs args)
		{
			OpenQuant.AddInstrument(args.Instrument);
		}

		private static void SQInstrumentManager_InstrumentRemoved(InstrumentEventArgs args)
		{
			OpenQuant.RemoveInstrument(args.Instrument);
		}

		private static void AddInstrument(FreeQuant.Instruments.Instrument sq_instrument)
		{
			Instrument instrument = new Instrument(sq_instrument);
			OpenQuant.instruments.Add(sq_instrument.Symbol, instrument);
			Map.OQ_SQ_Instrument[(object)instrument] = sq_instrument;
			Map.SQ_OQ_Instrument[(object)sq_instrument] = (object)instrument;
		}

		private static void RemoveInstrument(FreeQuant.Instruments.Instrument sq_instrument)
		{
			OpenQuant.instruments.Remove(sq_instrument.Symbol);
			Instrument instrument = Map.SQ_OQ_Instrument[(object)sq_instrument] as Instrument;
			Map.OQ_SQ_Instrument.Remove(instrument);
			Map.SQ_OQ_Instrument.Remove((object)sq_instrument);
		}

		private static void SQ_PortfolioManager_PortfolioAdded(PortfolioEventArgs args)
		{
			OpenQuant.AddPortfolio(args.Portfolio);
		}

		private static void AddPortfolio(FreeQuant.Instruments.Portfolio sq_portfolio)
		{
			Portfolio portfolio = new Portfolio(sq_portfolio);
			Map.OQ_SQ_Portfolio[portfolio] = sq_portfolio;
			Map.SQ_OQ_Portfolio[sq_portfolio] = portfolio;
		}
	}
}
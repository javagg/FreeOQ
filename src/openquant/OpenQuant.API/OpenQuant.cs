using OpenQuant.ObjectMap;
using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using System;

namespace OpenQuant.API
{
  public class OpenQuant
  {
    private static InstrumentList instruments = new InstrumentList();
    private static OrderList orders = new OrderList();
    private static BarSeriesList bars = new BarSeriesList();

    public static InstrumentList Instruments
    {
      get
      {
        return OpenQuant.instruments;
      }
    }

    public static OrderList Orders
    {
      get
      {
        return OpenQuant.orders;
      }
    }

    public static BarSeriesList Bars
    {
      get
      {
        return OpenQuant.bars;
      }
    }

    public static bool EnablePartialTransactions
    {
      get
      {
        return OrderManager.get_EnablePartialTransactions();
      }
      set
      {
        OrderManager.set_EnablePartialTransactions(value);
      }
    }

    static OpenQuant()
    {
    }

    public static void Init()
    {
      SmartQuant.Instruments.Currency.Converter = (ICurrencyConverter) new DefaultCurrencyConverter();
      foreach (SmartQuant.Instruments.Instrument sq_instrument in (FIXGroupList) SmartQuant.Instruments.InstrumentManager.Instruments)
        OpenQuant.AddInstrument(sq_instrument);
      SmartQuant.Instruments.InstrumentManager.InstrumentAdded += new InstrumentEventHandler(OpenQuant.SQInstrumentManager_InstrumentAdded);
      SmartQuant.Instruments.InstrumentManager.InstrumentRemoved += new InstrumentEventHandler(OpenQuant.SQInstrumentManager_InstrumentRemoved);
      foreach (SmartQuant.Instruments.Portfolio sq_portfolio in PortfolioManager.Portfolios)
        OpenQuant.AddPortfolio(sq_portfolio);
      PortfolioManager.PortfolioAdded += new PortfolioEventHandler(OpenQuant.SQ_PortfolioManager_PortfolioAdded);
      OpenQuant.InitOrders();
      // ISSUE: method pointer
      OrderManager.add_NewOrder(new OrderEventHandler((object) null, __methodptr(SQ_OrderManager_NewOrder)));
      // ISSUE: method pointer
      OrderManager.add_OrderRemoved(new OrderEventHandler((object) null, __methodptr(SQ_OrderManager_OrderRemoved)));
      OrderManager.add_OrderListUpdated(new EventHandler(OpenQuant.SQ_OrderManager_OrderListUpdated));
    }

    private static void InitOrders()
    {
      foreach (SingleOrder order in (FIXGroupList) ((InstrumentOrderListTable) OrderManager.get_Orders()).get_All())
      {
        Order wrapper = Order.CreateWrapper(order);
        OpenQuant.orders.Add(wrapper);
        Map.OQ_SQ_Order[(object) wrapper] = (object) order;
        Map.SQ_OQ_Order[(object) order] = (object) wrapper;
      }
    }

    private static void SQ_OrderManager_OrderListUpdated(object sender, EventArgs e)
    {
      OpenQuant.orders.Clear();
      Map.OQ_SQ_Order.Clear();
      Map.SQ_OQ_Order.Clear();
      foreach (SingleOrder order1 in (FIXGroupList) ((InstrumentOrderListTable) OrderManager.get_Orders()).get_All())
      {
        Order order2 = new Order(order1);
        OpenQuant.orders.Add(order2);
        Map.OQ_SQ_Order[(object) order2] = (object) order1;
        Map.SQ_OQ_Order[(object) order1] = (object) order2;
      }
    }

    private static void SQ_OrderManager_NewOrder(OrderEventArgs args)
    {
      Order order;
      if (Map.SQ_OQ_Order.ContainsKey((object) args.get_Order()))
      {
        order = Map.SQ_OQ_Order[(object) args.get_Order()] as Order;
      }
      else
      {
        order = new Order(args.get_Order());
        Map.OQ_SQ_Order[(object) order] = (object) args.get_Order();
        Map.SQ_OQ_Order[(object) args.get_Order()] = (object) order;
      }
      OpenQuant.orders.Add(order);
    }

    private static void SQ_OrderManager_OrderRemoved(OrderEventArgs args)
    {
      Order order = Map.SQ_OQ_Order[(object) args.get_Order()] as Order;
      OpenQuant.orders.Remove(order);
      Map.SQ_OQ_Order.Remove((object) args.get_Order());
      Map.OQ_SQ_Order.Remove((object) order);
    }

    private static void SQInstrumentManager_InstrumentAdded(InstrumentEventArgs args)
    {
      OpenQuant.AddInstrument(args.Instrument);
    }

    private static void SQInstrumentManager_InstrumentRemoved(InstrumentEventArgs args)
    {
      OpenQuant.RemoveInstrument(args.Instrument);
    }

    private static void AddInstrument(SmartQuant.Instruments.Instrument sq_instrument)
    {
      Instrument instrument = new Instrument(sq_instrument);
      OpenQuant.instruments.Add(sq_instrument.Symbol, instrument);
      Map.OQ_SQ_Instrument[(object) instrument] = (object) sq_instrument;
      Map.SQ_OQ_Instrument[(object) sq_instrument] = (object) instrument;
    }

    private static void RemoveInstrument(SmartQuant.Instruments.Instrument sq_instrument)
    {
      OpenQuant.instruments.Remove(sq_instrument.Symbol);
      Instrument instrument = Map.SQ_OQ_Instrument[(object) sq_instrument] as Instrument;
      Map.OQ_SQ_Instrument.Remove((object) instrument);
      Map.SQ_OQ_Instrument.Remove((object) sq_instrument);
    }

    private static void SQ_PortfolioManager_PortfolioAdded(PortfolioEventArgs args)
    {
      OpenQuant.AddPortfolio(args.Portfolio);
    }

    private static void AddPortfolio(SmartQuant.Instruments.Portfolio sq_portfolio)
    {
      Portfolio portfolio = new Portfolio(sq_portfolio);
      Map.OQ_SQ_Portfolio[(object) portfolio] = (object) sq_portfolio;
      Map.SQ_OQ_Portfolio[(object) sq_portfolio] = (object) portfolio;
    }
  }
}

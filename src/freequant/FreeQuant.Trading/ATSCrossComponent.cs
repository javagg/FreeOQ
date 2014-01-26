using FreeQuant;
using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Trading
{
  [StrategyComponent("{E70A6417-E7FA-4ec1-BC16-B03DE53C6E85}", ComponentType.ATSCrossComponent, Description = "", Name = "Default_ATSCrossComponent")]
  public class ATSCrossComponent : ATSStrategyMultiComponent
  {
    public const string GUID = "{E70A6417-E7FA-4ec1-BC16-B03DE53C6E85}";
    private Dictionary<SingleOrder, List<ExecutionReport>> fU8pNJpaT5;

   
		public ATSCrossComponent():base()
    {
      this.fU8pNJpaT5 = new Dictionary<SingleOrder, List<ExecutionReport>>();
    }

   
    public virtual void OnStopStatusChanged(ATSStop stop)
    {
    }

   
    public virtual void OnStopCanceled(ATSStop stop)
    {
    }

   
    public virtual void OnStopExecuted(ATSStop stop)
    {
    }

   
    public override sealed void OnNewOrder(SingleOrder order)
    {
    }

   
    public ATSStop SetStop(Position position, double level, StopType type, StopMode mode)
    {
      ATSStop atsStop = new ATSStop(position, level, type, mode);
      this.Strategy.nPMi9oJHY7(atsStop);
      return atsStop;
    }

   
    public ATSStop SetStop(Position position, DateTime dateTime)
    {
      ATSStop atsStop = new ATSStop(position, dateTime);
      this.Strategy.nPMi9oJHY7(atsStop);
      return atsStop;
    }

   
    public MarketOrder MarketOrder(Instrument instrument, Side side, double qty)
    {
      MarketOrder marketOrder = new MarketOrder(instrument, side, qty);
      this.Strategy.EB2iXBUSFK((SingleOrder) marketOrder);
      return marketOrder;
    }

   
    public LimitOrder LimitOrder(Instrument instrument, Side side, double qty, double price)
    {
      LimitOrder limitOrder = new LimitOrder(instrument, side, qty, price);
      this.Strategy.EB2iXBUSFK((SingleOrder) limitOrder);
      return limitOrder;
    }

   
    public StopOrder StopOrder(Instrument instrument, Side side, double qty, double price)
    {
      StopOrder stopOrder = new StopOrder(instrument, side, qty, price);
      this.Strategy.EB2iXBUSFK((SingleOrder) stopOrder);
      return stopOrder;
    }

   
    public StopLimitOrder StopLimitOrder(Instrument instrument, Side side, double qty, double limitPrice, double stopPrice)
    {
      StopLimitOrder stopLimitOrder = new StopLimitOrder(instrument, side, qty, limitPrice, stopPrice);
      this.Strategy.EB2iXBUSFK((SingleOrder) stopLimitOrder);
      return stopLimitOrder;
    }

   
    public TrailingStopOrder TrailingStopOrder(Instrument instrument, Side side, double qty, double delta)
    {
      TrailingStopOrder trailingStopOrder = new TrailingStopOrder(instrument, side, qty, delta);
      this.Strategy.EB2iXBUSFK((SingleOrder) trailingStopOrder);
      return trailingStopOrder;
    }

   
    internal void mfbpeU3YGv([In] SingleOrder obj0)
    {
      this.fU8pNJpaT5.Add(obj0, new List<ExecutionReport>());
      this.OnClientOrder(obj0);
    }

   
    public virtual void OnClientOrder(SingleOrder order)
    {
    }

   
    public void AcceptClientOrder(SingleOrder order)
    {
      ExecutionReport executionReport = this.feHpgokAEH(order);
      executionReport.AvgPx = 0.0;
      executionReport.CumQty = 0.0;
      executionReport.LeavesQty = order.OrderQty;
      executionReport.ExecType = ExecType.New;
      executionReport.OrdStatus = OrdStatus.New;
      this.Strategy.RM9EmoIgF(executionReport);
    }

   
    public void CancelClientOrder(SingleOrder order)
    {
      ExecutionReport executionReport = this.feHpgokAEH(order);
      executionReport.OrigClOrdID = order.ClOrdID;
      executionReport.AvgPx = order.AvgPx;
      executionReport.CumQty = order.CumQty;
      executionReport.LeavesQty = order.LeavesQty;
      executionReport.ExecType = ExecType.Cancelled;
      executionReport.OrdStatus = OrdStatus.Cancelled;
      this.Strategy.RM9EmoIgF(executionReport);
    }

   
    public void RejectClientOrder(SingleOrder order, string text)
    {
      ExecutionReport executionReport = this.feHpgokAEH(order);
      executionReport.AvgPx = 0.0;
      executionReport.CumQty = 0.0;
      executionReport.LeavesQty = order.OrderQty;
      executionReport.Text = text;
      executionReport.ExecType = ExecType.Rejected;
      executionReport.OrdStatus = OrdStatus.Rejected;
      this.Strategy.RM9EmoIgF(executionReport);
    }

   
    public void RejectClientOrder(SingleOrder order)
    {
      this.RejectClientOrder(order, string.Empty);
    }

   
    public void FillClientOrder(SingleOrder order, double price)
    {
      ExecutionReport executionReport = this.feHpgokAEH(order);
      executionReport.LastPx = price;
      executionReport.LastQty = order.OrderQty;
      executionReport.AvgPx = price;
      executionReport.CumQty = order.OrderQty;
      executionReport.LeavesQty = 0.0;
      executionReport.ExecType = ExecType.Fill;
      executionReport.OrdStatus = OrdStatus.Filled;
      this.Strategy.RM9EmoIgF(executionReport);
    }

   
    public void PartialFillClientOrder(SingleOrder order, double price, double qty)
    {
      List<ExecutionReport> list = this.fU8pNJpaT5[order];
      ExecutionReport executionReport1 = list[list.Count - 1];
      ExecutionReport executionReport2 = this.feHpgokAEH(order);
      executionReport2.LastPx = price;
      executionReport2.LastQty = qty;
      executionReport2.AvgPx = (executionReport1.AvgPx * executionReport1.CumQty + price * qty) / (executionReport1.CumQty + qty);
      executionReport2.CumQty = executionReport1.CumQty + qty;
      executionReport2.LeavesQty = executionReport1.LeavesQty - qty;
      if (executionReport2.LeavesQty == 0.0)
      {
        executionReport2.ExecType = ExecType.Fill;
        executionReport2.OrdStatus = OrdStatus.Filled;
      }
      else
      {
        executionReport2.ExecType = ExecType.PartialFill;
        executionReport2.OrdStatus = OrdStatus.PartiallyFilled;
      }
      this.Strategy.RM9EmoIgF(executionReport2);
    }

   
    private ExecutionReport feHpgokAEH([In] SingleOrder obj0)
    {
      ExecutionReport executionReport = new ExecutionReport();
      executionReport.TransactTime = Clock.Now;
      executionReport.ExecID = DateTime.Now.ToString();
      executionReport.ClOrdID = obj0.ClOrdID;
      executionReport.OrderID = obj0.OrderID;
      executionReport.ExecTransType = ExecTransType.New;
      executionReport.Symbol = obj0.Symbol;
      executionReport.SecurityType = obj0.SecurityType;
      executionReport.SecurityExchange = obj0.SecurityExchange;
      executionReport.Currency = obj0.Currency;
      executionReport.TimeInForce = obj0.TimeInForce;
      executionReport.Side = obj0.Side;
      executionReport.OrdType = obj0.OrdType;
      executionReport.Price = obj0.Price;
      executionReport.StopPx = obj0.StopPx;
      executionReport.OrderQty = obj0.OrderQty;
      this.fU8pNJpaT5[obj0].Add(executionReport);
      return executionReport;
    }
  }
}

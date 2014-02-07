using FreeQuant;
using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.Providers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using FreeQuant.Data;
using FreeQuant.Instruments;

namespace FreeQuant.Simulation
{
	internal class zo21q6cy3fImtUHATQ
	{
		private SimulationExecutionProvider A8bFJItyyx;
		private FIXNewOrderSingle PYBF7sahqY;
		private bool aXtFGP76FH;
		private FillOnBarMode kUyFaL3cQu;
		private double zGRFvN99ge;
		private Quote smCF4MYTNu;
		private bool yFOFUpVbqt;
		private bool L27FNaAWTp;
		private int w02FZf7vnP;
		private bool gxTF8gufMx;
		private double j57Fjc16NJ;

		public zo21q6cy3fImtUHATQ(SimulationExecutionProvider obj0, FIXNewOrderSingle obj1)
		{
			this.smCF4MYTNu = new Quote();
			this.j57Fjc16NJ = 1E-08;

			this.A8bFJItyyx = obj0;
			this.PYBF7sahqY = obj1;
			this.kUyFaL3cQu = obj0.FillOnBarMode;
			this.L27FNaAWTp = obj0.FillAtLimitPrice;
			this.yFOFUpVbqt = obj0.FillAtStopPrice;
			if (obj1.TradeVolumeDelay == 0)
				this.gxTF8gufMx = true;
			if ((this.PYBF7sahqY as SingleOrder).OrdType == OrdType.TrailingStop || (this.PYBF7sahqY as SingleOrder).OrdType == OrdType.TrailingStopLimit)
			{
				switch ((this.PYBF7sahqY as SingleOrder).Side)
				{
					case Side.Buy:
					case Side.BuyMinus:
						this.zGRFvN99ge = double.MaxValue;
						break;
					case Side.Sell:
					case Side.SellShort:
						this.zGRFvN99ge = double.MinValue;
						break;
					default:
						throw new NotSupportedException("" + obj1.Side.ToString());
				}
			}
			this.A8bFJItyyx.MyIPdEI7fi.Add(this.PYBF7sahqY.ClOrdID, this);
			this.dGEFgdOydF();
		}

		internal SingleOrder x6qFCwTWN2()
		{
			return this.PYBF7sahqY as SingleOrder;
		}

		
		private void dGEFgdOydF()
		{
			if (!(this.PYBF7sahqY is SingleOrder))
				return;
			SingleOrder singleOrder = this.PYBF7sahqY as SingleOrder;
			if (singleOrder.ContainsField(11201))
				this.kUyFaL3cQu = (FillOnBarMode) singleOrder.FillOnBarMode;
			Instrument instrument = singleOrder.Instrument;
			bool flag = !singleOrder.IsStopLimitReady && (singleOrder.OrdType == OrdType.TrailingStop || singleOrder.OrdType == OrdType.TrailingStopLimit || singleOrder.OrdType == OrdType.StopLimit);
			if (singleOrder.OrdType == OrdType.Market)
			{
				if ((this.A8bFJItyyx.FillOnQuote && !flag || this.A8bFJItyyx.TriggerOnQuote && flag) && this.A8bFJItyyx.FillOnQuoteMode == FillOnQuoteMode.LastQuote)
					this.Y18FFPmDy5(instrument.Quote, (Trade) null, (Bar) null);
				if ((this.A8bFJItyyx.FillOnTrade && !flag || this.A8bFJItyyx.TriggerOnTrade && flag) && this.A8bFJItyyx.FillOnTradeMode == FillOnTradeMode.LastTrade)
					this.Y18FFPmDy5((Quote) null, instrument.Trade, (Bar) null);
				if ((this.A8bFJItyyx.FillOnBar && !flag || this.A8bFJItyyx.TriggerOnBar && flag) && ((this.kUyFaL3cQu == FillOnBarMode.LastBarClose || singleOrder.ForceMarketOrder) && this.A8bFJItyyx.BarFilter.Contains(instrument.Bar.BarType, instrument.Bar.Size)))
					this.Y18FFPmDy5((Quote) null, (Trade) null, instrument.Bar);
			}
			else
			{
				if (instrument.Quote != null && (this.A8bFJItyyx.FillOnQuote && !flag || this.A8bFJItyyx.TriggerOnQuote && flag) && this.A8bFJItyyx.FillOnQuoteMode == FillOnQuoteMode.LastQuote)
					this.Y18FFPmDy5(instrument.Quote, (Trade) null, (Bar) null);
				if (instrument.Trade != null && (this.A8bFJItyyx.FillOnTrade && !flag || this.A8bFJItyyx.TriggerOnTrade && flag) && this.A8bFJItyyx.FillOnTradeMode == FillOnTradeMode.LastTrade)
					this.Y18FFPmDy5((Quote) null, instrument.Trade, (Bar) null);
				if (instrument.Bar != null && (this.A8bFJItyyx.FillOnBar && !flag || this.A8bFJItyyx.TriggerOnBar && flag) && (this.A8bFJItyyx.BarFilter.Contains(instrument.Bar.BarType, instrument.Bar.Size) && this.A8bFJItyyx.FillOnBarMode == FillOnBarMode.LastBarClose))
				{
					double close = instrument.Bar.Close;
					if (close != 0.0)
						this.wYBFLwFB4S(close, singleOrder.OrderQty);
				}
			}
			if (this.aXtFGP76FH)
				return;
			if (this.A8bFJItyyx.FillOnQuote || this.A8bFJItyyx.TriggerOnQuote)
				instrument.NewQuote += new QuoteEventHandler(this.PyJFklA8yp);
			if (this.A8bFJItyyx.FillOnTrade || this.A8bFJItyyx.TriggerOnTrade)
				instrument.NewTrade += new TradeEventHandler(this.YGKFrq1UXP);
			this.smCF4MYTNu = instrument.Quote;
			if (this.A8bFJItyyx.FillOnBar || this.A8bFJItyyx.TriggerOnBar)
			{
				if (singleOrder.ForceMarketOrder)
				{
					instrument.NewBar += new BarEventHandler(this.YgkFRBfPV0);
					instrument.NewBarOpen += new BarEventHandler(this.OyPFEsHGL2);
				}
				else if (singleOrder.OrdType == OrdType.Market)
				{
					switch (this.kUyFaL3cQu)
					{
						case FillOnBarMode.LastBarClose:
						case FillOnBarMode.NextBarClose:
							instrument.NewBar += new BarEventHandler(this.YgkFRBfPV0);
							break;
						case FillOnBarMode.NextBarOpen:
							instrument.NewBarOpen += new BarEventHandler(this.OyPFEsHGL2);
							break;
					}
				}
				else
				{
					instrument.NewBar += new BarEventHandler(this.YgkFRBfPV0);
					instrument.NewBarOpen += new BarEventHandler(this.OyPFEsHGL2);
				}
			}
			if ((int) this.PYBF7sahqY.TimeInForce != 54)
				return;
			Clock.AddReminder(new ReminderEventHandler(this.xT1FyAqCPT), this.PYBF7sahqY.ExpireTime, (object) null);
		}

		
		private void D7GFelmgQp()
		{
			Instrument instrument = (this.PYBF7sahqY as SingleOrder).Instrument;
			instrument.NewQuote -= new QuoteEventHandler(this.PyJFklA8yp);
			instrument.NewTrade -= new TradeEventHandler(this.YGKFrq1UXP);
			instrument.NewBar -= new BarEventHandler(this.YgkFRBfPV0);
			instrument.NewBarOpen -= new BarEventHandler(this.OyPFEsHGL2);
			if ((int) this.PYBF7sahqY.TimeInForce != 54)
				return;
			Clock.RemoveReminder(new ReminderEventHandler(this.xT1FyAqCPT));
		}

		
		private void xT1FyAqCPT(ReminderEventArgs obj0)
		{
			this.XNWFfvowtr();
		}

		
		private double VirF0ddUxQ(SingleOrder obj0, Quote obj1, Trade obj2, Bar obj3)
		{
			bool flag = !obj0.IsStopLimitReady && (obj0.OrdType == OrdType.TrailingStop || obj0.OrdType == OrdType.TrailingStopLimit || obj0.OrdType == OrdType.StopLimit);
			if (obj1 != null && this.A8bFJItyyx.PartialFills && (this.A8bFJItyyx.FillOnQuote && !flag || this.A8bFJItyyx.TriggerOnQuote && flag))
			{
				if (!this.A8bFJItyyx.FillAtWorstQuoteRate || obj1.Bid <= obj1.Ask)
				{
					switch (obj0.Side)
					{
						case Side.Buy:
							if (obj1.AskSize > 0)
								return (double) obj1.AskSize;
							else
								break;
						case Side.Sell:
						case Side.SellShort:
							if (obj1.BidSize > 0)
								return (double) obj1.BidSize;
							else
								break;
						default:
							return obj0.OrderQty;
					}
				}
				else
				{
					switch (obj0.Side)
					{
						case Side.Buy:
							if (obj1.BidSize > 0)
								return (double) obj1.BidSize;
							else
								break;
						case Side.Sell:
						case Side.SellShort:
							if (obj1.Ask > 0.0)
								return (double) obj1.AskSize;
							else
								break;
						default:
							return obj0.OrderQty;
					}
				}
			}
			if ((this.A8bFJItyyx.FillOnTrade && !flag || this.A8bFJItyyx.TriggerOnTrade && flag) && obj2 != null)
			{
				if ((obj0.OrdType == OrdType.Limit || (obj0.OrdType == OrdType.StopLimit || obj0.OrdType == OrdType.TrailingStopLimit) && obj0.IsStopLimitReady) && (obj0.CumQty == 0.0 && Math.Abs(obj2.Price - obj0.Price) < 0.001 && (obj0.TradeVolumeDelay != 0 && !this.gxTF8gufMx)))
				{
					this.w02FZf7vnP += obj2.Size;
					if (this.w02FZf7vnP <= obj0.TradeVolumeDelay)
						return 0.0;
					this.gxTF8gufMx = true;
					if (this.A8bFJItyyx.PartialFills)
						return (double) (this.w02FZf7vnP - obj0.TradeVolumeDelay);
					else
						return obj0.OrderQty;
				}
				else if (this.A8bFJItyyx.PartialFills)
					return (double) obj2.Size;
			}
			return obj0.OrderQty;
		}

		
		private double CcXFPEywDQ(Quote obj0, Trade obj1, Bar obj2)
		{
			SingleOrder singleOrder = this.PYBF7sahqY as SingleOrder;
			if (singleOrder.ContainsField(11103) && singleOrder.StrategyFill)
				return singleOrder.StrategyPrice;
			bool flag = !singleOrder.IsStopLimitReady && (singleOrder.OrdType == OrdType.TrailingStop || singleOrder.OrdType == OrdType.TrailingStopLimit || singleOrder.OrdType == OrdType.StopLimit);
			if (obj0 != null && (this.A8bFJItyyx.FillOnQuote && !flag || this.A8bFJItyyx.TriggerOnQuote && flag))
			{
				if (!this.A8bFJItyyx.FillAtWorstQuoteRate || obj0.Bid <= obj0.Ask)
				{
					switch (singleOrder.Side)
					{
						case Side.Buy:
						case Side.BuyMinus:
							if (obj0.Ask != 0.0)
								return obj0.Ask;
							else
								break;
						case Side.Sell:
						case Side.SellShort:
							if (obj0.Bid != 0.0)
								return obj0.Bid;
							else
								break;
						default:
							throw new NotSupportedException("" + ((object) singleOrder.Side).ToString());
					}
				}
				else
				{
					switch (singleOrder.Side)
					{
						case Side.Buy:
						case Side.BuyMinus:
							if (obj0.Bid != 0.0)
								return obj0.Bid;
							else
								break;
						case Side.Sell:
						case Side.SellShort:
							if (obj0.Ask != 0.0)
								return obj0.Ask;
							else
								break;
						default:
							throw new NotSupportedException("" + ((object) singleOrder.Side).ToString());
					}
				}
			}
			if (obj1 != null && (this.A8bFJItyyx.FillOnTrade && !flag || this.A8bFJItyyx.TriggerOnTrade && flag) && obj1.Price != 0.0)
				return obj1.Price;
			if (obj2 != null && (this.A8bFJItyyx.FillOnBar && !flag || this.A8bFJItyyx.TriggerOnBar && flag))
			{
				if (singleOrder.StrategyComponent == "which")
					return singleOrder.StrategyPrice;
				if (singleOrder.ForceMarketOrder)
				{
					if (obj2.Close != 0.0)
						return obj2.Close;
					if (obj2.Open != 0.0)
						return obj2.Open;
				}
				switch (this.kUyFaL3cQu)
				{
					case FillOnBarMode.LastBarClose:
					case FillOnBarMode.NextBarClose:
						return obj2.Close;
					case FillOnBarMode.NextBarOpen:
						return obj2.Open;
				}
			}
			return 0.0;
		}

		
		private void Y18FFPmDy5(Quote obj0, Trade obj1, Bar obj2)
		{
			SingleOrder singleOrder = this.PYBF7sahqY as SingleOrder;
			if (singleOrder.OrdStatus != OrdStatus.New && singleOrder.OrdStatus != OrdStatus.PendingNew && (singleOrder.OrdStatus != OrdStatus.PartiallyFilled && singleOrder.OrdStatus != OrdStatus.Replaced))
				return;
			double num1 = this.CcXFPEywDQ(obj0, obj1, obj2);
			double num2 = this.VirF0ddUxQ(singleOrder, obj0, obj1, obj2);
			if (num1 == 0.0 || num2 == 0.0)
				return;
			if (singleOrder.OrdType == OrdType.Market || singleOrder.OrdType == OrdType.TrailingStop && singleOrder.IsStopLimitReady)
				this.D35FmNWSPm(num1, num2);
			else
				this.wYBFLwFB4S(num1, num2);
		}

		
		private void D35FmNWSPm(double obj0, double obj1)
		{
			SingleOrder singleOrder = this.PYBF7sahqY as SingleOrder;
			if (singleOrder.IsDone)
				return;
			if (obj1 < singleOrder.LeavesQty)
			{
				this.aXtFGP76FH = false;
				ExecutionReport report = new ExecutionReport();
				report.TransactTime = Clock.Now;
				report.ClOrdID = singleOrder.ClOrdID;
				report.ExecType = ExecType.PartialFill;
				report.OrdStatus = OrdStatus.PartiallyFilled;
				report.Symbol = singleOrder.Symbol;
				report.Side = singleOrder.Side;
				report.OrdType = singleOrder.OrdType;
				report.AvgPx = (singleOrder.AvgPx * singleOrder.CumQty + obj0 * obj1) / (singleOrder.CumQty + obj1);
				report.OrderQty = singleOrder.OrderQty;
				report.LastQty = obj1;
				report.CumQty = singleOrder.CumQty + obj1;
				report.LeavesQty = singleOrder.LeavesQty - obj1;
				report.LastPx = obj0;
				report.Price = singleOrder.Price;
				report.StopPx = singleOrder.StopPx;
				report.SecurityType = singleOrder.SecurityType;
				report.SecurityExchange = singleOrder.SecurityExchange;
				report.Currency = singleOrder.Currency;
				report.Text = singleOrder.Text;
				FIXCommissionData commissionData = this.A8bFJItyyx.CommissionProvider.GetCommissionData((FIXExecutionReport) report);
				report.CommType = FIXCommType.FromFIX(commissionData.CommType);
				report.Commission = commissionData.Commission;
				report.AvgPx = this.A8bFJItyyx.SlippageProvider.GetExecutionPrice(report);
				this.A8bFJItyyx.JPVPJSWclF(report);
			}
			else
			{
				this.D7GFelmgQp();
				this.A8bFJItyyx.MyIPdEI7fi.Remove((object) this.PYBF7sahqY.ClOrdID);
				this.aXtFGP76FH = true;
				obj1 = singleOrder.LeavesQty;
				ExecutionReport report = new ExecutionReport();
				report.TransactTime = Clock.Now;
				report.ClOrdID = singleOrder.ClOrdID;
				report.ExecType = ExecType.Fill;
				report.OrdStatus = OrdStatus.Filled;
				report.Symbol = singleOrder.Symbol;
				report.Side = singleOrder.Side;
				report.OrdType = singleOrder.OrdType;
				report.AvgPx = (singleOrder.AvgPx * singleOrder.CumQty + obj0 * obj1) / (singleOrder.CumQty + obj1);
				report.OrderQty = singleOrder.OrderQty;
				report.LastQty = singleOrder.LeavesQty;
				report.CumQty = singleOrder.OrderQty;
				report.LeavesQty = 0.0;
				report.LastPx = obj0;
				report.Price = singleOrder.Price;
				report.StopPx = singleOrder.StopPx;
				report.SecurityType = singleOrder.SecurityType;
				report.SecurityExchange = singleOrder.SecurityExchange;
				report.Currency = singleOrder.Currency;
				report.Text = singleOrder.Text;
				FIXCommissionData commissionData = this.A8bFJItyyx.CommissionProvider.GetCommissionData((FIXExecutionReport) report);
				report.CommType = FIXCommType.FromFIX(commissionData.CommType);
				report.Commission = commissionData.Commission;
				report.AvgPx = this.A8bFJItyyx.SlippageProvider.GetExecutionPrice(report);
				this.A8bFJItyyx.JPVPJSWclF(report);
			}
		}

		
		internal void XNWFfvowtr()
		{
			this.D7GFelmgQp();
			this.A8bFJItyyx.MyIPdEI7fi.Remove((object) this.PYBF7sahqY.ClOrdID);
			SingleOrder singleOrder = this.PYBF7sahqY as SingleOrder;
			ExecutionReport executionReport = new ExecutionReport();
			executionReport.TransactTime = Clock.Now;
			executionReport.ClOrdID = singleOrder.ClOrdID;
			executionReport.OrigClOrdID = singleOrder.ClOrdID;
			executionReport.ExecType = ExecType.Cancelled;
			executionReport.OrdStatus = OrdStatus.Cancelled;
			executionReport.Symbol = singleOrder.Symbol;
			executionReport.Side = singleOrder.Side;
			executionReport.OrdType = singleOrder.OrdType;
			executionReport.AvgPx = singleOrder.AvgPx;
			executionReport.LeavesQty = singleOrder.LeavesQty;
			executionReport.CumQty = singleOrder.CumQty;
			executionReport.OrderQty = singleOrder.OrderQty;
			executionReport.Price = singleOrder.Price;
			executionReport.StopPx = singleOrder.StopPx;
			executionReport.Currency = singleOrder.Currency;
			executionReport.Text = singleOrder.Text;
			this.A8bFJItyyx.JPVPJSWclF(executionReport);
		}

		
		internal void CfcFBQBLXe(FIXOrderCancelReplaceRequest obj0)
		{
			SingleOrder singleOrder = this.PYBF7sahqY as SingleOrder;
			this.D7GFelmgQp();
			this.A8bFJItyyx.MyIPdEI7fi.Remove((object) obj0.OrigClOrdID);
			ExecutionReport executionReport = new ExecutionReport();
			executionReport.TransactTime = Clock.Now;
			executionReport.ClOrdID = obj0.ClOrdID;
			executionReport.OrigClOrdID = obj0.OrigClOrdID;
			executionReport.ExecType = ExecType.Replace;
			executionReport.OrdStatus = OrdStatus.Replaced;
			executionReport.Symbol = singleOrder.Symbol;
			executionReport.Side = singleOrder.Side;
			executionReport.OrdType = FIXOrdType.FromFIX(obj0.OrdType);
			executionReport.CumQty = singleOrder.CumQty;
			executionReport.OrderQty = obj0.OrderQty;
			executionReport.LeavesQty = obj0.OrderQty - singleOrder.CumQty;
			executionReport.AvgPx = singleOrder.AvgPx;
			executionReport.Price = obj0.Price;
			executionReport.StopPx = obj0.StopPx;
			executionReport.TrailingAmt = obj0.TrailingAmt;
			executionReport.Currency = singleOrder.Currency;
			executionReport.TimeInForce = FIXTimeInForce.FromFIX(obj0.TimeInForce);
			executionReport.Text = singleOrder.Text;
			this.A8bFJItyyx.JPVPJSWclF(executionReport);
			zo21q6cy3fImtUHATQ zo21q6cy3fImtUhatq = new zo21q6cy3fImtUHATQ(this.A8bFJItyyx, (FIXNewOrderSingle) singleOrder);
		}

		
		private void PyJFklA8yp(object obj0, QuoteEventArgs obj1)
		{
			SingleOrder singleOrder = this.PYBF7sahqY as SingleOrder;
			Quote quote = obj1.Quote;
			if (this.A8bFJItyyx.FillAtWorstQuoteRate || this.smCF4MYTNu.Bid <= this.smCF4MYTNu.Ask || quote.Bid <= quote.Ask)
			{
				switch (singleOrder.Side)
				{
					case Side.Buy:
						if (quote.Ask != this.smCF4MYTNu.Ask || quote.AskSize != this.smCF4MYTNu.AskSize)
						{
							this.Y18FFPmDy5(quote, (Trade) null, (Bar) null);
							break;
						}
						else
							break;
					case Side.Sell:
					case Side.SellShort:
						if (quote.Bid != this.smCF4MYTNu.Bid || quote.BidSize != this.smCF4MYTNu.BidSize)
						{
							this.Y18FFPmDy5(quote, (Trade) null, (Bar) null);
							break;
						}
						else
							break;
				}
			}
			else
			{
				switch (singleOrder.Side)
				{
					case Side.Buy:
						if (quote.Bid != this.smCF4MYTNu.Bid || quote.BidSize != this.smCF4MYTNu.BidSize)
						{
							this.Y18FFPmDy5(quote, (Trade) null, (Bar) null);
							break;
						}
						else
							break;
					case Side.Sell:
					case Side.SellShort:
						if (quote.Ask != this.smCF4MYTNu.Ask || quote.AskSize != this.smCF4MYTNu.AskSize)
						{
							this.Y18FFPmDy5(quote, (Trade) null, (Bar) null);
							break;
						}
						else
							break;
				}
			}
			this.smCF4MYTNu = quote;
		}

		
		private void YGKFrq1UXP(object obj0, TradeEventArgs obj1)
		{
			this.Y18FFPmDy5((Quote) null, obj1.Trade, (Bar) null);
		}

		
		private void YgkFRBfPV0(object obj0, BarEventArgs obj1)
		{
			if (!this.A8bFJItyyx.BarFilter.Contains(obj1.Bar.BarType, obj1.Bar.Size))
				return;
			SingleOrder singleOrder = this.PYBF7sahqY as SingleOrder;
			if (singleOrder.OrdType == OrdType.Market)
			{
				this.Y18FFPmDy5((Quote) null, (Trade) null, obj1.Bar);
			}
			else
			{
				if (obj1.Bar == null || !this.A8bFJItyyx.FillOnBar)
					return;
				if (singleOrder.OrdType == OrdType.Limit || (singleOrder.OrdType == OrdType.TrailingStopLimit || singleOrder.OrdType == OrdType.StopLimit) && singleOrder.IsStopLimitReady)
				{
					switch (singleOrder.Side)
					{
						case Side.Buy:
						case Side.BuyMinus:
							if (obj1.Bar.Low <= singleOrder.Price)
							{
								this.D35FmNWSPm(singleOrder.Price, singleOrder.OrderQty);
								break;
							}
							else
								break;
						case Side.Sell:
						case Side.SellShort:
							if (obj1.Bar.High >= singleOrder.Price)
							{
								this.D35FmNWSPm(singleOrder.Price, singleOrder.OrderQty);
								break;
							}
							else
								break;
						default:
							throw new NotSupportedException(""+ ((object) singleOrder.Side).ToString());
					}
				}
				if (singleOrder.OrdType == OrdType.Stop)
				{
					switch (singleOrder.Side)
					{
						case Side.Buy:
						case Side.BuyMinus:
							if (obj1.Bar.High >= singleOrder.StopPx)
							{
								this.D35FmNWSPm(singleOrder.StopPx, singleOrder.OrderQty);
								break;
							}
							else
								break;
						case Side.Sell:
						case Side.SellShort:
							if (obj1.Bar.Low <= singleOrder.StopPx)
							{
								this.D35FmNWSPm(singleOrder.StopPx, singleOrder.OrderQty);
								break;
							}
							else
								break;
						default:
							throw new NotSupportedException("" + ((object) singleOrder.Side).ToString());
					}
				}
				if (singleOrder.OrdType == OrdType.TrailingStop)
				{
					switch (singleOrder.Side)
					{
						case Side.Buy:
						case Side.BuyMinus:
							this.zGRFvN99ge = Math.Min(this.zGRFvN99ge, obj1.Bar.Low + singleOrder.TrailingAmt);
							if (this.dkuF6t82Gt(obj1.Bar.High, this.zGRFvN99ge, this.j57Fjc16NJ) >= 0)
							{
								this.D35FmNWSPm(this.zGRFvN99ge, singleOrder.OrderQty);
								break;
							}
							else
								break;
						case Side.Sell:
						case Side.SellShort:
							this.zGRFvN99ge = Math.Max(this.zGRFvN99ge, obj1.Bar.High - singleOrder.TrailingAmt);
							if (this.dkuF6t82Gt(obj1.Bar.Low, this.zGRFvN99ge, this.j57Fjc16NJ) <= 0)
							{
								this.D35FmNWSPm(this.zGRFvN99ge, singleOrder.OrderQty);
								break;
							}
							else
								break;
						default:
							throw new NotSupportedException("" + ((object) singleOrder.Side).ToString());
					}
				}
				if (singleOrder.OrdType == OrdType.TrailingStopLimit && !singleOrder.IsStopLimitReady)
				{
					switch (singleOrder.Side)
					{
						case Side.Buy:
						case Side.BuyMinus:
							this.zGRFvN99ge = Math.Min(this.zGRFvN99ge, obj1.Bar.Low + singleOrder.TrailingAmt);
							if (this.dkuF6t82Gt(obj1.Bar.High, this.zGRFvN99ge, this.j57Fjc16NJ) >= 0)
							{
								double num = singleOrder.StopPx - singleOrder.Price;
								singleOrder.StopPx = this.zGRFvN99ge;
								singleOrder.Price = this.zGRFvN99ge - num;
								singleOrder.IsStopLimitReady = true;
								break;
							}
							else
								break;
						case Side.Sell:
						case Side.SellShort:
							this.zGRFvN99ge = Math.Max(this.zGRFvN99ge, obj1.Bar.High - singleOrder.TrailingAmt);
							if (this.dkuF6t82Gt(obj1.Bar.Low, this.zGRFvN99ge, this.j57Fjc16NJ) <= 0)
							{
								double num = singleOrder.StopPx - singleOrder.Price;
								singleOrder.StopPx = this.zGRFvN99ge;
								singleOrder.Price = this.zGRFvN99ge - num;
								singleOrder.IsStopLimitReady = true;
								break;
							}
							else
								break;
						default:
							throw new NotSupportedException("" + ((object) singleOrder.Side).ToString());
					}
				}
				if (singleOrder.OrdType != OrdType.StopLimit || singleOrder.IsStopLimitReady)
					return;
				switch (singleOrder.Side)
				{
					case Side.Buy:
					case Side.BuyMinus:
						if (obj1.Bar.High < singleOrder.StopPx)
							break;
						singleOrder.IsStopLimitReady = true;
						break;
					case Side.Sell:
					case Side.SellShort:
						if (obj1.Bar.Low > singleOrder.StopPx)
							break;
						singleOrder.IsStopLimitReady = true;
						break;
					default:
						throw new NotSupportedException("" + ((object) singleOrder.Side).ToString());
				}
			}
		}

		
		private void OyPFEsHGL2(object obj0, BarEventArgs obj1)
		{
			if (!this.A8bFJItyyx.BarFilter.Contains(obj1.Bar.BarType, obj1.Bar.Size))
				return;
			SingleOrder singleOrder = this.PYBF7sahqY as SingleOrder;
			if (singleOrder.OrdType == OrdType.Market)
			{
				this.Y18FFPmDy5((Quote) null, (Trade) null, obj1.Bar);
			}
			else
			{
				if (obj1.Bar == null || !this.A8bFJItyyx.FillOnBar)
					return;
				double open = obj1.Bar.Open;
				if (open == 0.0)
					return;
				this.wYBFLwFB4S(open, singleOrder.OrderQty);
			}
		}

		
		private void wYBFLwFB4S(double obj0, double obj1)
		{
			SingleOrder singleOrder = this.PYBF7sahqY as SingleOrder;
			if (singleOrder.OrdType == OrdType.Limit || (singleOrder.OrdType == OrdType.StopLimit || singleOrder.OrdType == OrdType.TrailingStopLimit) && singleOrder.IsStopLimitReady)
			{
				switch (singleOrder.Side)
				{
					case Side.Buy:
					case Side.BuyMinus:
						if (obj0 <= singleOrder.Price)
						{
							if (this.L27FNaAWTp)
							{
								this.D35FmNWSPm(singleOrder.Price, obj1);
								break;
							}
							else
							{
								this.D35FmNWSPm(obj0, obj1);
								break;
							}
						}
						else
							break;
					case Side.Sell:
					case Side.SellShort:
						if (obj0 >= singleOrder.Price)
						{
							if (this.L27FNaAWTp)
							{
								this.D35FmNWSPm(singleOrder.Price, obj1);
								break;
							}
							else
							{
								this.D35FmNWSPm(obj0, obj1);
								break;
							}
						}
						else
							break;
					default:
						throw new NotSupportedException("" + ((object) singleOrder.Side).ToString());
				}
			}
			if (singleOrder.OrdType == OrdType.Stop)
			{
				switch (singleOrder.Side)
				{
					case Side.Buy:
					case Side.BuyMinus:
						if (obj0 >= singleOrder.StopPx)
						{
							if (this.yFOFUpVbqt)
							{
								this.D35FmNWSPm(singleOrder.StopPx, obj1);
								break;
							}
							else
							{
								this.D35FmNWSPm(obj0, obj1);
								break;
							}
						}
						else
							break;
					case Side.Sell:
					case Side.SellShort:
						if (obj0 <= singleOrder.StopPx)
						{
							if (this.yFOFUpVbqt)
							{
								this.D35FmNWSPm(singleOrder.StopPx, obj1);
								break;
							}
							else
							{
								this.D35FmNWSPm(obj0, obj1);
								break;
							}
						}
						else
							break;
					default:
						throw new NotSupportedException(""+ ((object) singleOrder.Side).ToString());
				}
			}
			if (singleOrder.OrdType == OrdType.TrailingStop)
			{
				switch (singleOrder.Side)
				{
					case Side.Buy:
					case Side.BuyMinus:
						this.zGRFvN99ge = Math.Min(this.zGRFvN99ge, obj0 + singleOrder.TrailingAmt);
						if (this.dkuF6t82Gt(obj0, this.zGRFvN99ge, this.j57Fjc16NJ) >= 0)
						{
							Console.WriteLine(string.Concat(new object[4]
								{
									(object) DateTime.Now,
									(object) "",
									(object) singleOrder.Text,
									(object)""
								}));
							singleOrder.IsStopLimitReady = true;
							break;
						}
						else
							break;
					case Side.Sell:
					case Side.SellShort:
						this.zGRFvN99ge = Math.Max(this.zGRFvN99ge, obj0 - singleOrder.TrailingAmt);
						if (this.dkuF6t82Gt(obj0, this.zGRFvN99ge, this.j57Fjc16NJ) <= 0)
						{
							Console.WriteLine(string.Concat(new object[4]
								{
									(object) Clock.Now,
									(object) "",
									(object) singleOrder.Text,
									(object) ""
								}));
							singleOrder.IsStopLimitReady = true;
							break;
						}
						else
							break;
					default:
						throw new NotSupportedException("" + ((object) singleOrder.Side).ToString());
				}
			}
			if (singleOrder.OrdType == OrdType.TrailingStopLimit && !singleOrder.IsStopLimitReady)
			{
				switch (singleOrder.Side)
				{
					case Side.Buy:
					case Side.BuyMinus:
						this.zGRFvN99ge = Math.Min(this.zGRFvN99ge, obj0 + singleOrder.TrailingAmt);
						if (this.dkuF6t82Gt(obj0, this.zGRFvN99ge, this.j57Fjc16NJ) >= 0)
						{
							double num = singleOrder.StopPx - singleOrder.Price;
							singleOrder.StopPx = Math.Round(this.zGRFvN99ge, 6);
							singleOrder.Price = Math.Round(this.zGRFvN99ge - num, 6);
							singleOrder.IsStopLimitReady = true;
							break;
						}
						else
							break;
					case Side.Sell:
					case Side.SellShort:
						this.zGRFvN99ge = Math.Max(this.zGRFvN99ge, obj0 - singleOrder.TrailingAmt);
						if (this.dkuF6t82Gt(obj0, this.zGRFvN99ge, this.j57Fjc16NJ) <= 0)
						{
							double num = singleOrder.StopPx - singleOrder.Price;
							singleOrder.StopPx = Math.Round(this.zGRFvN99ge, 6);
							singleOrder.Price = Math.Round(this.zGRFvN99ge - num, 6);
							singleOrder.IsStopLimitReady = true;
							break;
						}
						else
							break;
					default:
						throw new NotSupportedException("" + ((object) singleOrder.Side).ToString());
				}
			}
			if (singleOrder.OrdType != OrdType.StopLimit || singleOrder.IsStopLimitReady)
				return;
			switch (singleOrder.Side)
			{
				case Side.Buy:
				case Side.BuyMinus:
					if (obj0 < singleOrder.StopPx)
						break;
					singleOrder.IsStopLimitReady = true;
					break;
				case Side.Sell:
				case Side.SellShort:
					if (obj0 > singleOrder.StopPx)
						break;
					singleOrder.IsStopLimitReady = true;
					break;
				default:
					throw new NotSupportedException("" + ((object) singleOrder.Side).ToString());
			}
		}

		
		private int dkuF6t82Gt(double obj0, double obj1, double obj2)
		{
			if (Math.Abs(obj0 - obj1) < obj2)
				return 0;
			else
				return Math.Sign(obj0 - obj1);
		}
	}
}

using OpenQuant.Config;
using OpenQuant.ObjectMap;
using FreeQuant.Execution;
using FreeQuant.FIX;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace OpenQuant.API
{
	public class Order
	{
		private const string CATEGORY_APPEARANCE = "Appearance";
		private const string CATEGORY_EXECUTION = "Execution";
		private const string CATEGORY_STATUS = "Status";
		private const string CATEGORY_EXTENSIONS = "Extensions";
		internal SingleOrder order;
		private Instrument instrument;
		private IBEx ibEx;

		[Category("Appearance")]
		public DateTime DateTime
		{
			get
			{
				return ((FIXNewOrderSingle)this.order).TransactTime;
			}
		}

		[Category("Appearance")]
		public Instrument Instrument
		{
			get
			{
				return this.instrument;
			}
		}

		[Category("Appearance")]
		public OrderSide Side
		{
			get
			{
				switch (((NewOrderSingle)this.order).Side)
				{
					case Side.Buy:
						return OrderSide.Buy;
					case Side.Sell:
						return OrderSide.Sell;
					default:
						throw new NotImplementedException("OrderSide is not supported : " + (object)((NewOrderSingle)this.order).Side);
				}
			}
		}

		[Category("Appearance")]
		public OrderType Type
		{
			get
			{
				switch (((NewOrderSingle)this.order).OrdType)
				{
					case OrdType.Market:
						return OrderType.Market;
					case OrdType.Limit:
						return OrderType.Limit;
					case OrdType.Stop:
						return OrderType.Stop;
					case OrdType.StopLimit:
						return OrderType.StopLimit;
					case OrdType.MarketOnClose:
						return OrderType.MarketOnClose;
					case OrdType.TrailingStop:
						return OrderType.Trail;
					case OrdType.TrailingStopLimit:
						return OrderType.TrailLimit;
					default:
						throw new NotImplementedException("OrderType is not supported : " + (object)((NewOrderSingle)this.order).OrdType);
				}
			}
			set
			{
				switch (value)
				{
					case OrderType.Market:
						((NewOrderSingle)this.order).OrdType = OrdType.Market;
						break;
					case OrderType.Limit:
						((NewOrderSingle)this.order).OrdType = OrdType.Limit;
						break;
					case OrderType.Stop:
						((NewOrderSingle)this.order).OrdType = OrdType.Stop;
						break;
					case OrderType.StopLimit:
						((NewOrderSingle)this.order).OrdType = OrdType.StopLimit;
						break;
					case OrderType.Trail:
						((NewOrderSingle)this.order).OrdType = OrdType.TrailingStop;
						break;
					case OrderType.TrailLimit:
						((NewOrderSingle)this.order).OrdType = OrdType.TrailingStopLimit;
						break;
					case OrderType.MarketOnClose:
						((NewOrderSingle)this.order).OrdType = OrdType.MarketOnClose;
						break;
					default:
						throw new NotImplementedException("OrderType is not supported : " + (object)value);
				}
			}
		}

		[Category("Appearance")]
		public TimeInForce TimeInForce
		{
			get
			{
				switch (((NewOrderSingle)this.order).TimeInForce)
				{
					case FreeQuant.FIX.TimeInForce.Day:
						return TimeInForce.Day;
					case FreeQuant.FIX.TimeInForce.GTC:
						return TimeInForce.GTC;
					case FreeQuant.FIX.TimeInForce.OPG:
						return TimeInForce.OPG;
					case FreeQuant.FIX.TimeInForce.IOC:
						return TimeInForce.IOC;
					case FreeQuant.FIX.TimeInForce.FOK:
						return TimeInForce.FOK;
					case FreeQuant.FIX.TimeInForce.GTX:
						return TimeInForce.GTX;
					case FreeQuant.FIX.TimeInForce.GoodTillDate:
						return TimeInForce.GTD;
					case FreeQuant.FIX.TimeInForce.AtTheClose:
						return TimeInForce.ATC;
					case FreeQuant.FIX.TimeInForce.GoodForSeconds:
						return TimeInForce.GFS;
					default:
						throw new NotImplementedException("TimeInForce is not supported : " + (object)((NewOrderSingle)this.order).TimeInForce);
				}
			}
			set
			{
				switch (value)
				{
					case TimeInForce.Day:
						((NewOrderSingle)this.order).TimeInForce = FreeQuant.FIX.TimeInForce.Day;
						break;
					case TimeInForce.GTC:
						((NewOrderSingle)this.order).TimeInForce = FreeQuant.FIX.TimeInForce.GTC;
						break;
					case TimeInForce.OPG:
						((NewOrderSingle)this.order).TimeInForce = FreeQuant.FIX.TimeInForce.OPG;
						break;
					case TimeInForce.IOC:
						((NewOrderSingle)this.order).TimeInForce = FreeQuant.FIX.TimeInForce.IOC;
						break;
					case TimeInForce.FOK:
						((NewOrderSingle)this.order).TimeInForce = FreeQuant.FIX.TimeInForce.FOK;
						break;
					case TimeInForce.GTX:
						((NewOrderSingle)this.order).TimeInForce = FreeQuant.FIX.TimeInForce.GTX;
						break;
					case TimeInForce.GTD:
						((NewOrderSingle)this.order).TimeInForce = FreeQuant.FIX.TimeInForce.GoodTillDate;
						break;
					case TimeInForce.ATC:
						((NewOrderSingle)this.order).TimeInForce = FreeQuant.FIX.TimeInForce.AtTheClose;
						break;
					case TimeInForce.GFS:
						((NewOrderSingle)this.order).TimeInForce = FreeQuant.FIX.TimeInForce.GoodForSeconds;
						break;
					default:
						throw new NotImplementedException("TimeInForce is not supported : " + (object)value);
				}
			}
		}

		public DateTime ExpireTime
		{
			get
			{
				return ((FIXNewOrderSingle)this.order).ExpireTime;
			}
			set
			{
				((FIXNewOrderSingle)this.order).ExpireTime = value;
			}
		}

		public int ExpireSeconds
		{
			get
			{
				return ((FIXNewOrderSingle)this.order).ExpireSeconds;
			}
			set
			{
				((FIXNewOrderSingle)this.order).ExpireSeconds = value;
			}
		}

		public OrderStatus Status
		{
			get
			{
				return EnumConverter.Convert(this.order.get_OrdStatus());
			}
		}

		[Category("Appearance")]
		public double Qty
		{
			get
			{
				return ((FIXNewOrderSingle)this.order).OrderQty;
			}
			set
			{
				if (!this.order.get_IsSent())
					((FIXNewOrderSingle)this.order).OrderQty = value;
				else
					this.order.get_ReplaceOrder().OrderQty = value;
			}
		}

		[Category("Execution")]
		public double LastQty
		{
			get
			{
				return this.order.get_LastQty();
			}
		}

		[Category("Execution")]
		public double LeavesQty
		{
			get
			{
				return this.order.get_LeavesQty();
			}
		}

		[Category("Execution")]
		public double CumQty
		{
			get
			{
				return this.order.get_CumQty();
			}
		}

		[Category("Appearance")]
		public double Price
		{
			get
			{
				return ((FIXNewOrderSingle)this.order).Price;
			}
			set
			{
				if (!this.order.get_IsSent())
					((FIXNewOrderSingle)this.order).Price = value;
				else
					this.order.get_ReplaceOrder().Price = value;
			}
		}

		[Category("Appearance")]
		public double StopPrice
		{
			get
			{
				return ((FIXNewOrderSingle)this.order).StopPx;
			}
			set
			{
				if (!this.order.get_IsSent())
					((FIXNewOrderSingle)this.order).StopPx = value;
				else
					this.order.get_ReplaceOrder().StopPx = value;
			}
		}

		[Category("Appearance")]
		public double TrailingAmt
		{
			get
			{
				return ((FIXNewOrderSingle)this.order).TrailingAmt;
			}
			set
			{
				if (!this.order.get_IsSent())
					((FIXNewOrderSingle)this.order).TrailingAmt = value;
				else
					this.order.get_ReplaceOrder().TrailingAmt = value;
			}
		}

		[Category("Execution")]
		public double AvgPrice
		{
			get
			{
				return this.order.get_AvgPx();
			}
		}

		[Category("Execution")]
		public double LastPrice
		{
			get
			{
				return this.order.get_LastPx();
			}
		}

		[Category("Appearance")]
		public string Account
		{
			get
			{
				return ((FIXNewOrderSingle)this.order).Account;
			}
			set
			{
				((FIXNewOrderSingle)this.order).Account = value;
			}
		}

		[Category("Appearance")]
		public string ClientID
		{
			get
			{
				return ((FIXGroup)this.order).GetStringValue(109);
			}
			set
			{
				((FIXGroup)this.order).SetStringValue(109, value);
			}
		}

		public string OrderID
		{
			get
			{
				return this.order.get_OrderID();
			}
			set
			{
				this.order.set_OrderID(value);
			}
		}

		public string Text
		{
			get
			{
				return ((FIXNewOrderSingle)this.order).Text;
			}
			set
			{
				((FIXNewOrderSingle)this.order).Text = value;
			}
		}

		[Category("Status")]
		public bool IsNew
		{
			get
			{
				return this.order.get_IsNew();
			}
		}

		[Category("Status")]
		public bool IsPendingNew
		{
			get
			{
				return this.order.get_IsPendingNew();
			}
		}

		[Category("Status")]
		public bool IsFilled
		{
			get
			{
				return this.order.get_IsFilled();
			}
		}

		[Category("Status")]
		public bool IsPartiallyFilled
		{
			get
			{
				return this.order.get_IsPartiallyFilled();
			}
		}

		[Category("Status")]
		public bool IsPendingCancel
		{
			get
			{
				return this.order.get_IsPendingCancel();
			}
		}

		[Category("Status")]
		public bool IsCancelled
		{
			get
			{
				return this.order.get_IsCancelled();
			}
		}

		[Category("Status")]
		public bool IsExpired
		{
			get
			{
				return this.order.get_IsExpired();
			}
		}

		[Category("Status")]
		public bool IsPendingReplace
		{
			get
			{
				return this.order.get_IsPendingReplace();
			}
		}

		[Category("Status")]
		public bool IsRejected
		{
			get
			{
				return this.order.get_IsRejected();
			}
		}

		[Category("Status")]
		public bool IsDone
		{
			get
			{
				return this.order.get_IsDone();
			}
		}

		[Category("Appearance")]
		public string OCAGroup
		{
			get
			{
				return ((FIXNewOrderSingle)this.order).OCAGroup;
			}
			set
			{
				((FIXNewOrderSingle)this.order).OCAGroup = value;
			}
		}

		[Category("Extensions")]
		public IBEx IB
		{
			get
			{
				return this.ibEx;
			}
		}

		public ExecutionReportList ExecutionReports
		{
			get
			{
				List<FIXMessage> messages = new List<FIXMessage>();
				foreach (FIXMessage fixMessage in (FIXGroupList) this.order.get_Reports())
					messages.Add(fixMessage);
				foreach (FIXMessage fixMessage in (FIXGroupList) this.order.get_Rejects())
					messages.Add(fixMessage);
				messages.Sort((Comparison<FIXMessage>)((message1, message2) => message1.GetDateTimeValue(60).CompareTo(message2.GetDateTimeValue(60))));
				return new ExecutionReportList(messages);
			}
		}

		internal Portfolio Portfolio
		{
			get
			{
				return Map.SQ_OQ_Portfolio[(object)this.order.get_Portfolio()] as Portfolio;
			}
			set
			{
				this.order.set_Portfolio(value.portfolio);
				this.order.set_Persistent(value.portfolio.Persistent);
			}
		}

		public bool StrategyFill
		{
			get
			{
				return this.order.get_StrategyFill();
			}
			set
			{
				this.order.set_StrategyFill(value);
			}
		}

		public double StrategyPrice
		{
			get
			{
				return this.order.get_StrategyPrice();
			}
			set
			{
				this.order.set_StrategyPrice(value);
			}
		}

		internal NewOrderSingle ReplaceOrder
		{
			get
			{
				return this.order.get_ReplaceOrder();
			}
		}

		public byte Route
		{
			get
			{
				return (byte)((FIXNewOrderSingle)this.order).Route;
			}
			set
			{
				((FIXNewOrderSingle)this.order).Route = (int)value;
			}
		}

		public int TradeVolumeDelay
		{
			get
			{
				return ((FIXNewOrderSingle)this.order).TradeVolumeDelay;
			}
			set
			{
				((FIXNewOrderSingle)this.order).TradeVolumeDelay = value;
			}
		}

		internal Order(SingleOrder order)
		{
			this.order = order;
			this.instrument = Map.SQ_OQ_Instrument[(object)order.get_Instrument()] as Instrument;
			this.ibEx = new IBEx(order);
			if (order.get_Provider() != null)
				return;
			order.set_Provider(Configuration.Active.ExecutionProvider);
			order.set_StrategyMode(ConfigurationModeConverter.ModeToChar(Configuration.ActiveMode));
		}

		private Order()
		{
		}

		internal static Order CreateWrapper(SingleOrder order)
		{
			return new Order()
			{
				order = order,
				instrument = Map.SQ_OQ_Instrument[(object)order.get_Instrument()] as Instrument,
				ibEx = new IBEx(order)
			};
		}

		public void Send()
		{
			this.order.Send();
		}

		public void Cancel()
		{
			this.order.Cancel();
		}

		public void Replace()
		{
			this.order.Replace();
		}
	}
}

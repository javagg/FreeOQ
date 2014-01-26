using System;
using FreeQuant.Providers;
using FreeQuant.FIX;
using System.ComponentModel;

namespace FreeQuant.FIXApplication
{
	public class QuickFIX44Provider : IMarketDataProvider, IInstrumentProvider, IExecutionProvider
    {
		public event EventHandler StatusChanged;
		public event EventHandler Connected;
		public event EventHandler Disconnected;
		public event ProviderErrorEventHandler Error;
		public event SecurityDefinitionEventHandler SecurityDefinition;
		public event MarketDataRequestRejectEventHandler MarketDataRequestReject;
		public event MarketDataSnapshotEventHandler MarketDataSnapshot;
		public event MarketDataEventHandler NewMarketData;
		public event QuoteEventHandler NewQuote;
		public event TradeEventHandler NewTrade;
		public event BarEventHandler NewBar;
		public event BarEventHandler NewBarOpen;
		public event BarSliceEventHandler NewBarSlice;
		public event BarEventHandler NewMarketBar;
		public event MarketDepthEventHandler NewMarketDepth;
		public event FundamentalEventHandler NewFundamental;
		public event CorporateActionEventHandler NewCorporateAction;
		public event ExecutionReportEventHandler ExecutionReport;
		public event OrderCancelRejectEventHandler OrderCancelReject;

		[Description("FreeQuant unique identificator for this provider")]
		[Category("Information")]
		public virtual byte Id { get { return 5; } }

		[Description("Name of this provider")]
		[Category("Information")]
		public virtual string Name
		{
			get
			{
				return "QuickFIX44Provider";
			}
		}

		[Category("Information")]
		[Description("Description of this provider")]
		public virtual string Title
		{
			get
			{
				return "QuickFIX44Provider";
			}
		}

		[Category("Information")]
		[Description("URL of this provider")]
		public virtual string URL
		{
			get
			{
				return "Invalid URL";
			}
		}

		[Description("True if this provider is connected")]
		[Category("Status")]
		public virtual bool IsConnected { get; private set; }

		[Category("Status")]
		[Description("Current connection status of this provider")]
		public virtual ProviderStatus Status { get; private set; }

		public IBarFactory BarFactory { get; set; }
		public IMarketDataFilter MarketDataFilter { get; set; }

		public QuickFIX44Provider()
        {
        }

		public virtual void Connect()
		{
		}

		public virtual void Connect(int timeout)
		{
		}

		public virtual void Disconnect()
		{
		}

		public virtual void Shutdown()
		{
		}

		public virtual void RegisterOrder(NewOrderSingle order)
		{
		}

		public virtual void SendMarketDataRequest(FIXMarketDataRequest request)
		{
		}

		public virtual void SendSecurityDefinitionRequest(FIXSecurityDefinitionRequest request)
		{
		}

		public virtual void SendNewOrderSingle(NewOrderSingle order)
		{
		}

		public virtual void SendOrderCancelRequest(OrderCancelRequest request)
		{
		}

		public virtual void SendOrderCancelReplaceRequest(OrderCancelReplaceRequest request)
		{
		}

		public virtual void SendOrderStatusRequest(OrderStatusRequest request)
		{
		}

		public virtual BrokerInfo GetBrokerInfo()
		{
			return null;
		}
    }
}


using FreeQuant.Data;
using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.FIXData;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

namespace FreeQuant.Trading
{
	public class ATSStrategy : StrategyBase
	{
		private ATSComponent IR0iPwP5Kr;
		private ATSCrossComponent RaPiDqI6k4;
		private ATSCrossComponent klBiFcxZsD;
		private Dictionary<Instrument, ATSComponent> csNiLdTRqH;

		[Browsable(false)]
		public ATSMetaStrategy ATSMetaStrategy
		{
			get
			{
				return this.MetaStrategyBase as ATSMetaStrategy;
			}
		}
		//    [Editor(typeof (BLYMfxYh84Zjcbkgh5), typeof (UITypeEditor))]
		//    [TypeConverter(typeof (ComponentTypeConverter))]
		[Category("Components")]
		public ATSComponent ATSComponent
		{
			get
			{
				return this.IR0iPwP5Kr;
			}
			set
			{
				if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
					throw new InvalidOperationException();
				if (this.IR0iPwP5Kr != null)
				{
					this.IR0iPwP5Kr.Disconnect();
					this.IR0iPwP5Kr.StrategyBase = (StrategyBase)null;
				}
				this.IR0iPwP5Kr = value;
				if (this.IR0iPwP5Kr != null)
				{
					this.IR0iPwP5Kr.StrategyBase = (StrategyBase)this;
					this.IR0iPwP5Kr.Connect();
				}
				this.EmitComponentChanged(ComponentType.ATSComponent);
			}
		}

		[Category("Components")]
		//    [Editor(typeof (a67ZDE3fQwruwg4iyf), typeof (UITypeEditor))]
//    [TypeConverter(typeof (ComponentTypeConverter))]
    public ATSCrossComponent ATSCrossComponent
		{
			get
			{
				if (this.metaStrategyBase == null || !this.metaStrategyBase.ahdWYv7joQ)
					return this.RaPiDqI6k4;
				else
					return this.klBiFcxZsD;
			}
			set
			{
				if (this.metaStrategyBase != null && (this.metaStrategyBase.ahdWYv7joQ || !this.metaStrategyBase.DesignMode))
					throw new InvalidOperationException();
				if (this.RaPiDqI6k4 != null)
				{
					this.RaPiDqI6k4.Disconnect();
					this.RaPiDqI6k4.StrategyBase = (StrategyBase)null;
				}
				this.RaPiDqI6k4 = value;
				if (this.RaPiDqI6k4 != null)
				{
					this.RaPiDqI6k4.StrategyBase = (StrategyBase)this;
					this.RaPiDqI6k4.Connect();
				}
				this.EmitComponentChanged(ComponentType.ATSCrossComponent);
			}
		}

		public ATSStrategy(string name, string description)
			: base(name, description)
		{
			this.ATSCrossComponent = StrategyComponentManager.GetComponent("componentname", this) as ATSCrossComponent;
			this.ATSComponent = StrategyComponentManager.GetComponent("componentname", this) as ATSComponent;
			this.csNiLdTRqH = new Dictionary<Instrument, ATSComponent>();
			this.componentTypeList.Add(ComponentType.ATSComponent);
			this.componentTypeList.Add(ComponentType.ATSCrossComponent);
		}

		protected override void OnInit()
		{
			this.csNiLdTRqH.Clear();
			this.klBiFcxZsD = Activator.CreateInstance(this.RaPiDqI6k4.GetType()) as ATSCrossComponent;
			this.klBiFcxZsD.StrategyBase = (StrategyBase)this;
			this.SetProxyProperties((object)this.klBiFcxZsD, (object)this.RaPiDqI6k4);
			this.klBiFcxZsD.Init();
			foreach (Instrument instrument in (FIXGroupList) this.marketManager.Instruments)
			{
				this.activeInstruments.Add(instrument);
				ATSComponent atsComponent = Activator.CreateInstance(this.IR0iPwP5Kr.GetType()) as ATSComponent;
				atsComponent.StrategyBase = (StrategyBase)this;
				atsComponent.Instrument = instrument;
				this.SetProxyProperties((object)atsComponent, (object)this.IR0iPwP5Kr);
				atsComponent.Init();
				this.csNiLdTRqH.Add(instrument, atsComponent);
			}
		}

		protected override void OnStrategyStop()
		{
			this.klBiFcxZsD.OnStrategyStop();
			foreach (ComponentBase componentBase in this.csNiLdTRqH.Values)
				componentBase.OnStrategyStop();
		}

		internal void nPMi9oJHY7(ATSStop obj0)
		{
			this.stops.Add((IStop)obj0);
			this.activeStops[obj0.Instrument].Add((StopBase)obj0);
			obj0.StatusChanged += new StopEventHandler(this.HEXihCjKlK);
			this.EmitStopAdded((StopBase)obj0);
		}

		private void HEXihCjKlK(StopEventArgs obj0)
		{
			ATSStop atsStop = obj0.Stop as ATSStop;
			if (atsStop.Status != StopStatus.Active)
				this.activeStops[atsStop.Instrument].Remove((StopBase)atsStop);
			this.W2mi1ZwI9y(atsStop);
			if (atsStop.Status == StopStatus.Executed)
				this.mRciKlvZay(atsStop);
			if (atsStop.Status == StopStatus.Canceled)
				this.ANJiCtH3lb(atsStop);
			this.BSDIytBhT((StopBase)atsStop);
		}

		internal void W2mi1ZwI9y(ATSStop obj0)
		{
			this.klBiFcxZsD.OnStopStatusChanged(obj0);
			this.csNiLdTRqH[obj0.Instrument].OnStopStatusChanged(obj0);
		}

		internal void ANJiCtH3lb(ATSStop obj0)
		{
			this.klBiFcxZsD.OnStopCanceled(obj0);
			this.csNiLdTRqH[obj0.Instrument].OnStopCanceled(obj0);
		}

		internal void mRciKlvZay(ATSStop obj0)
		{
			this.klBiFcxZsD.OnStopExecuted(obj0);
			this.csNiLdTRqH[obj0.Instrument].OnStopExecuted(obj0);
		}

		protected override void OnNewTrade(Instrument instrument, Trade trade)
		{
			foreach (ATSStop atsStop in new ArrayList((ICollection) this.activeStops[instrument]))
			{
				if (atsStop.Connected)
					atsStop.OnNewTrade(trade);
			}
			this.marketManager.OnTrade(instrument, trade);
			this.klBiFcxZsD.OnTrade(instrument, trade);
			this.csNiLdTRqH[instrument].OnTrade(trade);
		}

		protected override void OnNewQuote(Instrument instrument, Quote quote)
		{
			foreach (ATSStop atsStop in new ArrayList((ICollection) this.activeStops[instrument]))
			{
				if (atsStop.Connected)
					atsStop.OnNewQuote(quote);
			}
			this.marketManager.OnQuote(instrument, quote);
			this.klBiFcxZsD.OnQuote(instrument, quote);
			this.csNiLdTRqH[instrument].OnQuote(quote);
		}

		protected override void OnNewMarketDepth(Instrument instrument, MarketDepth marketDepth)
		{
			this.marketManager.OnMarketDepth(instrument, marketDepth);
			this.klBiFcxZsD.OnMarketDepth(instrument, marketDepth);
			this.csNiLdTRqH[instrument].OnMarketDepth(marketDepth);
		}

		protected override void OnNewFundamental(Instrument instrument, Fundamental fundamental)
		{
			this.marketManager.OnFundamental(instrument, fundamental);
			this.klBiFcxZsD.OnFundamental(instrument, fundamental);
			this.csNiLdTRqH[instrument].OnFundamental(fundamental);
		}

		protected override void OnNewCorporateAction(Instrument instrument, CorporateAction corporateAction)
		{
			this.marketManager.OnCorporateAction(instrument, corporateAction);
			this.klBiFcxZsD.OnCorporateAction(instrument, corporateAction);
			this.csNiLdTRqH[instrument].OnCorporateAction(corporateAction);
		}

		protected override void OnNewBarOpen(Instrument instrument, Bar bar)
		{
			foreach (ATSStop atsStop in new ArrayList((ICollection) this.activeStops[instrument]))
			{
				if (atsStop.Connected)
					atsStop.OnNewBarOpen(bar);
			}
			this.marketManager.OnBarOpen(instrument, bar);
			this.klBiFcxZsD.OnBarOpen(instrument, bar);
			this.csNiLdTRqH[instrument].OnBarOpen(bar);
		}

		protected override void OnNewBar(Instrument instrument, Bar bar)
		{
			foreach (ATSStop atsStop in new ArrayList((ICollection) this.activeStops[instrument]))
			{
				if (atsStop.Connected)
					atsStop.OnNewBar(bar);
			}
			this.marketManager.OnBar(instrument, bar);
			this.klBiFcxZsD.OnBar(instrument, bar);
			this.csNiLdTRqH[instrument].OnBar(bar);
		}

		protected override void OnNewBarSlice(long barSize)
		{
			this.marketManager.OnBarSlice(barSize);
			this.klBiFcxZsD.OnBarSlice(barSize);
		}

		protected override void OnProviderConnected(IProvider provider)
		{
			this.marketManager.OnProviderConnected(provider);
			this.klBiFcxZsD.OnProviderConnected(provider);
		}

		protected override void OnProviderDisconnected(IProvider provider)
		{
			this.marketManager.OnProviderDisconnected(provider);
			this.klBiFcxZsD.OnProviderDisconnected(provider);
		}

		protected override void OnProviderError(IProvider provider, int id, int code, string message)
		{
			this.marketManager.OnProviderError(provider, id, code, message);
			this.klBiFcxZsD.OnProviderError(provider, id, code, message);
		}

		protected override void OnPositionOpened(Position position)
		{
			this.klBiFcxZsD.OnPositionOpened(position);
			this.csNiLdTRqH[position.Instrument].OnPositionOpened();
		}

		protected override void OnPositionChanged(Position position)
		{
			this.klBiFcxZsD.OnPositionChanged(position);
			this.csNiLdTRqH[position.Instrument].OnPositionChanged();
		}

		protected override void OnPositionClosed(Position position)
		{
			Instrument instrument = position.Instrument;
			foreach (ATSStop atsStop in new ArrayList((ICollection) this.activeStops[instrument]))
			{
				if (atsStop.Type == StopType.Time && atsStop.Status == StopStatus.Active || atsStop.Connected)
					atsStop.OnPositionClosed(position);
			}
			this.klBiFcxZsD.OnPositionClosed(position);
			this.csNiLdTRqH[instrument].OnPositionClosed();
		}

		protected override void OnPortfolioValueChanged(Position position)
		{
			this.klBiFcxZsD.OnPositionValueChanged(position);
			this.csNiLdTRqH[position.Instrument].OnPositionValueChanged();
		}

		internal void EB2iXBUSFK(SingleOrder order)
		{
			order.Strategy = this.Name;
			order.StrategyComponent = ((object)ComponentType.ATSComponent).ToString();
			this.MetaStrategyBase.cWMWqoTObJ(this, order);
		}

		protected override void OnNewOrder(SingleOrder order)
		{
			this.klBiFcxZsD.OnNewOrder(order);
			this.csNiLdTRqH[order.Instrument].OnNewOrder(order);
		}

		protected override void OnExecutionReport(SingleOrder order, ExecutionReport report)
		{
			this.klBiFcxZsD.OnExecutionReport(order, report);
			this.csNiLdTRqH[order.Instrument].OnExecutionReport(order, report);
		}

		protected override void OnOrderPartiallyFilled(SingleOrder order)
		{
			this.klBiFcxZsD.OnOrderPartiallyFilled(order);
			this.csNiLdTRqH[order.Instrument].OnOrderPartiallyFilled(order);
		}

		protected override void OnOrderStatusChanged(SingleOrder order)
		{
			this.klBiFcxZsD.OnOrderStatusChanged(order);
			this.csNiLdTRqH[order.Instrument].OnOrderStatusChanged(order);
		}

		protected override void OnOrderFilled(SingleOrder order)
		{
			this.klBiFcxZsD.OnOrderFilled(order);
			this.csNiLdTRqH[order.Instrument].OnOrderFilled(order);
		}

		protected override void OnOrderCancelled(SingleOrder order)
		{
			this.klBiFcxZsD.OnOrderCancelled(order);
			this.csNiLdTRqH[order.Instrument].OnOrderCancelled(order);
		}

		protected override void OnOrderRejected(SingleOrder order)
		{
			this.klBiFcxZsD.OnOrderRejected(order);
			this.csNiLdTRqH[order.Instrument].OnOrderRejected(order);
		}

		protected override void OnOrderDone(SingleOrder order)
		{
			this.klBiFcxZsD.OnOrderDone(order);
			this.csNiLdTRqH[order.Instrument].OnOrderDone(order);
		}

		protected override void OnNewClientOrder(SingleOrder order)
		{
			this.klBiFcxZsD.mfbpeU3YGv(order);
		}

		public override void ClosePosition(Instrument instrument, double price, ComponentType component, string text)
		{
		}

		public override IComponentBase GetComponent(ComponentType type)
		{
			switch (type)
			{
				case ComponentType.ATSComponent:
					return (IComponentBase)this.ATSComponent;
				case ComponentType.ATSCrossComponent:
					return (IComponentBase)this.ATSCrossComponent;
				case ComponentType.MarketManager:
					return (IComponentBase)this.MarketManager;
				case ComponentType.ReportManager:
					return (IComponentBase)this.ReportManager;
				default:
					throw new InvalidOperationException();
			}
		}

		public override void SetComponent(ComponentType type, IComponentBase component)
		{
			switch (type)
			{
				case ComponentType.ATSComponent:
					this.ATSComponent = component as ATSComponent;
					break;
				case ComponentType.ATSCrossComponent:
					this.ATSCrossComponent = component as ATSCrossComponent;
					break;
				case ComponentType.MarketManager:
					this.MarketManager = component as MarketManager;
					break;
				case ComponentType.ReportManager:
					this.ReportManager = component as ReportManager;
					break;
				default:
					throw new InvalidOperationException("");
			}
		}
	}
}

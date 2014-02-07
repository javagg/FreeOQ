using FreeQuant;
using FreeQuant.Data;
using FreeQuant.FIX;
using FreeQuant.FIXData;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

namespace FreeQuant.Simulation
{
	public class SimulationDataProvider : ISimulationMarketDataProvider, IMarketDataProvider, IProvider
	{
		private const string nWGyg9yZVO = "Simulator(market data)";
		private const string PROVIDER_NAME = "Simulation data provider";
		private const string CURL = "http://www.FreeQuant.com";
		private const byte PROVIDER_ID = 1;
		private const string CATEGORY_INFORMATION = "Information";
		private const string CATEGORY_STATUS = "Status";
		private IBarFactory barFactory;
		private Hashtable z1tyr7wr0l;
		private Dictionary<long, int> iSFyRrCNfO;
		private SortedList<DateTime, SimpleDataObject> Il6yEpdoR8;

		public IBarFactory BarFactory
		{
			get
			{
				return this.barFactory; 
			}
			set
			{
				if (this.barFactory != null)
				{
					this.barFactory.NewBar -= new BarEventHandler(this.OnNewBar);
					this.barFactory.NewBarOpen -= new BarEventHandler(this.OnNewBarOpen);
					this.barFactory.NewBarSlice -= new BarSliceEventHandler(this.OnNewBarSlice);
				}
				this.barFactory = value;
				if (this.barFactory != null)
				{
					this.barFactory.NewBar += new BarEventHandler(this.OnNewBar);
					this.barFactory.NewBarOpen += new BarEventHandler(this.OnNewBarOpen);
					this.barFactory.NewBarSlice += new BarSliceEventHandler(this.OnNewBarSlice);
				}
			}
		}

		[Browsable(false)]
		public IMarketDataFilter MarketDataFilter { get; set; }

		[Category("Information")]
		public string Name
		{
			get
			{
				return "Name";
			}
		}

		[Category("Information")]
		public string Title
		{
			get
			{
				return "Title";
			}
		}

		[Category("Information")]
		public byte Id
		{
			get
			{
				return PROVIDER_ID;
			}
		}

		[Category("Information")]
		public string URL
		{
			get
			{
				return CURL;
			}
		}

		[Category("Status")]
		public bool IsConnected { get; private set; }

		[Category("Status")]
		public ProviderStatus Status { get; private set; }
		//    [Editor(typeof (sgWeWhHGgY7IAm2Btf), typeof (UITypeEditor))]
		public Simulator Simulator { get; private set; }

		public event MarketDataRequestRejectEventHandler MarketDataRequestReject;
		public event MarketDataEventHandler NewMarketData;
		public event BarEventHandler NewBar;
		public event BarEventHandler NewBarOpen;
		public event BarSliceEventHandler NewBarSlice;
		public event QuoteEventHandler NewQuote;
		public event TradeEventHandler NewTrade;
		public event MarketDepthEventHandler NewMarketDepth;
		public event FundamentalEventHandler NewFundamental;
		public event CorporateActionEventHandler NewCorporateAction;
		public event MarketDataSnapshotEventHandler MarketDataSnapshot;
		public event BarEventHandler NewMarketBar;
		public event EventHandler Connected;
		public event EventHandler Disconnected;
		public event ProviderErrorEventHandler Error;
		public event EventHandler StatusChanged;

		public SimulationDataProvider() : this(PROVIDER_NAME, 100)
		{
		}

		public SimulationDataProvider(string name, int id) : base()
		{
			this.Simulator = new Simulator();
			this.Simulator.Error += (e) =>
			{
				if (this.Error != null)
				{
					this.Error(new ProviderErrorEventArgs(new ProviderError(DateTime.Now, this, -1, -1, e.Exception.ToString())));
				}
			};
			this.Simulator.NewObject += new SeriesObjectEventHandler(this.HandleNewObject);
			this.Simulator.LeaveInterval += (e) =>
			{
				this.iSFyRrCNfO.Clear();
			};
	
			this.IsConnected = false;
			this.Status = ProviderStatus.Unknown;
			this.BarFactory = new BarFactory(false);
			this.z1tyr7wr0l = new Hashtable();
			this.iSFyRrCNfO = new Dictionary<long, int>();
			this.Il6yEpdoR8 = new SortedList<DateTime, SimpleDataObject>();
			ProviderManager.Add(this);
			ProviderManager.MarketDataSimulator = this;
		}

		public void SendMarketDataRequest(FIXMarketDataRequest request)
		{
			bool flag = (int)request.SubscriptionRequestType == 49;
			for (int i = 0; i < request.NoRelatedSym; ++i)
				this.V6Aetvk5jr(InstrumentManager.Instruments[request.GetRelatedSymGroup(i).Symbol], request.GetRelatedSymGroup(i).GetStringValue(10001), flag);
		}

		public void Connect()
		{
			lock (this)
			{
				if (this.IsConnected)
					return;
				this.ChangeStatus(ProviderStatus.Connecting);
				this.IsConnected = true;
				this.ChangeStatus(ProviderStatus.Connected);
				this.EmitConnected();
				this.ChangeStatus(ProviderStatus.LoggingIn);
				this.ChangeStatus(ProviderStatus.LoggedIn);
			}
		}

		public void Connect(int timeout)
		{
			this.Connect();
			ProviderManager.WaitConnected(this, timeout);
		}

		public void Disconnect()
		{
			lock (this)
			{
				if (!this.IsConnected)
					return;
				this.Simulator.Stop();
				this.IsConnected = false;
				this.ChangeStatus(ProviderStatus.Disconnected);
				this.EmitDisconnected();
			}
		}

		public void Shutdown()
		{
			this.Disconnect();
		}

		public override string ToString()
		{
			return this.Name;
		}

		public void AddTrade(Trade trade, Instrument instrument)
		{
			this.Il6yEpdoR8.Add(trade.DateTime, new SimpleDataObject(instrument, trade));
		}

		public void AddQuote(Quote quote, Instrument instrument)
		{
			this.Il6yEpdoR8.Add(quote.DateTime, new SimpleDataObject(instrument, quote));
		}

		private void EmitConnected()
		{
			if (this.Connected != null)
			{
				this.Connected(this, EventArgs.Empty);
			}
		}

		private void EmitDisconnected()
		{
			if (this.Disconnected != null)
			{
				this.Disconnected(this, EventArgs.Empty);
			}
		}

		private void ChangeStatus(ProviderStatus status)
		{
			this.Status = status;
			this.EmitStatusChanged();
		}

		private void EmitStatusChanged()
		{
			if (this.StatusChanged != null)
			{
				this.StatusChanged(this, EventArgs.Empty);
			}
		}

		// TODO: read
		private void HandleNewObject(SeriesObjectEventArgs e)
		{
//			if (e.Object is SimpleDataObject)
//			{
//				SimpleDataObject dataObject = e.Object as SimpleDataObject;
//				if (dataObject.DataType == 0)
//				{
//					// ISSUE: reference to a compiler-generated method
//					this.EmitNewTrade(dataObject.Instrument, dataObject.VahFT29LTg());
//				}
//				else
//				{
//					// ISSUE: reference to a compiler-generated method
//					this.EmitNewQuote(dataObject.Instrument, dataObject.YcmFObcjsv());
//				}
//			}
//			else
//			{
//				Instrument instrument = this.z1tyr7wr0l[e.Series] as Instrument ?? InstrumentManager.Instruments[e.Series.Name.Substring(0, e.Series.Name.IndexOf('.'))];
//				IDataObject @object = e.Object;
//				if (@object is Bar)
//				{
//					Bar bar = @object as Bar;
//					if (bar.IsComplete)
//					{
//						if (this.MarketDataFilter != null)
//							bar = this.MarketDataFilter.FilterBar(bar, instrument.Symbol);
//						if (bar == null)
//							return;
//						this.EmitNewBar(instrument, bar);
//						if (bar.BarType != BarType.Time)
//							return;
//						Dictionary<long, int> dictionary;
//						long size;
//						(dictionary = this.iSFyRrCNfO)[size = bar.Size] = dictionary[size] - 1;
//						if (this.iSFyRrCNfO[bar.Size] != 0)
//							return;
//						this.EmitNewBarSlice(bar.Size);
//					}
//					else
//					{
//						if (this.MarketDataFilter != null)
//							bar = this.MarketDataFilter.FilterBarOpen(bar, instrument.Symbol);
//						if (bar == null)
//							return;
//						this.EmitNewBarOpen(instrument, bar);
//						if (bar.BarType != BarType.Time)
//							return;
//						if (!this.iSFyRrCNfO.ContainsKey(bar.Size))
//							this.iSFyRrCNfO[bar.Size] = 0;
//						Dictionary<long, int> dictionary;
//						long size;
//						(dictionary = this.iSFyRrCNfO)[size = bar.Size] = dictionary[size] + 1;
//					}
//				}
//				else if (@object is Trade)
//				{
//					Trade trade = @object as Trade;
//					if (this.MarketDataFilter != null)
//						trade = this.MarketDataFilter.FilterTrade(@object as Trade, instrument.Symbol);
//					if (trade == null)
//						return;
//					this.EmitNewTrade(instrument, trade);
//				}
//				else if (@object is Quote)
//				{
//					Quote quote = @object as Quote;
//					if (this.MarketDataFilter != null)
//						quote = this.MarketDataFilter.FilterQuote(@object as Quote, instrument.Symbol);
//					if (quote == null)
//						return;
//					this.EmitNewQuote(instrument, quote);
//				}
//				else if (@object is MarketDepth)
//					this.HiaeqOcUjh(instrument, @object as MarketDepth);
//				else if (@object is Fundamental)
//				{
//					this.YejeMsdynK(instrument, @object as Fundamental);
//				}
//				else
//				{
//					if (!(@object is CorporateAction))
//						return;
//					this.NQyesH3ccX(instrument, @object as CorporateAction);
//				}
//			}
		}

		private void EmitNewBarSlice(long barSize)
		{
			if (this.NewBarSlice != null)
			{
				this.NewBarSlice(this, new BarSliceEventArgs(barSize, this));
			}
		}

		private void EmitNewBar(IFIXInstrument instrument, Bar bar)
		{
			if (this.NewBar != null)
			{
				this.NewBar(this, new BarEventArgs(bar, instrument, this));
			}
		}

		private void EmitNewBarOpen(IFIXInstrument instrument, Bar bar)
		{
			if (this.NewBarOpen != null)
			{
				this.NewBarOpen(this, new BarEventArgs(bar, instrument, this));
			}
		}

		private void EmitNewTrade(IFIXInstrument instrument, Trade trade)
		{
			if (this.NewTrade != null)
			{
				this.NewTrade(this, new TradeEventArgs(trade, instrument, this));
			}
			if (this.barFactory != null)
			{
				this.barFactory.OnNewTrade(instrument, trade);
			}
		}

		private void EmitNewQuote(IFIXInstrument instrument, Quote quote)
		{
			if (this.NewQuote != null)
			{
				this.NewQuote(this, new QuoteEventArgs(quote, instrument, this));
			}
			if (this.barFactory != null)
			{
				this.barFactory.OnNewQuote(instrument, quote);
			}
		}

		private void HiaeqOcUjh(IFIXInstrument instrument, MarketDepth md)
		{
			if (this.NewMarketDepth != null)
			{
				this.NewMarketDepth(this, new MarketDepthEventArgs(md, instrument, this));
			}
		}

		private void YejeMsdynK(IFIXInstrument instrument, Fundamental fundamental)
		{
			if (this.NewFundamental != null)
			{
				this.NewFundamental(this, new FundamentalEventArgs(fundamental, instrument, this));
			}
		}

		private void NQyesH3ccX(IFIXInstrument instrument, CorporateAction action)
		{
			if (this.NewCorporateAction != null)
			{
				this.NewCorporateAction(this, new CorporateActionEventArgs(action, instrument, this));
			}
		}

		// TODO: read
		private void V6Aetvk5jr(Instrument instrument, string obj1, bool obj2)
		{
			DataSeriesList dataSeries = instrument.GetDataSeries();
//			Regex regex = new Regex(obj1);
			foreach (IDataSeries series in dataSeries)
			{
				if (series.Name.Substring(instrument.Symbol.Length + 1) == obj1)
				{
					if (obj2)
					{
						if (!this.Simulator.InputSeries.Contains(series))
						{
							this.Simulator.InputSeries.Add(series);
							if (!this.z1tyr7wr0l.Contains(series))
								this.z1tyr7wr0l.Add(series, instrument);
						}
					}
					else
					{
						this.Simulator.InputSeries.Remove(series);
						this.z1tyr7wr0l.Remove(series);
					}
				}
			}
		}

		private void OnNewBar(object sender, BarEventArgs e)
		{
			if (this.NewBar != null)
			{
				this.NewBar(this, new BarEventArgs(e.Bar, e.Instrument, this));
			}
		}

		private void OnNewBarOpen(object sender, BarEventArgs e)
		{
			if (this.NewBarOpen != null)
			{
				this.NewBarOpen(this, new BarEventArgs(e.Bar, e.Instrument, this));
			}
		}

		private void OnNewBarSlice(object sender, BarSliceEventArgs e)
		{
			if (this.NewBarSlice != null)
			{
				this.NewBarSlice(this, new BarSliceEventArgs(e.BarSize, this));
			}
		}

		public void EmitTrade(IFIXInstrument instrument, Trade trade)
		{
			this.Simulator.nNp9oHTwk(new SimpleDataObject(instrument, trade));
		}

		public void EmitQuote(IFIXInstrument instrument, Quote quote)
		{
			this.Simulator.nNp9oHTwk(new SimpleDataObject(instrument, quote));
		}
	}
}

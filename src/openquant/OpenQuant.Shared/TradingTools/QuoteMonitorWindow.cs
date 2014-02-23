using OpenQuant.Shared;
using OpenQuant.Shared.Properties;
using FreeQuant.Charting;
using FreeQuant.Data;
using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Shared.TradingTools
{
    public partial class QuoteMonitorWindow : FreeQuant.Docking.WinForms.DockControl, ITimerItem
    {
        private IMarketDataProvider marketDataProvider;
        private IExecutionProvider executionProvider;
        private Portfolio portfolio;
        private InstrumentPad instrumentPad;
        private HashSet<Instrument> instruments;
        private Dictionary<IFIXInstrument, QuoteViewRow> quoteRows;
        private Dictionary<IFIXInstrument, BarViewRow> barRows;
        private MarketDataEventQueue eventQueue;
        private ManualResetEvent eventQueueWaitHandle;
        private object lockObject;
        private bool sendOrdersEnabled;

        public bool SendOrdersEnabled
        {
            get
            {
                return this.sendOrdersEnabled;
            }
            set
            {
                this.sendOrdersEnabled = value;
                this.ctxQuotes_Trade.Visible = value;
                this.tssQuotes_Trade.Visible = value;
            }
        }

        private byte SelectedRoute
        {
            get
            {
                return this.Settings.GetByteValue("SelectedRoute", ((IProvider)ProviderManager.ExecutionSimulator).Id);
            }
            set
            {
                this.Settings.SetValue("SelectedRoute", value);
            }
        }

        [Browsable(false)]
        public virtual double Interval
        {
            get
            {
                return 1000.0;
            }
        }

        [Browsable(false)]
        public ISynchronizeInvoke SynchronizingObject
        {
            get
            {
                return (ISynchronizeInvoke)this;
            }
        }

        public QuoteMonitorWindow()
        {
            this.InitializeComponent();
            this.instruments = new HashSet<Instrument>();
            this.quoteRows = new Dictionary<IFIXInstrument, QuoteViewRow>();
            this.barRows = new Dictionary<IFIXInstrument, BarViewRow>();
            this.eventQueue = new MarketDataEventQueue();
            this.eventQueueWaitHandle = new ManualResetEvent(false);
            this.lockObject = new object();
            this.AllowDrop = true;
            this.chart.Pads[0].MarginRight = 27;
            this.chart.Pads[0].MarginBottom = 0;
            this.chart.Pads[0].XGridDashStyle = DashStyle.Dot;
            this.chart.Pads[0].YGridDashStyle = DashStyle.Dot;
            this.chart.Pads[0].XAxisType = EAxisType.DateTime;
            this.chart.Pads[0].XAxisTitleEnabled = false;
            this.chart.Pads[0].XAxisLabelEnabled = false;
            this.chart.Pads[0].YAxisTitleEnabled = false;
            this.chart.Pads[0].YAxisLabelEnabled = false;
            this.chart.Pads[0].LegendEnabled = false;
            this.chart.Pads[0].LegendPosition = ELegendPosition.TopLeft;
            this.chart.Pads[0].LegendBackColor = Color.White;
            this.chart.Pads[0].BorderEnabled = false;
            this.chart.Pads[0].BackColor = Color.FromKnownColor(KnownColor.Control);
            this.chart.Pads[0].AxisBottom.Type = EAxisType.DateTime;
            this.chart.Pads[0].AxisBottom.Zoomed = true;
            this.chart.Pads[0].AxisBottom.GridDashStyle = DashStyle.Dot;
            this.chart.Pads[0].AxisBottom.TitleEnabled = true;
            this.chart.Pads[0].AxisBottom.LabelEnabled = true;
            this.chart.Pads[0].AxisTop.Zoomed = true;
            this.chart.Pads[0].AxisLeft.Zoomed = true;
            this.chart.Pads[0].AxisLeft.GridDashStyle = DashStyle.Dot;
            this.chart.Pads[0].AxisLeft.TitleEnabled = false;
            this.chart.Pads[0].AxisLeft.LabelEnabled = false;
            this.chart.Pads[0].AxisRight.Zoomed = true;
            this.chart.Pads[0].AxisRight.LabelEnabled = true;
            this.chart.Pads[0].AxisRight.LabelFormat = "F2";
            this.chart.Pads[0].Title.Text = "Double click on symbol to view the chart";
            this.instrumentPad = new InstrumentPad(this.chart.Pads[0]);
            this.instrumentPad.Instrument = (Instrument)null;
            this.SendOrdersEnabled = false;
        }

        protected void Init(IMarketDataProvider marketDataProvider, IExecutionProvider executionProvider, Portfolio portfolio, bool asyncEventProcessing)
        {
            this.marketDataProvider = marketDataProvider;
            this.executionProvider = executionProvider;
            this.portfolio = portfolio;
            this.eventQueue.Enabled = asyncEventProcessing;
        }

        protected override void OnInit()
        {
            new Thread(new ThreadStart(this.RunQueue))
            {
                Name = "QuoteMonitor",
                IsBackground = true
            }.Start();
            Global.TimerManager.Start((ITimerItem)this);
        }

        protected override void OnClosing(DockControlClosingEventArgs e)
        {
            this.instrumentPad.Instrument = (Instrument)null;
            this.RemoveInstruments(new List<Instrument>((IEnumerable<Instrument>)this.instruments).ToArray());
            this.eventQueueWaitHandle.Reset();
            this.eventQueue.Enqueue((MarketDataUpdateItem)null);
            this.eventQueueWaitHandle.WaitOne();
            Global.TimerManager.Stop((ITimerItem)this);
            base.OnClosing(e);
        }

        private void AddInstruments(Instrument[] array)
        {
            List<Instrument> list = new List<Instrument>();
            foreach (Instrument instrument1 in array)
            {
                bool flag = false;
                lock (this.lockObject)
                {
                    if (this.instruments.Add(instrument1))
                    {
                        QuoteViewRow local_3 = new QuoteViewRow(instrument1);
                        this.dgvQuotes.Rows.Add((DataGridViewRow)local_3);
                        local_3.Height = this.dgvQuotes.RowTemplate.Height;
                        local_3.ContextMenuStrip = this.dgvQuotes.RowTemplate.ContextMenuStrip;
                        this.quoteRows.Add((IFIXInstrument)instrument1, local_3);
                        BarViewRow local_4 = new BarViewRow(instrument1);
                        this.dgvBars.Rows.Add((DataGridViewRow)local_4);
                        local_4.Height = this.dgvBars.RowTemplate.Height;
                        this.barRows.Add((IFIXInstrument)instrument1, local_4);
                        flag = true;
                    }
                }
                if (flag)
                {
                    list.Add(instrument1);
                    Instrument instrument2 = instrument1;
//          QuoteMonitorWindow quoteMonitorWindow1 = this;
//          // ISSUE: virtual method pointer
//          IntPtr num1 = __vmethodptr(quoteMonitorWindow1, OnNewQuote);
//          QuoteEventHandler quoteEventHandler = new QuoteEventHandler(quoteMonitorWindow1, num1);
//		  instrument2.NewQuote += quoteEventHandler;
                    instrument2.NewQuote += new QuoteEventHandler(this.OnNewQuote);
                    Instrument instrument3 = instrument1;
//          QuoteMonitorWindow quoteMonitorWindow2 = this;
//          // ISSUE: virtual method pointer
//          IntPtr num2 = __vmethodptr(quoteMonitorWindow2, OnNewTrade);
//          TradeEventHandler tradeEventHandler = new TradeEventHandler(quoteMonitorWindow2, num2);
                    instrument3.NewTrade += new TradeEventHandler(this.OnNewTrade);
                    Instrument instrument4 = instrument1;
//          QuoteMonitorWindow quoteMonitorWindow3 = this;
//          // ISSUE: virtual method pointer
//          IntPtr num3 = __vmethodptr(quoteMonitorWindow3, OnNewBar);
//          BarEventHandler barEventHandler = new BarEventHandler(quoteMonitorWindow3, num3);
//		
                    instrument4.NewBar += new BarEventHandler(this.OnNewBar);
                }
            }
            if ((int)((IProvider)this.marketDataProvider).Id == 1)
                return;
            ThreadPool.QueueUserWorkItem((WaitCallback)(obj =>
            {
                using (IEnumerator<Instrument> resource_0 = ((IEnumerable<Instrument>)obj).GetEnumerator())
                {
                    while (((IEnumerator)resource_0).MoveNext())
                        Global.ProviderHelper.RequestMarketData(this.marketDataProvider, resource_0.Current, (MarketDataType)3);
                }
            }), (object)list);
        }

        private void RemoveInstruments(Instrument[] array)
        {
            foreach (Instrument instrument1 in array)
            {
                Instrument instrument2 = instrument1;
//        QuoteMonitorWindow quoteMonitorWindow1 = this;
//        // ISSUE: virtual method pointer
//        IntPtr num1 = __vmethodptr(quoteMonitorWindow1, OnNewQuote);
//        QuoteEventHandler quoteEventHandler = new QuoteEventHandler( quoteMonitorWindow1, num1);
//		
                instrument2.NewQuote -= new QuoteEventHandler(this.OnNewQuote);
                Instrument instrument3 = instrument1;
//        QuoteMonitorWindow quoteMonitorWindow2 = this;
//        // ISSUE: virtual method pointer
//        IntPtr num2 = __vmethodptr(quoteMonitorWindow2, OnNewTrade);
//        TradeEventHandler tradeEventHandler = new TradeEventHandler(quoteMonitorWindow2, num2);
                instrument3.NewTrade -= new TradeEventHandler(this.OnNewTrade);
                Instrument instrument4 = instrument1;
//        QuoteMonitorWindow quoteMonitorWindow3 = this;
//        // ISSUE: virtual method pointer
//        IntPtr num3 = __vmethodptr(quoteMonitorWindow3, OnNewBar);
//        BarEventHandler barEventHandler = new BarEventHandler(quoteMonitorWindow3, num3);
                instrument4.NewBar -= new BarEventHandler(this.OnNewBar);
                lock (this.lockObject)
                {
                    this.instruments.Remove(instrument1);
                    QuoteViewRow local_1 = this.quoteRows[(IFIXInstrument)instrument1];
                    this.quoteRows.Remove((IFIXInstrument)instrument1);
                    local_1.Disconnect();
                    this.dgvQuotes.Rows.Remove((DataGridViewRow)local_1);
                    BarViewRow local_2 = this.barRows[(IFIXInstrument)instrument1];
                    this.barRows.Remove((IFIXInstrument)instrument1);
                    local_2.Disconnect();
                    this.dgvBars.Rows.Remove((DataGridViewRow)local_2);
                }
            }
            if ((int)((IProvider)this.marketDataProvider).Id == 1)
                return;
            ThreadPool.QueueUserWorkItem((WaitCallback)(obj =>
            {
                foreach (Instrument item_1 in (Instrument[]) obj)
                    Global.ProviderHelper.CancelMarketData(this.marketDataProvider, item_1, (MarketDataType)3);
            }), (object)array);
        }

        protected virtual void OnNewQuote(object sender, QuoteEventArgs args)
        {
            if (((IntradayEventArgs)args).Provider != this.marketDataProvider)
                return;
            QuoteViewRow quoteViewRow;
            bool flag;
            lock (this.lockObject)
                flag = this.quoteRows.TryGetValue(((IntradayEventArgs)args).Instrument, out quoteViewRow);
            if (!flag)
                return;
            if (this.eventQueue.Enabled)
                this.eventQueue.Enqueue(new MarketDataUpdateItem((MarketDataViewRow)quoteViewRow, args.Quote, (Trade)null, (Bar)null));
            else
                quoteViewRow.Update(args.Quote, (Trade)null, (Bar)null);
            this.instrumentPad.OnNewQuote(sender, args);
        }

        protected virtual void OnNewTrade(object sender, TradeEventArgs args)
        {
            if (((IntradayEventArgs)args).Provider != this.marketDataProvider)
                return;
            QuoteViewRow quoteViewRow;
            bool flag;
            lock (this.lockObject)
                flag = this.quoteRows.TryGetValue(((IntradayEventArgs)args).Instrument, out quoteViewRow);
            if (!flag)
                return;
            if (this.eventQueue.Enabled)
                this.eventQueue.Enqueue(new MarketDataUpdateItem((MarketDataViewRow)quoteViewRow, null, args.Trade, null));
            else
                quoteViewRow.Update((Quote)null, args.Trade, null);
            this.instrumentPad.OnNewTrade(sender, args);
        }

        protected virtual void OnNewBar(object sender, BarEventArgs args)
        {
            if (((IntradayEventArgs)args).Provider != this.marketDataProvider)
                return;
            BarViewRow barViewRow;
            bool flag;
            lock (this.lockObject)
                flag = this.barRows.TryGetValue(((IntradayEventArgs)args).Instrument, out barViewRow);
            if (!flag)
                return;
            if (this.eventQueue.Enabled)
                this.eventQueue.Enqueue(new MarketDataUpdateItem((MarketDataViewRow)barViewRow, (Quote)null, (Trade)null, args.Bar));
            else
                barViewRow.Update((Quote)null, (Trade)null, args.Bar);
        }

        private void dgvQuotes_DragOver(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(InstrumentList)))
                return;
            e.Effect = DragDropEffects.Move;
        }

        private void dgvQuotes_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(InstrumentList)))
                return;
            if (!((IProvider)this.marketDataProvider).IsConnected)
            {
                if (MessageBox.Show((IWin32Window)this, ((IProvider)this.marketDataProvider).Name + " is not connected. Do you want to connect?", "Connect " + ((IProvider)this.marketDataProvider).Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
                Global.ProviderHelper.Connect((IProvider)this.marketDataProvider);
                if (!((IProvider)this.marketDataProvider).IsConnected)
                {
                    int num = (int)MessageBox.Show((IWin32Window)this, "Unable to connect to " + ((IProvider)this.marketDataProvider).Name, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
            }
            this.AddInstruments((InstrumentList)e.Data.GetData(typeof(InstrumentList)));
        }

        private void dgvQuotes_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgvQuotes.SelectedRows.Count != 1)
                return;
            QuoteViewRow quoteViewRow = this.dgvQuotes.SelectedRows[0] as QuoteViewRow;
            this.chart.Pads[0].Title.Text = ((FIXInstrument)quoteViewRow.Instrument).Symbol;
            this.instrumentPad.Instrument = quoteViewRow.Instrument;
        }

        private void dgvQuotes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;
            DataGridView.HitTestInfo hitTestInfo = this.dgvQuotes.HitTest(e.X, e.Y);
            switch (hitTestInfo.Type)
            {
                case DataGridViewHitTestType.None:
                    this.dgvQuotes.ClearSelection();
                    break;
                case DataGridViewHitTestType.Cell:
                    if (this.dgvQuotes.Rows[hitTestInfo.RowIndex].Selected)
                        break;
                    this.dgvQuotes.ClearSelection();
                    this.dgvQuotes.Rows[hitTestInfo.RowIndex].Selected = true;
                    break;
            }
        }

        private void ctxQuotes_Opening(object sender, CancelEventArgs e)
        {
            switch (this.dgvQuotes.SelectedRows.Count)
            {
                case 0:
                    this.ctxQuotes_Trade.Enabled = false;
                    this.ctxQuotes_OrderBook.Enabled = false;
                    this.ctxQuotes_Remove.Enabled = false;
                    break;
                case 1:
                    this.ctxQuotes_Trade.Enabled = true;
                    this.ctxQuotes_OrderBook.Enabled = true;
                    this.ctxQuotes_Remove.Enabled = true;
                    break;
                default:
                    this.ctxQuotes_Trade.Enabled = false;
                    this.ctxQuotes_OrderBook.Enabled = false;
                    this.ctxQuotes_Remove.Enabled = true;
                    break;
            }
        }

        private void ctxQuotes_Buy_Click(object sender, EventArgs e)
        {
            this.MakeOrder((Side)1, (OrdType)1);
        }

        private void ctxQuotes_Sell_Click(object sender, EventArgs e)
        {
            this.MakeOrder((Side)2, (OrdType)1);
        }

        private void ctxQuotes_BuyLimit_Click(object sender, EventArgs e)
        {
            this.MakeOrder((Side)1, (OrdType)2);
        }

        private void ctxQuotes_SellLimit_Click(object sender, EventArgs e)
        {
            this.MakeOrder((Side)2, (OrdType)2);
        }

        private void ctxQuotes_BuyStop_Click(object sender, EventArgs e)
        {
            this.MakeOrder((Side)1, (OrdType)3);
        }

        private void ctxQuotes_SellStop_Click(object sender, EventArgs e)
        {
            this.MakeOrder((Side)2, (OrdType)3);
        }

        private void ctxQuotes_BuyStopLimit_Click(object sender, EventArgs e)
        {
            this.MakeOrder((Side)1, (OrdType)4);
        }

        private void ctxQuotes_SellStopLimit_Click(object sender, EventArgs e)
        {
            this.MakeOrder((Side)2, (OrdType)4);
        }

        private void MakeOrder(Side side, OrdType ordType)
        {
            Instrument instrument = (this.dgvQuotes.SelectedRows[0] as QuoteViewRow).Instrument;
            byte route = (byte)0;
            if (this.executionProvider is IMultiRouteExecutionProvider)
                route = this.SelectedRoute;
            OrderMiniBlotterForm orderMiniBlotterForm = new OrderMiniBlotterForm();
            orderMiniBlotterForm.Init(instrument, ordType, side, route);
            if (orderMiniBlotterForm.ShowDialog((IWin32Window)this) == DialogResult.OK)
            {
                SingleOrder singleOrder = null;
                switch (ordType)
                {
                    case OrdType.Market:
                        singleOrder = new MarketOrder(this.executionProvider, this.portfolio, instrument, side, (double)orderMiniBlotterForm.Qty);
                        break;
                    case OrdType.Limit:
                        singleOrder = new LimitOrder(this.executionProvider, this.portfolio, instrument, side, (double)orderMiniBlotterForm.Qty, orderMiniBlotterForm.LimitPrice);
                        break;
                    case OrdType.Stop:
                        singleOrder = new StopOrder(this.executionProvider, this.portfolio, instrument, side, (double)orderMiniBlotterForm.Qty, orderMiniBlotterForm.StopPrice);
                        break;
                    case OrdType.StopLimit:
                        singleOrder = new StopLimitOrder(this.executionProvider, this.portfolio, instrument, side, (double)orderMiniBlotterForm.Qty, orderMiniBlotterForm.LimitPrice, orderMiniBlotterForm.StopPrice);
                        break;
                }
                ((NewOrderSingle)singleOrder).TimeInForce = orderMiniBlotterForm.TimeInForce;
                ((FIXNewOrderSingle)singleOrder).Route = (int)orderMiniBlotterForm.Route;
                singleOrder.Persistent = this.portfolio.Persistent;
                if (!((IProvider)this.executionProvider).IsConnected)
                {
                    bool flag = false;
                    if (MessageBox.Show(this, "Cannot send the order, because provider is not connected." + Environment.NewLine + "Do you want to connect to " + ((IProvider)this.executionProvider).Name + "?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        flag = true;
                        ((IProvider)this.executionProvider).Connect(15000);
                    }
                    if (flag && !((IProvider)this.marketDataProvider).IsConnected)
                    {
                        MessageBox.Show(this, "Unable to connect to " + this.marketDataProvider.Name, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                if (((IProvider)this.executionProvider).IsConnected)
                    singleOrder.Send();
                if ((int)orderMiniBlotterForm.Route > 0)
                    this.SelectedRoute = orderMiniBlotterForm.Route;
            }
            orderMiniBlotterForm.Dispose();
        }

        private void ctxQuotes_OrderBook_Click(object sender, EventArgs e)
        {
            Global.DockManager.Open(typeof(OrderBookWindow), (object)new InstrumentProviderKey(((MarketDataViewRow)this.dgvQuotes.SelectedRows[0]).Instrument, (IProvider)this.marketDataProvider));
        }

        private void ctxQuotes_Remove_Click(object sender, EventArgs e)
        {
            bool flag = false;
            List<Instrument> list = new List<Instrument>();
            foreach (QuoteViewRow quoteViewRow in (BaseCollection) this.dgvQuotes.SelectedRows)
            {
                list.Add(quoteViewRow.Instrument);
                if (this.instrumentPad.Instrument == quoteViewRow.Instrument)
                    flag = true;
            }
            if (flag)
            {
                this.chart.Pads[0].Title.Text = "Double click on symbol to view the chart";
                this.instrumentPad.Instrument = (Instrument)null;
            }
            this.RemoveInstruments(list.ToArray());
        }

        private void RunQueue()
        {
            while (true)
            {
                MarketDataUpdateItem marketDataUpdateItem = this.eventQueue.Dequeue();
                if (marketDataUpdateItem != null)
                    marketDataUpdateItem.Row.Update(marketDataUpdateItem.Quote, marketDataUpdateItem.Trade, marketDataUpdateItem.Bar);
                else
                    break;
            }
            this.eventQueueWaitHandle.Set();
        }

        public virtual void OnElapsed()
        {
            this.instrumentPad.UpdatePad();
        }
    }
}

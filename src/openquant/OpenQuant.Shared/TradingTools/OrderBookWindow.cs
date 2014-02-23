using OpenQuant.Shared;
using OpenQuant.Shared.Properties;
using FreeQuant.Data;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FreeQuant.Docking.WinForms;
using TD.SandDock;

namespace OpenQuant.Shared.TradingTools
{
    partial class OrderBookWindow : FreeQuant.Docking.WinForms.DockControl, ITimerItem
  {

    private Instrument instrument;
    private IMarketDataProvider marketDataProvider;

    public double Interval
    {
      get
      {
        return TimeSpan.FromSeconds(1.0).TotalMilliseconds;
      }
    }

    public ISynchronizeInvoke SynchronizingObject
    {
      get
      {
        return (ISynchronizeInvoke) this;
      }
    }

    public OrderBookWindow()
    {
      this.InitializeComponent();
    }

    protected override void OnInit()
    {
      InstrumentProviderKey instrumentProviderKey = (InstrumentProviderKey) this.Key;
      this.instrument = instrumentProviderKey.Instrument;
      this.marketDataProvider = (IMarketDataProvider) instrumentProviderKey.Provider;
      if ((int) ((IProvider) this.marketDataProvider).Id != 1)
        ThreadPool.QueueUserWorkItem((WaitCallback) (state => Global.ProviderHelper.RequestMarketData(this.marketDataProvider, this.instrument, (MarketDataType) 4)));
      Global.TimerManager.Start((ITimerItem) this);
      this.Text = string.Format("Order Book [{0}]", (object) ((FIXInstrument) this.instrument).Symbol);
    }

    protected override void OnClosing(DockControlClosingEventArgs e)
    {
      Global.TimerManager.Stop((ITimerItem) this);
      if ((int) ((IProvider) this.marketDataProvider).Id != 1)
        ThreadPool.QueueUserWorkItem((WaitCallback) (state => Global.ProviderHelper.CancelMarketData(this.marketDataProvider, this.instrument, (MarketDataType) 4)));
      base.OnClosing(e);
    }

    public void OnElapsed()
    {
      if (this.tsbSuspendUpdates.Checked)
        return;
      this.UpdateOrderBook();
    }

    private void UpdateOrderBook()
    {
      List<OrderBookRowData> list = new List<OrderBookRowData>();
      lock (this.instrument.OrderBook.Ask.SyncRoot)
      {
        IEnumerator local_7 = this.instrument.OrderBook.Ask.GetEnumerator();
        try
        {
          while (local_7.MoveNext())
          {
            OrderBookEntry local_1 = (OrderBookEntry) local_7.Current;
            list.Insert(0, new OrderBookRowData(local_1.Price, new int?(), new int?(local_1.Size)));
          }
        }
        finally
        {
          IDisposable local_9 = local_7 as IDisposable;
          if (local_9 != null)
            local_9.Dispose();
        }
      }
      lock (this.instrument.OrderBook.Bid.SyncRoot)
      {
        IEnumerator local_11 = this.instrument.OrderBook.Bid.GetEnumerator();
        try
        {
          while (local_11.MoveNext())
          {
            OrderBookEntry local_2 = (OrderBookEntry) local_11.Current;
            list.Add(new OrderBookRowData(local_2.Price, new int?(local_2.Size), new int?()));
          }
        }
        finally
        {
          IDisposable local_13 = local_11 as IDisposable;
          if (local_13 != null)
            local_13.Dispose();
        }
      }
      this.dgvBook.Columns["colPrice"].DefaultCellStyle.Format = this.instrument.PriceDisplay;
      int scrollingRowIndex = this.dgvBook.FirstDisplayedScrollingRowIndex;
      this.dgvBook.DataSource = (object) list;
      if (scrollingRowIndex < 0 || scrollingRowIndex >= this.dgvBook.Rows.Count)
        return;
      this.dgvBook.FirstDisplayedScrollingRowIndex = scrollingRowIndex;
    }

    private void tsbSuspendUpdates_CheckedChanged(object sender, EventArgs e)
    {
      this.tsbSuspendUpdates.ToolTipText = this.tsbSuspendUpdates.Checked ? "Resume updates" : "Suspend updates";
    }

    private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }
  }
}

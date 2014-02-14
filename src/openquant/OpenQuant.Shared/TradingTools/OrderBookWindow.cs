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
  class OrderBookWindow : FreeQuant.Docking.WinForms.DockControl, ITimerItem
  {
    private IContainer components;
    private DataGridView dgvBook;
    private ToolStrip toolStrip1;
    private DataGridViewTextBoxColumn colBidSize;
    private DataGridViewTextBoxColumn colPrice;
    private DataGridViewTextBoxColumn colAskSize;
    private ToolStripButton tsbSuspendUpdates;
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

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (OrderBookWindow));
      this.dgvBook = new DataGridView();
      this.colBidSize = new DataGridViewTextBoxColumn();
      this.colPrice = new DataGridViewTextBoxColumn();
      this.colAskSize = new DataGridViewTextBoxColumn();
      this.toolStrip1 = new ToolStrip();
      this.tsbSuspendUpdates = new ToolStripButton();
//      this.dgvBook.BeginInit();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      this.dgvBook.AllowUserToAddRows = false;
      this.dgvBook.AllowUserToDeleteRows = false;
      this.dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvBook.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
      this.dgvBook.BackgroundColor = SystemColors.Window;
      this.dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvBook.Columns.AddRange((DataGridViewColumn) this.colBidSize, (DataGridViewColumn) this.colPrice, (DataGridViewColumn) this.colAskSize);
      this.dgvBook.Dock = DockStyle.Fill;
      this.dgvBook.Location = new Point(0, 25);
      this.dgvBook.Name = "dgvBook";
      this.dgvBook.ReadOnly = true;
      this.dgvBook.RowHeadersVisible = false;
      this.dgvBook.RowTemplate.Height = 40;
      this.dgvBook.ScrollBars = ScrollBars.Vertical;
      this.dgvBook.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.dgvBook.Size = new Size(200, 275);
      this.dgvBook.TabIndex = 0;
      this.colBidSize.DataPropertyName = "BidSize";
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle1.BackColor = Color.CornflowerBlue;
      gridViewCellStyle1.ForeColor = Color.Yellow;
      gridViewCellStyle1.Format = "n0";
      gridViewCellStyle1.NullValue = (object) null;
      gridViewCellStyle1.SelectionBackColor = Color.CornflowerBlue;
      gridViewCellStyle1.SelectionForeColor = Color.Yellow;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.False;
      this.colBidSize.DefaultCellStyle = gridViewCellStyle1;
      this.colBidSize.HeaderText = "";
      this.colBidSize.Name = "colBidSize";
      this.colBidSize.ReadOnly = true;
      this.colBidSize.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.colPrice.DataPropertyName = "Price";
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle2.BackColor = Color.Gray;
      gridViewCellStyle2.ForeColor = Color.White;
      gridViewCellStyle2.SelectionBackColor = Color.Gray;
      gridViewCellStyle2.SelectionForeColor = Color.White;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      this.colPrice.DefaultCellStyle = gridViewCellStyle2;
      this.colPrice.HeaderText = "";
      this.colPrice.Name = "colPrice";
      this.colPrice.ReadOnly = true;
      this.colPrice.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.colAskSize.DataPropertyName = "AskSize";
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle3.BackColor = Color.Salmon;
      gridViewCellStyle3.ForeColor = Color.Yellow;
      gridViewCellStyle3.Format = "n0";
      gridViewCellStyle3.SelectionBackColor = Color.Salmon;
      gridViewCellStyle3.SelectionForeColor = Color.Yellow;
      gridViewCellStyle3.WrapMode = DataGridViewTriState.False;
      this.colAskSize.DefaultCellStyle = gridViewCellStyle3;
      this.colAskSize.HeaderText = "";
      this.colAskSize.Name = "colAskSize";
      this.colAskSize.ReadOnly = true;
      this.colAskSize.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.toolStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.tsbSuspendUpdates
      });
      this.toolStrip1.Location = new Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new Size(200, 25);
      this.toolStrip1.TabIndex = 1;
      this.toolStrip1.Text = "toolStrip1";
      this.tsbSuspendUpdates.CheckOnClick = true;
      this.tsbSuspendUpdates.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbSuspendUpdates.Image = (Image) componentResourceManager.GetObject("tsbSuspendUpdates.Image");
      this.tsbSuspendUpdates.ImageTransparentColor = Color.Magenta;
      this.tsbSuspendUpdates.Name = "tsbSuspendUpdates";
      this.tsbSuspendUpdates.Size = new Size(23, 22);
      this.tsbSuspendUpdates.Text = "toolStripButton1";
      this.tsbSuspendUpdates.ToolTipText = "Suspend updates";
      this.tsbSuspendUpdates.CheckedChanged += new EventHandler(this.tsbSuspendUpdates_CheckedChanged);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.dgvBook);
      this.Controls.Add((Control) this.toolStrip1);
      this.FloatingSize = new Size(200, 300);
      this.Name = "OrderBookWindow";
      this.PersistState = false;
      this.ShowFloating = true;
      this.Size = new Size(200, 300);
      this.TabImage = (Image) Resources.orderbook;
      this.Text = "OrderBook";
//      this.dgvBook.EndInit();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
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
  }
}

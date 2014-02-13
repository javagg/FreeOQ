using OpenQuant.Shared;
using OpenQuant.Shared.Properties;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Shared.Data.Import.Realtime
{
  public class DataCaptureWindow : FreeQuant.Docking.WinForms.DockControl, ITimerItem, IBusyWindow
  {
    private EventQueue<Action> queue = new EventQueue<Action>();
    private ManualResetEvent waitHandle = new ManualResetEvent(false);
    private IContainer components;
    private StatusStrip statusStrip;
    private ToolStrip toolStrip1;
    private ToolStripButton tsbStart;
    private ToolStripButton tsbStop;
    private ContextMenuStrip ctxPanel;
    private ToolStripMenuItem ctxPanel_Remove;
    private ToolStripStatusLabel tssStatus;
    private ToolStripStatusLabel tssProviderStatus;
    private ImageList imageList;
    private DataGridView dgvPanel;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column5;
    private DataGridViewTextBoxColumn Column7;
    private DataGridViewTextBoxColumn Column10;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private IMarketDataProvider provider;
    private Hashtable instruments;
    private bool isRunning;
    private DateTime startDateTime;
    private CheckboxToolStripItem cbxTrades;
    private CheckboxToolStripItem cbxQuotes;
    private CheckboxToolStripItem cbxBars;
    private CheckboxToolStripItem cbxMarketDepth;

    public double Interval
    {
      get
      {
        return 1000.0;
      }
    }

    public ISynchronizeInvoke SynchronizingObject
    {
      get
      {
        return (ISynchronizeInvoke) this;
      }
    }

    public bool IsBusy
    {
      get
      {
        return this.isRunning;
      }
    }

    public string BusyWindowMessage
    {
      get
      {
        return this.TabText;
      }
    }

    public DataCaptureWindow()
    {
      this.InitializeComponent();
      this.tssProviderStatus.Alignment = ToolStripItemAlignment.Right;
      this.cbxMarketDepth = new CheckboxToolStripItem();
      this.cbxMarketDepth.CheckBoxText = "MarketDepth";
      this.toolStrip1.Items.Add((ToolStripItem) this.cbxMarketDepth);
      this.cbxBars = new CheckboxToolStripItem();
      this.cbxBars.CheckBoxText = "Bars";
      this.toolStrip1.Items.Add((ToolStripItem) this.cbxBars);
      this.cbxQuotes = new CheckboxToolStripItem();
      this.cbxQuotes.CheckBoxText = "Quotes";
      this.cbxQuotes.Checked = true;
      this.toolStrip1.Items.Add((ToolStripItem) this.cbxQuotes);
      this.cbxTrades = new CheckboxToolStripItem();
      this.cbxTrades.CheckBoxText = "Trades";
      this.cbxTrades.Checked = true;
      this.toolStrip1.Items.Add((ToolStripItem) this.cbxTrades);
      this.instruments = new Hashtable();
      this.isRunning = false;
      new Thread(new ThreadStart(this.RunQueue))
      {
        IsBackground = true
      }.Start();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle6 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle7 = new DataGridViewCellStyle();
      this.statusStrip = new StatusStrip();
      this.tssStatus = new ToolStripStatusLabel();
      this.tssProviderStatus = new ToolStripStatusLabel();
      this.toolStrip1 = new ToolStrip();
      this.tsbStart = new ToolStripButton();
      this.tsbStop = new ToolStripButton();
      this.ctxPanel = new ContextMenuStrip(this.components);
      this.ctxPanel_Remove = new ToolStripMenuItem();
      this.imageList = new ImageList(this.components);
      this.dgvPanel = new DataGridView();
      this.Column1 = new DataGridViewTextBoxColumn();
      this.Column5 = new DataGridViewTextBoxColumn();
      this.Column7 = new DataGridViewTextBoxColumn();
      this.Column10 = new DataGridViewTextBoxColumn();
      this.Column2 = new DataGridViewTextBoxColumn();
      this.Column3 = new DataGridViewTextBoxColumn();
      this.statusStrip.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.ctxPanel.SuspendLayout();
//      this.dgvPanel.BeginInit();
      this.SuspendLayout();
      this.statusStrip.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.tssStatus,
        (ToolStripItem) this.tssProviderStatus
      });
      this.statusStrip.Location = new Point(0, 273);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Size = new Size(530, 22);
      this.statusStrip.TabIndex = 0;
      this.statusStrip.Text = "statusStrip1";
      this.tssStatus.Name = "tssStatus";
      this.tssStatus.Size = new Size(118, 17);
      this.tssStatus.Text = "toolStripStatusLabel1";
      this.tssProviderStatus.Name = "tssProviderStatus";
      this.tssProviderStatus.Size = new Size(397, 17);
      this.tssProviderStatus.Spring = true;
      this.tssProviderStatus.Text = "toolStripStatusLabel1";
      this.tssProviderStatus.TextAlign = ContentAlignment.MiddleRight;
      this.toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
      this.toolStrip1.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.tsbStart,
        (ToolStripItem) this.tsbStop
      });
      this.toolStrip1.Location = new Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new Size(530, 25);
      this.toolStrip1.TabIndex = 1;
      this.toolStrip1.Text = "toolStrip1";
      this.tsbStart.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbStart.Image = (Image) Resources.capture_start;
      this.tsbStart.ImageTransparentColor = Color.Magenta;
      this.tsbStart.Name = "tsbStart";
      this.tsbStart.Size = new Size(23, 22);
      this.tsbStart.Text = "Start Capture";
      this.tsbStart.Click += new EventHandler(this.tsbStart_Click);
      this.tsbStop.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbStop.Enabled = false;
      this.tsbStop.Image = (Image) Resources.capture_stop;
      this.tsbStop.ImageTransparentColor = Color.Magenta;
      this.tsbStop.Name = "tsbStop";
      this.tsbStop.Size = new Size(23, 22);
      this.tsbStop.Text = "Stop Capture";
      this.tsbStop.Click += new EventHandler(this.tsbStop_Click);
      this.ctxPanel.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.ctxPanel_Remove
      });
      this.ctxPanel.Name = "ctxPanel";
      this.ctxPanel.Size = new Size(118, 26);
      this.ctxPanel.Opening += new CancelEventHandler(this.ctxPanel_Opening);
      this.ctxPanel_Remove.Image = (Image) Resources.delete;
      this.ctxPanel_Remove.Name = "ctxPanel_Remove";
      this.ctxPanel_Remove.Size = new Size(117, 22);
      this.ctxPanel_Remove.Text = "Remove";
      this.ctxPanel_Remove.Click += new EventHandler(this.ctxPanel_Remove_Click);
      this.imageList.ColorDepth = ColorDepth.Depth32Bit;
      this.imageList.ImageSize = new Size(16, 16);
      this.imageList.TransparentColor = Color.Transparent;
      this.dgvPanel.AllowDrop = true;
      this.dgvPanel.AllowUserToAddRows = false;
      this.dgvPanel.AllowUserToDeleteRows = false;
      this.dgvPanel.AllowUserToResizeRows = false;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle1.BackColor = SystemColors.Control;
      gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      gridViewCellStyle1.ForeColor = SystemColors.WindowText;
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.False;
      this.dgvPanel.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      this.dgvPanel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPanel.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column5, (DataGridViewColumn) this.Column7, (DataGridViewColumn) this.Column10, (DataGridViewColumn) this.Column2, (DataGridViewColumn) this.Column3);
      this.dgvPanel.ContextMenuStrip = this.ctxPanel;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle2.BackColor = SystemColors.Window;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      gridViewCellStyle2.ForeColor = SystemColors.ControlText;
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      this.dgvPanel.DefaultCellStyle = gridViewCellStyle2;
      this.dgvPanel.Dock = DockStyle.Fill;
      this.dgvPanel.Location = new Point(0, 25);
      this.dgvPanel.Name = "dgvPanel";
      this.dgvPanel.ReadOnly = true;
      this.dgvPanel.RowHeadersVisible = false;
      this.dgvPanel.RowTemplate.Height = 18;
      this.dgvPanel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvPanel.Size = new Size(530, 248);
      this.dgvPanel.TabIndex = 2;
      this.dgvPanel.DragDrop += new DragEventHandler(this.ltvPanel_DragDrop);
      this.dgvPanel.DragOver += new DragEventHandler(this.ltvPanel_DragOver);
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
      this.Column1.DefaultCellStyle = gridViewCellStyle3;
      this.Column1.Frozen = true;
      this.Column1.HeaderText = "Instrument";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      gridViewCellStyle4.Format = "N0";
      gridViewCellStyle4.NullValue = null;
      this.Column5.DefaultCellStyle = gridViewCellStyle4;
      this.Column5.HeaderText = "Trades";
      this.Column5.Name = "Column5";
      this.Column5.ReadOnly = true;
      gridViewCellStyle5.Format = "N0";
      gridViewCellStyle5.NullValue = null;
      this.Column7.DefaultCellStyle = gridViewCellStyle5;
      this.Column7.HeaderText = "Quotes";
      this.Column7.Name = "Column7";
      this.Column7.ReadOnly = true;
      gridViewCellStyle6.Format = "N0";
      gridViewCellStyle6.NullValue = null;
      this.Column10.DefaultCellStyle = gridViewCellStyle6;
      this.Column10.HeaderText = "Bars";
      this.Column10.Name = "Column10";
      this.Column10.ReadOnly = true;
      gridViewCellStyle7.Format = "N0";
      gridViewCellStyle7.NullValue = null;
      this.Column2.DefaultCellStyle = gridViewCellStyle7;
      this.Column2.HeaderText = "Market Depth";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column3.HeaderText = "";
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      this.Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.dgvPanel);
      this.Controls.Add((Control) this.toolStrip1);
      this.Controls.Add((Control) this.statusStrip);
      this.DefaultDockLocation = ContainerDockLocation.Center;
      this.Name = "DataCaptureWindow";
      this.PersistState = false;
      this.Size = new Size(530, 295);
      this.TabImage = (Image) Resources.download;
      this.Text = "DataCaptureWindow";
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ctxPanel.ResumeLayout(false);
//      this.dgvPanel.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void RunQueue()
    {
      while (true)
      {
        Action action = this.queue.Dequeue();
        if (action != null)
          this.Invoke((Delegate) action);
        else
          break;
      }
      this.waitHandle.Set();
    }

    protected override void OnInit()
    {
      this.provider = this.Key as IMarketDataProvider;
		this.provider.Connected += new EventHandler(this.OnConnected);
			this.provider.Disconnected += new EventHandler(this.OnDisconnected);
      // ISSUE: method pointer
			this.provider.NewTrade += new TradeEventHandler(this.OnNewTrade);
      // ISSUE: method pointer
			this.provider.NewQuote += new QuoteEventHandler(this.OnNewQuote);
      // ISSUE: method pointer
			this.provider.NewBar += new BarEventHandler(this.OnNewBar);
      // ISSUE: method pointer
			this.provider.NewMarketDepth += new MarketDepthEventHandler(this.OnNewMarketDepth);
      this.TabText = string.Format("Data Capture [{0}]", this.provider.Name);
      this.UpdateStatusBar();
    }

    protected override void OnClosing(DockControlClosingEventArgs e)
    {
      if (this.isRunning)
      {
        if (MessageBox.Show("Do you want to stop capture realtime data from " + ((IProvider) this.provider).Name + "?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
          this.Stop();
        else
          e.Cancel = true;
      }
      if (e.Cancel)
        return;
      this.waitHandle.Reset();
      this.queue.Enqueue((Action) null);
      this.waitHandle.WaitOne();
			((IProvider) this.provider).Connected -= new EventHandler(this.OnConnected);
			((IProvider) this.provider).Disconnected -= new EventHandler(this.OnDisconnected);
      // ISSUE: method pointer
			this.provider.NewTrade -= new TradeEventHandler(this.OnNewTrade);
      // ISSUE: method pointer
			this.provider.NewQuote -= new QuoteEventHandler(this.OnNewQuote);
      // ISSUE: method pointer
			this.provider.NewBar -= new BarEventHandler(this.OnNewBar);
      // ISSUE: method pointer
			this.provider.NewMarketDepth -= new MarketDepthEventHandler(this.OnNewMarketDepth);
    }

    public void OnElapsed()
    {
      for (int index = 0; index < this.dgvPanel.Rows.Count; ++index)
        (this.dgvPanel.Rows[index] as InstrumentRow).UpdateValues();
    }

    private void cbxTrade_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void cbxQuote_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void cbxBar_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void cbxMarketDepth_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void tsbStart_Click(object sender, EventArgs e)
    {
      this.Start();
    }

    private void tsbStop_Click(object sender, EventArgs e)
    {
      this.Stop();
    }

    private void ltvPanel_DragOver(object sender, DragEventArgs e)
    {
      if (!e.Data.GetDataPresent(typeof (InstrumentList)))
        return;
      e.Effect = DragDropEffects.Move;
    }

    private void ltvPanel_DragDrop(object sender, DragEventArgs e)
    {
      if (!e.Data.GetDataPresent(typeof (InstrumentList)))
        return;
      IEnumerator enumerator = ((FIXGroupList) e.Data.GetData(typeof (InstrumentList))).GetEnumerator();
      try
      {
        while (enumerator.MoveNext())
          this.AddInstrument((Instrument) enumerator.Current);
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        if (disposable != null)
          disposable.Dispose();
      }
    }

    private void Start()
    {
      if (!this.provider.IsConnected)
      {
				if (MessageBox.Show((IWin32Window) this, this.provider.Name + " is not connected. Do you want to connect?", "Connect " + this.provider.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
          return;
        Global.ProviderHelper.Connect((IProvider) this.provider);
        if (!((IProvider) this.provider).IsConnected)
        {
          int num = (int) MessageBox.Show((IWin32Window) this, "Unable to connect to " + this.provider.Name, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          return;
        }
      }
      if (!((IProvider) this.provider).IsConnected)
        return;
      this.RequestMarketData((Instrument[]) new ArrayList(this.instruments.Keys).ToArray(typeof (Instrument)), this.GetMarketDataType());
      this.isRunning = true;
      this.tsbStart.Enabled = false;
      this.tsbStop.Enabled = true;
      this.EnableCapturePanel(false);
      this.startDateTime = DateTime.Now;
      this.UpdateStatusBar();
      Global.TimerManager.Start((ITimerItem) this);
    }

    private void Stop()
    {
			if ( this.provider.IsConnected)
        this.CancelMarketData((Instrument[]) new ArrayList(this.instruments.Keys).ToArray(typeof (Instrument)), this.GetMarketDataType());
      this.isRunning = false;
			if (this.provider.BarFactory != null)
        this.provider.BarFactory.Reset();
      DataManager.Server.Flush();
      this.tsbStart.Enabled = true;
      this.tsbStop.Enabled = false;
      this.EnableCapturePanel(true);
      this.UpdateStatusBar();
      Global.TimerManager.Stop((ITimerItem) this);
    }

    private void AddInstrument(Instrument instrument)
    {
      if (this.instruments.ContainsKey(instrument))
        return;
      InstrumentRow instrumentRow = new InstrumentRow(instrument);
      instrumentRow.Height = this.dgvPanel.RowTemplate.Height;
      instrumentRow.ContextMenuStrip = this.dgvPanel.RowTemplate.ContextMenuStrip;
      this.dgvPanel.Rows.Add((DataGridViewRow) instrumentRow);
      this.instruments.Add(instrument, instrumentRow);
      if (!this.isRunning)
        return;
      this.RequestMarketData(new Instrument[1]
      {
        instrument
      }, this.GetMarketDataType());
    }

    private void RemoveInstrument(Instrument instrument)
    {
      InstrumentRow instrumentRow = this.instruments[instrument] as InstrumentRow;
      if (instrumentRow != null)
        this.dgvPanel.Rows.Remove((DataGridViewRow) instrumentRow);
      this.instruments.Remove(instrument);
      if (!this.isRunning)
        return;
      this.CancelMarketData(new Instrument[1]
      {
        instrument
      }, this.GetMarketDataType());
    }

    private void RequestMarketData(Instrument[] array, MarketDataType mdType)
    {
      ThreadPool.QueueUserWorkItem((WaitCallback) (objects =>
      {
        foreach (Instrument item_0 in (Instrument[]) objects)
          Global.ProviderHelper.RequestMarketData(this.provider, item_0, mdType);
      }), array);
    }

    private void CancelMarketData(Instrument[] array, MarketDataType mdType)
    {
      ThreadPool.QueueUserWorkItem((WaitCallback) (objects =>
      {
        foreach (Instrument item_0 in (Instrument[]) objects)
          Global.ProviderHelper.CancelMarketData(this.provider, item_0, mdType);
      }), array);
    }

    private void UpdateStatusBar()
    {
      if (this.isRunning)
        this.tssStatus.Text = "Running from " + this.startDateTime.ToString();
      else
        this.tssStatus.Text = "Stopped";
			if (this.provider.IsConnected)
        this.tssProviderStatus.Text = "Connected";
      else
        this.tssProviderStatus.Text = "Not connected";
    }

    private void EnableCapturePanel(bool enabled)
    {
      this.cbxTrades.Enabled = enabled;
      this.cbxQuotes.Enabled = enabled;
      this.cbxBars.Enabled = enabled;
      this.cbxMarketDepth.Enabled = enabled;
    }

    private MarketDataType GetMarketDataType()
    {
      MarketDataType marketDataType = (MarketDataType) 0;
      if (this.cbxTrades.Checked)
				marketDataType = (MarketDataType) (int) (byte) (marketDataType | MarketDataType.Trade);
      if (this.cbxQuotes.Checked)
				marketDataType = (MarketDataType) (int) (byte) (marketDataType | MarketDataType.Quote);
      if (this.cbxMarketDepth.Checked)
				marketDataType = (MarketDataType) (int) (byte) (marketDataType | MarketDataType.MarketDepth);
      return marketDataType;
    }

    private void OnConnected(object sender, EventArgs e)
    {
      this.UpdateStatusBar();
      if (this.InvokeRequired)
        this.Invoke((Delegate) new EventHandler(this.OnConnected), sender, e);
      else
        this.UpdateStatusBar();
    }

    private void OnDisconnected(object sender, EventArgs e)
    {
      this.UpdateStatusBar();
      if (this.InvokeRequired)
        this.Invoke((Delegate) new EventHandler(this.OnDisconnected), sender, e);
      else
        this.UpdateStatusBar();
    }

    private void OnNewTrade(object sender, TradeEventArgs args)
    {
      if (!this.isRunning || !this.cbxTrades.Checked)
        return;
      this.queue.Enqueue((Action) (() =>
      {
        Instrument local_0 = ((IntradayEventArgs) args).Instrument as Instrument;
        InstrumentRow local_1 = this.instruments[local_0] as InstrumentRow;
        if (local_1 == null)
          return;
        local_0.Add(args.Trade);
        ++local_1.Trades;
      }));
    }

    private void OnNewQuote(object sender, QuoteEventArgs args)
    {
      if (!this.isRunning || !this.cbxQuotes.Checked)
        return;
      this.queue.Enqueue((Action) (() =>
      {
        Instrument local_0 = ((IntradayEventArgs) args).Instrument as Instrument;
        InstrumentRow local_1 = this.instruments[local_0] as InstrumentRow;
        if (local_1 == null)
          return;
        local_0.Add(args.Quote);
        ++local_1.Quotes;
      }));
    }

    private void OnNewBar(object sender, BarEventArgs args)
    {
      if (!this.isRunning || !this.cbxBars.Checked)
        return;
      this.queue.Enqueue((Action) (() =>
      {
        Instrument local_0 = ((IntradayEventArgs) args).Instrument as Instrument;
        InstrumentRow local_1 = this.instruments[local_0] as InstrumentRow;
        if (local_1 == null)
          return;
        local_0.Add(args.Bar);
        ++local_1.Bars;
      }));
    }

    private void OnNewMarketDepth(object sender, MarketDepthEventArgs args)
    {
      if (!this.isRunning || !this.cbxMarketDepth.Checked)
        return;
      this.queue.Enqueue((Action) (() =>
      {
        Instrument local_0 = ((IntradayEventArgs) args).Instrument as Instrument;
        InstrumentRow local_1 = this.instruments[local_0] as InstrumentRow;
        if (local_1 == null)
          return;
        local_0.Add(args.MarketDepth);
        ++local_1.MarketDepths;
      }));
    }

    private void ctxPanel_Opening(object sender, CancelEventArgs e)
    {
      this.ctxPanel_Remove.Enabled = this.dgvPanel.SelectedRows.Count > 0;
    }

    private void ctxPanel_Remove_Click(object sender, EventArgs e)
    {
      InstrumentList instrumentList = new InstrumentList();
      foreach (InstrumentRow instrumentRow in (BaseCollection) this.dgvPanel.SelectedRows)
        instrumentList.Add(instrumentRow.Instrument);
      if (((FIXGroupList) instrumentList).Count <= 0 || MessageBox.Show("Do you want to remove selected instruments?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      IEnumerator enumerator = ((FIXGroupList) instrumentList).GetEnumerator();
      try
      {
        while (enumerator.MoveNext())
          this.RemoveInstrument((Instrument) enumerator.Current);
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        if (disposable != null)
          disposable.Dispose();
      }
    }
  }
}

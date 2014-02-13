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
//using TD.SandDock;

namespace OpenQuant.Shared.TradingTools
{
  public class QuoteMonitorWindow : FreeQuant.Docking.WinForms.DockControl, ITimerItem
  {
    private IContainer components;
    private ContextMenuStrip ctxQuotes;
    private ToolStripMenuItem ctxQuotes_Trade;
    private ToolStripMenuItem ctxQuotes_Buy;
    private ToolStripMenuItem ctxQuotes_Sell;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem ctxQuotes_BuyLimit;
    private ToolStripMenuItem ctxQuotes_SellLimit;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripMenuItem ctxQuotes_BuyStop;
    private ToolStripMenuItem ctxQuotes_SellStop;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripMenuItem ctxQuotes_BuyStopLimit;
    private ToolStripMenuItem ctxQuotes_SellStopLimit;
    private ToolStripSeparator tssQuotes_Trade;
    private ToolStripMenuItem ctxQuotes_Remove;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private DataGridView dgvBars;
    private Chart chart;
    private DataGridView dgvQuotes;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column4;
    private DataGridViewTextBoxColumn Column5;
    private DataGridViewTextBoxColumn Column6;
    private DataGridViewTextBoxColumn Column7;
    private DataGridViewTextBoxColumn Column8;
    private DataGridViewTextBoxColumn Column9;
    private DataGridViewTextBoxColumn Column10;
    private DataGridViewTextBoxColumn Column11;
    private Splitter splitter1;
    private DataGridViewTextBoxColumn Column12;
    private DataGridViewTextBoxColumn Column13;
    private DataGridViewTextBoxColumn Column14;
    private DataGridViewTextBoxColumn Column15;
    private DataGridViewTextBoxColumn Column16;
    private DataGridViewTextBoxColumn Column17;
    private DataGridViewTextBoxColumn Column18;
    private DataGridViewTextBoxColumn Column19;
    private DataGridViewTextBoxColumn Column21;
    private ToolStripMenuItem ctxQuotes_OrderBook;
    private ToolStripSeparator toolStripSeparator1;
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
				return this.Settings.GetByteValue("SelectedRoute", ((IProvider) ProviderManager.ExecutionSimulator).Id);
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
        return (ISynchronizeInvoke) this;
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
      this.instrumentPad.Instrument = (Instrument) null;
      this.SendOrdersEnabled = false;
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
      DataGridViewCellStyle gridViewCellStyle8 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle9 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle10 = new DataGridViewCellStyle();
      this.ctxQuotes = new ContextMenuStrip(this.components);
      this.ctxQuotes_Trade = new ToolStripMenuItem();
      this.ctxQuotes_Buy = new ToolStripMenuItem();
      this.ctxQuotes_Sell = new ToolStripMenuItem();
      this.toolStripSeparator3 = new ToolStripSeparator();
      this.ctxQuotes_BuyLimit = new ToolStripMenuItem();
      this.ctxQuotes_SellLimit = new ToolStripMenuItem();
      this.toolStripSeparator4 = new ToolStripSeparator();
      this.ctxQuotes_BuyStop = new ToolStripMenuItem();
      this.ctxQuotes_SellStop = new ToolStripMenuItem();
      this.toolStripSeparator5 = new ToolStripSeparator();
      this.ctxQuotes_BuyStopLimit = new ToolStripMenuItem();
      this.ctxQuotes_SellStopLimit = new ToolStripMenuItem();
      this.tssQuotes_Trade = new ToolStripSeparator();
      this.ctxQuotes_OrderBook = new ToolStripMenuItem();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.ctxQuotes_Remove = new ToolStripMenuItem();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.dgvQuotes = new DataGridView();
      this.Column1 = new DataGridViewTextBoxColumn();
      this.Column2 = new DataGridViewTextBoxColumn();
      this.Column3 = new DataGridViewTextBoxColumn();
      this.Column4 = new DataGridViewTextBoxColumn();
      this.Column5 = new DataGridViewTextBoxColumn();
      this.Column6 = new DataGridViewTextBoxColumn();
      this.Column7 = new DataGridViewTextBoxColumn();
      this.Column8 = new DataGridViewTextBoxColumn();
      this.Column9 = new DataGridViewTextBoxColumn();
      this.Column10 = new DataGridViewTextBoxColumn();
      this.Column11 = new DataGridViewTextBoxColumn();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.dgvBars = new DataGridView();
      this.Column12 = new DataGridViewTextBoxColumn();
      this.Column13 = new DataGridViewTextBoxColumn();
      this.Column14 = new DataGridViewTextBoxColumn();
      this.Column15 = new DataGridViewTextBoxColumn();
      this.Column16 = new DataGridViewTextBoxColumn();
      this.Column17 = new DataGridViewTextBoxColumn();
      this.Column18 = new DataGridViewTextBoxColumn();
      this.Column19 = new DataGridViewTextBoxColumn();
      this.Column21 = new DataGridViewTextBoxColumn();
      this.chart = new Chart();
      this.splitter1 = new Splitter();
      this.ctxQuotes.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
//      this.dgvQuotes.BeginInit();
      this.tabPage2.SuspendLayout();
//      this.dgvBars.BeginInit();
      this.SuspendLayout();
      this.ctxQuotes.Items.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.ctxQuotes_Trade,
        (ToolStripItem) this.tssQuotes_Trade,
        (ToolStripItem) this.ctxQuotes_OrderBook,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.ctxQuotes_Remove
      });
      this.ctxQuotes.Name = "ctxQuotes";
      this.ctxQuotes.Size = new Size(163, 82);
      this.ctxQuotes.Opening += new CancelEventHandler(this.ctxQuotes_Opening);
      this.ctxQuotes_Trade.DropDownItems.AddRange(new ToolStripItem[11]
      {
        (ToolStripItem) this.ctxQuotes_Buy,
        (ToolStripItem) this.ctxQuotes_Sell,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.ctxQuotes_BuyLimit,
        (ToolStripItem) this.ctxQuotes_SellLimit,
        (ToolStripItem) this.toolStripSeparator4,
        (ToolStripItem) this.ctxQuotes_BuyStop,
        (ToolStripItem) this.ctxQuotes_SellStop,
        (ToolStripItem) this.toolStripSeparator5,
        (ToolStripItem) this.ctxQuotes_BuyStopLimit,
        (ToolStripItem) this.ctxQuotes_SellStopLimit
      });
      this.ctxQuotes_Trade.Name = "ctxQuotes_Trade";
      this.ctxQuotes_Trade.Size = new Size(162, 22);
      this.ctxQuotes_Trade.Text = "Trade";
      this.ctxQuotes_Buy.Name = "ctxQuotes_Buy";
      this.ctxQuotes_Buy.Size = new Size(151, 22);
      this.ctxQuotes_Buy.Text = "Buy";
      this.ctxQuotes_Buy.Click += new EventHandler(this.ctxQuotes_Buy_Click);
      this.ctxQuotes_Sell.Name = "ctxQuotes_Sell";
      this.ctxQuotes_Sell.Size = new Size(151, 22);
      this.ctxQuotes_Sell.Text = "Sell";
      this.ctxQuotes_Sell.Click += new EventHandler(this.ctxQuotes_Sell_Click);
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new Size(148, 6);
      this.ctxQuotes_BuyLimit.Name = "ctxQuotes_BuyLimit";
      this.ctxQuotes_BuyLimit.Size = new Size(151, 22);
      this.ctxQuotes_BuyLimit.Text = "Buy Limit";
      this.ctxQuotes_BuyLimit.Click += new EventHandler(this.ctxQuotes_BuyLimit_Click);
      this.ctxQuotes_SellLimit.Name = "ctxQuotes_SellLimit";
      this.ctxQuotes_SellLimit.Size = new Size(151, 22);
      this.ctxQuotes_SellLimit.Text = "Sell Limit";
      this.ctxQuotes_SellLimit.Click += new EventHandler(this.ctxQuotes_SellLimit_Click);
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new Size(148, 6);
      this.ctxQuotes_BuyStop.Name = "ctxQuotes_BuyStop";
      this.ctxQuotes_BuyStop.Size = new Size(151, 22);
      this.ctxQuotes_BuyStop.Text = "Buy Stop";
      this.ctxQuotes_BuyStop.Click += new EventHandler(this.ctxQuotes_BuyStop_Click);
      this.ctxQuotes_SellStop.Name = "ctxQuotes_SellStop";
      this.ctxQuotes_SellStop.Size = new Size(151, 22);
      this.ctxQuotes_SellStop.Text = "Sell Stop";
      this.ctxQuotes_SellStop.Click += new EventHandler(this.ctxQuotes_SellStop_Click);
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new Size(148, 6);
      this.ctxQuotes_BuyStopLimit.Name = "ctxQuotes_BuyStopLimit";
      this.ctxQuotes_BuyStopLimit.Size = new Size(151, 22);
      this.ctxQuotes_BuyStopLimit.Text = "Buy Stop Limit";
      this.ctxQuotes_BuyStopLimit.Click += new EventHandler(this.ctxQuotes_BuyStopLimit_Click);
      this.ctxQuotes_SellStopLimit.Name = "ctxQuotes_SellStopLimit";
      this.ctxQuotes_SellStopLimit.Size = new Size(151, 22);
      this.ctxQuotes_SellStopLimit.Text = "Sell Stop Limit";
      this.ctxQuotes_SellStopLimit.Click += new EventHandler(this.ctxQuotes_SellStopLimit_Click);
      this.tssQuotes_Trade.Name = "tssQuotes_Trade";
      this.tssQuotes_Trade.Size = new Size(159, 6);
      this.ctxQuotes_OrderBook.Image = (Image) Resources.orderbook;
      this.ctxQuotes_OrderBook.Name = "ctxQuotes_OrderBook";
      this.ctxQuotes_OrderBook.Size = new Size(162, 22);
      this.ctxQuotes_OrderBook.Text = "View Order Book";
      this.ctxQuotes_OrderBook.Click += new EventHandler(this.ctxQuotes_OrderBook_Click);
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(159, 6);
      this.ctxQuotes_Remove.Image = (Image) Resources.delete;
      this.ctxQuotes_Remove.Name = "ctxQuotes_Remove";
      this.ctxQuotes_Remove.Size = new Size(162, 22);
      this.ctxQuotes_Remove.Text = "Remove";
      this.ctxQuotes_Remove.Click += new EventHandler(this.ctxQuotes_Remove_Click);
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Dock = DockStyle.Fill;
      this.tabControl1.Location = new Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(644, 302);
      this.tabControl1.TabIndex = 32;
      this.tabPage1.Controls.Add((Control) this.dgvQuotes);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(636, 276);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Quote";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.dgvQuotes.AllowDrop = true;
      this.dgvQuotes.AllowUserToAddRows = false;
      this.dgvQuotes.AllowUserToDeleteRows = false;
      this.dgvQuotes.AllowUserToResizeRows = false;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle1.BackColor = SystemColors.Control;
      gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      gridViewCellStyle1.ForeColor = SystemColors.WindowText;
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.False;
      this.dgvQuotes.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      this.dgvQuotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvQuotes.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column2, (DataGridViewColumn) this.Column3, (DataGridViewColumn) this.Column4, (DataGridViewColumn) this.Column5, (DataGridViewColumn) this.Column6, (DataGridViewColumn) this.Column7, (DataGridViewColumn) this.Column8, (DataGridViewColumn) this.Column9, (DataGridViewColumn) this.Column10, (DataGridViewColumn) this.Column11);
      this.dgvQuotes.ContextMenuStrip = this.ctxQuotes;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle2.BackColor = SystemColors.Window;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      gridViewCellStyle2.ForeColor = SystemColors.ControlText;
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      this.dgvQuotes.DefaultCellStyle = gridViewCellStyle2;
      this.dgvQuotes.Dock = DockStyle.Fill;
      this.dgvQuotes.Location = new Point(3, 3);
      this.dgvQuotes.Name = "dgvQuotes";
      this.dgvQuotes.ReadOnly = true;
      this.dgvQuotes.RowHeadersVisible = false;
      this.dgvQuotes.RowTemplate.Height = 18;
      this.dgvQuotes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvQuotes.Size = new Size(630, 270);
      this.dgvQuotes.TabIndex = 2;
      this.dgvQuotes.DragDrop += new DragEventHandler(this.dgvQuotes_DragDrop);
      this.dgvQuotes.DragOver += new DragEventHandler(this.dgvQuotes_DragOver);
      this.dgvQuotes.DoubleClick += new EventHandler(this.dgvQuotes_DoubleClick);
      this.dgvQuotes.MouseDown += new MouseEventHandler(this.dgvQuotes_MouseDown);
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
      this.Column1.DefaultCellStyle = gridViewCellStyle3;
      this.Column1.Frozen = true;
      this.Column1.HeaderText = "Instrument";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column1.Width = 90;
      gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.Column2.DefaultCellStyle = gridViewCellStyle4;
      this.Column2.HeaderText = "Time";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Width = 80;
      this.Column3.HeaderText = "Price";
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      this.Column3.Width = 60;
      this.Column4.HeaderText = "Change";
      this.Column4.Name = "Column4";
      this.Column4.ReadOnly = true;
      this.Column4.Width = 60;
      this.Column5.HeaderText = "Size";
      this.Column5.Name = "Column5";
      this.Column5.ReadOnly = true;
      this.Column5.Width = 60;
      this.Column6.HeaderText = "";
      this.Column6.Name = "Column6";
      this.Column6.ReadOnly = true;
      this.Column6.Resizable = DataGridViewTriState.False;
      this.Column6.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.Column6.Width = 5;
      this.Column7.HeaderText = "Bid Size";
      this.Column7.Name = "Column7";
      this.Column7.ReadOnly = true;
      this.Column7.Width = 60;
      this.Column8.HeaderText = "Bid";
      this.Column8.Name = "Column8";
      this.Column8.ReadOnly = true;
      this.Column8.Width = 60;
      this.Column9.HeaderText = "Ask";
      this.Column9.Name = "Column9";
      this.Column9.ReadOnly = true;
      this.Column9.Width = 60;
      this.Column10.HeaderText = "Ask Size";
      this.Column10.Name = "Column10";
      this.Column10.ReadOnly = true;
      this.Column10.Width = 60;
      this.Column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column11.HeaderText = "";
      this.Column11.Name = "Column11";
      this.Column11.ReadOnly = true;
      this.Column11.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.tabPage2.Controls.Add((Control) this.dgvBars);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(636, 276);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Bar";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.dgvBars.AllowUserToAddRows = false;
      this.dgvBars.AllowUserToDeleteRows = false;
      this.dgvBars.AllowUserToResizeRows = false;
      gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle5.BackColor = SystemColors.Control;
      gridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      gridViewCellStyle5.ForeColor = SystemColors.WindowText;
      gridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle5.WrapMode = DataGridViewTriState.False;
      this.dgvBars.ColumnHeadersDefaultCellStyle = gridViewCellStyle5;
      this.dgvBars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvBars.Columns.AddRange((DataGridViewColumn) this.Column12, (DataGridViewColumn) this.Column13, (DataGridViewColumn) this.Column14, (DataGridViewColumn) this.Column15, (DataGridViewColumn) this.Column16, (DataGridViewColumn) this.Column17, (DataGridViewColumn) this.Column18, (DataGridViewColumn) this.Column19, (DataGridViewColumn) this.Column21);
      gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle6.BackColor = SystemColors.Window;
      gridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      gridViewCellStyle6.ForeColor = SystemColors.ControlText;
      gridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle6.WrapMode = DataGridViewTriState.False;
      this.dgvBars.DefaultCellStyle = gridViewCellStyle6;
      this.dgvBars.Dock = DockStyle.Fill;
      this.dgvBars.Location = new Point(3, 3);
      this.dgvBars.MultiSelect = false;
      this.dgvBars.Name = "dgvBars";
      this.dgvBars.ReadOnly = true;
      this.dgvBars.RowHeadersVisible = false;
      this.dgvBars.RowTemplate.Height = 18;
      this.dgvBars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvBars.Size = new Size(630, 270);
      this.dgvBars.TabIndex = 0;
      gridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
      this.Column12.DefaultCellStyle = gridViewCellStyle7;
      this.Column12.Frozen = true;
      this.Column12.HeaderText = "Instrument";
      this.Column12.Name = "Column12";
      this.Column12.ReadOnly = true;
      gridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
      this.Column13.DefaultCellStyle = gridViewCellStyle8;
      this.Column13.HeaderText = "Interval";
      this.Column13.Name = "Column13";
      this.Column13.ReadOnly = true;
      this.Column13.Width = 120;
      this.Column14.HeaderText = "Open";
      this.Column14.Name = "Column14";
      this.Column14.ReadOnly = true;
      this.Column14.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.Column14.Width = 60;
      this.Column15.HeaderText = "High";
      this.Column15.Name = "Column15";
      this.Column15.ReadOnly = true;
      this.Column15.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.Column15.Width = 60;
      this.Column16.HeaderText = "Low";
      this.Column16.Name = "Column16";
      this.Column16.ReadOnly = true;
      this.Column16.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.Column16.Width = 60;
      this.Column17.HeaderText = "Close";
      this.Column17.Name = "Column17";
      this.Column17.ReadOnly = true;
      this.Column17.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.Column17.Width = 60;
      gridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.Column18.DefaultCellStyle = gridViewCellStyle9;
      this.Column18.HeaderText = "Volume";
      this.Column18.Name = "Column18";
      this.Column18.ReadOnly = true;
      this.Column18.Width = 80;
      gridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.Column19.DefaultCellStyle = gridViewCellStyle10;
      this.Column19.HeaderText = "Bar Size";
      this.Column19.Name = "Column19";
      this.Column19.ReadOnly = true;
      this.Column19.Width = 80;
      this.Column21.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column21.HeaderText = "";
      this.Column21.Name = "Column21";
      this.Column21.ReadOnly = true;
      this.Column21.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.chart.AntiAliasingEnabled = false;
      ((Control) this.chart).Dock = DockStyle.Bottom;
			this.chart.DoubleBufferingEnabled = true;
			this.chart.FileName = null;
			this.chart.GroupLeftMarginEnabled = false;
			this.chart.GroupRightMarginEnabled = false;
			this.chart.GroupZoomEnabled = false;
      ((Control) this.chart).Location = new Point(0, 302);
      ((Control) this.chart).Name = "chart";
			this.chart.PadsForeColor = Color.White;
			this.chart.PrintAlign=EPrintAlign.None;
			this.chart.PrintHeight = 400;
			this.chart.PrintLayout=EPrintLayout.Portrait;
			this.chart.PrintWidth = 600;
			this.chart.PrintX=10;
			this.chart.PrintY = 10;
			this.chart.SessionEnd = TimeSpan.Parse("1.00:00:00");
			this.chart.SessionGridColor = Color.Blue;
			this.chart.SessionGridEnabled = false;
			this.chart.SessionStart = TimeSpan.Parse("00:00:00");
			this.chart.Size = new Size(644, 167);
			this.chart.SmoothingEnabled = false;
			this.chart.TabIndex = 31;
			this.chart.TransformationType = ETransformationType.Empty;
      this.splitter1.Dock = DockStyle.Bottom;
      this.splitter1.Location = new Point(0, 299);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new Size(644, 3);
      this.splitter1.TabIndex = 33;
      this.splitter1.TabStop = false;
      this.AllowDockLeft = false;
      this.AllowDockRight = false;
      this.AllowDrop = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.splitter1);
      this.Controls.Add((Control) this.tabControl1);
      this.Controls.Add((Control) this.chart);
      this.DefaultDockLocation = ContainerDockLocation.Center;
      this.Name = "QuoteMonitorWindow";
      this.PersistState = false;
      this.Size = new Size(644, 469);
      this.TabImage = (Image) Resources.quote_monitor;
      this.Text = "Quote Monitor";
      this.ctxQuotes.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
//      this.dgvQuotes.EndInit();
      this.tabPage2.ResumeLayout(false);
//      this.dgvBars.EndInit();
      this.ResumeLayout(false);
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
      Global.TimerManager.Start((ITimerItem) this);
    }

    protected override void OnClosing(DockControlClosingEventArgs e)
    {
      this.instrumentPad.Instrument = (Instrument) null;
      this.RemoveInstruments(new List<Instrument>((IEnumerable<Instrument>) this.instruments).ToArray());
      this.eventQueueWaitHandle.Reset();
      this.eventQueue.Enqueue((MarketDataUpdateItem) null);
      this.eventQueueWaitHandle.WaitOne();
      Global.TimerManager.Stop((ITimerItem) this);
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
            this.dgvQuotes.Rows.Add((DataGridViewRow) local_3);
            local_3.Height = this.dgvQuotes.RowTemplate.Height;
            local_3.ContextMenuStrip = this.dgvQuotes.RowTemplate.ContextMenuStrip;
            this.quoteRows.Add((IFIXInstrument) instrument1, local_3);
            BarViewRow local_4 = new BarViewRow(instrument1);
            this.dgvBars.Rows.Add((DataGridViewRow) local_4);
            local_4.Height = this.dgvBars.RowTemplate.Height;
            this.barRows.Add((IFIXInstrument) instrument1, local_4);
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
      if ((int) ((IProvider) this.marketDataProvider).Id == 1)
        return;
      ThreadPool.QueueUserWorkItem((WaitCallback) (obj =>
      {
        using (IEnumerator<Instrument> resource_0 = ((IEnumerable<Instrument>) obj).GetEnumerator())
        {
          while (((IEnumerator) resource_0).MoveNext())
            Global.ProviderHelper.RequestMarketData(this.marketDataProvider, resource_0.Current, (MarketDataType) 3);
        }
      }), (object) list);
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
          QuoteViewRow local_1 = this.quoteRows[(IFIXInstrument) instrument1];
          this.quoteRows.Remove((IFIXInstrument) instrument1);
          local_1.Disconnect();
          this.dgvQuotes.Rows.Remove((DataGridViewRow) local_1);
          BarViewRow local_2 = this.barRows[(IFIXInstrument) instrument1];
          this.barRows.Remove((IFIXInstrument) instrument1);
          local_2.Disconnect();
          this.dgvBars.Rows.Remove((DataGridViewRow) local_2);
        }
      }
			if ((int) ((IProvider) this.marketDataProvider).Id == 1)
        return;
      ThreadPool.QueueUserWorkItem((WaitCallback) (obj =>
      {
        foreach (Instrument item_1 in (Instrument[]) obj)
          Global.ProviderHelper.CancelMarketData(this.marketDataProvider, item_1, (MarketDataType) 3);
      }), (object) array);
    }

    protected virtual void OnNewQuote(object sender, QuoteEventArgs args)
    {
      if (((IntradayEventArgs) args).Provider != this.marketDataProvider)
        return;
      QuoteViewRow quoteViewRow;
      bool flag;
      lock (this.lockObject)
        flag = this.quoteRows.TryGetValue(((IntradayEventArgs) args).Instrument, out quoteViewRow);
      if (!flag)
        return;
      if (this.eventQueue.Enabled)
        this.eventQueue.Enqueue(new MarketDataUpdateItem((MarketDataViewRow) quoteViewRow, args.Quote, (Trade) null, (Bar) null));
      else
        quoteViewRow.Update(args.Quote, (Trade) null, (Bar) null);
      this.instrumentPad.OnNewQuote(sender, args);
    }

    protected virtual void OnNewTrade(object sender, TradeEventArgs args)
    {
      if (((IntradayEventArgs) args).Provider != this.marketDataProvider)
        return;
      QuoteViewRow quoteViewRow;
      bool flag;
      lock (this.lockObject)
        flag = this.quoteRows.TryGetValue(((IntradayEventArgs) args).Instrument, out quoteViewRow);
      if (!flag)
        return;
      if (this.eventQueue.Enabled)
				this.eventQueue.Enqueue(new MarketDataUpdateItem((MarketDataViewRow) quoteViewRow, null, args.Trade, null));
      else
        quoteViewRow.Update((Quote) null, args.Trade, null);
      this.instrumentPad.OnNewTrade(sender, args);
    }

    protected virtual void OnNewBar(object sender, BarEventArgs args)
    {
      if (((IntradayEventArgs) args).Provider != this.marketDataProvider)
        return;
      BarViewRow barViewRow;
      bool flag;
      lock (this.lockObject)
        flag = this.barRows.TryGetValue(((IntradayEventArgs) args).Instrument, out barViewRow);
      if (!flag)
        return;
      if (this.eventQueue.Enabled)
        this.eventQueue.Enqueue(new MarketDataUpdateItem((MarketDataViewRow) barViewRow, (Quote) null, (Trade) null, args.Bar));
      else
        barViewRow.Update((Quote) null, (Trade) null, args.Bar);
    }

    private void dgvQuotes_DragOver(object sender, DragEventArgs e)
    {
      if (!e.Data.GetDataPresent(typeof (InstrumentList)))
        return;
      e.Effect = DragDropEffects.Move;
    }

    private void dgvQuotes_DragDrop(object sender, DragEventArgs e)
    {
      if (!e.Data.GetDataPresent(typeof (InstrumentList)))
        return;
      if (!((IProvider) this.marketDataProvider).IsConnected)
      {
				if (MessageBox.Show((IWin32Window) this, ((IProvider) this.marketDataProvider).Name + " is not connected. Do you want to connect?", "Connect " + ((IProvider) this.marketDataProvider).Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
          return;
        Global.ProviderHelper.Connect((IProvider) this.marketDataProvider);
        if (!((IProvider) this.marketDataProvider).IsConnected)
        {
          int num = (int) MessageBox.Show((IWin32Window) this, "Unable to connect to " + ((IProvider) this.marketDataProvider).Name, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
			this.chart.Pads[0].Title.Text = ((FIXInstrument) quoteViewRow.Instrument).Symbol;
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
      this.MakeOrder((Side) 1, (OrdType) 1);
    }

    private void ctxQuotes_Sell_Click(object sender, EventArgs e)
    {
      this.MakeOrder((Side) 2, (OrdType) 1);
    }

    private void ctxQuotes_BuyLimit_Click(object sender, EventArgs e)
    {
      this.MakeOrder((Side) 1, (OrdType) 2);
    }

    private void ctxQuotes_SellLimit_Click(object sender, EventArgs e)
    {
      this.MakeOrder((Side) 2, (OrdType) 2);
    }

    private void ctxQuotes_BuyStop_Click(object sender, EventArgs e)
    {
      this.MakeOrder((Side) 1, (OrdType) 3);
    }

    private void ctxQuotes_SellStop_Click(object sender, EventArgs e)
    {
      this.MakeOrder((Side) 2, (OrdType) 3);
    }

    private void ctxQuotes_BuyStopLimit_Click(object sender, EventArgs e)
    {
      this.MakeOrder((Side) 1, (OrdType) 4);
    }

    private void ctxQuotes_SellStopLimit_Click(object sender, EventArgs e)
    {
      this.MakeOrder((Side) 2, (OrdType) 4);
    }

    private void MakeOrder(Side side, OrdType ordType)
    {
      Instrument instrument = (this.dgvQuotes.SelectedRows[0] as QuoteViewRow).Instrument;
      byte route = (byte) 0;
      if (this.executionProvider is IMultiRouteExecutionProvider)
        route = this.SelectedRoute;
      OrderMiniBlotterForm orderMiniBlotterForm = new OrderMiniBlotterForm();
      orderMiniBlotterForm.Init(instrument, ordType, side, route);
      if (orderMiniBlotterForm.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        SingleOrder singleOrder = null;
        switch (ordType)
        {
					case OrdType.Market:
            singleOrder = new MarketOrder(this.executionProvider, this.portfolio, instrument, side, (double) orderMiniBlotterForm.Qty);
            break;
					case OrdType.Limit:
            singleOrder =  new LimitOrder(this.executionProvider, this.portfolio, instrument, side, (double) orderMiniBlotterForm.Qty, orderMiniBlotterForm.LimitPrice);
            break;
					case OrdType.Stop:
            singleOrder =  new StopOrder(this.executionProvider, this.portfolio, instrument, side, (double) orderMiniBlotterForm.Qty, orderMiniBlotterForm.StopPrice);
            break;
					case OrdType.StopLimit:
            singleOrder =  new StopLimitOrder(this.executionProvider, this.portfolio, instrument, side, (double) orderMiniBlotterForm.Qty, orderMiniBlotterForm.LimitPrice, orderMiniBlotterForm.StopPrice);
            break;
        }
				((NewOrderSingle) singleOrder).TimeInForce = orderMiniBlotterForm.TimeInForce;
				((FIXNewOrderSingle)singleOrder).Route = (int)orderMiniBlotterForm.Route;
				singleOrder.Persistent = this.portfolio.Persistent;
        if (!((IProvider) this.executionProvider).IsConnected)
        {
          bool flag = false;
          if (MessageBox.Show(this, "Cannot send the order, because provider is not connected." + Environment.NewLine + "Do you want to connect to " + ((IProvider) this.executionProvider).Name + "?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
          {
            flag = true;
            ((IProvider) this.executionProvider).Connect(15000);
          }
          if (flag && !((IProvider) this.marketDataProvider).IsConnected)
          {
             MessageBox.Show(this, "Unable to connect to " + this.marketDataProvider.Name, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
        }
        if (((IProvider) this.executionProvider).IsConnected)
          singleOrder.Send();
        if ((int) orderMiniBlotterForm.Route > 0)
          this.SelectedRoute = orderMiniBlotterForm.Route;
      }
      orderMiniBlotterForm.Dispose();
    }

    private void ctxQuotes_OrderBook_Click(object sender, EventArgs e)
    {
      Global.DockManager.Open(typeof (OrderBookWindow), (object) new InstrumentProviderKey(((MarketDataViewRow) this.dgvQuotes.SelectedRows[0]).Instrument, (IProvider) this.marketDataProvider));
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
        this.instrumentPad.Instrument = (Instrument) null;
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

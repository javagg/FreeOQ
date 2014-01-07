// Type: OpenQuant.Projects.UI.ResultsWindow
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Config;
using OpenQuant.Projects;
using OpenQuant.Projects.UI.Tester;
using OpenQuant.Properties;
using OpenQuant.Shared;
using OpenQuant.Shared.Charting;
using OpenQuant.Shared.Instruments;
using OpenQuant.Trading;
using SmartQuant.Docking.WinForms;
using SmartQuant.ExcelLib;
using SmartQuant.FinChart;
using SmartQuant.Instruments;
using SmartQuant.Series;
using SmartQuant.Testing;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Projects.UI
{
  public class ResultsWindow : DockControl, IInstrumentListSource, IChartControl
  {
    private IContainer components;
    private Panel panel2;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private Chart chart;
    private ToolTip toolTip1;
    private ImageList imageList1;
    private TabPage tabPage2;
    private Splitter splitter1;
    private Panel panel1;
    private Button btnPrevInstrument;
    private Button btnNextInstrument;
    private Button btnPrevTransaction;
    private Button btnNextTransaction;
    private CheckBox chbxBindToChart;
    private TabControl tabControl2;
    private TabPage tabPage3;
    private ListView ltvTransactions;
    private ColumnHeader columnHeader8;
    private ColumnHeader columnHeader9;
    private ColumnHeader columnHeader10;
    private ColumnHeader columnHeader11;
    private ColumnHeader columnHeader12;
    private ColumnHeader columnHeader5;
    private ColumnHeader columnHeader15;
    private ColumnHeader columnHeader36;
    private ColumnHeader columnHeader16;
    private ColumnHeader columnHeader14;
    private ListView ltvSummary1;
    private ColumnHeader columnHeader37;
    private ColumnHeader columnHeader38;
    private ListView ltvSummary2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private LinkLabel lblExport;
    private TabPage tabPage4;
    private TesterPanel testerPanel1;
    private Label waitLabel;
    private IInstrumentSource strategyRunner;
    private Portfolio currentPortfolio;
    private Instrument seriesInstrument;
    private Instrument currentInstrument;
    private InstrumentListSource instrumentListSource;
    private BarSeries selectedSeries;

    public InstrumentListSource InstrumentListSource
    {
      get
      {
        return this.instrumentListSource;
      }
    }

    public Chart ChartControl
    {
      get
      {
        return this.chart;
      }
    }

    public ResultsWindow()
    {
      base.\u002Ector();
      this.InitializeComponent();
      ListViewSorter listViewSorter = new ListViewSorter(this.ltvTransactions);
      this.waitLabel = new Label();
      this.waitLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.waitLabel.Size = new Size(200, 40);
      this.waitLabel.Left = ((Control) this).Width / 2 - this.waitLabel.Width / 2;
      this.waitLabel.Top = ((Control) this).Height / 2 - this.waitLabel.Height / 2;
      this.waitLabel.BorderStyle = BorderStyle.FixedSingle;
      this.waitLabel.TextAlign = ContentAlignment.MiddleCenter;
      this.waitLabel.Text = "Updating.. please wait";
      this.waitLabel.Visible = false;
      ((Control) this).Controls.Add((Control) this.waitLabel);
      this.waitLabel.BringToFront();
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      ((DockControl) this).Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ResultsWindow));
      ListViewGroup listViewGroup1 = new ListViewGroup("All Trades", HorizontalAlignment.Left);
      ListViewGroup listViewGroup2 = new ListViewGroup("Long Trades", HorizontalAlignment.Left);
      ListViewGroup listViewGroup3 = new ListViewGroup("Short Trades", HorizontalAlignment.Left);
      ListViewItem listViewItem1 = new ListViewItem(new string[2]
      {
        "All Trades #",
        ""
      }, -1);
      ListViewItem listViewItem2 = new ListViewItem(new string[2]
      {
        "Long Trades #",
        ""
      }, -1);
      ListViewItem listViewItem3 = new ListViewItem(new string[2]
      {
        "Short Trades #",
        ""
      }, -1);
      ListViewItem listViewItem4 = new ListViewItem(new string[2]
      {
        "Total PnL",
        ""
      }, -1);
      ListViewItem listViewItem5 = new ListViewItem(new string[2]
      {
        "Long Trades PnL",
        ""
      }, -1);
      ListViewItem listViewItem6 = new ListViewItem(new string[2]
      {
        "Short Trade PnL",
        ""
      }, -1);
      ListViewItem listViewItem7 = new ListViewItem(new string[2]
      {
        "PnL Per Long Trade",
        ""
      }, -1);
      ListViewItem listViewItem8 = new ListViewItem(new string[2]
      {
        "PnL Per Short Trade",
        ""
      }, -1);
      ListViewItem listViewItem9 = new ListViewItem(new string[2]
      {
        "PnL Per Trade",
        ""
      }, -1);
      ListViewItem listViewItem10 = new ListViewItem(new string[2]
      {
        "Winning Trades #",
        ""
      }, -1);
      ListViewItem listViewItem11 = new ListViewItem(new string[2]
      {
        "Losing Trades #",
        ""
      }, -1);
      ListViewItem listViewItem12 = new ListViewItem(new string[2]
      {
        "Winning Long Trades #",
        ""
      }, -1);
      ListViewItem listViewItem13 = new ListViewItem(new string[2]
      {
        "Losing Long Trades #",
        ""
      }, -1);
      ListViewItem listViewItem14 = new ListViewItem(new string[2]
      {
        "Winning Short Trades #",
        ""
      }, -1);
      ListViewItem listViewItem15 = new ListViewItem(new string[2]
      {
        "Losing Short Trades #",
        ""
      }, -1);
      ListViewGroup listViewGroup4 = new ListViewGroup("Summary", HorizontalAlignment.Left);
      ListViewGroup listViewGroup5 = new ListViewGroup("Transactions", HorizontalAlignment.Left);
      ListViewItem listViewItem16 = new ListViewItem(new string[2]
      {
        "Initial Wealth",
        ""
      }, -1);
      ListViewItem listViewItem17 = new ListViewItem(new string[2]
      {
        "Final Wealth",
        ""
      }, -1);
      ListViewItem listViewItem18 = new ListViewItem(new string[2]
      {
        "Value",
        ""
      }, -1);
      ListViewItem listViewItem19 = new ListViewItem(new string[2]
      {
        "Debt",
        ""
      }, -1);
      ListViewItem listViewItem20 = new ListViewItem(new string[2]
      {
        "Margin",
        ""
      }, -1);
      ListViewItem listViewItem21 = new ListViewItem(new string[2]
      {
        "PnL",
        ""
      }, -1);
      ListViewItem listViewItem22 = new ListViewItem(new string[2]
      {
        "Return",
        ""
      }, -1);
      ListViewItem listViewItem23 = new ListViewItem(new string[2]
      {
        "Annual Return",
        ""
      }, -1);
      ListViewItem listViewItem24 = new ListViewItem(new string[2]
      {
        "Total Transactions #",
        ""
      }, -1);
      ListViewItem listViewItem25 = new ListViewItem(new string[2]
      {
        "Long Transactions #",
        ""
      }, -1);
      ListViewItem listViewItem26 = new ListViewItem(new string[2]
      {
        "Short Transactions #",
        ""
      }, -1);
      ListViewItem listViewItem27 = new ListViewItem(new string[2]
      {
        "Account",
        ""
      }, -1);
      ListViewItem listViewItem28 = new ListViewItem(new string[2]
      {
        "Position",
        ""
      }, -1);
      ListViewItem listViewItem29 = new ListViewItem(new string[2]
      {
        "Currency",
        ""
      }, -1);
      ListViewItem listViewItem30 = new ListViewItem(new string[2]
      {
        "Trades Duration",
        ""
      }, -1);
      ListViewItem listViewItem31 = new ListViewItem(new string[2]
      {
        "Trades Frequency",
        ""
      }, -1);
      ListViewItem listViewItem32 = new ListViewItem(new string[2]
      {
        "",
        ""
      }, -1);
      this.imageList1 = new ImageList(this.components);
      this.panel2 = new Panel();
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.chart = new Chart();
      this.splitter1 = new Splitter();
      this.panel1 = new Panel();
      this.btnPrevInstrument = new Button();
      this.btnNextInstrument = new Button();
      this.btnPrevTransaction = new Button();
      this.btnNextTransaction = new Button();
      this.chbxBindToChart = new CheckBox();
      this.tabControl2 = new TabControl();
      this.tabPage3 = new TabPage();
      this.ltvTransactions = new ListView();
      this.columnHeader8 = new ColumnHeader();
      this.columnHeader9 = new ColumnHeader();
      this.columnHeader10 = new ColumnHeader();
      this.columnHeader11 = new ColumnHeader();
      this.columnHeader12 = new ColumnHeader();
      this.columnHeader5 = new ColumnHeader();
      this.columnHeader15 = new ColumnHeader();
      this.columnHeader36 = new ColumnHeader();
      this.columnHeader16 = new ColumnHeader();
      this.columnHeader14 = new ColumnHeader();
      this.tabPage2 = new TabPage();
      this.ltvSummary2 = new ListView();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.ltvSummary1 = new ListView();
      this.columnHeader37 = new ColumnHeader();
      this.columnHeader38 = new ColumnHeader();
      this.tabPage4 = new TabPage();
      this.testerPanel1 = new TesterPanel();
      this.toolTip1 = new ToolTip(this.components);
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.lblExport = new LinkLabel();
      this.panel2.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.tabControl2.SuspendLayout();
      this.tabPage3.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.tabPage4.SuspendLayout();
      ((Control) this).SuspendLayout();
      this.imageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imageList1.ImageStream");
      this.imageList1.TransparentColor = Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "arrow_right_green.ico");
      this.imageList1.Images.SetKeyName(1, "arrow_left_blue.ico");
      this.imageList1.Images.SetKeyName(2, "arrow_left_green.ico");
      this.imageList1.Images.SetKeyName(3, "arrow_right_blue.ico");
      this.panel2.Controls.Add((Control) this.tabControl1);
      this.panel2.Dock = DockStyle.Fill;
      this.panel2.Location = new Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(838, 420);
      this.panel2.TabIndex = 2;
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Controls.Add((Control) this.tabPage4);
      this.tabControl1.Dock = DockStyle.Fill;
      this.tabControl1.Location = new Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(838, 420);
      this.tabControl1.TabIndex = 26;
      this.tabPage1.Controls.Add((Control) this.chart);
      this.tabPage1.Controls.Add((Control) this.splitter1);
      this.tabPage1.Controls.Add((Control) this.panel1);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Size = new Size(830, 394);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Chart";
      this.tabPage1.UseVisualStyleBackColor = true;
      ((Chart) this.chart).ActionType = ChartActionType.Cross;
      ((Chart) this.chart).ActiveStopColor = Color.Yellow;
      ((Control) this.chart).AllowDrop = true;
      ((ScrollableControl) this.chart).AutoScroll = true;
      ((Control) this.chart).BackColor = Color.MidnightBlue;
      ((Chart) this.chart).BarSeriesStyle = BSStyle.Candle;
      this.chart.set_BarStyleButtonsEnabled(true);
      ((Chart) this.chart).BorderColor = Color.Gray;
      ((Chart) this.chart).BottomAxisGridColor = Color.LightGray;
      ((Chart) this.chart).BottomAxisLabelColor = Color.LightGray;
      ((Chart) this.chart).CanceledStopColor = Color.Gray;
      ((Chart) this.chart).CandleDownColor = Color.Black;
      ((Chart) this.chart).CandleUpColor = Color.Lime;
      ((Chart) this.chart).CanvasColor = Color.MidnightBlue;
      ((Chart) this.chart).ChartBackColor = Color.MidnightBlue;
      ((Chart) this.chart).ContextMenuEnabled = true;
      ((Chart) this.chart).CrossColor = Color.DarkGray;
      ((Chart) this.chart).DateTipRectangleColor = Color.LightGray;
      ((Chart) this.chart).DateTipTextColor = Color.Black;
      this.chart.set_DefaultLineColor(Color.White);
      ((Control) this.chart).Dock = DockStyle.Fill;
      ((Chart) this.chart).DrawItems = false;
      ((Chart) this.chart).ExecutedStopColor = Color.MediumSeaGreen;
      ((Control) this.chart).Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      ((Chart) this.chart).ItemTextColor = Color.LightGray;
      ((Chart) this.chart).LabelDigitsCount = 2;
      ((Control) this.chart).Location = new Point(0, 0);
      ((Chart) this.chart).MinNumberOfBars = 80;
      ((Control) this.chart).Name = "chart";
      ((Chart) this.chart).RightAxesFontSize = 7;
      ((Chart) this.chart).RightAxisGridColor = Color.DimGray;
      ((Chart) this.chart).RightAxisMajorTicksColor = Color.LightGray;
      ((Chart) this.chart).RightAxisMinorTicksColor = Color.LightGray;
      ((Chart) this.chart).RightAxisTextColor = Color.LightGray;
      ((Chart) this.chart).ScaleStyle = PadScaleStyle.Arith;
      ((Chart) this.chart).SelectedItemTextColor = Color.Yellow;
      ((Chart) this.chart).SelectedTransactionHighlightColor = Color.FromArgb(100, 173, 216, 230);
      ((Chart) this.chart).SessionEnd = TimeSpan.Parse("00:00:00");
      ((Chart) this.chart).SessionGridColor = Color.Empty;
      ((Chart) this.chart).SessionGridEnabled = false;
      ((Chart) this.chart).SessionStart = TimeSpan.Parse("00:00:00");
      ((Control) this.chart).Size = new Size(830, 193);
      ((Chart) this.chart).SmoothingMode = SmoothingMode.HighSpeed;
      ((Chart) this.chart).SplitterColor = Color.LightGray;
      ((Control) this.chart).TabIndex = 0;
      ((Chart) this.chart).UpdateStyle = ChartUpdateStyle.Trailing;
      ((Chart) this.chart).ValTipRectangleColor = Color.LightGray;
      ((Chart) this.chart).ValTipTextColor = Color.Black;
      ((Chart) this.chart).VolumeColor = Color.SteelBlue;
      ((Chart) this.chart).VolumePadVisible = false;
      this.splitter1.Dock = DockStyle.Bottom;
      this.splitter1.Location = new Point(0, 193);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new Size(830, 4);
      this.splitter1.TabIndex = 2;
      this.splitter1.TabStop = false;
      this.panel1.Controls.Add((Control) this.btnPrevInstrument);
      this.panel1.Controls.Add((Control) this.btnNextInstrument);
      this.panel1.Controls.Add((Control) this.btnPrevTransaction);
      this.panel1.Controls.Add((Control) this.btnNextTransaction);
      this.panel1.Controls.Add((Control) this.chbxBindToChart);
      this.panel1.Controls.Add((Control) this.tabControl2);
      this.panel1.Dock = DockStyle.Bottom;
      this.panel1.Location = new Point(0, 197);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(830, 197);
      this.panel1.TabIndex = 3;
      this.btnPrevInstrument.FlatAppearance.BorderSize = 0;
      this.btnPrevInstrument.ImageKey = "arrow_left_green.ico";
      this.btnPrevInstrument.ImageList = this.imageList1;
      this.btnPrevInstrument.Location = new Point(138, 0);
      this.btnPrevInstrument.Name = "btnPrevInstrument";
      this.btnPrevInstrument.Size = new Size(20, 20);
      this.btnPrevInstrument.TabIndex = 28;
      this.btnPrevInstrument.UseVisualStyleBackColor = true;
      this.btnPrevInstrument.Click += new EventHandler(this.btnPrevInstrument_Click);
      this.btnNextInstrument.FlatAppearance.BorderSize = 0;
      this.btnNextInstrument.ImageKey = "arrow_right_green.ico";
      this.btnNextInstrument.ImageList = this.imageList1;
      this.btnNextInstrument.Location = new Point(158, 0);
      this.btnNextInstrument.Name = "btnNextInstrument";
      this.btnNextInstrument.Size = new Size(20, 20);
      this.btnNextInstrument.TabIndex = 27;
      this.btnNextInstrument.UseVisualStyleBackColor = true;
      this.btnNextInstrument.Click += new EventHandler(this.btnNextInstrument_Click);
      this.btnPrevTransaction.ImageKey = "arrow_right_blue.ico";
      this.btnPrevTransaction.ImageList = this.imageList1;
      this.btnPrevTransaction.Location = new Point(110, 0);
      this.btnPrevTransaction.Name = "btnPrevTransaction";
      this.btnPrevTransaction.Size = new Size(20, 20);
      this.btnPrevTransaction.TabIndex = 26;
      this.toolTip1.SetToolTip((Control) this.btnPrevTransaction, "Next Transaction");
      this.btnPrevTransaction.UseVisualStyleBackColor = true;
      this.btnPrevTransaction.Click += new EventHandler(this.btnPrevTransaction_Click);
      this.btnNextTransaction.ImageKey = "arrow_left_blue.ico";
      this.btnNextTransaction.ImageList = this.imageList1;
      this.btnNextTransaction.Location = new Point(90, 0);
      this.btnNextTransaction.Name = "btnNextTransaction";
      this.btnNextTransaction.Size = new Size(20, 20);
      this.btnNextTransaction.TabIndex = 24;
      this.toolTip1.SetToolTip((Control) this.btnNextTransaction, "Prev Transaction");
      this.btnNextTransaction.UseVisualStyleBackColor = true;
      this.btnNextTransaction.Click += new EventHandler(this.btnNextTransaction_Click);
      this.chbxBindToChart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.chbxBindToChart.Checked = true;
      this.chbxBindToChart.CheckState = CheckState.Checked;
      this.chbxBindToChart.Location = new Point(732, 3);
      this.chbxBindToChart.Name = "chbxBindToChart";
      this.chbxBindToChart.Size = new Size(91, 17);
      this.chbxBindToChart.TabIndex = 23;
      this.chbxBindToChart.Text = "Bind to Chart";
      this.chbxBindToChart.UseVisualStyleBackColor = true;
      this.tabControl2.Controls.Add((Control) this.tabPage3);
      this.tabControl2.Dock = DockStyle.Fill;
      this.tabControl2.Location = new Point(0, 0);
      this.tabControl2.Name = "tabControl2";
      this.tabControl2.SelectedIndex = 0;
      this.tabControl2.Size = new Size(830, 197);
      this.tabControl2.TabIndex = 25;
      this.tabPage3.Controls.Add((Control) this.ltvTransactions);
      this.tabPage3.Location = new Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Size = new Size(822, 171);
      this.tabPage3.TabIndex = 0;
      this.tabPage3.Text = "Transactions";
      this.ltvTransactions.BorderStyle = BorderStyle.None;
      this.ltvTransactions.Columns.AddRange(new ColumnHeader[10]
      {
        this.columnHeader8,
        this.columnHeader9,
        this.columnHeader10,
        this.columnHeader11,
        this.columnHeader12,
        this.columnHeader5,
        this.columnHeader15,
        this.columnHeader36,
        this.columnHeader16,
        this.columnHeader14
      });
      this.ltvTransactions.Dock = DockStyle.Fill;
      this.ltvTransactions.FullRowSelect = true;
      this.ltvTransactions.GridLines = true;
      this.ltvTransactions.HideSelection = false;
      this.ltvTransactions.Location = new Point(0, 0);
      this.ltvTransactions.MultiSelect = false;
      this.ltvTransactions.Name = "ltvTransactions";
      this.ltvTransactions.Size = new Size(822, 171);
      this.ltvTransactions.TabIndex = 1;
      this.ltvTransactions.UseCompatibleStateImageBehavior = false;
      this.ltvTransactions.View = View.Details;
      this.ltvTransactions.SelectedIndexChanged += new EventHandler(this.ltvTransactions_SelectedIndexChanged);
      this.ltvTransactions.DoubleClick += new EventHandler(this.ltvTransactions_DoubleClick);
      this.columnHeader8.Text = "DateTime";
      this.columnHeader8.Width = 130;
      this.columnHeader9.Text = "Symbol";
      this.columnHeader9.TextAlign = HorizontalAlignment.Right;
      this.columnHeader9.Width = 70;
      this.columnHeader10.Text = "Side";
      this.columnHeader10.TextAlign = HorizontalAlignment.Right;
      this.columnHeader10.Width = 57;
      this.columnHeader11.Text = "Price";
      this.columnHeader11.TextAlign = HorizontalAlignment.Right;
      this.columnHeader11.Width = 57;
      this.columnHeader12.Text = "Qty";
      this.columnHeader12.TextAlign = HorizontalAlignment.Right;
      this.columnHeader12.Width = 55;
      this.columnHeader5.Text = "Value";
      this.columnHeader5.TextAlign = HorizontalAlignment.Right;
      this.columnHeader5.Width = 67;
      this.columnHeader15.Text = "Cost";
      this.columnHeader15.TextAlign = HorizontalAlignment.Right;
      this.columnHeader15.Width = 57;
      this.columnHeader36.Text = "PnL";
      this.columnHeader36.TextAlign = HorizontalAlignment.Right;
      this.columnHeader36.Width = 56;
      this.columnHeader16.Text = "Currency";
      this.columnHeader16.TextAlign = HorizontalAlignment.Right;
      this.columnHeader16.Width = 62;
      this.columnHeader14.Text = "Comment";
      this.columnHeader14.TextAlign = HorizontalAlignment.Right;
      this.columnHeader14.Width = 209;
      this.tabPage2.AutoScroll = true;
      this.tabPage2.BackColor = SystemColors.Window;
      this.tabPage2.Controls.Add((Control) this.ltvSummary2);
      this.tabPage2.Controls.Add((Control) this.ltvSummary1);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Size = new Size(830, 394);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Summary";
      this.ltvSummary2.BorderStyle = BorderStyle.None;
      this.ltvSummary2.Columns.AddRange(new ColumnHeader[2]
      {
        this.columnHeader3,
        this.columnHeader4
      });
      this.ltvSummary2.FullRowSelect = true;
      this.ltvSummary2.GridLines = true;
      listViewGroup1.Header = "All Trades";
      listViewGroup1.Name = "ltvGroupAllTransactions";
      listViewGroup2.Header = "Long Trades";
      listViewGroup2.Name = "ltvGroupLongTransactions";
      listViewGroup3.Header = "Short Trades";
      listViewGroup3.Name = "ltvGroupShortTransactions";
      this.ltvSummary2.Groups.AddRange(new ListViewGroup[3]
      {
        listViewGroup1,
        listViewGroup2,
        listViewGroup3
      });
      this.ltvSummary2.HeaderStyle = ColumnHeaderStyle.None;
      listViewItem1.Group = listViewGroup1;
      listViewItem2.Group = listViewGroup2;
      listViewItem3.Group = listViewGroup3;
      listViewItem4.Group = listViewGroup1;
      listViewItem5.Group = listViewGroup2;
      listViewItem6.Group = listViewGroup3;
      listViewItem7.Group = listViewGroup2;
      listViewItem8.Group = listViewGroup3;
      listViewItem9.Group = listViewGroup1;
      listViewItem10.Group = listViewGroup1;
      listViewItem11.Group = listViewGroup1;
      listViewItem12.Group = listViewGroup2;
      listViewItem13.Group = listViewGroup2;
      listViewItem14.Group = listViewGroup3;
      listViewItem15.Group = listViewGroup3;
      this.ltvSummary2.Items.AddRange(new ListViewItem[15]
      {
        listViewItem1,
        listViewItem2,
        listViewItem3,
        listViewItem4,
        listViewItem5,
        listViewItem6,
        listViewItem7,
        listViewItem8,
        listViewItem9,
        listViewItem10,
        listViewItem11,
        listViewItem12,
        listViewItem13,
        listViewItem14,
        listViewItem15
      });
      this.ltvSummary2.Location = new Point(238, 0);
      this.ltvSummary2.Name = "ltvSummary2";
      this.ltvSummary2.Scrollable = false;
      this.ltvSummary2.Size = new Size(234, 391);
      this.ltvSummary2.TabIndex = 2;
      this.ltvSummary2.UseCompatibleStateImageBehavior = false;
      this.ltvSummary2.View = View.Details;
      this.columnHeader3.Text = "Statistics";
      this.columnHeader3.Width = 122;
      this.columnHeader4.Text = "Value";
      this.columnHeader4.TextAlign = HorizontalAlignment.Right;
      this.columnHeader4.Width = 110;
      this.ltvSummary1.BorderStyle = BorderStyle.None;
      this.ltvSummary1.Columns.AddRange(new ColumnHeader[2]
      {
        this.columnHeader37,
        this.columnHeader38
      });
      this.ltvSummary1.FullRowSelect = true;
      this.ltvSummary1.GridLines = true;
      listViewGroup4.Header = "Summary";
      listViewGroup4.Name = "ltvGroupSummary";
      listViewGroup5.Header = "Transactions";
      listViewGroup5.Name = "ltvGroupTransactions";
      this.ltvSummary1.Groups.AddRange(new ListViewGroup[2]
      {
        listViewGroup4,
        listViewGroup5
      });
      this.ltvSummary1.HeaderStyle = ColumnHeaderStyle.None;
      listViewItem16.Group = listViewGroup4;
      listViewItem17.Group = listViewGroup4;
      listViewItem18.Group = listViewGroup4;
      listViewItem19.Group = listViewGroup4;
      listViewItem20.Group = listViewGroup4;
      listViewItem21.Group = listViewGroup4;
      listViewItem22.Group = listViewGroup4;
      listViewItem23.Group = listViewGroup4;
      listViewItem24.Group = listViewGroup5;
      listViewItem25.Group = listViewGroup5;
      listViewItem26.Group = listViewGroup5;
      listViewItem27.Group = listViewGroup4;
      listViewItem28.Group = listViewGroup4;
      listViewItem29.Group = listViewGroup4;
      listViewItem30.Group = listViewGroup4;
      listViewItem31.Group = listViewGroup5;
      listViewItem32.Group = listViewGroup4;
      this.ltvSummary1.Items.AddRange(new ListViewItem[17]
      {
        listViewItem16,
        listViewItem17,
        listViewItem18,
        listViewItem19,
        listViewItem20,
        listViewItem21,
        listViewItem22,
        listViewItem23,
        listViewItem24,
        listViewItem25,
        listViewItem26,
        listViewItem27,
        listViewItem28,
        listViewItem29,
        listViewItem30,
        listViewItem31,
        listViewItem32
      });
      this.ltvSummary1.Location = new Point(0, 0);
      this.ltvSummary1.Name = "ltvSummary1";
      this.ltvSummary1.Scrollable = false;
      this.ltvSummary1.Size = new Size(233, 391);
      this.ltvSummary1.TabIndex = 1;
      this.ltvSummary1.UseCompatibleStateImageBehavior = false;
      this.ltvSummary1.View = View.Details;
      this.columnHeader37.Text = "Statistics";
      this.columnHeader37.Width = 122;
      this.columnHeader38.Text = "Value";
      this.columnHeader38.TextAlign = HorizontalAlignment.Right;
      this.columnHeader38.Width = 110;
      this.tabPage4.Controls.Add((Control) this.testerPanel1);
      this.tabPage4.Location = new Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Size = new Size(830, 394);
      this.tabPage4.TabIndex = 2;
      this.tabPage4.Text = "Details";
      this.tabPage4.UseVisualStyleBackColor = true;
      this.testerPanel1.Dock = DockStyle.Fill;
      this.testerPanel1.Location = new Point(0, 0);
      this.testerPanel1.Name = "testerPanel1";
      this.testerPanel1.Size = new Size(921, 394);
      this.testerPanel1.TabIndex = 0;
      this.testerPanel1.Tester = (LiveTester) null;
      this.columnHeader1.Width = 122;
      this.columnHeader2.TextAlign = HorizontalAlignment.Right;
      this.columnHeader2.Width = 110;
      this.lblExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.lblExport.AutoSize = true;
      this.lblExport.Location = new Point(790, 3);
      this.lblExport.Name = "lblExport";
      this.lblExport.Size = new Size(37, 13);
      this.lblExport.TabIndex = 14;
      this.lblExport.TabStop = true;
      this.lblExport.Text = "Export";
      this.lblExport.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lblExport_LinkClicked);
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
      ((Control) this).Controls.Add((Control) this.lblExport);
      ((Control) this).Controls.Add((Control) this.panel2);
      this.set_DefaultDockLocation((ContainerDockLocation) 5);
      ((Control) this).Name = "ResultsWindow";
      ((DockControl) this).set_PersistState(false);
      ((Control) this).Size = new Size(838, 420);
      ((DockControl) this).set_TabImage((Image) Resources.results);
      ((Control) this).Text = "Results";
      this.panel2.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.tabControl2.ResumeLayout(false);
      this.tabPage3.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage4.ResumeLayout(false);
      ((Control) this).ResumeLayout(false);
      ((Control) this).PerformLayout();
    }

    protected virtual void OnInit()
    {
      this.strategyRunner = this.GetKeySource();
      if (this.strategyRunner is StrategyRunner)
        ((Control) this).Text = "Results (" + (this.strategyRunner as StrategyRunner).get_StrategyName() + ")";
      else
        ((Control) this).Text = "Results";
      Runner.Starting += new EventHandler(this.Runner_Starting);
      Runner.Stopped += new EventHandler(this.Runner_Stopped);
      Configuration.add_ConfigurationModeChanged(new EventHandler(this.Configuration_ConfigurationModeChanged));
      this.currentPortfolio = this.strategyRunner.get_Portfolio();
      this.instrumentListSource = new InstrumentListSource();
      this.instrumentListSource.set_AllowAll(true);
      this.instrumentListSource.set_ShowSeries(true);
      this.instrumentListSource.add_SelectedInstrumentChanged(new InstrumentEventHandler(this.instrumentListSource_SelectedInstrumentChanged));
      this.instrumentListSource.add_SelectedSeriesChanged(new EventHandler(this.instrumentListSource_SelectedSeriesChanged));
      if (this.strategyRunner == null || Runner.IsRunning)
        return;
      this.UpdateGUI();
    }

    private void Configuration_ConfigurationModeChanged(object sender, EventArgs e)
    {
      this.currentPortfolio = this.strategyRunner.get_Portfolio();
      this.UpdateGUI();
    }

    private void instrumentListSource_SelectedInstrumentChanged(InstrumentEventArgs args)
    {
      if (args.Instrument != null)
      {
        this.currentInstrument = args.Instrument;
        this.seriesInstrument = this.currentInstrument;
      }
      else
        this.currentInstrument = (Instrument) null;
      this.waitLabel.Size = new Size(200, 40);
      this.waitLabel.Left = ((Control) this).Width / 2 - this.waitLabel.Width / 2;
      this.waitLabel.Top = ((Control) this).Height / 2 - this.waitLabel.Height / 2;
      this.waitLabel.Show();
      this.btnNextInstrument.Enabled = this.btnNextTransaction.Enabled = this.btnPrevInstrument.Enabled = this.btnPrevTransaction.Enabled = false;
      Application.DoEvents();
      this.UpdateView();
      this.DrawSelectedSeries();
      this.waitLabel.Hide();
    }

    private void instrumentListSource_SelectedSeriesChanged(object sender, EventArgs e)
    {
      this.selectedSeries = this.instrumentListSource.get_SelectedSeries();
      this.DrawSelectedSeries();
    }

    protected virtual void OnClosing(DockControlClosingEventArgs e)
    {
      Runner.Starting -= new EventHandler(this.Runner_Starting);
      Runner.Stopped -= new EventHandler(this.Runner_Stopped);
      Configuration.remove_ConfigurationModeChanged(new EventHandler(this.Configuration_ConfigurationModeChanged));
    }

    private void Runner_Stopped(object sender, EventArgs e)
    {
      // ISSUE: explicit non-virtual call
      if (__nonvirtual (((Control) this).InvokeRequired))
      {
        // ISSUE: explicit non-virtual call
        __nonvirtual (((Control) this).Invoke((Delegate) new EventHandler(this.Runner_Stopped), sender, (object) e));
      }
      else
      {
        this.strategyRunner = this.GetKeySource();
        this.UpdateGUI();
      }
    }

    private void Runner_Starting(object sender, EventArgs e)
    {
      // ISSUE: explicit non-virtual call
      if (__nonvirtual (((Control) this).InvokeRequired))
      {
        // ISSUE: explicit non-virtual call
        __nonvirtual (((Control) this).Invoke((Delegate) new EventHandler(this.Runner_Starting), sender, (object) e));
      }
      else
      {
        this.strategyRunner = this.GetKeySource();
        this.instrumentListSource.Clear();
        this.instrumentListSource.Refresh();
        this.Disable();
      }
    }

    private void Disable()
    {
      this.ltvTransactions.Items.Clear();
      ((Chart) this.chart).Reset();
      ((Chart) this.chart).LabelDigitsCount = PriceFormatHelper.GetDecimalPlaces(this.seriesInstrument);
      ((Control) this.chart).Refresh();
      foreach (ListViewGroup listViewGroup in this.ltvSummary1.Groups)
      {
        foreach (ListViewItem listViewItem in listViewGroup.Items)
          listViewItem.SubItems[1].Text = "";
      }
      foreach (ListViewGroup listViewGroup in this.ltvSummary2.Groups)
      {
        foreach (ListViewItem listViewItem in listViewGroup.Items)
          listViewItem.SubItems[1].Text = "";
      }
      this.currentPortfolio = this.strategyRunner.get_Portfolio();
      this.currentInstrument = (Instrument) null;
    }

    private void UpdateSummary()
    {
      double num1 = 0.0;
      double num2 = 0.0;
      double num3 = 0.0;
      double num4 = 0.0;
      double num5 = 0.0;
      int num6 = 0;
      int num7 = 0;
      int num8 = 0;
      int num9 = 0;
      int num10 = 0;
      int num11 = 0;
      int num12 = 0;
      int num13 = 0;
      int num14 = 0;
      double num15 = 0.0;
      double num16 = 0.0;
      double num17 = 0.0;
      double num18 = 0.0;
      double num19 = 0.0;
      string str1 = "";
      string str2 = "";
      if (this.currentPortfolio.Account.Transactions.Count > 0)
        num1 = this.currentPortfolio.Account.Transactions[0].Value;
      if (this.currentPortfolio.Transactions.Count > 0)
      {
        long ticks = (this.currentPortfolio.Transactions[this.currentPortfolio.Transactions.Count - 1].DateTime - this.currentPortfolio.Transactions[0].DateTime).Ticks;
        str1 = this.DateTimeValueToString(ticks);
        str2 = this.DateTimeValueToString(ticks / (long) this.currentPortfolio.Transactions.Count);
        num1 = this.currentPortfolio.Account.Transactions[0].Value;
        num2 = this.currentPortfolio.GetTotalEquity();
        num3 = num2 - num1;
        num4 = (num2 / num1 - 1.0) * 100.0;
        double y = 315360000000000.0 / (double) ticks;
        num5 = (Math.Pow(Math.Abs(num2 / num1), y) - 1.0) * 100.0;
        foreach (Position position in this.currentPortfolio.Positions)
        {
          double unrealizedPnL = position.GetUnrealizedPnL();
          if (position.Side == PositionSide.Short)
          {
            ++num7;
            if (unrealizedPnL > 0.0)
            {
              ++num9;
              ++num11;
            }
            if (unrealizedPnL < 0.0)
            {
              ++num10;
              ++num13;
            }
            num15 += unrealizedPnL;
          }
          else
          {
            ++num8;
            if (unrealizedPnL > 0.0)
            {
              ++num9;
              ++num12;
            }
            if (unrealizedPnL < 0.0)
            {
              ++num10;
              ++num14;
            }
            num16 += unrealizedPnL;
          }
        }
        foreach (Transaction transaction in this.currentPortfolio.Transactions)
        {
          if (transaction.Amount > 0.0)
          {
            ++num7;
            if (transaction.RealizedPnL > 0.0)
            {
              ++num9;
              ++num11;
            }
            if (transaction.RealizedPnL < 0.0)
            {
              ++num10;
              ++num13;
            }
            num15 += transaction.RealizedPnL;
          }
          else
          {
            ++num8;
            if (transaction.RealizedPnL > 0.0)
            {
              ++num9;
              ++num12;
            }
            if (transaction.RealizedPnL < 0.0)
            {
              ++num10;
              ++num14;
            }
            num16 += transaction.RealizedPnL;
          }
        }
        num6 = this.currentPortfolio.Transactions.Count;
        num17 = num3 / (double) (num9 + num10);
        num18 = num15 / (double) (num11 + num13);
        num19 = num16 / (double) (num12 + num14);
      }
      ListViewGroup listViewGroup1 = this.ltvSummary1.Groups["ltvGroupSummary"];
      listViewGroup1.Items[0].SubItems[1].Text = num1.ToString("F2");
      listViewGroup1.Items[1].SubItems[1].Text = num2.ToString("F2");
      listViewGroup1.Items[2].SubItems[1].Text = this.currentPortfolio.GetValue().ToString("F2");
      listViewGroup1.Items[3].SubItems[1].Text = this.currentPortfolio.GetDebtValue().ToString("F2");
      listViewGroup1.Items[4].SubItems[1].Text = this.currentPortfolio.GetMarginValue().ToString("F2");
      listViewGroup1.Items[5].SubItems[1].Text = num3.ToString("F2");
      listViewGroup1.Items[6].SubItems[1].Text = num4.ToString("F2") + " %";
      listViewGroup1.Items[7].SubItems[1].Text = num5.ToString("F2") + " %";
      listViewGroup1.Items[8].SubItems[1].Text = this.currentPortfolio.GetAccountValue().ToString("F2");
      listViewGroup1.Items[9].SubItems[1].Text = this.currentPortfolio.GetPositionValue().ToString("F2");
      listViewGroup1.Items[10].SubItems[1].Text = this.currentPortfolio.Account.Currency.ToString();
      listViewGroup1.Items[11].SubItems[1].Text = str1;
      ListViewGroup listViewGroup2 = this.ltvSummary1.Groups["ltvGroupTransactions"];
      listViewGroup2.Items[0].SubItems[1].Text = num6.ToString();
      listViewGroup2.Items[1].SubItems[1].Text = num7.ToString("F2");
      listViewGroup2.Items[2].SubItems[1].Text = num8.ToString("F2");
      listViewGroup2.Items[3].SubItems[1].Text = str2;
      ListViewGroup listViewGroup3 = this.ltvSummary2.Groups["ltvGroupAllTransactions"];
      listViewGroup3.Items[0].SubItems[1].Text = (num9 + num10).ToString();
      listViewGroup3.Items[1].SubItems[1].Text = num3.ToString("F2");
      listViewGroup3.Items[2].SubItems[1].Text = num17.ToString("F2");
      listViewGroup3.Items[3].SubItems[1].Text = num9.ToString();
      listViewGroup3.Items[4].SubItems[1].Text = num10.ToString();
      ListViewGroup listViewGroup4 = this.ltvSummary2.Groups["ltvGroupShortTransactions"];
      listViewGroup4.Items[0].SubItems[1].Text = (num13 + num11).ToString();
      listViewGroup4.Items[1].SubItems[1].Text = num15.ToString("F2");
      listViewGroup4.Items[2].SubItems[1].Text = num18.ToString("F2");
      listViewGroup4.Items[3].SubItems[1].Text = num11.ToString();
      listViewGroup4.Items[4].SubItems[1].Text = num13.ToString();
      ListViewGroup listViewGroup5 = this.ltvSummary2.Groups["ltvGroupLongTransactions"];
      listViewGroup5.Items[0].SubItems[1].Text = (num14 + num12).ToString();
      listViewGroup5.Items[1].SubItems[1].Text = num16.ToString("F2");
      listViewGroup5.Items[2].SubItems[1].Text = num19.ToString("F2");
      listViewGroup5.Items[3].SubItems[1].Text = num12.ToString();
      listViewGroup5.Items[4].SubItems[1].Text = num14.ToString();
    }

    public virtual string DateTimeValueToString(long value)
    {
      string str = "";
      long ticks = value;
      if (ticks <= 0L)
        return "";
      TimeSpan timeSpan = new TimeSpan(ticks);
      if (timeSpan.Days != 0)
        str = str + timeSpan.Days.ToString() + " Days ";
      if (timeSpan.Hours != 0)
        str = str + timeSpan.Hours.ToString() + " Hours ";
      if (str.Length >= 15)
        return str.Substring(0, str.Length - 1);
      if (timeSpan.Minutes != 0)
        str = str + timeSpan.Minutes.ToString() + " Minutes ";
      if (str.Length >= 17)
        return str.Substring(0, str.Length - 1);
      if (timeSpan.Minutes != 0)
        str = str + timeSpan.Minutes.ToString() + " Seconds ";
      if (str.Length == 0)
        return str;
      else
        return str.Substring(0, str.Length - 1);
    }

    private void UpdateGUI()
    {
      this.btnNextInstrument.Enabled = this.btnNextTransaction.Enabled = this.btnPrevInstrument.Enabled = this.btnPrevTransaction.Enabled = false;
      this.waitLabel.Size = new Size(200, 40);
      this.waitLabel.Left = ((Control) this).Width / 2 - this.waitLabel.Width / 2;
      this.waitLabel.Top = ((Control) this).Height / 2 - this.waitLabel.Height / 2;
      this.waitLabel.Show();
      Application.DoEvents();
      this.Init();
      this.UpdateView();
      this.waitLabel.Hide();
    }

    private void Init()
    {
      this.instrumentListSource.Clear();
      foreach (Instrument instrument in this.strategyRunner.get_Instruments())
        this.instrumentListSource.AddInstrument(instrument);
      foreach (DictionaryEntry dictionaryEntry in DataManager.Bars)
      {
        foreach (BarSeries barSeries in (IEnumerable) dictionaryEntry.Value)
          this.instrumentListSource.AddSeries(dictionaryEntry.Key as Instrument, barSeries);
      }
      this.instrumentListSource.set_SelectedInstrument(this.currentInstrument);
      this.instrumentListSource.Refresh();
      if (this.strategyRunner.get_Instruments().Count <= 0)
        return;
      this.seriesInstrument = this.strategyRunner.get_Instruments()[0];
      if (this.instrumentListSource.get_InstrumentTable()[this.seriesInstrument].get_SeriesList().Count > 0)
        this.selectedSeries = this.instrumentListSource.get_InstrumentTable()[this.seriesInstrument].get_SeriesList()[0];
      this.DrawSelectedSeries();
    }

    private void DrawSelectedSeries()
    {
      if (this.seriesInstrument == null)
        return;
      lock (this.chart)
      {
        DoubleSeries local_0 = (DoubleSeries) this.selectedSeries;
        ((Chart) this.chart).Reset();
        ((Chart) this.chart).LabelDigitsCount = PriceFormatHelper.GetDecimalPlaces(this.seriesInstrument);
        if (this.selectedSeries != null)
          ((Chart) this.chart).SetMainSeries(local_0, false);
        this.chart.ApplyDefaultTemplate();
        if (this.selectedSeries == null)
          return;
        foreach (Transaction item_0 in this.currentPortfolio.Transactions)
        {
          if (item_0.Instrument == this.seriesInstrument)
            ((Chart) this.chart).DrawTransaction(item_0, 0);
        }
      }
    }

    private void UpdateView()
    {
      this.ltvTransactions.BeginUpdate();
      this.ltvTransactions.Items.Clear();
      List<TransactionViewItem> list = new List<TransactionViewItem>();
      foreach (Transaction transaction in this.currentPortfolio.Transactions)
      {
        if (this.currentInstrument == null || transaction.Instrument == this.currentInstrument)
          list.Add(new TransactionViewItem(transaction));
      }
      list.Reverse();
      this.ltvTransactions.Items.AddRange((ListViewItem[]) list.ToArray());
      this.ltvTransactions.EndUpdate();
      this.UpdateSummary();
      this.testerPanel1.Tester = this.strategyRunner.get_Tester();
    }

    private void btnNextTransaction_Click(object sender, EventArgs e)
    {
      if (this.ltvTransactions.SelectedIndices.Count <= 0)
        return;
      int num = this.ltvTransactions.SelectedIndices[0];
      this.ltvTransactions.Items[num + 1].Selected = true;
      this.ltvTransactions.EnsureVisible(num + 1);
      this.ltvTransactions.Focus();
    }

    private void btnPrevTransaction_Click(object sender, EventArgs e)
    {
      if (this.ltvTransactions.SelectedIndices.Count <= 0)
        return;
      int num = this.ltvTransactions.SelectedIndices[0];
      this.ltvTransactions.Items[num - 1].Selected = true;
      this.ltvTransactions.EnsureVisible(num - 1);
      this.ltvTransactions.Focus();
    }

    private void btnPrevInstrument_Click(object sender, EventArgs e)
    {
      if (this.ltvTransactions.SelectedIndices.Count <= 0)
        return;
      Instrument instrument = (this.ltvTransactions.SelectedItems[0] as TransactionViewItem).Transaction.Instrument;
      for (int index = this.ltvTransactions.SelectedIndices[0] + 1; index < this.ltvTransactions.Items.Count; ++index)
      {
        TransactionViewItem transactionViewItem = this.ltvTransactions.Items[index] as TransactionViewItem;
        if (transactionViewItem.Transaction.Instrument == instrument)
        {
          transactionViewItem.Selected = true;
          transactionViewItem.EnsureVisible();
          break;
        }
      }
      this.ltvTransactions.Focus();
    }

    private void btnNextInstrument_Click(object sender, EventArgs e)
    {
      if (this.ltvTransactions.SelectedIndices.Count <= 0)
        return;
      Instrument instrument = (this.ltvTransactions.SelectedItems[0] as TransactionViewItem).Transaction.Instrument;
      for (int index = this.ltvTransactions.SelectedIndices[0] - 1; index >= 0; --index)
      {
        TransactionViewItem transactionViewItem = this.ltvTransactions.Items[index] as TransactionViewItem;
        if (transactionViewItem.Transaction.Instrument == instrument)
        {
          transactionViewItem.Selected = true;
          transactionViewItem.EnsureVisible();
          break;
        }
      }
      this.ltvTransactions.Focus();
    }

    private void cbxSeries_SelectionChangeCommitted(object sender, EventArgs e)
    {
      this.DrawSelectedSeries();
    }

    private void cbxInstruments_SelectionChangeCommitted(object sender, EventArgs e)
    {
    }

    private void ltvTransactions_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.ltvTransactions.SelectedItems.Count <= 0)
        return;
      int num = this.ltvTransactions.SelectedIndices[0];
      Instrument instrument = (this.ltvTransactions.SelectedItems[0] as TransactionViewItem).Transaction.Instrument;
      this.btnNextTransaction.Enabled = num != this.ltvTransactions.Items.Count - 1;
      this.btnPrevTransaction.Enabled = num != 0;
      bool flag1 = false;
      bool flag2 = false;
      for (int index = num - 1; index >= 0; --index)
      {
        if ((this.ltvTransactions.Items[index] as TransactionViewItem).Transaction.Instrument == instrument)
        {
          flag1 = true;
          break;
        }
      }
      for (int index = num + 1; index < this.ltvTransactions.Items.Count; ++index)
      {
        if ((this.ltvTransactions.Items[index] as TransactionViewItem).Transaction.Instrument == instrument)
        {
          flag2 = true;
          break;
        }
      }
      this.btnNextInstrument.Enabled = flag1;
      this.btnPrevInstrument.Enabled = flag2;
      if (this.toolTip1.GetToolTip((Control) this.btnNextInstrument) != "Next " + instrument.Symbol + " Transaction")
      {
        this.toolTip1.SetToolTip((Control) this.btnNextInstrument, "Next " + instrument.Symbol + " Transaction");
        this.toolTip1.SetToolTip((Control) this.btnPrevInstrument, "Previous " + instrument.Symbol + " Transaction");
      }
      if (!this.chbxBindToChart.Checked)
        return;
      TransactionViewItem transactionViewItem = this.ltvTransactions.SelectedItems[0] as TransactionViewItem;
      if (((Chart) this.chart).MainSeries == null || transactionViewItem.Transaction.Instrument != this.seriesInstrument)
        return;
      ((Chart) this.chart).EnsureVisible(transactionViewItem.Transaction);
    }

    private void lblExport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.Export();
    }

    private void Export()
    {
      string text = this.waitLabel.Text;
      this.waitLabel.Text = "Creating report..";
      this.waitLabel.Size = new Size(200, 40);
      this.waitLabel.Left = ((Control) this).Width / 2 - this.waitLabel.Width / 2;
      this.waitLabel.Top = ((Control) this).Height / 2 - this.waitLabel.Height / 2;
      this.waitLabel.Show();
      Application.DoEvents();
      CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
      try
      {
        ((Control) this).Cursor = Cursors.WaitCursor;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        Excel excel = new Excel();
        excel.get_Workbooks().Add();
        Workbook workbook = excel.get_Workbooks().get_Item(1);
        WorksheetList worksheets = workbook.get_Worksheets();
        worksheets.AddLast();
        Worksheet sheet1 = worksheets.get_Item(1);
        sheet1.set_Name("Transactions");
        this.CopyDataToWorksheet(sheet1, new ListView[1]
        {
          this.ltvTransactions
        });
        worksheets.AddLast();
        Worksheet sheet2 = worksheets.get_Item(2);
        sheet2.set_Name("Summary");
        this.CopyDataToWorksheet(sheet2, new ListView[2]
        {
          this.ltvSummary1,
          this.ltvSummary2
        });
        this.testerPanel1.CreateExcelReport(worksheets);
        workbook.get_Worksheets().get_Item(1).Activate();
        excel.set_Visible(true);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show((IWin32Window) Global.MainForm, string.Format("An error occured while exporting results. Possible, MS Office is not installed.{0}{0}{1}", (object) Environment.NewLine, (object) ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      finally
      {
        Thread.CurrentThread.CurrentCulture = currentCulture;
        ((Control) this).Cursor = Cursors.Default;
        this.waitLabel.Hide();
        this.waitLabel.Text = text;
      }
    }

    private void CopyDataToWorksheet(Worksheet sheet, ListView[] listViewList)
    {
      int num = 2;
      for (int index = 0; index < listViewList[0].Columns.Count; ++index)
      {
        ColumnHeader columnHeader = listViewList[0].Columns[index];
        Range range = sheet.GetRange(1, index + 1);
        range.set_Bold(true);
        range.set_Value((object) columnHeader.Text);
      }
      foreach (ListView listView in listViewList)
      {
        for (int index1 = 0; index1 < listView.Items.Count; ++index1)
        {
          ListViewItem listViewItem = listView.Items[index1];
          for (int index2 = 0; index2 < listViewItem.SubItems.Count; ++index2)
          {
            Range range = sheet.GetRange(index1 + num, index2 + 1);
            if (listViewItem.SubItems[index2].Font.Italic)
              range.set_Italic(true);
            if (listViewItem.SubItems[index2].Font.Bold)
              range.set_Bold(true);
            if (listViewItem.SubItems[index2].Font.Underline)
              range.set_Underline(true);
            range.set_Value((object) listViewItem.SubItems[index2].Text);
          }
        }
        num += listView.Items.Count;
      }
    }

    private void ltvTransactions_DoubleClick(object sender, EventArgs e)
    {
      TransactionViewItem transactionViewItem = this.ltvTransactions.SelectedItems[0] as TransactionViewItem;
      if (transactionViewItem == null || transactionViewItem.Transaction.Instrument == this.currentInstrument)
        return;
      this.seriesInstrument = transactionViewItem.Transaction.Instrument;
      if (this.instrumentListSource.get_InstrumentTable()[this.seriesInstrument].get_SeriesList().Count > 0)
        this.selectedSeries = this.instrumentListSource.get_InstrumentTable()[this.seriesInstrument].get_SeriesList()[0];
      this.DrawSelectedSeries();
      if (((Chart) this.chart).MainSeries == null)
        return;
      ((Chart) this.chart).EnsureVisible(transactionViewItem.Transaction);
    }

    private IInstrumentSource GetKeySource()
    {
      StrategyProject strategyProject = this.get_Key() as StrategyProject;
      if (strategyProject == null)
        return (IInstrumentSource) (this.get_Key() as Solution).SolutionRunner;
      else
        return (IInstrumentSource) strategyProject.StrategyRunner;
    }
  }
}

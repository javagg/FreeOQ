using OpenQuant.Shared;
using OpenQuant.Shared.Charting;
using OpenQuant.Shared.Data;
using OpenQuant.Shared.Data.Bars;
using OpenQuant.Shared.Data.Export.CSV;
using OpenQuant.Shared.Properties;
using FreeQuant.Data;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using TD.SandDock;

namespace OpenQuant.Shared.Data.Management
{
  public class InstrumentDataWindow : FreeQuant.Docking.WinForms.DockControl, ITimerItem, IChartControl
  {
    private IContainer components;
    private SplitContainer splitContainer1;
    private System.Windows.Forms.TabControl tabControl2;
    private System.Windows.Forms.TabPage tabData;
    private ImageList images;
    private ListView ltvDataSeries;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private DataSeriesViewer dataSeriesViewer;
    private ContextMenuStrip ctxDataSeries;
    private ToolStripMenuItem ctxDataSeries_Clear;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem ctxDataSeries_Delete;
    private ToolStripMenuItem ctxDataSeries_Refresh;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem ctxDataSeries_New;
    private ToolStripMenuItem ctxDataSeries_New_Bar;
    private ToolStripMenuItem ctxDataSeries_New_Daily;
    private ToolStripMenuItem ctxDataSeries_New_Trade;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem ctxDataSeries_New_Quote;
    private ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.TabPage tabChart;
    private ToolStripMenuItem ctxDataSeries_ExportCSV;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripMenuItem ctxDataSeries_CompressBars;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStrip toolStrip1;
    private ToolStripButton tsbRefresh;
    private Instrument instrument;
    private ChartPanel chartPanel;

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

    public Chart ChartControl
    {
      get
      {
        return this.chartPanel.ChartControl;
      }
    }

    public InstrumentDataWindow()
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
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (InstrumentDataWindow));
      this.splitContainer1 = new SplitContainer();
      this.ltvDataSeries = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.ctxDataSeries = new ContextMenuStrip(this.components);
      this.ctxDataSeries_New = new ToolStripMenuItem();
      this.ctxDataSeries_New_Bar = new ToolStripMenuItem();
      this.toolStripMenuItem1 = new ToolStripMenuItem();
      this.ctxDataSeries_New_Daily = new ToolStripMenuItem();
      this.ctxDataSeries_New_Trade = new ToolStripMenuItem();
      this.ctxDataSeries_New_Quote = new ToolStripMenuItem();
      this.toolStripSeparator3 = new ToolStripSeparator();
      this.ctxDataSeries_Refresh = new ToolStripMenuItem();
      this.toolStripSeparator2 = new ToolStripSeparator();
      this.ctxDataSeries_ExportCSV = new ToolStripMenuItem();
      this.toolStripSeparator4 = new ToolStripSeparator();
      this.ctxDataSeries_CompressBars = new ToolStripMenuItem();
      this.toolStripSeparator5 = new ToolStripSeparator();
      this.ctxDataSeries_Clear = new ToolStripMenuItem();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.ctxDataSeries_Delete = new ToolStripMenuItem();
      this.images = new ImageList(this.components);
      this.tabControl2 = new System.Windows.Forms.TabControl();
      this.tabData = new System.Windows.Forms.TabPage();
      this.dataSeriesViewer = new DataSeriesViewer();
      this.tabChart = new System.Windows.Forms.TabPage();
      this.toolStrip1 = new ToolStrip();
      this.tsbRefresh = new ToolStripButton();
      this.splitContainer1.BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.ctxDataSeries.SuspendLayout();
      this.tabControl2.SuspendLayout();
      this.tabData.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      this.splitContainer1.Dock = DockStyle.Fill;
      this.splitContainer1.Location = new Point(0, 25);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = Orientation.Horizontal;
      this.splitContainer1.Panel1.Controls.Add((Control) this.ltvDataSeries);
      this.splitContainer1.Panel1.Padding = new Padding(4);
      this.splitContainer1.Panel2.Controls.Add((Control) this.tabControl2);
      this.splitContainer1.Panel2.Padding = new Padding(4);
      this.splitContainer1.Size = new Size(250, 375);
      this.splitContainer1.SplitterDistance = 97;
      this.splitContainer1.TabIndex = 0;
      this.ltvDataSeries.Columns.AddRange(new ColumnHeader[4]
      {
        this.columnHeader1,
        this.columnHeader2,
        this.columnHeader3,
        this.columnHeader4
      });
      this.ltvDataSeries.ContextMenuStrip = this.ctxDataSeries;
      this.ltvDataSeries.Dock = DockStyle.Fill;
      this.ltvDataSeries.FullRowSelect = true;
      this.ltvDataSeries.GridLines = true;
      this.ltvDataSeries.HideSelection = false;
      this.ltvDataSeries.Location = new Point(4, 4);
      this.ltvDataSeries.Name = "ltvDataSeries";
      this.ltvDataSeries.ShowGroups = false;
      this.ltvDataSeries.Size = new Size(242, 89);
      this.ltvDataSeries.SmallImageList = this.images;
      this.ltvDataSeries.Sorting = SortOrder.Ascending;
      this.ltvDataSeries.TabIndex = 1;
      this.ltvDataSeries.UseCompatibleStateImageBehavior = false;
      this.ltvDataSeries.View = View.Details;
      this.ltvDataSeries.SelectedIndexChanged += new EventHandler(this.ltvDataSeries_SelectedIndexChanged);
      this.columnHeader1.Text = "Data Series";
      this.columnHeader1.Width = 112;
      this.columnHeader2.Text = "Object Count";
      this.columnHeader2.TextAlign = HorizontalAlignment.Right;
      this.columnHeader2.Width = 96;
      this.columnHeader3.Text = "First DateTime";
      this.columnHeader3.TextAlign = HorizontalAlignment.Right;
      this.columnHeader3.Width = 144;
      this.columnHeader4.Text = "Last DateTime";
      this.columnHeader4.TextAlign = HorizontalAlignment.Right;
      this.columnHeader4.Width = 144;
      this.ctxDataSeries.Items.AddRange(new ToolStripItem[11]
      {
        (ToolStripItem) this.ctxDataSeries_New,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.ctxDataSeries_Refresh,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.ctxDataSeries_ExportCSV,
        (ToolStripItem) this.toolStripSeparator4,
        (ToolStripItem) this.ctxDataSeries_CompressBars,
        (ToolStripItem) this.toolStripSeparator5,
        (ToolStripItem) this.ctxDataSeries_Clear,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.ctxDataSeries_Delete
      });
      this.ctxDataSeries.Name = "ctxDataSeries";
      this.ctxDataSeries.Size = new Size(169, 188);
      this.ctxDataSeries.Opening += new CancelEventHandler(this.ctxDataSeries_Opening);
      this.ctxDataSeries_New.DropDownItems.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.ctxDataSeries_New_Bar,
        (ToolStripItem) this.ctxDataSeries_New_Daily,
        (ToolStripItem) this.ctxDataSeries_New_Trade,
        (ToolStripItem) this.ctxDataSeries_New_Quote
      });
      this.ctxDataSeries_New.Image = (Image) Resources.data_add;
      this.ctxDataSeries_New.Name = "ctxDataSeries_New";
      this.ctxDataSeries_New.Size = new Size(168, 22);
      this.ctxDataSeries_New.Text = "New Data Series";
      this.ctxDataSeries_New_Bar.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.toolStripMenuItem1
      });
      this.ctxDataSeries_New_Bar.Name = "ctxDataSeries_New_Bar";
      this.ctxDataSeries_New_Bar.Size = new Size(107, 22);
      this.ctxDataSeries_New_Bar.Text = "Bar";
      this.ctxDataSeries_New_Bar.DropDownOpening += new EventHandler(this.ctxDataSeries_New_Bar_DropDownOpening);
      this.ctxDataSeries_New_Bar.DropDownItemClicked += new ToolStripItemClickedEventHandler(this.ctxDataSeries_New_Bar_DropDownItemClicked);
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new Size(116, 22);
      this.toolStripMenuItem1.Text = "(Empty)";
      this.ctxDataSeries_New_Daily.Name = "ctxDataSeries_New_Daily";
      this.ctxDataSeries_New_Daily.Size = new Size(107, 22);
      this.ctxDataSeries_New_Daily.Text = "Daily";
      this.ctxDataSeries_New_Daily.Click += new EventHandler(this.ctxDataSeries_New_Daily_Click);
      this.ctxDataSeries_New_Trade.Name = "ctxDataSeries_New_Trade";
      this.ctxDataSeries_New_Trade.Size = new Size(107, 22);
      this.ctxDataSeries_New_Trade.Text = "Trade";
      this.ctxDataSeries_New_Trade.Click += new EventHandler(this.ctxDataSeries_New_Trade_Click);
      this.ctxDataSeries_New_Quote.Name = "ctxDataSeries_New_Quote";
      this.ctxDataSeries_New_Quote.Size = new Size(107, 22);
      this.ctxDataSeries_New_Quote.Text = "Quote";
      this.ctxDataSeries_New_Quote.Click += new EventHandler(this.ctxDataSeries_New_Quote_Click);
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new Size(165, 6);
      this.ctxDataSeries_Refresh.Image = (Image) Resources.refresh;
      this.ctxDataSeries_Refresh.Name = "ctxDataSeries_Refresh";
      this.ctxDataSeries_Refresh.Size = new Size(168, 22);
      this.ctxDataSeries_Refresh.Text = "Refresh";
      this.ctxDataSeries_Refresh.Click += new EventHandler(this.ctxDataSeries_Refresh_Click);
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new Size(165, 6);
      this.ctxDataSeries_ExportCSV.Image = (Image) Resources.csv;
      this.ctxDataSeries_ExportCSV.Name = "ctxDataSeries_ExportCSV";
      this.ctxDataSeries_ExportCSV.Size = new Size(168, 22);
      this.ctxDataSeries_ExportCSV.Text = "Export To CSV...";
      this.ctxDataSeries_ExportCSV.Click += new EventHandler(this.ctxDataSeries_ExportCSV_Click);
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new Size(165, 6);
      this.ctxDataSeries_CompressBars.Name = "ctxDataSeries_CompressBars";
      this.ctxDataSeries_CompressBars.Size = new Size(168, 22);
      this.ctxDataSeries_CompressBars.Text = "Compress Bars...";
      this.ctxDataSeries_CompressBars.Click += new EventHandler(this.ctxDataSeries_CompressBars_Click);
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new Size(165, 6);
      this.ctxDataSeries_Clear.Image = (Image) Resources.clear;
      this.ctxDataSeries_Clear.Name = "ctxDataSeries_Clear";
      this.ctxDataSeries_Clear.Size = new Size(168, 22);
      this.ctxDataSeries_Clear.Text = "Clear";
      this.ctxDataSeries_Clear.Click += new EventHandler(this.ctxDataSeries_Clear_Click);
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(165, 6);
      this.ctxDataSeries_Delete.Image = (Image) Resources.data_delete;
      this.ctxDataSeries_Delete.Name = "ctxDataSeries_Delete";
      this.ctxDataSeries_Delete.Size = new Size(168, 22);
      this.ctxDataSeries_Delete.Text = "Delete";
      this.ctxDataSeries_Delete.Click += new EventHandler(this.ctxDataSeries_Delete_Click);
      this.images.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("images.ImageStream");
      this.images.TransparentColor = Color.Transparent;
      this.images.Images.SetKeyName(0, "data.png");
      this.tabControl2.Controls.Add((Control) this.tabData);
      this.tabControl2.Controls.Add((Control) this.tabChart);
      this.tabControl2.Dock = DockStyle.Fill;
      this.tabControl2.Location = new Point(4, 4);
      this.tabControl2.Name = "tabControl2";
      this.tabControl2.SelectedIndex = 0;
      this.tabControl2.Size = new Size(242, 266);
      this.tabControl2.TabIndex = 0;
      this.tabData.Controls.Add((Control) this.dataSeriesViewer);
      this.tabData.Location = new Point(4, 22);
      this.tabData.Name = "tabData";
      this.tabData.Padding = new Padding(3);
      this.tabData.Size = new Size(234, 240);
      this.tabData.TabIndex = 0;
      this.tabData.Text = "Data";
      this.tabData.UseVisualStyleBackColor = true;
      this.dataSeriesViewer.Dock = DockStyle.Fill;
      this.dataSeriesViewer.Location = new Point(3, 3);
      this.dataSeriesViewer.Name = "dataSeriesViewer";
      this.dataSeriesViewer.Size = new Size(228, 234);
      this.dataSeriesViewer.TabIndex = 0;
      this.tabChart.Location = new Point(4, 22);
      this.tabChart.Name = "tabChart";
      this.tabChart.Size = new Size(534, 240);
      this.tabChart.TabIndex = 1;
      this.tabChart.Text = "Chart";
      this.tabChart.UseVisualStyleBackColor = true;
      this.toolStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.tsbRefresh
      });
      this.toolStrip1.Location = new Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new Size(250, 25);
      this.toolStrip1.TabIndex = 1;
      this.toolStrip1.Text = "toolStrip1";
      this.tsbRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbRefresh.Image = (Image) Resources.refresh;
      this.tsbRefresh.ImageTransparentColor = Color.Magenta;
      this.tsbRefresh.Name = "tsbRefresh";
      this.tsbRefresh.Size = new Size(23, 22);
      this.tsbRefresh.Text = "Refresh";
      this.tsbRefresh.Click += new EventHandler(this.tsbRefresh_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.splitContainer1);
      this.Controls.Add((Control) this.toolStrip1);
      this.DefaultDockLocation = ContainerDockLocation.Center;
      this.Name = "InstrumentDataDocument";
      this.PersistState = false;
      this.TabImage = (Image) Resources.data;
      this.Text = "InstrumentDataDocument";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.ctxDataSeries.ResumeLayout(false);
      this.tabControl2.ResumeLayout(false);
      this.tabData.ResumeLayout(false);
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public void OnElapsed()
    {
      foreach (DataSeriesViewItem dataSeriesViewItem in this.ltvDataSeries.Items)
        dataSeriesViewItem.Update();
    }

    protected override void OnInit()
    {
      this.instrument = (Instrument) this.Key;
      this.InitDataSeriesList();
      this.InitDataSeriesViewer();
      this.InitChart();
      this.Text = string.Format("Data [{0}]", (object) ((FIXInstrument) this.instrument).Symbol);
      Global.TimerManager.Start((ITimerItem) this);
    }

    protected override void OnClosing(DockControlClosingEventArgs e)
    {
      Global.TimerManager.Stop((ITimerItem) this);
      base.OnClosing(e);
    }

    private void InitDataSeriesList()
    {
      DataSeriesList dataSeries = this.instrument.GetDataSeries();
      this.ltvDataSeries.BeginUpdate();
      this.ltvDataSeries.Items.Clear();
      IEnumerator enumerator = dataSeries.GetEnumerator();
      try
      {
        while (enumerator.MoveNext())
          this.ltvDataSeries.Items.Add((ListViewItem) new DataSeriesViewItem((IDataSeries) enumerator.Current));
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        if (disposable != null)
          disposable.Dispose();
      }
      this.ltvDataSeries.EndUpdate();
    }

    private void InitDataSeriesViewer()
    {
      this.dataSeriesViewer.SetPriceFormat(PriceFormatHelper.GetFormat(this.instrument));
      this.dataSeriesViewer.SetDataSeries((IDataSeries) null);
    }

    private void InitChart(ChartPanel chartPanel, IDataSeries dataSeries)
    {
      this.chartPanel = chartPanel;
      this.chartPanel.Dock = DockStyle.Fill;
      foreach (Component component in (ArrangedElementCollection) this.tabChart.Controls)
        component.Dispose();
      this.tabChart.Controls.Clear();
      this.tabChart.Controls.Add((Control) chartPanel);
      this.chartPanel.Init(dataSeries);
      if (this.chartPanel.ChartControl == null)
        return;
			this.chartPanel.ChartControl.LabelDigitsCount = PriceFormatHelper.GetDecimalPlaces(this.instrument);
    }

    private void InitChart()
    {
      this.InitChart(new ChartPanel(), (IDataSeries) null);
    }

    private void ltvDataSeries_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.InitChart();
      if (this.ltvDataSeries.SelectedItems.Count == 1)
      {
        IDataSeries dataSeries = (this.ltvDataSeries.SelectedItems[0] as DataSeriesViewItem).DataSeries;
        this.dataSeriesViewer.SetDataSeries(dataSeries);
				switch (DataSeriesHelper.GetDataSeriesInfo(dataSeries.Name).DataType)
        {
          case DataType.Trade:
            this.InitChart((ChartPanel) new TradeChartPanel(), dataSeries);
            break;
          case DataType.Quote:
            this.InitChart((ChartPanel) new QuoteChartPanel(), dataSeries);
            break;
          case DataType.Bar:
          case DataType.Daily:
            this.InitChart((ChartPanel) new BarChartPanel(), dataSeries);
            break;
        }
      }
      else
        this.dataSeriesViewer.SetDataSeries((IDataSeries) null);
    }

    private void tsbRefresh_Click(object sender, EventArgs e)
    {
      this.InitDataSeriesList();
      this.InitDataSeriesViewer();
    }

    private void ctxDataSeries_Opening(object sender, CancelEventArgs e)
    {
      switch (this.ltvDataSeries.SelectedItems.Count)
      {
        case 0:
          this.ctxDataSeries_New.Enabled = true;
          this.ctxDataSeries_Refresh.Enabled = true;
          this.ctxDataSeries_ExportCSV.Enabled = false;
          this.ctxDataSeries_CompressBars.Enabled = false;
          this.ctxDataSeries_Clear.Enabled = false;
          this.ctxDataSeries_Delete.Enabled = false;
          break;
        case 1:
          this.ctxDataSeries_New.Enabled = true;
          this.ctxDataSeries_Refresh.Enabled = true;
          this.ctxDataSeries_ExportCSV.Enabled = true;
          this.ctxDataSeries_CompressBars.Enabled = true;
          this.ctxDataSeries_Clear.Enabled = true;
          this.ctxDataSeries_Delete.Enabled = true;
          break;
        default:
          this.ctxDataSeries_New.Enabled = true;
          this.ctxDataSeries_Refresh.Enabled = true;
          this.ctxDataSeries_ExportCSV.Enabled = true;
          this.ctxDataSeries_CompressBars.Enabled = false;
          this.ctxDataSeries_Clear.Enabled = true;
          this.ctxDataSeries_Delete.Enabled = true;
          break;
      }
    }

    private void ctxDataSeries_Refresh_Click(object sender, EventArgs e)
    {
      this.InitDataSeriesList();
      this.InitDataSeriesViewer();
    }

    private void ctxDataSeries_ExportCSV_Click(object sender, EventArgs e)
    {
      List<IDataSeries> list = new List<IDataSeries>();
      foreach (DataSeriesViewItem dataSeriesViewItem in this.ltvDataSeries.SelectedItems)
      {
        DataType dataType = DataSeriesHelper.GetDataSeriesInfo(dataSeriesViewItem.DataSeries.Name).DataType;
        switch (dataType)
        {
          case DataType.Unknown:
          case DataType.MarketDepth:
            int num = (int) MessageBox.Show((IWin32Window) this, string.Format("Cannot export {0} series to CSV format.", (object) dataType), "Export To CSV", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            continue;
          default:
            list.Add(dataSeriesViewItem.DataSeries);
            continue;
        }
      }
      if (list.Count <= 0)
        return;
      DataSeriesExportForm seriesExportForm = new DataSeriesExportForm();
      seriesExportForm.Init(list.ToArray());
      int num1 = (int) seriesExportForm.ShowDialog((IWin32Window) this);
      seriesExportForm.Dispose();
    }

    private void ctxDataSeries_CompressBars_Click(object sender, EventArgs e)
    {
      IDataSeries dataSeries = (this.ltvDataSeries.SelectedItems[0] as DataSeriesViewItem).DataSeries;
      DataType dataType = DataSeriesHelper.GetDataSeriesInfo(dataSeries.Name).DataType;
      switch (dataType)
      {
        case DataType.Trade:
        case DataType.Quote:
        case DataType.Bar:
          CompressBarsForm compressBarsForm = new CompressBarsForm();
          compressBarsForm.Init(new IDataSeries[1]
          {
            dataSeries
          }, 1 != 0);
          int num1 = (int) compressBarsForm.ShowDialog((IWin32Window) this);
          compressBarsForm.Dispose();
          break;
        default:
          int num2 = (int) MessageBox.Show((IWin32Window) this, string.Format("Cannot compress bars from {0} series.", (object) dataType), "Compress Bars", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          break;
      }
    }

    private void ctxDataSeries_Clear_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show((IWin32Window) this, "Are you sure to clear selected series?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      foreach (DataSeriesViewItem dataSeriesViewItem in this.ltvDataSeries.SelectedItems)
        dataSeriesViewItem.DataSeries.Clear();
      this.InitDataSeriesList();
      this.InitDataSeriesViewer();
      this.InitChart();
    }

    private void ctxDataSeries_Delete_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show((IWin32Window) this, "Are you sure to delete selected series?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      foreach (DataSeriesViewItem dataSeriesViewItem in this.ltvDataSeries.SelectedItems)
        DataManager.DeleteDataSeries(dataSeriesViewItem.DataSeries.Name);
      this.InitDataSeriesList();
      this.InitDataSeriesViewer();
      this.InitChart();
    }

    private void ctxDataSeries_New_Bar_DropDownOpening(object sender, EventArgs e)
    {
      this.ctxDataSeries_New_Bar.DropDownItems.Clear();
      this.ctxDataSeries_New_Bar.DropDownItems.AddRange(new ToolStripItem[13]
      {
        (ToolStripItem) new BarSeriesMenuItem((BarType) 1, 60L),
        (ToolStripItem) new BarSeriesMenuItem((BarType) 1, 300L),
        (ToolStripItem) new BarSeriesMenuItem((BarType) 1, 600L),
        (ToolStripItem) new BarSeriesMenuItem((BarType) 1, 1800L),
        (ToolStripItem) new ToolStripSeparator(),
        (ToolStripItem) new BarSeriesMenuItem((BarType) 1, 3600L),
        (ToolStripItem) new BarSeriesMenuItem((BarType) 1, 10800L),
        (ToolStripItem) new BarSeriesMenuItem((BarType) 1, 21600L),
        (ToolStripItem) new ToolStripSeparator(),
        (ToolStripItem) new BarSeriesMenuItem((BarType) 2, 50L),
        (ToolStripItem) new BarSeriesMenuItem((BarType) 2, 100L),
        (ToolStripItem) new ToolStripSeparator(),
        (ToolStripItem) new CustomBarSeriesMenuItem()
      });
    }

    private void ctxDataSeries_New_Bar_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
      BarSeriesMenuItem barSeriesMenuItem = (BarSeriesMenuItem) e.ClickedItem;
      this.ctxDataSeries.Close();
      if (!barSeriesMenuItem.CreateSeries)
        return;
      this.NewDataSeries(barSeriesMenuItem.BarType, barSeriesMenuItem.BarSize);
    }

    private void ctxDataSeries_New_Daily_Click(object sender, EventArgs e)
    {
      this.NewDataSeries("Daily");
    }

    private void ctxDataSeries_New_Trade_Click(object sender, EventArgs e)
    {
      this.NewDataSeries("Trade");
    }

    private void ctxDataSeries_New_Quote_Click(object sender, EventArgs e)
    {
      this.NewDataSeries("Quote");
    }

    private void NewDataSeries(string seriesSuffix)
    {
      if (this.instrument.GetDataSeries(seriesSuffix) == null)
      {
        this.instrument.AddDataSeries(seriesSuffix);
        this.InitDataSeriesList();
        this.InitDataSeriesViewer();
        this.InitChart();
      }
      else
      {
        int num = (int) MessageBox.Show((IWin32Window) this, "The series already exists.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private void NewDataSeries(BarType barType, long barSize)
    {
      this.NewDataSeries(string.Format("{0}{1}{2}{1}{3}", (object) "Bar", (object) '.', (object) barType, (object) barSize));
    }
  }
}

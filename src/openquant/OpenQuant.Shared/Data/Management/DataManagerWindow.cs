using OpenQuant.Shared;
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
using TD.SandDock;

namespace OpenQuant.Shared.Data.Management
{
  public class DataManagerWindow : FreeQuant.Docking.WinForms.DockControl
  {
    private IContainer components;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private TreeView trvDataTypes;
    private Splitter splitter1;
    private System.Windows.Forms.TabControl tabControl2;
    private System.Windows.Forms.TabPage tabDataSeries;
    private ListView ltvDataSeries;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ImageList imgDataTypes;
    private ImageList imgDataSeries;
    private ToolStrip toolStrip;
    private ToolStripButton tsbRefresh;
    private ContextMenuStrip ctxDataSeries;
    private ToolStripMenuItem ctxDataSeries_Export;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem ctxDataSeries_Clear;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem ctxDataSeries_Delete;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem ctxDataSeries_CompressBars;
    private SortedList<DataTypeItem, List<InstrumentDataSeries>> seriesLists;
    private DataSeriesViewItemComparer itemComparer;

    public DataManagerWindow()
    {
      this.InitializeComponent();
      this.seriesLists = new SortedList<DataTypeItem, List<InstrumentDataSeries>>((IComparer<DataTypeItem>) new DataTypeItemComparer());
      this.itemComparer = new DataSeriesViewItemComparer();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (DataManagerWindow));
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.trvDataTypes = new TreeView();
      this.imgDataTypes = new ImageList(this.components);
      this.splitter1 = new Splitter();
      this.tabControl2 = new System.Windows.Forms.TabControl();
      this.tabDataSeries = new System.Windows.Forms.TabPage();
      this.ltvDataSeries = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.ctxDataSeries = new ContextMenuStrip(this.components);
      this.ctxDataSeries_Export = new ToolStripMenuItem();
      this.toolStripSeparator3 = new ToolStripSeparator();
      this.ctxDataSeries_CompressBars = new ToolStripMenuItem();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.ctxDataSeries_Clear = new ToolStripMenuItem();
      this.toolStripSeparator2 = new ToolStripSeparator();
      this.ctxDataSeries_Delete = new ToolStripMenuItem();
      this.imgDataSeries = new ImageList(this.components);
      this.toolStrip = new ToolStrip();
      this.tsbRefresh = new ToolStripButton();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabControl2.SuspendLayout();
      this.tabDataSeries.SuspendLayout();
      this.ctxDataSeries.SuspendLayout();
      this.toolStrip.SuspendLayout();
      this.SuspendLayout();
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Dock = DockStyle.Left;
      this.tabControl1.Location = new Point(0, 25);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(140, 375);
      this.tabControl1.TabIndex = 0;
      this.tabPage1.Controls.Add((Control) this.trvDataTypes);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(132, 349);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Data Type";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.trvDataTypes.Dock = DockStyle.Fill;
      this.trvDataTypes.HideSelection = false;
      this.trvDataTypes.ImageIndex = 0;
      this.trvDataTypes.ImageList = this.imgDataTypes;
      this.trvDataTypes.Location = new Point(3, 3);
      this.trvDataTypes.Name = "trvDataTypes";
      this.trvDataTypes.SelectedImageIndex = 0;
      this.trvDataTypes.ShowLines = false;
      this.trvDataTypes.ShowRootLines = false;
      this.trvDataTypes.Size = new Size(126, 343);
      this.trvDataTypes.TabIndex = 0;
      this.trvDataTypes.AfterSelect += new TreeViewEventHandler(this.trvDataTypes_AfterSelect);
      this.trvDataTypes.MouseDown += new MouseEventHandler(this.trvDataTypes_MouseDown);
      this.imgDataTypes.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imgDataTypes.ImageStream");
      this.imgDataTypes.TransparentColor = Color.Transparent;
      this.imgDataTypes.Images.SetKeyName(0, "data_type.png");
      this.splitter1.Location = new Point(140, 25);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new Size(4, 375);
      this.splitter1.TabIndex = 1;
      this.splitter1.TabStop = false;
      this.tabControl2.Controls.Add((Control) this.tabDataSeries);
      this.tabControl2.Dock = DockStyle.Fill;
      this.tabControl2.Location = new Point(144, 25);
      this.tabControl2.Name = "tabControl2";
      this.tabControl2.SelectedIndex = 0;
      this.tabControl2.Size = new Size(448, 375);
      this.tabControl2.TabIndex = 2;
      this.tabDataSeries.Controls.Add((Control) this.ltvDataSeries);
      this.tabDataSeries.Location = new Point(4, 22);
      this.tabDataSeries.Name = "tabDataSeries";
      this.tabDataSeries.Padding = new Padding(3);
      this.tabDataSeries.Size = new Size(440, 349);
      this.tabDataSeries.TabIndex = 0;
      this.tabDataSeries.Text = "Data Series";
      this.tabDataSeries.UseVisualStyleBackColor = true;
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
      this.ltvDataSeries.Location = new Point(3, 3);
      this.ltvDataSeries.Name = "ltvDataSeries";
      this.ltvDataSeries.ShowItemToolTips = true;
      this.ltvDataSeries.Size = new Size(434, 343);
      this.ltvDataSeries.SmallImageList = this.imgDataSeries;
      this.ltvDataSeries.TabIndex = 0;
      this.ltvDataSeries.UseCompatibleStateImageBehavior = false;
      this.ltvDataSeries.View = View.Details;
      this.ltvDataSeries.ColumnClick += new ColumnClickEventHandler(this.ltvDataSeries_ColumnClick);
      this.ltvDataSeries.ColumnWidthChanged += new ColumnWidthChangedEventHandler(this.ltvDataSeries_ColumnWidthChanged);
      this.columnHeader1.Text = "Instrument";
      this.columnHeader1.Width = 79;
      this.columnHeader2.Text = "Count";
      this.columnHeader2.TextAlign = HorizontalAlignment.Right;
      this.columnHeader2.Width = 86;
      this.columnHeader3.Text = "First DateTime";
      this.columnHeader3.TextAlign = HorizontalAlignment.Right;
      this.columnHeader3.Width = 114;
      this.columnHeader4.Text = "Last DateTime";
      this.columnHeader4.TextAlign = HorizontalAlignment.Right;
      this.columnHeader4.Width = 118;
      this.ctxDataSeries.Items.AddRange(new ToolStripItem[7]
      {
        (ToolStripItem) this.ctxDataSeries_Export,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.ctxDataSeries_CompressBars,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.ctxDataSeries_Clear,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.ctxDataSeries_Delete
      });
      this.ctxDataSeries.Name = "ctxDataSeries";
      this.ctxDataSeries.Size = new Size(169, 132);
      this.ctxDataSeries.Opening += new CancelEventHandler(this.ctxDataSeries_Opening);
      this.ctxDataSeries_Export.Image = (Image) Resources.csv;
      this.ctxDataSeries_Export.Name = "ctxDataSeries_Export";
      this.ctxDataSeries_Export.Size = new Size(168, 22);
      this.ctxDataSeries_Export.Text = "Export To CSV...";
      this.ctxDataSeries_Export.Click += new EventHandler(this.ctxDataSeries_Export_Click);
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new Size(165, 6);
      this.ctxDataSeries_CompressBars.Name = "ctxDataSeries_CompressBars";
      this.ctxDataSeries_CompressBars.Size = new Size(168, 22);
      this.ctxDataSeries_CompressBars.Text = "Compress Bars...";
      this.ctxDataSeries_CompressBars.Click += new EventHandler(this.ctxDataSeries_CompressBars_Click);
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(165, 6);
      this.ctxDataSeries_Clear.Image = (Image) Resources.clear;
      this.ctxDataSeries_Clear.Name = "ctxDataSeries_Clear";
      this.ctxDataSeries_Clear.Size = new Size(168, 22);
      this.ctxDataSeries_Clear.Text = "Clear";
      this.ctxDataSeries_Clear.Click += new EventHandler(this.ctxDataSeries_Clear_Click);
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new Size(165, 6);
      this.ctxDataSeries_Delete.Image = (Image) Resources.delete;
      this.ctxDataSeries_Delete.Name = "ctxDataSeries_Delete";
      this.ctxDataSeries_Delete.Size = new Size(168, 22);
      this.ctxDataSeries_Delete.Text = "Delete";
      this.ctxDataSeries_Delete.Click += new EventHandler(this.ctxDataSeries_Delete_Click);
      this.imgDataSeries.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imgDataSeries.ImageStream");
      this.imgDataSeries.TransparentColor = Color.Transparent;
      this.imgDataSeries.Images.SetKeyName(0, "data.png");
      this.toolStrip.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.tsbRefresh
      });
      this.toolStrip.Location = new Point(0, 0);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new Size(592, 25);
      this.toolStrip.TabIndex = 3;
      this.toolStrip.Text = "toolStrip1";
      this.tsbRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbRefresh.Image = (Image) Resources.refresh;
      this.tsbRefresh.ImageTransparentColor = Color.Magenta;
      this.tsbRefresh.Name = "tsbRefresh";
      this.tsbRefresh.Size = new Size(23, 22);
      this.tsbRefresh.Text = "Refresh";
      this.tsbRefresh.Click += new EventHandler(this.tsbRefresh_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.tabControl2);
      this.Controls.Add((Control) this.splitter1);
      this.Controls.Add((Control) this.tabControl1);
      this.Controls.Add((Control) this.toolStrip);
      this.DefaultDockLocation = ContainerDockLocation.Center;
      this.FloatingSize = new Size(550, 400);
      this.Name = "DataManagerWindow";
      this.Size = new Size(592, 400);
      this.TabImage = (Image) Resources.data;
      this.Text = "Data Manager";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabControl2.ResumeLayout(false);
      this.tabDataSeries.ResumeLayout(false);
      this.ctxDataSeries.ResumeLayout(false);
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    protected override void OnInit()
    {
      this.LoadLayout();
      this.Init();
    }

    private void trvDataTypes_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Right)
        return;
      this.trvDataTypes.SelectedNode = this.trvDataTypes.GetNodeAt(e.Location);
    }

    private void trvDataTypes_AfterSelect(object sender, TreeViewEventArgs e)
    {
      DataTypeNode dataTypeNode = this.trvDataTypes.SelectedNode as DataTypeNode;
      if (dataTypeNode == null)
        this.UpdateDataSeriesList((DataTypeItem) null);
      else
        this.UpdateDataSeriesList(dataTypeNode.Item);
    }

    private void tsbRefresh_Click(object sender, EventArgs e)
    {
      this.Init();
    }

    private void ctxDataSeries_Opening(object sender, CancelEventArgs e)
    {
      if (this.ltvDataSeries.SelectedItems.Count == 0)
      {
        this.ctxDataSeries_Export.Enabled = false;
        this.ctxDataSeries_CompressBars.Enabled = false;
        this.ctxDataSeries_Clear.Enabled = false;
        this.ctxDataSeries_Delete.Enabled = false;
      }
      else
      {
        DataType dataType = (this.ltvDataSeries.SelectedItems[0] as InstrumentDataSeriesViewItem).Series.DataTypeItem.DataType;
        this.ctxDataSeries_Export.Enabled = dataType != DataType.MarketDepth;
        this.ctxDataSeries_CompressBars.Enabled = dataType != DataType.Daily && dataType != DataType.MarketDepth;
        this.ctxDataSeries_Clear.Enabled = true;
        this.ctxDataSeries_Delete.Enabled = true;
      }
    }

    private void ctxDataSeries_Export_Click(object sender, EventArgs e)
    {
      List<IDataSeries> list = new List<IDataSeries>();
      foreach (InstrumentDataSeriesViewItem dataSeriesViewItem in this.ltvDataSeries.SelectedItems)
        list.Add(dataSeriesViewItem.Series.DataSeries);
      DataSeriesExportForm seriesExportForm = new DataSeriesExportForm();
      seriesExportForm.Init(list.ToArray());
      int num = (int) seriesExportForm.ShowDialog((IWin32Window) this);
      seriesExportForm.Dispose();
    }

    private void ctxDataSeries_CompressBars_Click(object sender, EventArgs e)
    {
      List<IDataSeries> list = new List<IDataSeries>();
      foreach (InstrumentDataSeriesViewItem dataSeriesViewItem in this.ltvDataSeries.SelectedItems)
        list.Add(dataSeriesViewItem.Series.DataSeries);
      CompressBarsForm compressBarsForm = new CompressBarsForm();
      compressBarsForm.Init(list.ToArray(), true);
      int num = (int) compressBarsForm.ShowDialog((IWin32Window) this);
      compressBarsForm.Dispose();
    }

    private void ctxDataSeries_Clear_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show((IWin32Window) this, "Are you sure to clear selected series?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      foreach (InstrumentDataSeriesViewItem dataSeriesViewItem in this.ltvDataSeries.SelectedItems)
      {
        dataSeriesViewItem.Series.DataSeries.Clear();
        dataSeriesViewItem.UpdateValues();
      }
    }

    private void ctxDataSeries_Delete_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show((IWin32Window) this, "Are you sure to delete selected series?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      foreach (InstrumentDataSeriesViewItem dataSeriesViewItem in this.ltvDataSeries.SelectedItems)
      {
        DataManager.DeleteDataSeries(dataSeriesViewItem.Series.DataSeries.Name);
        dataSeriesViewItem.Remove();
        List<InstrumentDataSeries> list = this.seriesLists[dataSeriesViewItem.Series.DataTypeItem];
        list.Remove(dataSeriesViewItem.Series);
        if (list.Count == 0)
        {
          foreach (DataTypeNode dataTypeNode in this.trvDataTypes.Nodes)
          {
            if (dataTypeNode.Item == dataSeriesViewItem.Series.DataTypeItem)
            {
              dataTypeNode.Remove();
              break;
            }
          }
        }
      }
    }

    private void ltvDataSeries_ColumnClick(object sender, ColumnClickEventArgs e)
    {
      this.itemComparer.SortByColumn(e.Column);
      this.ltvDataSeries.Sort();
    }

    private void ltvDataSeries_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
    {
      this.SaveLayout();
    }

    private void Init()
    {
      this.seriesLists.Clear();
      IEnumerator enumerator1 = DataManager.Server.GetDataSeries().GetEnumerator();
      try
      {
        while (enumerator1.MoveNext())
        {
          IDataSeries dataSeries = (IDataSeries) enumerator1.Current;
          DataSeriesInfo dataSeriesInfo = DataSeriesHelper.GetDataSeriesInfo(dataSeries.Name);
					Instrument instrument = InstrumentManager.Instruments[dataSeriesInfo.Symbol];
          if (instrument != null)
          {
            DataTypeItem dataTypeItem = (DataTypeItem) null;
            switch (dataSeriesInfo.DataType)
            {
              case DataType.Trade:
              case DataType.Quote:
              case DataType.Daily:
              case DataType.MarketDepth:
                dataTypeItem = new DataTypeItem(dataSeriesInfo.DataType);
                break;
              case DataType.Bar:
                dataTypeItem = (DataTypeItem) new BarDataTypeItem(dataSeriesInfo.BarType, dataSeriesInfo.BarSize);
                break;
            }
            if (dataTypeItem != null)
            {
              List<InstrumentDataSeries> list;
              if (!this.seriesLists.TryGetValue(dataTypeItem, out list))
              {
                list = new List<InstrumentDataSeries>();
                this.seriesLists.Add(dataTypeItem, list);
              }
              list.Add(new InstrumentDataSeries(instrument, dataSeries, dataTypeItem));
            }
          }
        }
      }
      finally
      {
        IDisposable disposable = enumerator1 as IDisposable;
        if (disposable != null)
          disposable.Dispose();
      }
      string str = this.trvDataTypes.SelectedNode == null ? (string) null : this.trvDataTypes.SelectedNode.Text;
      HashSet<string> hashSet = new HashSet<string>();
      foreach (ListViewItem listViewItem in this.ltvDataSeries.SelectedItems)
        hashSet.Add(listViewItem.Text);
      this.trvDataTypes.BeginUpdate();
      this.trvDataTypes.Nodes.Clear();
      foreach (DataTypeItem dataTypeItem in (IEnumerable<DataTypeItem>) this.seriesLists.Keys)
        this.trvDataTypes.Nodes.Add((TreeNode) new DataTypeNode(dataTypeItem));
      this.trvDataTypes.EndUpdate();
      this.UpdateDataSeriesList((DataTypeItem) null);
      if (str == null)
        return;
      foreach (TreeNode treeNode in this.trvDataTypes.Nodes)
      {
        if (treeNode.Text == str)
        {
          this.trvDataTypes.SelectedNode = treeNode;
          if (hashSet.Count <= 0)
            break;
          IEnumerator enumerator2 = this.ltvDataSeries.Items.GetEnumerator();
          try
          {
            while (enumerator2.MoveNext())
            {
              ListViewItem listViewItem = (ListViewItem) enumerator2.Current;
              if (hashSet.Contains(listViewItem.Text))
                listViewItem.Selected = true;
            }
            break;
          }
          finally
          {
            IDisposable disposable = enumerator2 as IDisposable;
            if (disposable != null)
              disposable.Dispose();
          }
        }
      }
    }

    private void UpdateDataSeriesList(DataTypeItem item)
    {
      this.Cursor = Cursors.WaitCursor;
      this.ltvDataSeries.BeginUpdate();
      this.ltvDataSeries.Items.Clear();
      this.ltvDataSeries.Groups.Clear();
      this.ltvDataSeries.ListViewItemSorter = (IComparer) null;
      if (item == null)
      {
        this.tabDataSeries.ResetText();
      }
      else
      {
        List<InstrumentDataSeries> list = this.seriesLists[item];
        foreach (InstrumentDataSeries series in list)
        {
          ListViewItem listViewItem = (ListViewItem) new InstrumentDataSeriesViewItem(series);
          this.ltvDataSeries.Items.Add(listViewItem);
          ListViewGroup group = this.ltvDataSeries.Groups[((FIXInstrument) series.Instrument).SecurityType];
          if (group == null)
          {
            group = new ListViewGroup(((FIXInstrument) series.Instrument).SecurityType, (APITypeConverter.InstrumentType.Convert(((FIXInstrument) series.Instrument).SecurityType)).ToString());
            this.ltvDataSeries.Groups.Add(group);
          }
          listViewItem.Group = group;
        }
        this.tabDataSeries.Text = string.Format("{0} - {1:n0} instruments", (object) item, (object) list.Count);
      }
      this.ltvDataSeries.ListViewItemSorter = (IComparer) this.itemComparer;
      this.ltvDataSeries.EndUpdate();
      this.Cursor = Cursors.Default;
    }

    private void SaveLayout()
    {
      List<int> list = new List<int>();
      foreach (ColumnHeader columnHeader in this.ltvDataSeries.Columns)
        list.Add(columnHeader.Width);
      this.Settings.SetValue("columns.width", list.ToArray());
    }

    private void LoadLayout()
    {
      int[] int32ArrayValue = this.Settings.GetInt32ArrayValue("columns.width", new int[0]);
      for (int index = 0; index < int32ArrayValue.Length && index < this.ltvDataSeries.Columns.Count; ++index)
        this.ltvDataSeries.Columns[index].Width = int32ArrayValue[index];
    }
  }
}

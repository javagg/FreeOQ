using OpenQuant.Shared;
using OpenQuant.Shared.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace OpenQuant.Shared.Logs
{
  class StrategyMonitorControl : UserControl, ITimerItem
  {
    private IContainer components;
    private ImageList imgStrategies;
    private DataGridView dgvStrategies;
    private Splitter splitter1;
    private ContextMenuStrip ctxFirstColumn;
    private TabControl tabControl1;
    private TabPage tabInstruments;
    private DataGridView dgvInstruments;
    private Splitter splitter2;
    private TabControl tabControl2;
    private DataGridViewImageColumn _StrategyImage_;
    private DataGridViewTextBoxColumn _Strategy_;
    private DataGridViewImageColumn _InstrumentImage_;
    private DataGridViewTextBoxColumn _Instrument_;
    private TabPage tabData;
    private ToolStrip tstData;
    private ToolStripLabel lblDataViewMode;
    private ToolStripComboBox cbxDataViewMode;
    private ToolStripLabel lblColumnItem;
    private ToolStripComboBox cbxColumnItem;
    private DataGridView dgvData;
    private StrategyLogManager manager;
    private string solutionName;
    private Dictionary<string, DataGridViewRow> strategyRows;
    private Dictionary<string, DataGridViewRow> instrumentRows;
    private bool ignoreSelectionChangedEvent;
    private DataViewOptions dataViewOptions;
    private ILogDataSource logDataSource;

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

    public StrategyMonitorControl()
    {
      this.InitializeComponent();
      this.strategyRows = new Dictionary<string, DataGridViewRow>();
      this.instrumentRows = new Dictionary<string, DataGridViewRow>();
      this.ignoreSelectionChangedEvent = false;
      this.dataViewOptions = new DataViewOptions();
      this.logDataSource = (ILogDataSource) null;
      this._Strategy_.HeaderCell.ContextMenuStrip = this.ctxFirstColumn;
      this._Strategy_.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
      this._StrategyImage_.HeaderCell.ContextMenuStrip = this.ctxFirstColumn;
      this._Instrument_.HeaderCell.ContextMenuStrip = this.ctxFirstColumn;
      this._Instrument_.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
      this._InstrumentImage_.HeaderCell.ContextMenuStrip = this.ctxFirstColumn;
      Dictionary<string, DataViewMode> dictionary = new Dictionary<string, DataViewMode>();
      dictionary.Add("Row history", DataViewMode.RowHistory);
      dictionary.Add("Column history", DataViewMode.ColumnHistory);
      dictionary.Add("Cross monitor", DataViewMode.CrossMonitor);
      this.cbxDataViewMode.ComboBox.DisplayMember = "Key";
      this.cbxDataViewMode.ComboBox.ValueMember = "Value";
      this.cbxDataViewMode.ComboBox.DataSource = (object) new BindingSource((object) dictionary, (string) null);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (StrategyMonitorControl));
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle6 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle7 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle8 = new DataGridViewCellStyle();
      this.imgStrategies = new ImageList(this.components);
      this.dgvStrategies = new DataGridView();
      this._StrategyImage_ = new DataGridViewImageColumn();
      this._Strategy_ = new DataGridViewTextBoxColumn();
      this.splitter1 = new Splitter();
      this.ctxFirstColumn = new ContextMenuStrip(this.components);
      this.tabControl1 = new TabControl();
      this.tabInstruments = new TabPage();
      this.dgvInstruments = new DataGridView();
      this._InstrumentImage_ = new DataGridViewImageColumn();
      this._Instrument_ = new DataGridViewTextBoxColumn();
      this.splitter2 = new Splitter();
      this.tabControl2 = new TabControl();
      this.tabData = new TabPage();
      this.dgvData = new DataGridView();
      this.tstData = new ToolStrip();
      this.lblDataViewMode = new ToolStripLabel();
      this.cbxDataViewMode = new ToolStripComboBox();
      this.lblColumnItem = new ToolStripLabel();
      this.cbxColumnItem = new ToolStripComboBox();
//      this.dgvStrategies.BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabInstruments.SuspendLayout();
//      this.dgvInstruments.BeginInit();
      this.tabControl2.SuspendLayout();
      this.tabData.SuspendLayout();
//      this.dgvData.BeginInit();
      this.tstData.SuspendLayout();
      this.SuspendLayout();
      this.imgStrategies.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imgStrategies.ImageStream");
      this.imgStrategies.TransparentColor = Color.Transparent;
      this.imgStrategies.Images.SetKeyName(0, "solution.png");
      this.imgStrategies.Images.SetKeyName(1, "strategy.png");
      this.dgvStrategies.AllowUserToAddRows = false;
      this.dgvStrategies.AllowUserToDeleteRows = false;
      this.dgvStrategies.AllowUserToOrderColumns = true;
      this.dgvStrategies.AllowUserToResizeRows = false;
      this.dgvStrategies.BackgroundColor = SystemColors.Window;
      this.dgvStrategies.BorderStyle = BorderStyle.None;
      this.dgvStrategies.CellBorderStyle = DataGridViewCellBorderStyle.None;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle1.BackColor = SystemColors.Control;
      gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      gridViewCellStyle1.ForeColor = SystemColors.WindowText;
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      this.dgvStrategies.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      this.dgvStrategies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvStrategies.Columns.AddRange((DataGridViewColumn) this._StrategyImage_, (DataGridViewColumn) this._Strategy_);
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle2.BackColor = SystemColors.Window;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      gridViewCellStyle2.ForeColor = SystemColors.ControlText;
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      this.dgvStrategies.DefaultCellStyle = gridViewCellStyle2;
      this.dgvStrategies.Dock = DockStyle.Top;
      this.dgvStrategies.Location = new Point(0, 0);
      this.dgvStrategies.MultiSelect = false;
      this.dgvStrategies.Name = "dgvStrategies";
      this.dgvStrategies.ReadOnly = true;
      this.dgvStrategies.RowHeadersVisible = false;
      this.dgvStrategies.RowTemplate.Height = 17;
      this.dgvStrategies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvStrategies.ShowCellErrors = false;
      this.dgvStrategies.ShowEditingIcon = false;
      this.dgvStrategies.ShowRowErrors = false;
      this.dgvStrategies.Size = new Size(579, 106);
      this.dgvStrategies.TabIndex = 0;
      this.dgvStrategies.ColumnDisplayIndexChanged += new DataGridViewColumnEventHandler(this.DataGridView_ColumnDisplayIndexChanged);
      this.dgvStrategies.ColumnStateChanged += new DataGridViewColumnStateChangedEventHandler(this.DataGridView_ColumnStateChanged);
      this.dgvStrategies.SelectionChanged += new EventHandler(this.DataGridView_SelectionChanged);
      this.dgvStrategies.MouseUp += new MouseEventHandler(this.DataGridView_MouseUp);
      this._StrategyImage_.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
      this._StrategyImage_.Frozen = true;
      this._StrategyImage_.HeaderText = " ";
      this._StrategyImage_.Name = "_StrategyImage_";
      this._StrategyImage_.ReadOnly = true;
      this._StrategyImage_.Resizable = DataGridViewTriState.False;
      this._StrategyImage_.Width = 5;
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
      this._Strategy_.DefaultCellStyle = gridViewCellStyle3;
      this._Strategy_.Frozen = true;
      this._Strategy_.HeaderText = "Strategy";
      this._Strategy_.Name = "_Strategy_";
      this._Strategy_.ReadOnly = true;
      this._Strategy_.Resizable = DataGridViewTriState.True;
      this._Strategy_.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.splitter1.Dock = DockStyle.Top;
      this.splitter1.Location = new Point(0, 106);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new Size(579, 4);
      this.splitter1.TabIndex = 1;
      this.splitter1.TabStop = false;
      this.ctxFirstColumn.Name = "ctxFirstColumn";
      this.ctxFirstColumn.Size = new Size(61, 4);
      this.ctxFirstColumn.Opening += new CancelEventHandler(this.ctxFirstColumn_Opening);
      this.tabControl1.Controls.Add((Control) this.tabInstruments);
      this.tabControl1.Dock = DockStyle.Top;
      this.tabControl1.Location = new Point(0, 110);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(579, 139);
      this.tabControl1.TabIndex = 2;
      this.tabInstruments.Controls.Add((Control) this.dgvInstruments);
      this.tabInstruments.Location = new Point(4, 22);
      this.tabInstruments.Name = "tabInstruments";
      this.tabInstruments.Padding = new Padding(3);
      this.tabInstruments.Size = new Size(571, 113);
      this.tabInstruments.TabIndex = 0;
      this.tabInstruments.UseVisualStyleBackColor = true;
      this.dgvInstruments.AllowUserToAddRows = false;
      this.dgvInstruments.AllowUserToDeleteRows = false;
      this.dgvInstruments.AllowUserToOrderColumns = true;
      this.dgvInstruments.AllowUserToResizeRows = false;
      this.dgvInstruments.BackgroundColor = SystemColors.Window;
      this.dgvInstruments.BorderStyle = BorderStyle.None;
      this.dgvInstruments.CellBorderStyle = DataGridViewCellBorderStyle.None;
      gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle4.BackColor = SystemColors.Control;
      gridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      gridViewCellStyle4.ForeColor = SystemColors.WindowText;
      gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle4.WrapMode = DataGridViewTriState.True;
      this.dgvInstruments.ColumnHeadersDefaultCellStyle = gridViewCellStyle4;
      this.dgvInstruments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvInstruments.Columns.AddRange((DataGridViewColumn) this._InstrumentImage_, (DataGridViewColumn) this._Instrument_);
      gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle5.BackColor = SystemColors.Window;
      gridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      gridViewCellStyle5.ForeColor = SystemColors.ControlText;
      gridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle5.WrapMode = DataGridViewTriState.False;
      this.dgvInstruments.DefaultCellStyle = gridViewCellStyle5;
      this.dgvInstruments.Dock = DockStyle.Fill;
      this.dgvInstruments.Location = new Point(3, 3);
      this.dgvInstruments.MultiSelect = false;
      this.dgvInstruments.Name = "dgvInstruments";
      this.dgvInstruments.ReadOnly = true;
      this.dgvInstruments.RowHeadersVisible = false;
      this.dgvInstruments.RowTemplate.Height = 17;
      this.dgvInstruments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvInstruments.ShowCellErrors = false;
      this.dgvInstruments.ShowEditingIcon = false;
      this.dgvInstruments.ShowRowErrors = false;
      this.dgvInstruments.Size = new Size(565, 107);
      this.dgvInstruments.TabIndex = 3;
      this.dgvInstruments.ColumnDisplayIndexChanged += new DataGridViewColumnEventHandler(this.DataGridView_ColumnDisplayIndexChanged);
      this.dgvInstruments.ColumnStateChanged += new DataGridViewColumnStateChangedEventHandler(this.DataGridView_ColumnStateChanged);
      this.dgvInstruments.SelectionChanged += new EventHandler(this.DataGridView_SelectionChanged);
      this.dgvInstruments.MouseUp += new MouseEventHandler(this.DataGridView_MouseUp);
      this._InstrumentImage_.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
      this._InstrumentImage_.Frozen = true;
      this._InstrumentImage_.HeaderText = " ";
      this._InstrumentImage_.Image = (Image) Resources.instrument;
      this._InstrumentImage_.Name = "_InstrumentImage_";
      this._InstrumentImage_.ReadOnly = true;
      this._InstrumentImage_.Resizable = DataGridViewTriState.False;
      this._InstrumentImage_.Width = 5;
      gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
      this._Instrument_.DefaultCellStyle = gridViewCellStyle6;
      this._Instrument_.Frozen = true;
      this._Instrument_.HeaderText = "Instrument";
      this._Instrument_.Name = "_Instrument_";
      this._Instrument_.ReadOnly = true;
      this._Instrument_.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.splitter2.Dock = DockStyle.Top;
      this.splitter2.Location = new Point(0, 249);
      this.splitter2.Name = "splitter2";
      this.splitter2.Size = new Size(579, 4);
      this.splitter2.TabIndex = 3;
      this.splitter2.TabStop = false;
      this.tabControl2.Controls.Add((Control) this.tabData);
      this.tabControl2.Dock = DockStyle.Fill;
      this.tabControl2.Location = new Point(0, 253);
      this.tabControl2.Name = "tabControl2";
      this.tabControl2.SelectedIndex = 0;
      this.tabControl2.Size = new Size(579, 235);
      this.tabControl2.TabIndex = 4;
      this.tabData.Controls.Add((Control) this.dgvData);
      this.tabData.Controls.Add((Control) this.tstData);
      this.tabData.Location = new Point(4, 22);
      this.tabData.Name = "tabData";
      this.tabData.Size = new Size(571, 209);
      this.tabData.TabIndex = 2;
      this.tabData.UseVisualStyleBackColor = true;
      this.dgvData.AllowUserToAddRows = false;
      this.dgvData.AllowUserToDeleteRows = false;
      this.dgvData.AllowUserToResizeRows = false;
      this.dgvData.BackgroundColor = SystemColors.Window;
      this.dgvData.BorderStyle = BorderStyle.None;
      this.dgvData.CellBorderStyle = DataGridViewCellBorderStyle.None;
      gridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle7.BackColor = SystemColors.Control;
      gridViewCellStyle7.ForeColor = SystemColors.WindowText;
      gridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle7.WrapMode = DataGridViewTriState.True;
      this.dgvData.ColumnHeadersDefaultCellStyle = gridViewCellStyle7;
      this.dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      gridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle8.BackColor = SystemColors.Window;
      gridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      gridViewCellStyle8.ForeColor = SystemColors.ControlText;
      gridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle8.WrapMode = DataGridViewTriState.False;
      this.dgvData.DefaultCellStyle = gridViewCellStyle8;
      this.dgvData.Dock = DockStyle.Fill;
      this.dgvData.Location = new Point(0, 25);
      this.dgvData.Name = "dgvData";
      this.dgvData.ReadOnly = true;
      this.dgvData.RowHeadersVisible = false;
      this.dgvData.RowTemplate.Height = 17;
      this.dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvData.ShowCellErrors = false;
      this.dgvData.ShowEditingIcon = false;
      this.dgvData.ShowRowErrors = false;
      this.dgvData.Size = new Size(571, 184);
      this.dgvData.TabIndex = 1;
      this.dgvData.VirtualMode = true;
      this.dgvData.CellValueNeeded += new DataGridViewCellValueEventHandler(this.dgvData_CellValueNeeded);
      this.tstData.GripStyle = ToolStripGripStyle.Hidden;
      this.tstData.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.lblDataViewMode,
        (ToolStripItem) this.cbxDataViewMode,
        (ToolStripItem) this.lblColumnItem,
        (ToolStripItem) this.cbxColumnItem
      });
      this.tstData.Location = new Point(0, 0);
      this.tstData.Name = "tstData";
      this.tstData.Size = new Size(571, 25);
      this.tstData.TabIndex = 0;
      this.tstData.Text = "toolStrip2";
      this.lblDataViewMode.Name = "lblDataViewMode";
      this.lblDataViewMode.Size = new Size(32, 22);
      this.lblDataViewMode.Text = "View";
      this.cbxDataViewMode.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxDataViewMode.Name = "cbxDataViewMode";
      this.cbxDataViewMode.Size = new Size(121, 25);
      this.cbxDataViewMode.SelectedIndexChanged += new EventHandler(this.cbxDataViewMode_SelectedIndexChanged);
      this.lblColumnItem.Name = "lblColumnItem";
      this.lblColumnItem.Size = new Size(50, 22);
      this.lblColumnItem.Text = "Column";
      this.cbxColumnItem.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxColumnItem.DropDownWidth = 200;
      this.cbxColumnItem.Name = "cbxColumnItem";
      this.cbxColumnItem.Size = new Size(160, 25);
      this.cbxColumnItem.SelectedIndexChanged += new EventHandler(this.cbxColumnItem_SelectedIndexChanged);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.tabControl2);
      this.Controls.Add((Control) this.splitter2);
      this.Controls.Add((Control) this.tabControl1);
      this.Controls.Add((Control) this.splitter1);
      this.Controls.Add((Control) this.dgvStrategies);
      this.Name = "StrategyMonitorControl";
      this.Size = new Size(579, 488);
//      this.dgvStrategies.EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabInstruments.ResumeLayout(false);
//      this.dgvInstruments.EndInit();
      this.tabControl2.ResumeLayout(false);
      this.tabData.ResumeLayout(false);
      this.tabData.PerformLayout();
//      this.dgvData.EndInit();
      this.tstData.ResumeLayout(false);
      this.tstData.PerformLayout();
      this.ResumeLayout(false);
    }

    public void Init(StrategyLogManager manager, string solutionName)
    {
      this.manager = manager;
      this.solutionName = solutionName;
      lock (manager.SyncRoot)
      {
        foreach (StrategyLogList item_1 in manager.LogLists)
        {
          foreach (StrategyLog item_0 in item_1.Logs)
          {
            this.Add(item_0);
            if (item_0.Count > 0)
              this.Add(item_0.Last);
          }
        }
        manager.Cleared += new EventHandler(this.manager_Cleared);
        manager.LogAdded += new EventHandler<StrategyLogEventArgs>(this.manager_LogAdded);
        manager.LogItemAdded += new EventHandler<StrategyLogItemEventArgs>(this.manager_LogItemAdded);
        this.cbxDataViewMode_SelectedIndexChanged((object) this.cbxDataViewMode, EventArgs.Empty);
      }
      Global.TimerManager.Start((ITimerItem) this);
    }

    public void Detach()
    {
      Global.TimerManager.Stop((ITimerItem) this);
      lock (this.manager.SyncRoot)
      {
        this.manager.Cleared -= new EventHandler(this.manager_Cleared);
        this.manager.LogAdded -= new EventHandler<StrategyLogEventArgs>(this.manager_LogAdded);
        this.manager.LogItemAdded -= new EventHandler<StrategyLogItemEventArgs>(this.manager_LogItemAdded);
      }
    }

    private void manager_Cleared(object sender, EventArgs e)
    {
			this.Invoke((Action) (() =>
      {
        this.ResetStrategies();
        this.ResetInstruments();
        this.ResetData();
        this.dataViewOptions.StrategyName = (string) null;
        this.dataViewOptions.Symbol = (string) null;
      }));
    }

    private void manager_LogAdded(object sender, StrategyLogEventArgs e)
    {
			this.Invoke((Action) (() => this.Add(e.Log)));
    }

    private void manager_LogItemAdded(object sender, StrategyLogItemEventArgs e)
    {
      this.Add(e.Item);
    }

    private void ctxFirstColumn_Opening(object sender, CancelEventArgs e)
    {
      this.ctxFirstColumn.Items.Clear();
      foreach (DataGridViewColumn dataGridViewColumn in (IEnumerable<DataGridViewColumn>) this.GetColumns((DataGridView) this.ctxFirstColumn.SourceControl))
      {
        ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
        toolStripMenuItem.Text = dataGridViewColumn.HeaderText;
        toolStripMenuItem.Checked = dataGridViewColumn.Visible;
        toolStripMenuItem.Tag = (object) dataGridViewColumn;
        toolStripMenuItem.Click += new EventHandler(this.ctxFirstColumnItem_Click);
        this.ctxFirstColumn.Items.Add((ToolStripItem) toolStripMenuItem);
      }
      e.Cancel = this.ctxFirstColumn.Items.Count == 0;
    }

    private void ctxFirstColumnItem_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem) sender;
      ((DataGridViewBand) toolStripMenuItem.Tag).Visible = !toolStripMenuItem.Checked;
    }

    private void ctxColumn_Hide_Click(object sender, EventArgs e)
    {
      ((DataGridViewBand) ((ToolStripItem) sender).Tag).Visible = false;
    }

    private void DataGridView_ColumnDisplayIndexChanged(object sender, DataGridViewColumnEventArgs e)
    {
      DataGridViewColumn column = e.Column;
      if (column.Index != 0 || column.DisplayIndex == 0)
        return;
      DataGridView dgv = (DataGridView) sender;
      MouseEventHandler handlerToRemove = (MouseEventHandler) null;
      MouseEventHandler mouseEventHandler = (MouseEventHandler) ((s, args) =>
      {
        dgv.MouseUp -= handlerToRemove;
        column.DisplayIndex = 0;
      });
      handlerToRemove = mouseEventHandler;
      dgv.MouseUp += mouseEventHandler;
    }

    private void DataGridView_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      DataGridView dataGridView = (DataGridView) sender;
      if (dataGridView.HitTest(e.X, e.Y).Type != DataGridViewHitTestType.None)
        return;
      dataGridView.ClearSelection();
      dataGridView.CurrentCell = (DataGridViewCell) null;
    }

    private void DataGridView_SelectionChanged(object sender, EventArgs e)
    {
      if (this.ignoreSelectionChangedEvent || !Monitor.TryEnter(this.manager.SyncRoot))
        return;
      this.ignoreSelectionChangedEvent = true;
      try
      {
        DataGridView dataGridView = (DataGridView) sender;
        if (dataGridView == this.dgvStrategies)
        {
          this.dataViewOptions.StrategyName = this.GetSelectedLogName(this.dgvStrategies);
          this.dataViewOptions.Symbol = (string) null;
        }
        if (dataGridView == this.dgvInstruments)
          this.dataViewOptions.Symbol = this.GetSelectedLogName(this.dgvInstruments);
        if (this.dataViewOptions.StrategyName == null)
        {
          this.ResetInstruments();
          this.tabInstruments.Text = string.Empty;
        }
        else
        {
          this.tabInstruments.Text = this.GetStrategyDisplayName(this.dataViewOptions.StrategyName);
          if (this.dataViewOptions.Symbol == null)
            this.ResetInstruments();
          foreach (StrategyLogList strategyLogList in this.manager.LogLists)
          {
            if (strategyLogList.StrategyName == this.dataViewOptions.StrategyName)
            {
              foreach (StrategyLog log in strategyLogList.Logs)
              {
                this.Add(log);
                if (log.Count > 0)
                  this.Add(log.Last);
              }
            }
          }
        }
        if (this.dataViewOptions.Mode != DataViewMode.RowHistory)
          return;
        this.DataSourceChanged();
      }
      finally
      {
        this.ignoreSelectionChangedEvent = false;
        Monitor.Exit(this.manager.SyncRoot);
      }
    }

    private void DataGridView_ColumnStateChanged(object sender, DataGridViewColumnStateChangedEventArgs e)
    {
      if (e.StateChanged != DataGridViewElementStates.Visible)
        return;
      ColumnItem columnItem = (ColumnItem) e.Column.Tag;
      if (e.Column.Visible)
      {
        this.AddColumnItem(columnItem);
      }
      else
      {
        bool flag = columnItem.Equals(this.cbxColumnItem.SelectedItem);
        this.cbxColumnItem.Items.Remove((object) columnItem);
        if (!flag)
          return;
        this.cbxColumnItem_SelectedIndexChanged((object) this.cbxColumnItem, EventArgs.Empty);
      }
    }

    private void dgvData_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
    {
      e.Value = this.logDataSource[e.RowIndex, e.ColumnIndex];
    }

    private void cbxDataViewMode_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.manager == null)
        return;
      if (!Monitor.TryEnter(this.manager.SyncRoot))
        return;
      try
      {
        DataViewMode dataViewMode = (DataViewMode) this.cbxDataViewMode.ComboBox.SelectedValue;
        if (dataViewMode == this.dataViewOptions.Mode)
          return;
        switch (dataViewMode)
        {
          case DataViewMode.RowHistory:
            this.lblColumnItem.Visible = false;
            this.cbxColumnItem.Visible = false;
            break;
          case DataViewMode.ColumnHistory:
            this.lblColumnItem.Visible = true;
            this.cbxColumnItem.Visible = true;
            break;
          case DataViewMode.CrossMonitor:
            this.lblColumnItem.Visible = true;
            this.cbxColumnItem.Visible = true;
            break;
        }
        this.dataViewOptions.Mode = dataViewMode;
        this.DataSourceChanged();
      }
      finally
      {
        Monitor.Exit(this.manager.SyncRoot);
      }
    }

    private void cbxColumnItem_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!Monitor.TryEnter(this.manager.SyncRoot))
        return;
      try
      {
        this.dataViewOptions.ColumnItem = (ColumnItem) this.cbxColumnItem.SelectedItem;
        this.DataSourceChanged();
      }
      finally
      {
        Monitor.Exit(this.manager.SyncRoot);
      }
    }

    private void DataSourceChanged()
    {
      this.ResetData();
      this.tabData.Text = string.Empty;
      switch (this.dataViewOptions.Mode)
      {
        case DataViewMode.RowHistory:
          if (this.dataViewOptions.StrategyName == null)
            break;
          IList<DataGridViewColumn> columns = this.GetColumns(this.dataViewOptions.Symbol == null ? this.dgvStrategies : this.dgvInstruments);
          DataGridViewColumn dataGridViewColumn1 = this.AddColumn(this.dgvData, ColumnType.Data, "DateTime", "_DateTime_");
          dataGridViewColumn1.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
          dataGridViewColumn1.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
          dataGridViewColumn1.Width = 120;
          this.logDataSource = (ILogDataSource) new LogDataSource<DateTime>();
          this.logDataSource.AddColumn(dataGridViewColumn1.HeaderText);
          foreach (DataGridViewColumn dataGridViewColumn2 in (IEnumerable<DataGridViewColumn>) columns)
          {
            if (dataGridViewColumn2.Visible)
            {
              this.AddColumn(this.dgvData, ColumnType.Data, dataGridViewColumn2.HeaderText);
              this.logDataSource.AddColumn(dataGridViewColumn2.HeaderText);
            }
          }
          foreach (StrategyLogList strategyLogList in this.manager.LogLists)
          {
            if (strategyLogList.StrategyName == this.dataViewOptions.StrategyName && (strategyLogList.Symbol == this.dataViewOptions.Symbol || strategyLogList.Symbol == string.Empty && this.dataViewOptions.Symbol == null))
            {
              foreach (StrategyLog strategyLog in strategyLogList.Logs)
              {
                foreach (StrategyLogItem strategyLogItem in strategyLog.Items)
                  this.logDataSource.Add((object) strategyLogItem.DateTime, strategyLog.Name, strategyLogItem.Value);
              }
            }
          }
          if (this.dataViewOptions.Symbol == null)
          {
            this.tabData.Text = this.GetStrategyDisplayName(this.dataViewOptions.StrategyName);
            break;
          }
          else
          {
            this.tabData.Text = string.Format("{0} [{1}]", (object) this.dataViewOptions.Symbol, (object) this.dataViewOptions.StrategyName);
            break;
          }
        case DataViewMode.ColumnHistory:
          ColumnItem columnItem1 = this.dataViewOptions.ColumnItem;
          if (columnItem1 == null)
            break;
          DataGridView dataGridView = columnItem1.Type == ColumnType.Strategy ? this.dgvStrategies : this.dgvInstruments;
          DataGridViewColumn dataGridViewColumn3 = this.AddColumn(this.dgvData, ColumnType.Data, "DateTime", "_DateTime_");
          dataGridViewColumn3.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
          dataGridViewColumn3.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
          dataGridViewColumn3.Width = 120;
          this.logDataSource = (ILogDataSource) new LogDataSource<DateTime>();
          this.logDataSource.AddColumn(dataGridViewColumn3.HeaderText);
          foreach (DataGridViewBand dataGridViewBand in (IEnumerable) dataGridView.Rows)
          {
            string str = (string) dataGridViewBand.Tag;
            this.AddColumn(this.dgvData, ColumnType.Data, columnItem1.Type == ColumnType.Strategy ? this.GetStrategyDisplayName(str) : str, str);
            this.logDataSource.AddColumn(str);
          }
          foreach (StrategyLogList strategyLogList in this.manager.LogLists)
          {
            if (columnItem1.Type == ColumnType.Strategy && strategyLogList.Symbol == string.Empty)
            {
              foreach (StrategyLog strategyLog in strategyLogList.Logs)
              {
                if (strategyLog.Name == columnItem1.Name)
                {
                  foreach (StrategyLogItem strategyLogItem in strategyLog.Items)
                    this.logDataSource.Add((object) strategyLogItem.DateTime, strategyLogList.StrategyName, strategyLogItem.Value);
                }
              }
            }
            if (columnItem1.Type == ColumnType.Instrument && strategyLogList.Symbol != string.Empty)
            {
              foreach (StrategyLog strategyLog in strategyLogList.Logs)
              {
                if (strategyLog.Name == columnItem1.Name)
                {
                  foreach (StrategyLogItem strategyLogItem in strategyLog.Items)
                    this.logDataSource.Add((object) strategyLogItem.DateTime, strategyLogList.Symbol, strategyLogItem.Value);
                }
              }
            }
          }
          this.tabData.Text = columnItem1.ToString();
          break;
        case DataViewMode.CrossMonitor:
          ColumnItem columnItem2 = this.dataViewOptions.ColumnItem;
          if (columnItem2 == null || columnItem2.Type != ColumnType.Instrument)
            break;
          this.logDataSource = (ILogDataSource) new LogDataSource<string>();
          DataGridViewColumn dataGridViewColumn4 = this.AddColumn(this.dgvData, ColumnType.Data, "Instrument", "_Instrument_");
          dataGridViewColumn4.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
          dataGridViewColumn4.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
          dataGridViewColumn4.Width = 80;
          this.logDataSource.AddColumn(dataGridViewColumn4.HeaderText);
          foreach (DataGridViewBand dataGridViewBand in (IEnumerable) this.dgvStrategies.Rows)
          {
            string str = (string) dataGridViewBand.Tag;
            if (str != string.Empty)
            {
              this.AddColumn(this.dgvData, ColumnType.Data, str);
              this.logDataSource.AddColumn(str);
            }
          }
          foreach (StrategyLogList strategyLogList in this.manager.LogLists)
          {
            if (strategyLogList.StrategyName != string.Empty && strategyLogList.Symbol != string.Empty)
            {
              foreach (StrategyLog strategyLog in strategyLogList.Logs)
              {
                if (strategyLog.Name == columnItem2.Name && strategyLog.Count > 0)
                  this.logDataSource.Add((object) strategyLogList.Symbol, strategyLogList.StrategyName, strategyLog.Last.Value);
              }
            }
          }
          this.tabData.Text = columnItem2.ToString();
          break;
      }
    }

    public void SetColumnLayout(ColumnLayoutInfo[] strategyColumns, ColumnLayoutInfo[] instrumentColumns)
    {
      foreach (ColumnLayoutInfo columnLayoutInfo in strategyColumns)
      {
        if (!this.dgvStrategies.Columns.Contains(columnLayoutInfo.ColumnName))
        {
          DataGridViewColumn dataGridViewColumn = this.AddColumn(this.dgvStrategies, ColumnType.Strategy, columnLayoutInfo.ColumnName);
          dataGridViewColumn.Width = columnLayoutInfo.Width;
          dataGridViewColumn.Visible = columnLayoutInfo.Visible;
        }
      }
      foreach (ColumnLayoutInfo columnLayoutInfo in instrumentColumns)
      {
        if (!this.dgvInstruments.Columns.Contains(columnLayoutInfo.ColumnName))
        {
          DataGridViewColumn dataGridViewColumn = this.AddColumn(this.dgvInstruments, ColumnType.Instrument, columnLayoutInfo.ColumnName);
          dataGridViewColumn.Width = columnLayoutInfo.Width;
          dataGridViewColumn.Visible = columnLayoutInfo.Visible;
        }
      }
      foreach (StrategyLogList strategyLogList in this.manager.LogLists)
      {
        foreach (StrategyLog log in strategyLogList.Logs)
        {
          this.Add(log);
          if (log.Count > 0)
            this.Add(log.Last);
        }
      }
    }

    public ColumnLayoutInfo[] GetStrategyColumnLayout()
    {
      return this.GetColumnLayout(this.dgvStrategies);
    }

    public ColumnLayoutInfo[] GetInstrumentColumnLayout()
    {
      return this.GetColumnLayout(this.dgvInstruments);
    }

    private ColumnLayoutInfo[] GetColumnLayout(DataGridView dgv)
    {
      List<ColumnLayoutInfo> list = new List<ColumnLayoutInfo>();
      foreach (DataGridViewColumn dataGridViewColumn in (IEnumerable<DataGridViewColumn>) this.GetColumns(dgv))
        list.Add(new ColumnLayoutInfo()
        {
          ColumnName = dataGridViewColumn.HeaderText,
          Width = dataGridViewColumn.Width,
          Visible = dataGridViewColumn.Visible
        });
      return list.ToArray();
    }

    private void Add(StrategyLog log)
    {
      string strategyName = log.List.StrategyName;
      string symbol = log.List.Symbol;
      string name = log.Name;
      DataGridViewRow dataGridViewRow1;
      if (!this.strategyRows.TryGetValue(strategyName, out dataGridViewRow1))
      {
        DataGridViewRow dataGridViewRow2 = this.AddRow(this.dgvStrategies, strategyName);
        dataGridViewRow2.Cells[0].Value = (object) this.GetStrategyImage(strategyName);
        dataGridViewRow2.Cells[1].Value = (object) this.GetStrategyDisplayName(strategyName);
        this.strategyRows.Add(strategyName, dataGridViewRow2);
      }
      if (symbol == string.Empty)
      {
        if (this.dgvStrategies.Columns.Contains(name))
          return;
        this.AddColumn(this.dgvStrategies, ColumnType.Strategy, name);
      }
      else
      {
        if (!(strategyName == this.dataViewOptions.StrategyName))
          return;
        DataGridViewRow dataGridViewRow2;
        if (!this.instrumentRows.TryGetValue(symbol, out dataGridViewRow2))
        {
          dataGridViewRow2 = this.AddRow(this.dgvInstruments, symbol);
          dataGridViewRow2.Cells[1].Value = (object) symbol;
          this.instrumentRows.Add(symbol, dataGridViewRow2);
        }
        if (this.dgvInstruments.Columns.Contains(name))
          return;
        this.AddColumn(this.dgvInstruments, ColumnType.Instrument, name);
      }
    }

    private void Add(StrategyLogItem item)
    {
      string strategyName = item.Log.List.StrategyName;
      string symbol = item.Log.List.Symbol;
      string name = item.Log.Name;
      if (symbol == string.Empty)
      {
        this.strategyRows[strategyName].Cells[name].Value = item.Value;
        switch (this.dataViewOptions.Mode)
        {
          case DataViewMode.RowHistory:
            if (!(strategyName == this.dataViewOptions.StrategyName) || this.dataViewOptions.Symbol != null || this.logDataSource == null)
              break;
            this.logDataSource.Add((object) item.DateTime, name, item.Value);
            break;
          case DataViewMode.ColumnHistory:
            ColumnItem columnItem = this.dataViewOptions.ColumnItem;
            if (columnItem == null || columnItem.Type != ColumnType.Strategy || (!(columnItem.Name == name) || this.logDataSource == null))
              break;
            this.logDataSource.Add((object) item.DateTime, strategyName, item.Value);
            break;
        }
      }
      else
      {
        if (strategyName == this.dataViewOptions.StrategyName)
          this.instrumentRows[symbol].Cells[name].Value = item.Value;
        switch (this.dataViewOptions.Mode)
        {
          case DataViewMode.RowHistory:
            if (!(strategyName == this.dataViewOptions.StrategyName) || !(symbol == this.dataViewOptions.Symbol) || this.logDataSource == null)
              break;
            this.logDataSource.Add((object) item.DateTime, name, item.Value);
            break;
          case DataViewMode.ColumnHistory:
            ColumnItem columnItem1 = this.dataViewOptions.ColumnItem;
            if (columnItem1 == null || columnItem1.Type != ColumnType.Instrument || (!(columnItem1.Name == name) || this.logDataSource == null))
              break;
            this.logDataSource.Add((object) item.DateTime, symbol, item.Value);
            break;
          case DataViewMode.CrossMonitor:
            ColumnItem columnItem2 = this.dataViewOptions.ColumnItem;
            if (columnItem2 == null || columnItem2.Type != ColumnType.Instrument || (!(columnItem2.Name == name) || this.logDataSource == null))
              break;
            this.logDataSource.Add((object) symbol, strategyName, item.Value);
            break;
        }
      }
    }

    private void ResetStrategies()
    {
      this.dgvStrategies.Rows.Clear();
      this.strategyRows.Clear();
    }

    private void ResetInstruments()
    {
      this.dgvInstruments.Rows.Clear();
      this.instrumentRows.Clear();
    }

    private void ResetData()
    {
      this.dgvData.Columns.Clear();
      this.dgvData.RowCount = 0;
      this.logDataSource = (ILogDataSource) null;
    }

    private DataGridViewColumn AddColumn(DataGridView dgv, ColumnType columnType, string headerText)
    {
      return this.AddColumn(dgv, columnType, headerText, headerText);
    }

    private DataGridViewColumn AddColumn(DataGridView dgv, ColumnType columnType, string headerText, string columnName)
    {
      int index = dgv.Columns.Add(columnName, headerText);
      DataGridViewColumn dataGridViewColumn = dgv.Columns[index];
      dataGridViewColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
      if (columnType == ColumnType.Strategy || columnType == ColumnType.Instrument)
      {
        ColumnItem columnItem = new ColumnItem(columnType, columnName);
        dataGridViewColumn.Tag = (object) columnItem;
        ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
        toolStripMenuItem.Text = "Hide";
        toolStripMenuItem.Tag = (object) dataGridViewColumn;
        toolStripMenuItem.Click += new EventHandler(this.ctxColumn_Hide_Click);
        dataGridViewColumn.HeaderCell.ContextMenuStrip = new ContextMenuStrip(this.components);
        dataGridViewColumn.HeaderCell.ContextMenuStrip.Items.Add((ToolStripItem) toolStripMenuItem);
        this.AddColumnItem(columnItem);
      }
      return dataGridViewColumn;
    }

    private IList<DataGridViewColumn> GetColumns(DataGridView dgv)
    {
      SortedList<int, DataGridViewColumn> sortedList = new SortedList<int, DataGridViewColumn>();
      for (int index = 2; index < dgv.ColumnCount; ++index)
      {
        DataGridViewColumn dataGridViewColumn = dgv.Columns[index];
        sortedList.Add(dataGridViewColumn.DisplayIndex, dataGridViewColumn);
      }
      return sortedList.Values;
    }

    private DataGridViewRow AddRow(DataGridView dgv, string tag)
    {
      int rowIndex = 0;
      while (rowIndex < dgv.RowCount && string.Compare((string) dgv.Rows[rowIndex].Tag, tag) <= 0)
        ++rowIndex;
      this.ignoreSelectionChangedEvent = true;
      dgv.Rows.Insert(rowIndex, 1);
      DataGridViewRow dataGridViewRow = dgv.Rows[rowIndex];
      dataGridViewRow.Tag = (object) tag;
      dataGridViewRow.Selected = false;
      this.ignoreSelectionChangedEvent = false;
      return dataGridViewRow;
    }

    private void AddColumnItem(ColumnItem item)
    {
      int index;
      for (index = 0; index < this.cbxColumnItem.Items.Count; ++index)
      {
        ColumnItem other = (ColumnItem) this.cbxColumnItem.Items[index];
        if (item.CompareTo(other) <= 0)
          break;
      }
      this.cbxColumnItem.Items.Insert(index, (object) item);
    }

    private string GetStrategyDisplayName(string strategyName)
    {
      if (strategyName == null)
        return string.Empty;
      if (strategyName == string.Empty)
        return this.solutionName;
      else
        return strategyName;
    }

    private Image GetStrategyImage(string strategyName)
    {
      if (strategyName == string.Empty)
        return this.imgStrategies.Images[0];
      else
        return this.imgStrategies.Images[1];
    }

    private string GetSelectedLogName(DataGridView dgv)
    {
      if (dgv.SelectedRows.Count == 1)
        return (string) dgv.SelectedRows[0].Tag;
      else
        return (string) null;
    }

    public void OnElapsed()
    {
      if (this.logDataSource == null || !this.logDataSource.HasChanges(true))
        return;
      this.dgvData.RowCount = this.logDataSource.Count;
      this.dgvData.Invalidate();
    }
  }
}

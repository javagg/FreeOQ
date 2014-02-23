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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StrategyMonitorControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imgStrategies = new System.Windows.Forms.ImageList(this.components);
            this.dgvStrategies = new System.Windows.Forms.DataGridView();
            this._StrategyImage_ = new System.Windows.Forms.DataGridViewImageColumn();
            this._Strategy_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ctxFirstColumn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInstruments = new System.Windows.Forms.TabPage();
            this.dgvInstruments = new System.Windows.Forms.DataGridView();
            this._InstrumentImage_ = new System.Windows.Forms.DataGridViewImageColumn();
            this._Instrument_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabData = new System.Windows.Forms.TabPage();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.tstData = new System.Windows.Forms.ToolStrip();
            this.lblDataViewMode = new System.Windows.Forms.ToolStripLabel();
            this.cbxDataViewMode = new System.Windows.Forms.ToolStripComboBox();
            this.lblColumnItem = new System.Windows.Forms.ToolStripLabel();
            this.cbxColumnItem = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrategies)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabInstruments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstruments)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tstData.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgStrategies
            // 
            this.imgStrategies.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgStrategies.ImageStream")));
            this.imgStrategies.TransparentColor = System.Drawing.Color.Transparent;
            this.imgStrategies.Images.SetKeyName(0, "btnAdd.Image.png");
            // 
            // dgvStrategies
            // 
            this.dgvStrategies.AllowUserToAddRows = false;
            this.dgvStrategies.AllowUserToDeleteRows = false;
            this.dgvStrategies.AllowUserToOrderColumns = true;
            this.dgvStrategies.AllowUserToResizeRows = false;
            this.dgvStrategies.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvStrategies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStrategies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStrategies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStrategies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStrategies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._StrategyImage_,
            this._Strategy_});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStrategies.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStrategies.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvStrategies.Location = new System.Drawing.Point(0, 0);
            this.dgvStrategies.MultiSelect = false;
            this.dgvStrategies.Name = "dgvStrategies";
            this.dgvStrategies.ReadOnly = true;
            this.dgvStrategies.RowHeadersVisible = false;
            this.dgvStrategies.RowTemplate.Height = 17;
            this.dgvStrategies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStrategies.ShowCellErrors = false;
            this.dgvStrategies.ShowEditingIcon = false;
            this.dgvStrategies.ShowRowErrors = false;
            this.dgvStrategies.Size = new System.Drawing.Size(579, 106);
            this.dgvStrategies.TabIndex = 0;
            this.dgvStrategies.ColumnDisplayIndexChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.DataGridView_ColumnDisplayIndexChanged);
            this.dgvStrategies.ColumnStateChanged += new System.Windows.Forms.DataGridViewColumnStateChangedEventHandler(this.DataGridView_ColumnStateChanged);
            this.dgvStrategies.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
            this.dgvStrategies.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DataGridView_MouseUp);
            // 
            // _StrategyImage_
            // 
            this._StrategyImage_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this._StrategyImage_.Frozen = true;
            this._StrategyImage_.HeaderText = " ";
            this._StrategyImage_.Name = "_StrategyImage_";
            this._StrategyImage_.ReadOnly = true;
            this._StrategyImage_.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._StrategyImage_.Width = 5;
            // 
            // _Strategy_
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this._Strategy_.DefaultCellStyle = dataGridViewCellStyle2;
            this._Strategy_.Frozen = true;
            this._Strategy_.HeaderText = "Strategy";
            this._Strategy_.Name = "_Strategy_";
            this._Strategy_.ReadOnly = true;
            this._Strategy_.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._Strategy_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 106);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(579, 4);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // ctxFirstColumn
            // 
            this.ctxFirstColumn.Name = "ctxFirstColumn";
            this.ctxFirstColumn.Size = new System.Drawing.Size(61, 4);
            this.ctxFirstColumn.Opening += new System.ComponentModel.CancelEventHandler(this.ctxFirstColumn_Opening);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInstruments);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 110);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(579, 139);
            this.tabControl1.TabIndex = 2;
            // 
            // tabInstruments
            // 
            this.tabInstruments.Controls.Add(this.dgvInstruments);
            this.tabInstruments.Location = new System.Drawing.Point(4, 22);
            this.tabInstruments.Name = "tabInstruments";
            this.tabInstruments.Padding = new System.Windows.Forms.Padding(3);
            this.tabInstruments.Size = new System.Drawing.Size(571, 113);
            this.tabInstruments.TabIndex = 0;
            this.tabInstruments.UseVisualStyleBackColor = true;
            // 
            // dgvInstruments
            // 
            this.dgvInstruments.AllowUserToAddRows = false;
            this.dgvInstruments.AllowUserToDeleteRows = false;
            this.dgvInstruments.AllowUserToOrderColumns = true;
            this.dgvInstruments.AllowUserToResizeRows = false;
            this.dgvInstruments.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvInstruments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInstruments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInstruments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInstruments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstruments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._InstrumentImage_,
            this._Instrument_});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInstruments.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInstruments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInstruments.Location = new System.Drawing.Point(3, 3);
            this.dgvInstruments.MultiSelect = false;
            this.dgvInstruments.Name = "dgvInstruments";
            this.dgvInstruments.ReadOnly = true;
            this.dgvInstruments.RowHeadersVisible = false;
            this.dgvInstruments.RowTemplate.Height = 17;
            this.dgvInstruments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInstruments.ShowCellErrors = false;
            this.dgvInstruments.ShowEditingIcon = false;
            this.dgvInstruments.ShowRowErrors = false;
            this.dgvInstruments.Size = new System.Drawing.Size(565, 107);
            this.dgvInstruments.TabIndex = 3;
            this.dgvInstruments.ColumnDisplayIndexChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.DataGridView_ColumnDisplayIndexChanged);
            this.dgvInstruments.ColumnStateChanged += new System.Windows.Forms.DataGridViewColumnStateChangedEventHandler(this.DataGridView_ColumnStateChanged);
            this.dgvInstruments.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
            this.dgvInstruments.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DataGridView_MouseUp);
            // 
            // _InstrumentImage_
            // 
            this._InstrumentImage_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this._InstrumentImage_.Frozen = true;
            this._InstrumentImage_.HeaderText = " ";
            this._InstrumentImage_.Image = global::OpenQuant.Shared.Properties.Resources.instrument;
            this._InstrumentImage_.Name = "_InstrumentImage_";
            this._InstrumentImage_.ReadOnly = true;
            this._InstrumentImage_.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._InstrumentImage_.Width = 5;
            // 
            // _Instrument_
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this._Instrument_.DefaultCellStyle = dataGridViewCellStyle5;
            this._Instrument_.Frozen = true;
            this._Instrument_.HeaderText = "Instrument";
            this._Instrument_.Name = "_Instrument_";
            this._Instrument_.ReadOnly = true;
            this._Instrument_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 249);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(579, 4);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabData);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 253);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(579, 235);
            this.tabControl2.TabIndex = 4;
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.dgvData);
            this.tabData.Controls.Add(this.tstData);
            this.tabData.Location = new System.Drawing.Point(4, 22);
            this.tabData.Name = "tabData";
            this.tabData.Size = new System.Drawing.Size(571, 209);
            this.tabData.TabIndex = 2;
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 25);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowTemplate.Height = 17;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.ShowCellErrors = false;
            this.dgvData.ShowEditingIcon = false;
            this.dgvData.ShowRowErrors = false;
            this.dgvData.Size = new System.Drawing.Size(571, 184);
            this.dgvData.TabIndex = 1;
            this.dgvData.VirtualMode = true;
            this.dgvData.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvData_CellValueNeeded);
            // 
            // tstData
            // 
            this.tstData.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tstData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDataViewMode,
            this.cbxDataViewMode,
            this.lblColumnItem,
            this.cbxColumnItem});
            this.tstData.Location = new System.Drawing.Point(0, 0);
            this.tstData.Name = "tstData";
            this.tstData.Size = new System.Drawing.Size(571, 25);
            this.tstData.TabIndex = 0;
            this.tstData.Text = "toolStrip2";
            // 
            // lblDataViewMode
            // 
            this.lblDataViewMode.Name = "lblDataViewMode";
            this.lblDataViewMode.Size = new System.Drawing.Size(32, 22);
            this.lblDataViewMode.Text = "View";
            // 
            // cbxDataViewMode
            // 
            this.cbxDataViewMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDataViewMode.Name = "cbxDataViewMode";
            this.cbxDataViewMode.Size = new System.Drawing.Size(121, 25);
            this.cbxDataViewMode.SelectedIndexChanged += new System.EventHandler(this.cbxDataViewMode_SelectedIndexChanged);
            // 
            // lblColumnItem
            // 
            this.lblColumnItem.Name = "lblColumnItem";
            this.lblColumnItem.Size = new System.Drawing.Size(50, 22);
            this.lblColumnItem.Text = "Column";
            // 
            // cbxColumnItem
            // 

            this.imgStrategies.Images.SetKeyName(0, "solution.png");
            this.imgStrategies.Images.SetKeyName(1, "strategy.png");
            this.cbxColumnItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxColumnItem.DropDownWidth = 200;
            this.cbxColumnItem.Name = "cbxColumnItem";
            this.cbxColumnItem.Size = new System.Drawing.Size(160, 25);
            this.cbxColumnItem.SelectedIndexChanged += new System.EventHandler(this.cbxColumnItem_SelectedIndexChanged);
            // 
            // StrategyMonitorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dgvStrategies);
            this.Name = "StrategyMonitorControl";
            this.Size = new System.Drawing.Size(579, 488);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrategies)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabInstruments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstruments)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabData.ResumeLayout(false);
            this.tabData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
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

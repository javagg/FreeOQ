using OpenQuant.Shared;
using OpenQuant.Shared.Properties;
using FreeQuant.FIX;
using FreeQuant.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Shared.Diagnostics
{
  public class EventMonitorWindow : FreeQuant.Docking.WinForms.DockControl, ITimerItem
  {
    private TotalCounter counter;
    private Dictionary<IProvider, ProviderCounterViewRow> providerCounterRows;
    private Dictionary<IFIXInstrument, InstrumentCounterViewRow> instrumentCounterRows;
    private IProvider selectedProvider;
    private IContainer components;
    private ToolStrip toolStrip1;
    private ToolStripButton tsbResetCounters;
    private DataGridView dgvProviderCounters;
    private Splitter splitter1;
    private DataGridView dgvInstrumentCounters;
    private DataGridViewTextBoxColumn colProvider;
    private DataGridViewTextBoxColumn colTrades;
    private DataGridViewTextBoxColumn colTradesDelta;
    private DataGridViewTextBoxColumn colQuotes;
    private DataGridViewTextBoxColumn colQuotesDelta;
    private DataGridViewTextBoxColumn colEmpty;
    private DataGridViewTextBoxColumn colInstrument;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

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

    public EventMonitorWindow()
    {
      this.InitializeComponent();
      this.counter = new TotalCounter();
      this.providerCounterRows = new Dictionary<IProvider, ProviderCounterViewRow>();
      this.instrumentCounterRows = new Dictionary<IFIXInstrument, InstrumentCounterViewRow>();
      this.selectedProvider = (IProvider) null;
    }

    protected override void OnInit()
    {
      // ISSUE: method pointer
			ProviderManager.NewTrade += new TradeEventHandler(this.ProviderManager_NewTrade);
      // ISSUE: method pointer
			ProviderManager.NewQuote += new QuoteEventHandler(this.ProviderManager_NewQuote);
      Global.TimerManager.Start((ITimerItem) this);
    }

    protected override void OnClosing(DockControlClosingEventArgs e)
    {
      Global.TimerManager.Stop((ITimerItem) this);
      // ISSUE: method pointer
			ProviderManager.NewTrade -= new TradeEventHandler(this.ProviderManager_NewTrade);
      // ISSUE: method pointer
			ProviderManager.NewQuote -= new QuoteEventHandler(this.ProviderManager_NewQuote);
      base.OnClosing(e);
    }

    private void tsbResetCounters_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show((IWin32Window) this, "Do you really want to reset counters?", "Reset Counters", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      this.counter.Reset();
      this.OnTotalCounterReset();
    }

    private void dgvProviderCounters_SelectionChanged(object sender, EventArgs e)
    {
      this.OnSelectedProviderCounterChanged();
    }

    private void ProviderManager_NewTrade(object sender, TradeEventArgs args)
    {
      this.counter.Add(args);
    }

    private void ProviderManager_NewQuote(object sender, QuoteEventArgs args)
    {
      this.counter.Add(args);
    }

    public void OnElapsed()
    {
      this.UpdateProviderCounters(this.counter.GetSnapshot().ProviderCounters);
    }

    private void OnTotalCounterReset()
    {
      this.providerCounterRows.Clear();
      this.dgvProviderCounters.Rows.Clear();
    }

    private void UpdateProviderCounters(ICollection<ProviderCounter> providerCounters)
    {
      foreach (ProviderCounter counter in (IEnumerable<ProviderCounter>) providerCounters)
      {
        ProviderCounterViewRow providerCounterViewRow;
        if (!this.providerCounterRows.TryGetValue(counter.Provider, out providerCounterViewRow))
        {
          providerCounterViewRow = new ProviderCounterViewRow(counter);
          providerCounterViewRow.Height = this.dgvProviderCounters.RowTemplate.Height;
          this.providerCounterRows.Add(counter.Provider, providerCounterViewRow);
          this.dgvProviderCounters.Rows.Add((DataGridViewRow) providerCounterViewRow);
        }
        providerCounterViewRow.UpdateCounter((EventCounter) counter);
        if (counter.Provider == this.selectedProvider)
          this.UpdateInstrumentCounters(counter.InstrumentCounters);
      }
    }

    private void OnSelectedProviderCounterChanged()
    {
      this.instrumentCounterRows.Clear();
      this.dgvInstrumentCounters.Rows.Clear();
      this.selectedProvider = (IProvider) null;
      if (this.dgvProviderCounters.SelectedRows.Count != 1)
        return;
      ProviderCounter providerCounter = (ProviderCounter) ((EventCounterViewRow) this.dgvProviderCounters.SelectedRows[0]).Counter;
      this.UpdateInstrumentCounters(providerCounter.InstrumentCounters);
      this.selectedProvider = providerCounter.Provider;
    }

    private void UpdateInstrumentCounters(ICollection<InstrumentCounter> instrumentCounters)
    {
      foreach (InstrumentCounter counter in (IEnumerable<InstrumentCounter>) instrumentCounters)
      {
        InstrumentCounterViewRow instrumentCounterViewRow;
        if (!this.instrumentCounterRows.TryGetValue(counter.Instrument, out instrumentCounterViewRow))
        {
          instrumentCounterViewRow = new InstrumentCounterViewRow(counter);
          instrumentCounterViewRow.Height = this.dgvInstrumentCounters.RowTemplate.Height;
          this.instrumentCounterRows.Add(counter.Instrument, instrumentCounterViewRow);
          this.dgvInstrumentCounters.Rows.Add((DataGridViewRow) instrumentCounterViewRow);
        }
        instrumentCounterViewRow.UpdateCounter((EventCounter) counter);
      }
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
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle6 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle7 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle8 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle9 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle10 = new DataGridViewCellStyle();
      this.toolStrip1 = new ToolStrip();
      this.tsbResetCounters = new ToolStripButton();
      this.dgvProviderCounters = new DataGridView();
      this.splitter1 = new Splitter();
      this.dgvInstrumentCounters = new DataGridView();
      this.colProvider = new DataGridViewTextBoxColumn();
      this.colTrades = new DataGridViewTextBoxColumn();
      this.colTradesDelta = new DataGridViewTextBoxColumn();
      this.colQuotes = new DataGridViewTextBoxColumn();
      this.colQuotesDelta = new DataGridViewTextBoxColumn();
      this.colEmpty = new DataGridViewTextBoxColumn();
      this.colInstrument = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
      this.toolStrip1.SuspendLayout();
//      this.dgvProviderCounters.BeginInit();
//      this.dgvInstrumentCounters.BeginInit();
      this.SuspendLayout();
      this.toolStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.tsbResetCounters
      });
      this.toolStrip1.Location = new Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new Size(586, 25);
      this.toolStrip1.TabIndex = 0;
      this.toolStrip1.Text = "toolStrip1";
      this.tsbResetCounters.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbResetCounters.Image = (Image) Resources.evtmon_reset;
      this.tsbResetCounters.ImageTransparentColor = Color.Magenta;
      this.tsbResetCounters.Name = "tsbResetCounters";
      this.tsbResetCounters.Size = new Size(23, 22);
      this.tsbResetCounters.Text = "Reset Counters";
      this.tsbResetCounters.Click += new EventHandler(this.tsbResetCounters_Click);
      this.dgvProviderCounters.AllowUserToAddRows = false;
      this.dgvProviderCounters.AllowUserToDeleteRows = false;
      this.dgvProviderCounters.AllowUserToResizeRows = false;
      this.dgvProviderCounters.BackgroundColor = SystemColors.Window;
			this.dgvProviderCounters.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgvProviderCounters.CellBorderStyle = DataGridViewCellBorderStyle.None;
      this.dgvProviderCounters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvProviderCounters.Columns.AddRange((DataGridViewColumn) this.colProvider, (DataGridViewColumn) this.colTrades, (DataGridViewColumn) this.colTradesDelta, (DataGridViewColumn) this.colQuotes, (DataGridViewColumn) this.colQuotesDelta, (DataGridViewColumn) this.colEmpty);
      this.dgvProviderCounters.Dock = DockStyle.Top;
      this.dgvProviderCounters.Location = new Point(0, 25);
      this.dgvProviderCounters.MultiSelect = false;
      this.dgvProviderCounters.Name = "dgvProviderCounters";
      this.dgvProviderCounters.RowHeadersVisible = false;
      this.dgvProviderCounters.RowTemplate.Height = 19;
      this.dgvProviderCounters.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvProviderCounters.ShowCellErrors = false;
      this.dgvProviderCounters.ShowEditingIcon = false;
      this.dgvProviderCounters.ShowRowErrors = false;
      this.dgvProviderCounters.Size = new Size(586, 130);
      this.dgvProviderCounters.TabIndex = 1;
      this.dgvProviderCounters.SelectionChanged += new EventHandler(this.dgvProviderCounters_SelectionChanged);
      this.splitter1.Dock = DockStyle.Top;
      this.splitter1.Location = new Point(0, 155);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new Size(586, 4);
      this.splitter1.TabIndex = 2;
      this.splitter1.TabStop = false;
      this.dgvInstrumentCounters.AllowUserToAddRows = false;
      this.dgvInstrumentCounters.AllowUserToDeleteRows = false;
      this.dgvInstrumentCounters.AllowUserToResizeRows = false;
      this.dgvInstrumentCounters.BackgroundColor = SystemColors.Window;
			this.dgvInstrumentCounters.BorderStyle =System.Windows.Forms.BorderStyle.None;
      this.dgvInstrumentCounters.CellBorderStyle = DataGridViewCellBorderStyle.None;
      this.dgvInstrumentCounters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvInstrumentCounters.Columns.AddRange((DataGridViewColumn) this.colInstrument, (DataGridViewColumn) this.dataGridViewTextBoxColumn1, (DataGridViewColumn) this.dataGridViewTextBoxColumn2, (DataGridViewColumn) this.dataGridViewTextBoxColumn3, (DataGridViewColumn) this.dataGridViewTextBoxColumn4, (DataGridViewColumn) this.dataGridViewTextBoxColumn5);
      this.dgvInstrumentCounters.Dock = DockStyle.Fill;
      this.dgvInstrumentCounters.Location = new Point(0, 159);
      this.dgvInstrumentCounters.MultiSelect = false;
      this.dgvInstrumentCounters.Name = "dgvInstrumentCounters";
      this.dgvInstrumentCounters.RowHeadersVisible = false;
      this.dgvInstrumentCounters.RowTemplate.Height = 19;
      this.dgvInstrumentCounters.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvInstrumentCounters.ShowCellErrors = false;
      this.dgvInstrumentCounters.ShowEditingIcon = false;
      this.dgvInstrumentCounters.ShowRowErrors = false;
      this.dgvInstrumentCounters.Size = new Size(586, 269);
      this.dgvInstrumentCounters.TabIndex = 3;
      this.colProvider.HeaderText = "Provider";
      this.colProvider.Name = "colProvider";
      this.colProvider.ReadOnly = true;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle1.Format = "n0";
      this.colTrades.DefaultCellStyle = gridViewCellStyle1;
      this.colTrades.HeaderText = "Trades (total)";
      this.colTrades.Name = "colTrades";
      this.colTrades.ReadOnly = true;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle2.Format = "n0";
      this.colTradesDelta.DefaultCellStyle = gridViewCellStyle2;
      this.colTradesDelta.HeaderText = "Trades (delta)";
      this.colTradesDelta.Name = "colTradesDelta";
      this.colTradesDelta.ReadOnly = true;
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle3.Format = "n0";
      this.colQuotes.DefaultCellStyle = gridViewCellStyle3;
      this.colQuotes.HeaderText = "Quotes (total)";
      this.colQuotes.Name = "colQuotes";
      this.colQuotes.ReadOnly = true;
      gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle4.Format = "n0";
      this.colQuotesDelta.DefaultCellStyle = gridViewCellStyle4;
      this.colQuotesDelta.HeaderText = "Quotes (delta)";
      this.colQuotesDelta.Name = "colQuotesDelta";
      this.colQuotesDelta.ReadOnly = true;
      this.colEmpty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      gridViewCellStyle5.SelectionBackColor = SystemColors.Window;
      this.colEmpty.DefaultCellStyle = gridViewCellStyle5;
      this.colEmpty.HeaderText = "";
      this.colEmpty.Name = "colEmpty";
      this.colEmpty.ReadOnly = true;
      this.colEmpty.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.colInstrument.HeaderText = "Instrument";
      this.colInstrument.Name = "colInstrument";
      this.colInstrument.ReadOnly = true;
      gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle6.Format = "n0";
      this.dataGridViewTextBoxColumn1.DefaultCellStyle = gridViewCellStyle6;
      this.dataGridViewTextBoxColumn1.HeaderText = "Trades (total)";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      gridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle7.Format = "n0";
      this.dataGridViewTextBoxColumn2.DefaultCellStyle = gridViewCellStyle7;
      this.dataGridViewTextBoxColumn2.HeaderText = "Trades (delta)";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      gridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle8.Format = "n0";
      this.dataGridViewTextBoxColumn3.DefaultCellStyle = gridViewCellStyle8;
      this.dataGridViewTextBoxColumn3.HeaderText = "Quotes (total)";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      gridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle9.Format = "n0";
      this.dataGridViewTextBoxColumn4.DefaultCellStyle = gridViewCellStyle9;
      this.dataGridViewTextBoxColumn4.HeaderText = "Quotes (delta)";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      this.dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      gridViewCellStyle10.SelectionBackColor = SystemColors.Window;
      this.dataGridViewTextBoxColumn5.DefaultCellStyle = gridViewCellStyle10;
      this.dataGridViewTextBoxColumn5.HeaderText = "";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.ReadOnly = true;
      this.dataGridViewTextBoxColumn5.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.dgvInstrumentCounters);
      this.Controls.Add((Control) this.splitter1);
      this.Controls.Add((Control) this.dgvProviderCounters);
      this.Controls.Add((Control) this.toolStrip1);
      this.DefaultDockLocation = ContainerDockLocation.Center;
      this.Name = "EventMonitorWindow";
      this.Size = new Size(586, 428);
      this.TabImage = (Image) Resources.evtmon;
      this.Text = "Event Monitor";
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
//      this.dgvProviderCounters.EndInit();
//      this.dgvInstrumentCounters.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

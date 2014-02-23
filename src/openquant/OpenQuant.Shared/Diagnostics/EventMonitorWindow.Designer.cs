using System.ComponentModel;
using System.Windows.Forms;
namespace OpenQuant.Shared.Diagnostics
{
    public partial class EventMonitorWindow
  {
        private IContainer components = null;
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

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbResetCounters = new System.Windows.Forms.ToolStripButton();
            this.dgvProviderCounters = new System.Windows.Forms.DataGridView();
            this.colProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTradesDelta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuotesDelta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dgvInstrumentCounters = new System.Windows.Forms.DataGridView();
            this.colInstrument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviderCounters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrumentCounters)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbResetCounters});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(586, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbResetCounters
            // 
            this.tsbResetCounters.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbResetCounters.Image = global::OpenQuant.Shared.Properties.Resources.evtmon_reset;
            this.tsbResetCounters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbResetCounters.Name = "tsbResetCounters";
            this.tsbResetCounters.Size = new System.Drawing.Size(23, 22);
            this.tsbResetCounters.Text = "Reset Counters";
            this.tsbResetCounters.Click += new System.EventHandler(this.tsbResetCounters_Click);
            // 
            // dgvProviderCounters
            // 
            this.dgvProviderCounters.AllowUserToAddRows = false;
            this.dgvProviderCounters.AllowUserToDeleteRows = false;
            this.dgvProviderCounters.AllowUserToResizeRows = false;
            this.dgvProviderCounters.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProviderCounters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProviderCounters.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProviderCounters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProviderCounters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProvider,
            this.colTrades,
            this.colTradesDelta,
            this.colQuotes,
            this.colQuotesDelta,
            this.colEmpty});
            this.dgvProviderCounters.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProviderCounters.Location = new System.Drawing.Point(0, 25);
            this.dgvProviderCounters.MultiSelect = false;
            this.dgvProviderCounters.Name = "dgvProviderCounters";
            this.dgvProviderCounters.RowHeadersVisible = false;
            this.dgvProviderCounters.RowTemplate.Height = 19;
            this.dgvProviderCounters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProviderCounters.ShowCellErrors = false;
            this.dgvProviderCounters.ShowEditingIcon = false;
            this.dgvProviderCounters.ShowRowErrors = false;
            this.dgvProviderCounters.Size = new System.Drawing.Size(586, 130);
            this.dgvProviderCounters.TabIndex = 1;
            this.dgvProviderCounters.SelectionChanged += new System.EventHandler(this.dgvProviderCounters_SelectionChanged);
            // 
            // colProvider
            // 
            this.colProvider.HeaderText = "Provider";
            this.colProvider.Name = "colProvider";
            this.colProvider.ReadOnly = true;
            // 
            // colTrades
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "n0";
            this.colTrades.DefaultCellStyle = dataGridViewCellStyle1;
            this.colTrades.HeaderText = "Trades (total)";
            this.colTrades.Name = "colTrades";
            this.colTrades.ReadOnly = true;
            // 
            // colTradesDelta
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "n0";
            this.colTradesDelta.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTradesDelta.HeaderText = "Trades (delta)";
            this.colTradesDelta.Name = "colTradesDelta";
            this.colTradesDelta.ReadOnly = true;
            // 
            // colQuotes
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "n0";
            this.colQuotes.DefaultCellStyle = dataGridViewCellStyle3;
            this.colQuotes.HeaderText = "Quotes (total)";
            this.colQuotes.Name = "colQuotes";
            this.colQuotes.ReadOnly = true;
            // 
            // colQuotesDelta
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n0";
            this.colQuotesDelta.DefaultCellStyle = dataGridViewCellStyle4;
            this.colQuotesDelta.HeaderText = "Quotes (delta)";
            this.colQuotesDelta.Name = "colQuotesDelta";
            this.colQuotesDelta.ReadOnly = true;
            // 
            // colEmpty
            // 
            this.colEmpty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Window;
            this.colEmpty.DefaultCellStyle = dataGridViewCellStyle5;
            this.colEmpty.HeaderText = "";
            this.colEmpty.Name = "colEmpty";
            this.colEmpty.ReadOnly = true;
            this.colEmpty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 155);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(586, 4);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // dgvInstrumentCounters
            // 
            this.dgvInstrumentCounters.AllowUserToAddRows = false;
            this.dgvInstrumentCounters.AllowUserToDeleteRows = false;
            this.dgvInstrumentCounters.AllowUserToResizeRows = false;
            this.dgvInstrumentCounters.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvInstrumentCounters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInstrumentCounters.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInstrumentCounters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstrumentCounters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInstrument,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvInstrumentCounters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInstrumentCounters.Location = new System.Drawing.Point(0, 159);
            this.dgvInstrumentCounters.MultiSelect = false;
            this.dgvInstrumentCounters.Name = "dgvInstrumentCounters";
            this.dgvInstrumentCounters.RowHeadersVisible = false;
            this.dgvInstrumentCounters.RowTemplate.Height = 19;
            this.dgvInstrumentCounters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInstrumentCounters.ShowCellErrors = false;
            this.dgvInstrumentCounters.ShowEditingIcon = false;
            this.dgvInstrumentCounters.ShowRowErrors = false;
            this.dgvInstrumentCounters.Size = new System.Drawing.Size(586, 269);
            this.dgvInstrumentCounters.TabIndex = 3;
            // 
            // colInstrument
            // 
            this.colInstrument.HeaderText = "Instrument";
            this.colInstrument.Name = "colInstrument";
            this.colInstrument.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "n0";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn1.HeaderText = "Trades (total)";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "n0";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn2.HeaderText = "Trades (delta)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "n0";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn3.HeaderText = "Quotes (total)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "n0";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn4.HeaderText = "Quotes (delta)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Window;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn5.HeaderText = "";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EventMonitorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvInstrumentCounters);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dgvProviderCounters);
            this.Controls.Add(this.toolStrip1);
            this.DefaultDockLocation = TD.SandDock.ContainerDockLocation.Center;
            this.Name = "EventMonitorWindow";
            this.Size = new System.Drawing.Size(586, 428);
            this.TabImage = global::OpenQuant.Shared.Properties.Resources.evtmon;
            this.Text = "Event Monitor";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviderCounters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrumentCounters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
  }
}

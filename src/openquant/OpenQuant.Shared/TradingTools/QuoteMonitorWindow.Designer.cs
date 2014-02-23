namespace OpenQuant.Shared.TradingTools
{
    public partial class QuoteMonitorWindow
    {
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ContextMenuStrip ctxQuotes;
        private System.Windows.Forms.ToolStripMenuItem ctxQuotes_Trade;
        private System.Windows.Forms.ToolStripMenuItem ctxQuotes_Buy;
        private System.Windows.Forms.ToolStripMenuItem ctxQuotes_Sell;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ctxQuotes_BuyLimit;
        private System.Windows.Forms.ToolStripMenuItem ctxQuotes_SellLimit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ctxQuotes_BuyStop;
        private System.Windows.Forms.ToolStripMenuItem ctxQuotes_SellStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem ctxQuotes_BuyStopLimit;
        private System.Windows.Forms.ToolStripMenuItem ctxQuotes_SellStopLimit;
        private System.Windows.Forms.ToolStripSeparator tssQuotes_Trade;
        private System.Windows.Forms.ToolStripMenuItem ctxQuotes_Remove;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvBars;
        private FreeQuant.Charting.Chart chart;
        private System.Windows.Forms.DataGridView dgvQuotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.ToolStripMenuItem ctxQuotes_OrderBook;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ctxQuotes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxQuotes_Trade = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxQuotes_Buy = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxQuotes_Sell = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxQuotes_BuyLimit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxQuotes_SellLimit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxQuotes_BuyStop = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxQuotes_SellStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxQuotes_BuyStopLimit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxQuotes_SellStopLimit = new System.Windows.Forms.ToolStripMenuItem();
            this.tssQuotes_Trade = new System.Windows.Forms.ToolStripSeparator();
            this.ctxQuotes_OrderBook = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxQuotes_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvQuotes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvBars = new System.Windows.Forms.DataGridView();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart = new FreeQuant.Charting.Chart();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ctxQuotes.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotes)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBars)).BeginInit();
            this.SuspendLayout();
            // 
            // ctxQuotes
            // 
            this.ctxQuotes.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.ctxQuotes_Trade,
                this.tssQuotes_Trade,
                this.ctxQuotes_OrderBook,
                this.toolStripSeparator1,
                this.ctxQuotes_Remove
            });
            this.ctxQuotes.Name = "ctxQuotes";
            this.ctxQuotes.Size = new System.Drawing.Size(163, 82);
            this.ctxQuotes.Opening += new System.ComponentModel.CancelEventHandler(this.ctxQuotes_Opening);
            // 
            // ctxQuotes_Trade
            // 
            this.ctxQuotes_Trade.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.ctxQuotes_Buy,
                this.ctxQuotes_Sell,
                this.toolStripSeparator3,
                this.ctxQuotes_BuyLimit,
                this.ctxQuotes_SellLimit,
                this.toolStripSeparator4,
                this.ctxQuotes_BuyStop,
                this.ctxQuotes_SellStop,
                this.toolStripSeparator5,
                this.ctxQuotes_BuyStopLimit,
                this.ctxQuotes_SellStopLimit
            });
            this.ctxQuotes_Trade.Name = "ctxQuotes_Trade";
            this.ctxQuotes_Trade.Size = new System.Drawing.Size(162, 22);
            this.ctxQuotes_Trade.Text = "Trade";
            // 
            // ctxQuotes_Buy
            // 
            this.ctxQuotes_Buy.Name = "ctxQuotes_Buy";
            this.ctxQuotes_Buy.Size = new System.Drawing.Size(151, 22);
            this.ctxQuotes_Buy.Text = "Buy";
            this.ctxQuotes_Buy.Click += new System.EventHandler(this.ctxQuotes_Buy_Click);
            // 
            // ctxQuotes_Sell
            // 
            this.ctxQuotes_Sell.Name = "ctxQuotes_Sell";
            this.ctxQuotes_Sell.Size = new System.Drawing.Size(151, 22);
            this.ctxQuotes_Sell.Text = "Sell";
            this.ctxQuotes_Sell.Click += new System.EventHandler(this.ctxQuotes_Sell_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(148, 6);
            // 
            // ctxQuotes_BuyLimit
            // 
            this.ctxQuotes_BuyLimit.Name = "ctxQuotes_BuyLimit";
            this.ctxQuotes_BuyLimit.Size = new System.Drawing.Size(151, 22);
            this.ctxQuotes_BuyLimit.Text = "Buy Limit";
            this.ctxQuotes_BuyLimit.Click += new System.EventHandler(this.ctxQuotes_BuyLimit_Click);
            // 
            // ctxQuotes_SellLimit
            // 
            this.ctxQuotes_SellLimit.Name = "ctxQuotes_SellLimit";
            this.ctxQuotes_SellLimit.Size = new System.Drawing.Size(151, 22);
            this.ctxQuotes_SellLimit.Text = "Sell Limit";
            this.ctxQuotes_SellLimit.Click += new System.EventHandler(this.ctxQuotes_SellLimit_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(148, 6);
            // 
            // ctxQuotes_BuyStop
            // 
            this.ctxQuotes_BuyStop.Name = "ctxQuotes_BuyStop";
            this.ctxQuotes_BuyStop.Size = new System.Drawing.Size(151, 22);
            this.ctxQuotes_BuyStop.Text = "Buy Stop";
            this.ctxQuotes_BuyStop.Click += new System.EventHandler(this.ctxQuotes_BuyStop_Click);
            // 
            // ctxQuotes_SellStop
            // 
            this.ctxQuotes_SellStop.Name = "ctxQuotes_SellStop";
            this.ctxQuotes_SellStop.Size = new System.Drawing.Size(151, 22);
            this.ctxQuotes_SellStop.Text = "Sell Stop";
            this.ctxQuotes_SellStop.Click += new System.EventHandler(this.ctxQuotes_SellStop_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(148, 6);
            // 
            // ctxQuotes_BuyStopLimit
            // 
            this.ctxQuotes_BuyStopLimit.Name = "ctxQuotes_BuyStopLimit";
            this.ctxQuotes_BuyStopLimit.Size = new System.Drawing.Size(151, 22);
            this.ctxQuotes_BuyStopLimit.Text = "Buy Stop Limit";
            this.ctxQuotes_BuyStopLimit.Click += new System.EventHandler(this.ctxQuotes_BuyStopLimit_Click);
            // 
            // ctxQuotes_SellStopLimit
            // 
            this.ctxQuotes_SellStopLimit.Name = "ctxQuotes_SellStopLimit";
            this.ctxQuotes_SellStopLimit.Size = new System.Drawing.Size(151, 22);
            this.ctxQuotes_SellStopLimit.Text = "Sell Stop Limit";
            this.ctxQuotes_SellStopLimit.Click += new System.EventHandler(this.ctxQuotes_SellStopLimit_Click);
            // 
            // tssQuotes_Trade
            // 
            this.tssQuotes_Trade.Name = "tssQuotes_Trade";
            this.tssQuotes_Trade.Size = new System.Drawing.Size(159, 6);
            // 
            // ctxQuotes_OrderBook
            // 
            this.ctxQuotes_OrderBook.Image = global::OpenQuant.Shared.Properties.Resources.orderbook;
            this.ctxQuotes_OrderBook.Name = "ctxQuotes_OrderBook";
            this.ctxQuotes_OrderBook.Size = new System.Drawing.Size(162, 22);
            this.ctxQuotes_OrderBook.Text = "View Order Book";
            this.ctxQuotes_OrderBook.Click += new System.EventHandler(this.ctxQuotes_OrderBook_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // ctxQuotes_Remove
            // 
            this.ctxQuotes_Remove.Image = global::OpenQuant.Shared.Properties.Resources.delete;
            this.ctxQuotes_Remove.Name = "ctxQuotes_Remove";
            this.ctxQuotes_Remove.Size = new System.Drawing.Size(162, 22);
            this.ctxQuotes_Remove.Text = "Remove";
            this.ctxQuotes_Remove.Click += new System.EventHandler(this.ctxQuotes_Remove_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 313);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvQuotes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(632, 287);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quote";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvQuotes
            // 
            this.dgvQuotes.AllowDrop = true;
            this.dgvQuotes.AllowUserToAddRows = false;
            this.dgvQuotes.AllowUserToDeleteRows = false;
            this.dgvQuotes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.Column1,
                this.Column2,
                this.Column3,
                this.Column4,
                this.Column5,
                this.Column6,
                this.Column7,
                this.Column8,
                this.Column9,
                this.Column10,
                this.Column11
            });
            this.dgvQuotes.ContextMenuStrip = this.ctxQuotes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuotes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQuotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuotes.Location = new System.Drawing.Point(3, 3);
            this.dgvQuotes.Name = "dgvQuotes";
            this.dgvQuotes.ReadOnly = true;
            this.dgvQuotes.RowHeadersVisible = false;
            this.dgvQuotes.RowTemplate.Height = 18;
            this.dgvQuotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuotes.Size = new System.Drawing.Size(626, 281);
            this.dgvQuotes.TabIndex = 2;
            this.dgvQuotes.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvQuotes_DragDrop);
            this.dgvQuotes.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvQuotes_DragOver);
            this.dgvQuotes.DoubleClick += new System.EventHandler(this.dgvQuotes_DoubleClick);
            this.dgvQuotes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvQuotes_MouseDown);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Instrument";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Time";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Change";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Size";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 5;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Bid Size";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 60;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Bid";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 60;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Ask";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 60;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Ask Size";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 60;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.HeaderText = "";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvBars);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(636, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvBars
            // 
            this.dgvBars.AllowUserToAddRows = false;
            this.dgvBars.AllowUserToDeleteRows = false;
            this.dgvBars.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.Column12,
                this.Column13,
                this.Column14,
                this.Column15,
                this.Column16,
                this.Column17,
                this.Column18,
                this.Column19,
                this.Column21
            });
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBars.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvBars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBars.Location = new System.Drawing.Point(3, 3);
            this.dgvBars.MultiSelect = false;
            this.dgvBars.Name = "dgvBars";
            this.dgvBars.ReadOnly = true;
            this.dgvBars.RowHeadersVisible = false;
            this.dgvBars.RowTemplate.Height = 18;
            this.dgvBars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBars.Size = new System.Drawing.Size(630, 270);
            this.dgvBars.TabIndex = 0;
            // 
            // Column12
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column12.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column12.Frozen = true;
            this.Column12.HeaderText = "Instrument";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column13.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column13.HeaderText = "Interval";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 120;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Open";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column14.Width = 60;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "High";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column15.Width = 60;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Low";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column16.Width = 60;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Close";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column17.Width = 60;
            // 
            // Column18
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column18.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column18.HeaderText = "Volume";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Width = 80;
            // 
            // Column19
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column19.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column19.HeaderText = "Bar Size";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Width = 80;
            // 
            // Column21
            // 
            this.Column21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column21.HeaderText = "";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            this.Column21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // chart
            // 
            this.chart.AntiAliasingEnabled = false;
            this.chart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chart.DoubleBufferingEnabled = true;
            this.chart.FileName = null;
            this.chart.GroupLeftMarginEnabled = false;
            this.chart.GroupRightMarginEnabled = false;
            this.chart.GroupZoomEnabled = false;
            this.chart.Location = new System.Drawing.Point(0, 313);
            this.chart.Name = "chart";
            this.chart.PadsForeColor = System.Drawing.Color.White;
            this.chart.PrintAlign = FreeQuant.Charting.EPrintAlign.None;
            this.chart.PrintHeight = 400;
            this.chart.PrintLayout = FreeQuant.Charting.EPrintLayout.Portrait;
            this.chart.PrintWidth = 600;
            this.chart.PrintX = 10;
            this.chart.PrintY = 10;
            this.chart.SessionEnd = System.TimeSpan.Parse("1.00:00:00");
            this.chart.SessionGridColor = System.Drawing.Color.Blue;
            this.chart.SessionGridEnabled = false;
            this.chart.SessionStart = System.TimeSpan.Parse("00:00:00");
            this.chart.Size = new System.Drawing.Size(640, 167);
            this.chart.SmoothingEnabled = false;
            this.chart.TabIndex = 31;
            this.chart.TransformationType = FreeQuant.Charting.ETransformationType.Empty;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 310);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(640, 3);
            this.splitter1.TabIndex = 33;
            this.splitter1.TabStop = false;
            // 
            // QuoteMonitorWindow
            // 
            this.AllowDockLeft = false;
            this.AllowDockRight = false;
            this.AllowDrop = true;
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.chart);
            this.DefaultDockLocation = TD.SandDock.ContainerDockLocation.Center;
            this.Name = "QuoteMonitorWindow";
            this.PersistState = false;
            this.Size = new System.Drawing.Size(640, 480);
            this.TabImage = global::OpenQuant.Shared.Properties.Resources.quote_monitor;
            this.Text = "Quote Monitor";
            this.ctxQuotes.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBars)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

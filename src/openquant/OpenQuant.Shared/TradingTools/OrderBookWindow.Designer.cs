namespace OpenQuant.Shared.TradingTools
{
    partial class OrderBookWindow
    {
        private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.DataGridView dgvBook;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.DataGridViewTextBoxColumn colBidSize;
    private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn colAskSize;
    private System.Windows.Forms.ToolStripButton tsbSuspendUpdates;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderBookWindow));
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.colBidSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAskSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSuspendUpdates = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvBook.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBidSize,
            this.colPrice,
            this.colAskSize});
            this.dgvBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBook.Location = new System.Drawing.Point(0, 25);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowHeadersVisible = false;
            this.dgvBook.RowTemplate.Height = 40;
            this.dgvBook.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBook.Size = new System.Drawing.Size(200, 275);
            this.dgvBook.TabIndex = 0;
            // 
            // colBidSize
            // 
            this.colBidSize.DataPropertyName = "BidSize";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.Format = "n0";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.colBidSize.DefaultCellStyle = dataGridViewCellStyle4;
            this.colBidSize.HeaderText = "";
            this.colBidSize.Name = "colBidSize";
            this.colBidSize.ReadOnly = true;
            this.colBidSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.colPrice.HeaderText = "";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAskSize
            // 
            this.colAskSize.DataPropertyName = "AskSize";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.Format = "n0";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.colAskSize.DefaultCellStyle = dataGridViewCellStyle6;
            this.colAskSize.HeaderText = "";
            this.colAskSize.Name = "colAskSize";
            this.colAskSize.ReadOnly = true;
            this.colAskSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSuspendUpdates});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(200, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbSuspendUpdates
            // 
            this.tsbSuspendUpdates.CheckOnClick = true;
            this.tsbSuspendUpdates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSuspendUpdates.Image = ((System.Drawing.Image)(resources.GetObject("tsbSuspendUpdates.Image")));
            this.tsbSuspendUpdates.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSuspendUpdates.Name = "tsbSuspendUpdates";
            this.tsbSuspendUpdates.Size = new System.Drawing.Size(23, 22);
            this.tsbSuspendUpdates.Text = "toolStripButton1";
            this.tsbSuspendUpdates.ToolTipText = "Suspend updates";
            this.tsbSuspendUpdates.CheckedChanged += new System.EventHandler(this.tsbSuspendUpdates_CheckedChanged);
            // 
            // OrderBookWindow
            // 
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.toolStrip1);
            this.FloatingSize = new System.Drawing.Size(200, 300);
            this.Name = "OrderBookWindow";
            this.PersistState = false;
            this.ShowFloating = true;
            this.Size = new System.Drawing.Size(200, 300);
            this.TabImage = global::OpenQuant.Shared.Properties.Resources.orderbook;
            this.Text = "OrderBook";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }


  }
}

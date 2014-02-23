using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Options
{
  class MemoryManagementPanel : OptionsPanel
  {
        private IContainer components = null;
    private GroupBox groupBox1;
    private CheckBox chbPortfolioPerformance;
    private CheckBox chbCalculateDrawdown;
    private CheckBox chbCalculatePnL;
    private GroupBox groupBox2;
    private CheckBox chbRemoveOrders;
    private CheckBox chbUpdateInterval;
    private NumericUpDown nudIntervalLength;

    public MemoryManagementPanel()
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudIntervalLength = new System.Windows.Forms.NumericUpDown();
            this.chbCalculateDrawdown = new System.Windows.Forms.CheckBox();
            this.chbCalculatePnL = new System.Windows.Forms.CheckBox();
            this.chbUpdateInterval = new System.Windows.Forms.CheckBox();
            this.chbPortfolioPerformance = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbRemoveOrders = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalLength)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudIntervalLength);
            this.groupBox1.Controls.Add(this.chbCalculateDrawdown);
            this.groupBox1.Controls.Add(this.chbCalculatePnL);
            this.groupBox1.Controls.Add(this.chbUpdateInterval);
            this.groupBox1.Controls.Add(this.chbPortfolioPerformance);
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Performance";
            // 
            // nudIntervalLength
            // 
            this.nudIntervalLength.Location = new System.Drawing.Point(195, 108);
            this.nudIntervalLength.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudIntervalLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIntervalLength.Name = "nudIntervalLength";
            this.nudIntervalLength.Size = new System.Drawing.Size(73, 20);
            this.nudIntervalLength.TabIndex = 3;
            this.nudIntervalLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudIntervalLength.ThousandsSeparator = true;
            this.nudIntervalLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIntervalLength.ValueChanged += new System.EventHandler(this.nudIntervalLength_ValueChanged);
            // 
            // chbCalculateDrawdown
            // 
            this.chbCalculateDrawdown.Location = new System.Drawing.Point(31, 80);
            this.chbCalculateDrawdown.Name = "chbCalculateDrawdown";
            this.chbCalculateDrawdown.Size = new System.Drawing.Size(237, 22);
            this.chbCalculateDrawdown.TabIndex = 2;
            this.chbCalculateDrawdown.Text = "Calculate Drawdown";
            this.chbCalculateDrawdown.UseVisualStyleBackColor = true;
            this.chbCalculateDrawdown.CheckedChanged += new System.EventHandler(this.chbCalculateDrawdown_CheckedChanged);
            // 
            // chbCalculatePnL
            // 
            this.chbCalculatePnL.Location = new System.Drawing.Point(31, 52);
            this.chbCalculatePnL.Name = "chbCalculatePnL";
            this.chbCalculatePnL.Size = new System.Drawing.Size(237, 22);
            this.chbCalculatePnL.TabIndex = 1;
            this.chbCalculatePnL.Text = "Calculate PnL";
            this.chbCalculatePnL.UseVisualStyleBackColor = true;
            this.chbCalculatePnL.CheckedChanged += new System.EventHandler(this.chbCalculatePnL_CheckedChanged);
            // 
            // chbUpdateInterval
            // 
            this.chbUpdateInterval.Location = new System.Drawing.Point(31, 108);
            this.chbUpdateInterval.Name = "chbUpdateInterval";
            this.chbUpdateInterval.Size = new System.Drawing.Size(151, 22);
            this.chbUpdateInterval.TabIndex = 0;
            this.chbUpdateInterval.Text = "Update interval (seconds)";
            this.chbUpdateInterval.UseVisualStyleBackColor = true;
            this.chbUpdateInterval.CheckedChanged += new System.EventHandler(this.chbUpdateInterval_CheckedChanged);
            // 
            // chbPortfolioPerformance
            // 
            this.chbPortfolioPerformance.Location = new System.Drawing.Point(16, 24);
            this.chbPortfolioPerformance.Name = "chbPortfolioPerformance";
            this.chbPortfolioPerformance.Size = new System.Drawing.Size(237, 22);
            this.chbPortfolioPerformance.TabIndex = 0;
            this.chbPortfolioPerformance.Text = "Enable built-in portfolio performance calculation";
            this.chbPortfolioPerformance.UseVisualStyleBackColor = true;
            this.chbPortfolioPerformance.CheckedChanged += new System.EventHandler(this.chbPortfolioPerformance_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbRemoveOrders);
            this.groupBox2.Location = new System.Drawing.Point(8, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 58);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orders";
            // 
            // chbRemoveOrders
            // 
            this.chbRemoveOrders.Location = new System.Drawing.Point(16, 24);
            this.chbRemoveOrders.Name = "chbRemoveOrders";
            this.chbRemoveOrders.Size = new System.Drawing.Size(259, 22);
            this.chbRemoveOrders.TabIndex = 0;
            this.chbRemoveOrders.Text = "Remove done orders from the Order Manager";
            this.chbRemoveOrders.UseVisualStyleBackColor = true;
            this.chbRemoveOrders.CheckedChanged += new System.EventHandler(this.chbRemoveOrders_CheckedChanged);
            // 
            // MemoryManagementPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MemoryManagementPanel";
            this.Size = new System.Drawing.Size(400, 353);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalLength)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    protected override void OnInit()
    {
      MemoryManagementOptions managementOptions = (MemoryManagementOptions) this.Options;
      this.chbPortfolioPerformance.Checked = managementOptions.PortfolioPerformanceEnabled;
      this.chbCalculatePnL.Checked = managementOptions.PortfolioPerformancePnLCalculationEnabled;
      this.chbCalculateDrawdown.Checked = managementOptions.PortfolioPerformanceDrawdownCalculationEnabled;
      this.chbUpdateInterval.Checked = managementOptions.PortfolioPerformanceUpdateOnIntervalEnabled;
      this.nudIntervalLength.Value = (Decimal) managementOptions.PortfolioPerformanceUpdateInterval;
      this.chbRemoveOrders.Checked = managementOptions.RemoveOrders;
      this.UpdateControlsState();
    }

    protected override void OnCommitChanges()
    {
      MemoryManagementOptions managementOptions = (MemoryManagementOptions) this.Options;
      managementOptions.PortfolioPerformanceEnabled = this.chbPortfolioPerformance.Checked;
      managementOptions.PortfolioPerformanceDrawdownCalculationEnabled = this.chbCalculateDrawdown.Checked;
      managementOptions.PortfolioPerformancePnLCalculationEnabled = this.chbCalculatePnL.Checked;
      managementOptions.RemoveOrders = this.chbRemoveOrders.Checked;
      managementOptions.PortfolioPerformanceUpdateOnIntervalEnabled = this.chbUpdateInterval.Checked;
      managementOptions.PortfolioPerformanceUpdateInterval = (long) this.nudIntervalLength.Value;
      managementOptions.Save();
    }

    private void chbPortfolioPerformance_CheckedChanged(object sender, EventArgs e)
    {
      this.OptionsChanged = true;
      this.UpdateControlsState();
    }

    private void chbCalculatePnL_CheckedChanged(object sender, EventArgs e)
    {
      this.OptionsChanged = true;
    }

    private void chbCalculateDrawdown_CheckedChanged(object sender, EventArgs e)
    {
      this.OptionsChanged = true;
    }

    private void chbUpdateInterval_CheckedChanged(object sender, EventArgs e)
    {
      this.OptionsChanged = true;
      this.UpdateControlsState();
    }

    private void nudIntervalLength_ValueChanged(object sender, EventArgs e)
    {
      this.OptionsChanged = true;
    }

    private void chbRemoveOrders_CheckedChanged(object sender, EventArgs e)
    {
      this.OptionsChanged = true;
    }

    private void UpdateControlsState()
    {
      if (this.chbPortfolioPerformance.Checked)
      {
        this.chbCalculatePnL.Enabled = true;
        this.chbCalculateDrawdown.Enabled = true;
        this.chbUpdateInterval.Enabled = true;
        this.nudIntervalLength.Enabled = this.chbUpdateInterval.Checked;
      }
      else
      {
        this.chbCalculatePnL.Enabled = false;
        this.chbCalculateDrawdown.Enabled = false;
        this.chbUpdateInterval.Enabled = false;
        this.nudIntervalLength.Enabled = false;
      }
    }
  }
}

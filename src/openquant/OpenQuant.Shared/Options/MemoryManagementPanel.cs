using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Options
{
  class MemoryManagementPanel : OptionsPanel
  {
    private IContainer components;
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
      this.groupBox1 = new GroupBox();
      this.nudIntervalLength = new NumericUpDown();
      this.chbCalculateDrawdown = new CheckBox();
      this.chbCalculatePnL = new CheckBox();
      this.chbUpdateInterval = new CheckBox();
      this.chbPortfolioPerformance = new CheckBox();
      this.groupBox2 = new GroupBox();
      this.chbRemoveOrders = new CheckBox();
      this.groupBox1.SuspendLayout();
      this.nudIntervalLength.BeginInit();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.nudIntervalLength);
      this.groupBox1.Controls.Add((Control) this.chbCalculateDrawdown);
      this.groupBox1.Controls.Add((Control) this.chbCalculatePnL);
      this.groupBox1.Controls.Add((Control) this.chbUpdateInterval);
      this.groupBox1.Controls.Add((Control) this.chbPortfolioPerformance);
      this.groupBox1.Location = new Point(8, 4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(384, 148);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Performance";
      this.nudIntervalLength.Location = new Point(195, 108);
      this.nudIntervalLength.Maximum = new Decimal(new int[4]
      {
        -727379968,
        232,
        0,
        0
      });
      NumericUpDown numericUpDown1 = this.nudIntervalLength;
      int[] bits1 = new int[4];
      bits1[0] = 1;
      Decimal num1 = new Decimal(bits1);
      numericUpDown1.Minimum = num1;
      this.nudIntervalLength.Name = "nudIntervalLength";
      this.nudIntervalLength.Size = new Size(73, 20);
      this.nudIntervalLength.TabIndex = 3;
      this.nudIntervalLength.TextAlign = HorizontalAlignment.Right;
      this.nudIntervalLength.ThousandsSeparator = true;
      NumericUpDown numericUpDown2 = this.nudIntervalLength;
      int[] bits2 = new int[4];
      bits2[0] = 1;
      Decimal num2 = new Decimal(bits2);
      numericUpDown2.Value = num2;
      this.nudIntervalLength.ValueChanged += new EventHandler(this.nudIntervalLength_ValueChanged);
      this.chbCalculateDrawdown.Location = new Point(31, 80);
      this.chbCalculateDrawdown.Name = "chbCalculateDrawdown";
      this.chbCalculateDrawdown.Size = new Size(237, 22);
      this.chbCalculateDrawdown.TabIndex = 2;
      this.chbCalculateDrawdown.Text = "Calculate Drawdown";
      this.chbCalculateDrawdown.UseVisualStyleBackColor = true;
      this.chbCalculateDrawdown.CheckedChanged += new EventHandler(this.chbCalculateDrawdown_CheckedChanged);
      this.chbCalculatePnL.Location = new Point(31, 52);
      this.chbCalculatePnL.Name = "chbCalculatePnL";
      this.chbCalculatePnL.Size = new Size(237, 22);
      this.chbCalculatePnL.TabIndex = 1;
      this.chbCalculatePnL.Text = "Calculate PnL";
      this.chbCalculatePnL.UseVisualStyleBackColor = true;
      this.chbCalculatePnL.CheckedChanged += new EventHandler(this.chbCalculatePnL_CheckedChanged);
      this.chbUpdateInterval.Location = new Point(31, 108);
      this.chbUpdateInterval.Name = "chbUpdateInterval";
      this.chbUpdateInterval.Size = new Size(151, 22);
      this.chbUpdateInterval.TabIndex = 0;
      this.chbUpdateInterval.Text = "Update interval (seconds)";
      this.chbUpdateInterval.UseVisualStyleBackColor = true;
      this.chbUpdateInterval.CheckedChanged += new EventHandler(this.chbUpdateInterval_CheckedChanged);
      this.chbPortfolioPerformance.Location = new Point(16, 24);
      this.chbPortfolioPerformance.Name = "chbPortfolioPerformance";
      this.chbPortfolioPerformance.Size = new Size(237, 22);
      this.chbPortfolioPerformance.TabIndex = 0;
      this.chbPortfolioPerformance.Text = "Enable built-in portfolio performance calculation";
      this.chbPortfolioPerformance.UseVisualStyleBackColor = true;
      this.chbPortfolioPerformance.CheckedChanged += new EventHandler(this.chbPortfolioPerformance_CheckedChanged);
      this.groupBox2.Controls.Add((Control) this.chbRemoveOrders);
      this.groupBox2.Location = new Point(8, 162);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(384, 58);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Orders";
      this.chbRemoveOrders.Location = new Point(16, 24);
      this.chbRemoveOrders.Name = "chbRemoveOrders";
      this.chbRemoveOrders.Size = new Size(259, 22);
      this.chbRemoveOrders.TabIndex = 0;
      this.chbRemoveOrders.Text = "Remove done orders from the Order Manager";
      this.chbRemoveOrders.UseVisualStyleBackColor = true;
      this.chbRemoveOrders.CheckedChanged += new EventHandler(this.chbRemoveOrders_CheckedChanged);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.Name = "MemoryManagementPanel";
      this.groupBox1.ResumeLayout(false);
      this.nudIntervalLength.EndInit();
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

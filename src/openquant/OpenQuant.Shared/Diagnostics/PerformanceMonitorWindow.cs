using OpenQuant.Shared.Properties;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TD.SandDock;
using OpenQuant.Shared.Charting;
using System.Windows.Forms.DataVisualization.Charting;

namespace OpenQuant.Shared.Diagnostics
{
    public class PerformanceMonitorWindow : FreeQuant.Docking.WinForms.DockControl
    {
        private const string KEY_MONITOR_INTERVAL = "monitor.interval";
        private IContainer components = null;
        private ToolStrip toolStrip1;
        private ToolStripButton tbbResetCounters;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox cbxMonitorInterval;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ListView ltvEvents;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private PerformanceCounter counter;

        private TimeSpan MonitorInterval
        {
            get
            {
                return this.Settings.GetTimeSpanValue("monitor.interval", TimeSpan.FromMinutes(10.0));
            }
            set
            {
                this.Settings.SetValue("monitor.interval", value);
            }
        }

        public PerformanceMonitorWindow()
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbbResetCounters = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbxMonitorInterval = new System.Windows.Forms.ToolStripComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ltvEvents = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbbResetCounters,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.cbxMonitorInterval});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(578, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbbResetCounters
            // 
            this.tbbResetCounters.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbResetCounters.Image = global::OpenQuant.Shared.Properties.Resources.perfmon_reset;
            this.tbbResetCounters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbResetCounters.Name = "tbbResetCounters";
            this.tbbResetCounters.Size = new System.Drawing.Size(23, 22);
            this.tbbResetCounters.Text = "toolStripButton1";
            this.tbbResetCounters.ToolTipText = "Reset counters";
            this.tbbResetCounters.Click += new System.EventHandler(this.tbbResetCounters_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(92, 22);
            this.toolStripLabel1.Text = "Monitor Interval";
            // 
            // cbxMonitorInterval
            // 
            this.cbxMonitorInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMonitorInterval.DropDownWidth = 60;
            this.cbxMonitorInterval.Name = "cbxMonitorInterval";
            this.cbxMonitorInterval.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxMonitorInterval.Size = new System.Drawing.Size(75, 25);
            this.cbxMonitorInterval.SelectedIndexChanged += new System.EventHandler(this.cbxMonitorInterval_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 438);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ltvEvents);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(570, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Events";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ltvEvents
            // 
            this.ltvEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ltvEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltvEvents.FullRowSelect = true;
            this.ltvEvents.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ltvEvents.HideSelection = false;
            this.ltvEvents.LabelWrap = false;
            this.ltvEvents.Location = new System.Drawing.Point(3, 3);
            this.ltvEvents.MultiSelect = false;
            this.ltvEvents.Name = "ltvEvents";
            this.ltvEvents.ShowItemToolTips = true;
            this.ltvEvents.Size = new System.Drawing.Size(564, 406);
            this.ltvEvents.TabIndex = 3;
            this.ltvEvents.UseCompatibleStateImageBehavior = false;
            this.ltvEvents.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Event";
            this.columnHeader1.Width = 159;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Average (per sec)";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 122;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Peak (per sec)";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 100;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(570, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Performance";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AlignWithChartArea = "ChartArea2";
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)));
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.DarkGreen;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGreen;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Empty;
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 8;
            chartArea1.AxisY.LabelAutoFitMinFontSize = 7;
            chartArea1.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont)));
            chartArea1.AxisY.LineColor = System.Drawing.Color.Green;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGreen;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            chartArea2.AlignWithChartArea = "ChartArea2";
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)));
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.LineColor = System.Drawing.Color.DarkGreen;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGreen;
            chartArea2.AxisY.LabelAutoFitMaxFontSize = 8;
            chartArea2.AxisY.LabelAutoFitMinFontSize = 7;
            chartArea2.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont)));
            chartArea2.AxisY.LineColor = System.Drawing.Color.Green;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGreen;
            chartArea2.AxisY.Maximum = 100D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea3";
            chartArea3.AlignWithChartArea = "ChartArea1";
            chartArea3.AxisX.LabelAutoFitMaxFontSize = 8;
            chartArea3.AxisX.LabelAutoFitMinFontSize = 7;
            chartArea3.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont)));
            chartArea3.AxisX.LabelStyle.Format = "HH:mm:ss";
            chartArea3.AxisX.LineColor = System.Drawing.Color.DarkGreen;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGreen;
            chartArea3.AxisY.LabelAutoFitMaxFontSize = 8;
            chartArea3.AxisY.LabelAutoFitMinFontSize = 7;
            chartArea3.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont)));
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGreen;
            chartArea3.BackColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea2";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.ChartAreas.Add(chartArea2);
            this.chart.ChartAreas.Add(chartArea3);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Location = new System.Drawing.Point(3, 3);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Gold;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Events (Market Data)";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.DeepSkyBlue;
            series2.IsVisibleInLegend = false;
            series2.IsXValueIndexed = true;
            series2.Name = "Events (Execution)";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series3.ChartArea = "ChartArea3";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Lime;
            series3.IsVisibleInLegend = false;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "CPU Usage (Total)";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series4.ChartArea = "ChartArea3";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Red;
            series4.IsVisibleInLegend = false;
            series4.IsXValueIndexed = true;
            series4.Legend = "Legend1";
            series4.Name = "CPU Usage (Core)";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series5.ChartArea = "ChartArea2";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Yellow;
            series5.IsXValueIndexed = true;
            series5.Legend = "Legend1";
            series5.Name = "Memory allocation";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Series.Add(series4);
            this.chart.Series.Add(series5);
            this.chart.Size = new System.Drawing.Size(564, 406);
            this.chart.TabIndex = 4;
            this.chart.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.DockedToChartArea = "ChartArea1";
            title1.IsDockedInsideChartArea = false;
            title1.Name = "Title1";
            title1.Text = "Events, per sec";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.DockedToChartArea = "ChartArea3";
            title2.IsDockedInsideChartArea = false;
            title2.Name = "Title3";
            title2.Text = "CPU Usage, %";
            title3.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title3.DockedToChartArea = "ChartArea2";
            title3.IsDockedInsideChartArea = false;
            title3.Name = "Title2";
            title3.Text = "Memory allocation, MB";
            this.chart.Titles.Add(title1);
            this.chart.Titles.Add(title2);
            this.chart.Titles.Add(title3);
            // 
            // PerformanceMonitorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.DefaultDockLocation = TD.SandDock.ContainerDockLocation.Center;
            this.Name = "PerformanceMonitorWindow";
            this.Size = new System.Drawing.Size(578, 463);
            this.TabImage = global::OpenQuant.Shared.Properties.Resources.perfmon;
            this.Text = "Performance Monitor";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void OnInit()
        {
            this.cbxMonitorInterval.BeginUpdate();
            this.cbxMonitorInterval.Items.Clear();
            this.cbxMonitorInterval.Items.Add((object)(MonitorIntervalItem)TimeSpan.FromMinutes(1.0));
            this.cbxMonitorInterval.Items.Add((object)(MonitorIntervalItem)TimeSpan.FromMinutes(5.0));
            this.cbxMonitorInterval.Items.Add((object)(MonitorIntervalItem)TimeSpan.FromMinutes(10.0));
            this.cbxMonitorInterval.Items.Add((object)(MonitorIntervalItem)TimeSpan.FromMinutes(30.0));
            this.cbxMonitorInterval.Items.Add((object)(MonitorIntervalItem)TimeSpan.FromHours(1.0));
            this.cbxMonitorInterval.Items.Add((object)(MonitorIntervalItem)TimeSpan.FromHours(3.0));
            this.cbxMonitorInterval.Items.Add((object)(MonitorIntervalItem)TimeSpan.FromHours(6.0));
            this.cbxMonitorInterval.Items.Add((object)(MonitorIntervalItem)TimeSpan.FromHours(12.0));
            this.cbxMonitorInterval.SelectedItem = (object)(MonitorIntervalItem)this.MonitorInterval;
            this.cbxMonitorInterval.EndUpdate();
            this.counter = new PerformanceCounter();
            this.ltvEvents.BeginUpdate();
            this.ltvEvents.Groups.Clear();
            this.ltvEvents.Items.Clear();
            ListViewGroup group1 = this.ltvEvents.Groups.Add("MarketData", "Market data");
            ListViewGroup group2 = this.ltvEvents.Groups.Add("Execution", "Execution");
            ListViewGroup group3 = this.ltvEvents.Groups.Add("Memory", "Memory");
            this.ltvEvents.Items.Add((ListViewItem)new PerformanceCounterViewItem("Bar", group1, this.counter.Bar));
            this.ltvEvents.Items.Add((ListViewItem)new PerformanceCounterViewItem("Trade", group1, this.counter.Trade));
            this.ltvEvents.Items.Add((ListViewItem)new PerformanceCounterViewItem("Quote", group1, this.counter.Quote));
            this.ltvEvents.Items.Add((ListViewItem)new PerformanceCounterViewItem("Market Depth", group1, this.counter.MarketDepth));
            this.ltvEvents.Items.Add(new ListViewItem(string.Empty, group1));
            this.ltvEvents.Items.Add((ListViewItem)new PerformanceCounterViewItem("Total", group1, this.counter.MarketDataTotal));
            this.ltvEvents.Items.Add(new ListViewItem(string.Empty, group1));
            this.ltvEvents.Items.Add((ListViewItem)new PerformanceCounterViewItem("Order", group2, this.counter.Order));
            this.ltvEvents.Items.Add((ListViewItem)new PerformanceCounterViewItem("Execution Report", group2, this.counter.Report));
            this.ltvEvents.Items.Add((ListViewItem)new PerformanceCounterViewItem("Cancel & Replace Reject", group2, this.counter.Reject));
            this.ltvEvents.Items.Add(new ListViewItem(string.Empty, group2));
            this.ltvEvents.Items.Add((ListViewItem)new PerformanceCounterViewItem("Total", group2, this.counter.ExecutionTotal));
            this.ltvEvents.Items.Add(new ListViewItem(string.Empty, group2));
            this.ltvEvents.Items.Add((ListViewItem)new PerformanceCounterViewItem("Total Memory Allocated (bytes)", group3, this.counter.MemoryAllocation));
            this.ltvEvents.EndUpdate();
            this.counter.Updated += new EventHandler(this.counter_Updated);
            this.counter.Start();
        }

        protected override void OnClosing(DockControlClosingEventArgs e)
        {
            this.counter.Stop();
        }

        private void counter_Updated(object sender, EventArgs e)
        {
            Action action = (Action)(() =>
            {
                foreach (ListViewItem item_0 in this.ltvEvents.Items)
                {
                    if (item_0 is PerformanceCounterViewItem)
                        ((PerformanceCounterViewItem)item_0).Update();
                }
                DateTime local_1 = DateTime.Now;
                ((Collection<Series>)this.chart.Series)[0].Points.AddXY((object)local_1, new object[1]
                {
                    (object)this.counter.MarketDataTotal.Average
                });
                ((Collection<Series>)this.chart.Series)[1].Points.AddXY((object)local_1, new object[1]
                {
                    (object)this.counter.ExecutionTotal.Average
                });
                ((Collection<Series>)this.chart.Series)[2].Points.AddXY((object)local_1, new object[1]
                {
                    (object)this.counter.CPUUsageTotal.Average
                });
                ((Collection<Series>)this.chart.Series)[3].Points.AddXY((object)local_1, new object[1]
                {
                    (object)this.counter.CPUUsageCore.Average
                });
                ((Collection<Series>)this.chart.Series)[4].Points.AddXY((object)local_1, new object[1]
                {
                    (object)(this.counter.MemoryAllocation.Count / 1024L / 1024L)
                });
                double local_2 = local_1.Subtract(this.MonitorInterval).ToOADate();
                bool local_3 = false;
                while (((Collection<Series>)this.chart.Series)[0].Points[0].XValue < local_2)
                {
                    ((Collection<Series>)this.chart.Series)[0].Points.RemoveAt(0);
                    ((Collection<Series>)this.chart.Series)[1].Points.RemoveAt(0);
                    ((Collection<Series>)this.chart.Series)[2].Points.RemoveAt(0);
                    ((Collection<Series>)this.chart.Series)[3].Points.RemoveAt(0);
                    ((Collection<Series>)this.chart.Series)[4].Points.RemoveAt(0);
                    local_3 = true;
                }
                if (!local_3)
                    return;
                this.chart.ResetAutoValues();
            });
            try
            {
                this.Invoke((Delegate)action);
            }
            catch (ObjectDisposedException ex)
            {
            }
        }

        private void tbbResetCounters_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show((IWin32Window)this, "Do you really want to reset counters?", "Reset Counters", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            this.counter.Reset();
            ((Collection<Series>)this.chart.Series)[0].Points.Clear();
            ((Collection<Series>)this.chart.Series)[1].Points.Clear();
            ((Collection<Series>)this.chart.Series)[2].Points.Clear();
            ((Collection<Series>)this.chart.Series)[3].Points.Clear();
            ((Collection<Series>)this.chart.Series)[4].Points.Clear();
        }

        private void cbxMonitorInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.MonitorInterval = (TimeSpan)((MonitorIntervalItem)this.cbxMonitorInterval.SelectedItem);
        }
    }
}

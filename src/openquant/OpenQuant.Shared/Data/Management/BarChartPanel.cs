using OpenQuant.Shared.Charting;
using OpenQuant.Shared.Data;
using FreeQuant.Data;
using FreeQuant.FinChart;
using FreeQuant.Series;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using Chart = OpenQuant.Shared.Charting.Chart;

namespace OpenQuant.Shared.Data.Management
{
  internal class BarChartPanel : ChartPanel
  {
    private IContainer components;
    private Chart chart;

    public override Chart ChartControl
    {
      get
      {
        return this.chart;
      }
    }

    public BarChartPanel()
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (BarChartPanel));
      this.chart = new Chart();
      this.SuspendLayout();
			this.chart.ActionType = (ChartActionType) 0;
      this.chart.AllowDrop = true;
      ((ScrollableControl) this.chart).AutoScroll = true;
			this.chart.BarSeriesStyle = (BSStyle) 0;
      this.chart.BarStyleButtonsEnabled = true;
			this.chart.BorderColor = Color.Gray;
			this.chart.BottomAxisGridColor = Color.LightGray;
			this.chart.BottomAxisLabelColor = Color.LightGray;
			this.chart.CandleDownColor = Color.Black;
			this.chart.CandleUpColor = Color.Lime;
			this.chart.CanvasColor = Color.MidnightBlue;
			this.chart.ChartBackColor = Color.MidnightBlue;
			this.chart.ContextMenuEnabled = true;
			this.chart.CrossColor = Color.DarkGray;
			this.chart.DateTipRectangleColor = Color.LightGray;
			this.chart.DateTipTextColor = Color.Black;
      ((Control) this.chart).Dock = DockStyle.Fill;
			this.chart.DrawItems = false;
      ((Control) this.chart).Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      ((Control) this.chart).Location = new Point(0, 0);
			this.chart.MinNumberOfBars = 125;
      ((Control) this.chart).Name = "chart";
			this.chart.RightAxisGridColor = Color.DimGray;
			this.chart.RightAxisMajorTicksColor = Color.LightGray;
			this.chart.RightAxisMinorTicksColor = Color.LightGray;
			this.chart.RightAxisTextColor = Color.LightGray;
			this.chart.ScaleStyle = (PadScaleStyle) 0;
			this.chart.SessionEnd = TimeSpan.Parse("00:00:00");
			this.chart.SessionGridColor = Color.Empty;
			this.chart.SessionGridEnabled = false;
			this.chart.SessionStart=TimeSpan.Parse("00:00:00");
      ((Control) this.chart).Size = new Size(383, 264);
			this.chart.SmoothingMode=SmoothingMode.HighSpeed;
			this.chart.SplitterColor=Color.LightGray;
      ((Control) this.chart).TabIndex = 0;
			this.chart.UpdateStyle = (ChartUpdateStyle)1;		                            ;
			this.chart.ValTipRectangleColor=Color.LightGray;
			this.chart.ValTipTextColor = Color.Black;
			this.chart.VolumeColor = Color.SteelBlue;
			this.chart.VolumePadVisible = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.Controls.Add((Control) this.chart);
      this.Name = "BarChartPanel";
      this.Size = new Size(383, 264);
      this.ResumeLayout(false);
    }

    protected override void OnInit()
    {
			BarSeries barSeries = new BarSeries(DataSeriesHelper.SeriesNameToString(this.dataSeries.Name));
      foreach (Bar bar in (IEnumerable) this.dataSeries)
        barSeries.Add(bar);
      this.chart.ApplyDefaultTemplate();
      this.chart.SetMainSeries((DoubleSeries) barSeries, true);
    }
  }
}

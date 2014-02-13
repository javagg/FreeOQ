using OpenQuant.Shared;
using OpenQuant.Shared.Data;
using OpenQuant.Shared.Instruments;
using OpenQuant.Shared.Properties;
using OpenQuant.Shared.ToolWindows;
using FreeQuant.Data;
using FreeQuant.FinChart;
using FreeQuant.FIX;
using FreeQuant.Indicators;
using FreeQuant.Instruments;
using FreeQuant.Series;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
//using TD.SandDock;

namespace OpenQuant.Shared.Charting
{
	partial class QuickChartForm 
  {

    private IContainer components;
    private Chart chart;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (QuickChartForm));
      this.chart = new Chart();
      this.SuspendLayout();
			this.chart.ActionType = ChartActionType.None;
			this.chart.ActiveStopColor = Color.Yellow;
      this.chart.AdditionalButtonsEnabled = true;
			this.chart.AllowDrop = true;
			this.chart.AutoScroll = true;
			this.chart.BackColor = Color.MidnightBlue;
			this.chart.BarSeriesStyle = BSStyle.Candle;
      this.chart.BarStyleButtonsEnabled = true;
			this.chart.BorderColor = Color.Gray;
			this.chart.BottomAxisGridColor = Color.LightGray;
			this.chart.BottomAxisLabelColor = Color.LightGray;
			this.chart.CanceledStopColor = Color.Gray;
			this.chart.CandleDownColor = Color.Black;
			this.chart.CandleUpColor = Color.Lime;
			this.chart.CanvasColor = Color.MidnightBlue;
			this.chart.ChartBackColor = Color.MidnightBlue;
			this.chart.ContextMenuEnabled = true;
			this.chart.CrossColor = Color.DarkGray;
			this.chart.DateTipRectangleColor = Color.LightGray;
			this.chart.DateTipTextColor = Color.Black;
      this.chart.DefaultLineColor = Color.White;
			this.chart.Dock = DockStyle.Fill;
			this.chart.DrawItems = false;
			this.chart.ExecutedStopColor = Color.MediumSeaGreen;
			this.chart.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.chart.IndicatorDropEnabled = true;
			this.chart.ItemTextColor = Color.LightGray;
			this.chart.LabelDigitsCount = 2;
			this.chart.Location = new Point(0, 0);
			this.chart.MinNumberOfBars = 125;
			this.chart.Name = "chart";
			this.chart.RightAxesFontSize = 7;
			this.chart.RightAxisGridColor = Color.DimGray;
			this.chart.RightAxisMajorTicksColor = Color.LightGray;
			this.chart.RightAxisMinorTicksColor = Color.LightGray;
			this.chart.RightAxisTextColor = Color.LightGray;
			this.chart.ScaleStyle = PadScaleStyle.Arith;
			this.chart.SelectedItemTextColor = Color.Yellow;
			this.chart.SelectedTransactionHighlightColor = Color.FromArgb(100, 173, 216, 230);
			this.chart.SessionEnd = TimeSpan.Parse("00:00:00");
			this.chart.SessionGridColor = Color.Empty;
			this.chart.SessionGridEnabled=false;
			this.chart.SessionStart = TimeSpan.Parse("00:00:00");
			this.chart.Size = new Size(576, 338);
			this.chart.SmoothingMode = SmoothingMode.HighSpeed;
			this.chart.SplitterColor = Color.LightGray;
			this.chart.TabIndex = 2;
			this.chart.UpdateStyle = ChartUpdateStyle.Trailing;
			this.chart.ValTipRectangleColor = Color.LightGray;
			this.chart.ValTipTextColor = Color.Black;
			this.chart.VolumeColor = Color.SteelBlue;
			this.chart.VolumePadVisible = false;
      this.AllowDrop = true;
      this.Controls.Add((Control) this.chart);
      this.DefaultDockLocation = ContainerDockLocation.Center;
      this.Name = "QuickChartForm";
      this.PersistState = false;
      this.Size = new Size(576, 338);
      this.TabImage = (Image) Resources.chart;
      this.ResumeLayout(false);
    }
  }
}

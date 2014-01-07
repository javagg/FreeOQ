// Type: OpenQuant.Projects.UI.PerformanceWindow
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Config;
using OpenQuant.Properties;
using OpenQuant.Shared.Charting;
using SmartQuant.Docking.WinForms;
using SmartQuant.FinChart;
using SmartQuant.Instruments;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Projects.UI
{
  public class PerformanceWindow : DockControl, IChartControl, IUpdateUI
  {
    private IContainer components;
    private Chart chart;
    private Portfolio currentPortfolio;

    public Chart ChartControl
    {
      get
      {
        return this.chart;
      }
    }

    public PerformanceWindow()
    {
      base.\u002Ector();
      this.InitializeComponent();
      this.chart.ApplyDefaultTemplate();
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      ((DockControl) this).Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (PerformanceWindow));
      this.chart = new Chart();
      ((Control) this).SuspendLayout();
      ((Chart) this.chart).ActionType = ChartActionType.Cross;
      ((Chart) this.chart).ActiveStopColor = Color.Yellow;
      ((Control) this.chart).AllowDrop = true;
      ((ScrollableControl) this.chart).AutoScroll = true;
      ((Control) this.chart).BackColor = Color.MidnightBlue;
      ((Chart) this.chart).BarSeriesStyle = BSStyle.Candle;
      this.chart.set_BarStyleButtonsEnabled(false);
      ((Chart) this.chart).BorderColor = Color.Gray;
      ((Chart) this.chart).BottomAxisGridColor = Color.LightGray;
      ((Chart) this.chart).BottomAxisLabelColor = Color.LightGray;
      ((Chart) this.chart).CanceledStopColor = Color.Gray;
      ((Chart) this.chart).CandleDownColor = Color.Black;
      ((Chart) this.chart).CandleUpColor = Color.Lime;
      ((Chart) this.chart).CanvasColor = Color.MidnightBlue;
      ((Chart) this.chart).ChartBackColor = Color.MidnightBlue;
      ((Chart) this.chart).ContextMenuEnabled = false;
      ((Chart) this.chart).CrossColor = Color.DarkGray;
      ((Chart) this.chart).DateTipRectangleColor = Color.LightGray;
      ((Chart) this.chart).DateTipTextColor = Color.Black;
      this.chart.set_DefaultLineColor(Color.White);
      ((Control) this.chart).Dock = DockStyle.Fill;
      ((Chart) this.chart).DrawItems = false;
      ((Chart) this.chart).ExecutedStopColor = Color.MediumSeaGreen;
      ((Control) this.chart).Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      ((Chart) this.chart).ItemTextColor = Color.LightGray;
      ((Chart) this.chart).LabelDigitsCount = 2;
      ((Control) this.chart).Location = new Point(0, 0);
      ((Chart) this.chart).MinNumberOfBars = 125;
      ((Control) this.chart).Name = "chart";
      ((Chart) this.chart).RightAxesFontSize = 7;
      ((Chart) this.chart).RightAxisGridColor = Color.DimGray;
      ((Chart) this.chart).RightAxisMajorTicksColor = Color.LightGray;
      ((Chart) this.chart).RightAxisMinorTicksColor = Color.LightGray;
      ((Chart) this.chart).RightAxisTextColor = Color.LightGray;
      ((Chart) this.chart).ScaleStyle = PadScaleStyle.Arith;
      ((Chart) this.chart).SelectedItemTextColor = Color.Yellow;
      ((Chart) this.chart).SelectedTransactionHighlightColor = Color.LightBlue;
      ((Chart) this.chart).SessionEnd = TimeSpan.Parse("00:00:00");
      ((Chart) this.chart).SessionGridColor = Color.Empty;
      ((Chart) this.chart).SessionGridEnabled = false;
      ((Chart) this.chart).SessionStart = TimeSpan.Parse("00:00:00");
      ((Control) this.chart).Size = new Size(597, 400);
      ((Chart) this.chart).SmoothingMode = SmoothingMode.HighSpeed;
      ((Chart) this.chart).SplitterColor = Color.LightGray;
      ((Control) this.chart).TabIndex = 0;
      ((Chart) this.chart).UpdateStyle = ChartUpdateStyle.WholeRange;
      ((Chart) this.chart).ValTipRectangleColor = Color.LightGray;
      ((Chart) this.chart).ValTipTextColor = Color.Black;
      ((Chart) this.chart).VolumeColor = Color.SteelBlue;
      ((Chart) this.chart).VolumePadVisible = false;
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
      ((Control) this).Controls.Add((Control) this.chart);
      this.set_DefaultDockLocation((ContainerDockLocation) 5);
      ((Control) this).Name = "PerformanceWindow";
      ((DockControl) this).set_PersistState(false);
      ((Control) this).Size = new Size(597, 400);
      ((DockControl) this).set_TabImage((Image) Resources.performance);
      ((Control) this).Text = "Performance";
      ((Control) this).ResumeLayout(false);
    }

    protected virtual void OnInit()
    {
      Runner.Started += new EventHandler(this.Runner_Started);
      Runner.Stopped += new EventHandler(this.Runner_Stopped);
      this.currentPortfolio = this.get_Key() as Portfolio;
      if (this.currentPortfolio == Configuration.get_Active().get_Portfolio())
      {
        ((Control) this).Text = "Performance";
      }
      else
      {
        string str = this.currentPortfolio.Name;
        if ((int) str[str.Length - 2] == 95)
          str = str.Remove(str.Length - 2, 2);
        if (this.currentPortfolio == Global.ProjectManager.ActiveSolution.SolutionRunner.get_Portfolio())
          str = str.Remove(str.Length - "_Solution".Length, "_Solution".Length);
        ((Control) this).Text = "Performance (" + str + ")";
      }
      Configuration.add_ConfigurationModeChanged(new EventHandler(this.Configuration_ConfigurationModeChanged));
      this.Reset();
    }

    public void UpdateUI()
    {
      ((Control) this).Invoke((Delegate) (() => this.Reset()));
    }

    protected virtual void OnClosing(DockControlClosingEventArgs e)
    {
      Runner.Started -= new EventHandler(this.Runner_Started);
      Runner.Stopped -= new EventHandler(this.Runner_Stopped);
      Configuration.remove_ConfigurationModeChanged(new EventHandler(this.Configuration_ConfigurationModeChanged));
    }

    private void Runner_Started(object sender, EventArgs e)
    {
      if (Global.Flags.UpdateUI)
        ((Control) this).Invoke((Delegate) (() => this.Reset()));
      else
        ((Control) this).Invoke((Delegate) (() =>
        {
          ((Chart) this.chart).Reset();
          Application.DoEvents();
        }));
    }

    private void Runner_Stopped(object sender, EventArgs e)
    {
      if (Global.Flags.UpdateUI)
        return;
      ((Control) this).Invoke((Delegate) (() => this.Reset()));
    }

    private void Configuration_ConfigurationModeChanged(object sender, EventArgs e)
    {
      Portfolio portfolio;
      if (this.currentPortfolio.Name == "Live" || this.currentPortfolio.Name == "Simulation" || this.currentPortfolio.Name == "Paper")
      {
        portfolio = Configuration.get_Active().get_Portfolio();
      }
      else
      {
        string index = this.currentPortfolio.Name.Remove(this.currentPortfolio.Name.Length - 2, 2);
        portfolio = !(index == Global.ProjectManager.ActiveSolution.Name + "_Solution") ? Global.ProjectManager.ActiveSolution.Projects[index].StrategyRunner.get_Portfolio() : Global.ProjectManager.ActiveSolution.SolutionRunner.get_Portfolio();
      }
      this.currentPortfolio = portfolio;
      this.Reset();
    }

    private void Reset()
    {
      Performance performance = this.currentPortfolio.Performance;
      ((Chart) this.chart).Reset();
      this.chart.SetDefaultColoredMainSeries(performance.EquitySeries);
      ((Chart) this.chart).AddPad();
      this.chart.DrawDefaultColoredSeries(performance.PnLSeries, 2, SimpleDSStyle.Bar, SmoothingMode.HighSpeed);
      ((Chart) this.chart).AddPad();
      this.chart.DrawDefaultColoredSeries(performance.DrawdownSeries, 3, SimpleDSStyle.Line, SmoothingMode.HighSpeed);
      ((Chart) this.chart).UpdateStyle = ChartUpdateStyle.WholeRange;
    }
  }
}

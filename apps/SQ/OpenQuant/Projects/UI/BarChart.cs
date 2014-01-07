// Type: OpenQuant.Projects.UI.BarChart
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.API;
using OpenQuant.Config;
using OpenQuant.ObjectMap;
using OpenQuant.Projects;
using OpenQuant.Properties;
using OpenQuant.Shared;
using OpenQuant.Shared.Charting;
using OpenQuant.Shared.Instruments;
using OpenQuant.Trading;
using SmartQuant.Docking.WinForms;
using SmartQuant.FinChart;
using SmartQuant.Instruments;
using SmartQuant.Series;
using SmartQuant.Trading;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Projects.UI
{
  public class BarChart : DockControl, IInstrumentListSource, IChartControl, IUpdateUI
  {
    private IContainer components;
    private Chart chart;
    private IInstrumentSource strategyRunner;
    private Instrument selectedInstrument;
    private Portfolio portfolio;
    private InstrumentListSource instrumentListSource;
    private BarSeries selectedSeries;

    public Chart ChartControl
    {
      get
      {
        return this.chart;
      }
    }

    public InstrumentListSource InstrumentListSource
    {
      get
      {
        return this.instrumentListSource;
      }
    }

    public BarChart()
    {
      base.\u002Ector();
      this.InitializeComponent();
      this.instrumentListSource = new InstrumentListSource();
      this.instrumentListSource.set_AllowAll(false);
      this.instrumentListSource.set_ShowSeries(true);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (BarChart));
      this.chart = new Chart();
      ((Control) this).SuspendLayout();
      ((Chart) this.chart).ActionType = ChartActionType.Cross;
      ((Chart) this.chart).ActiveStopColor = Color.Yellow;
      ((Control) this.chart).AllowDrop = true;
      ((ScrollableControl) this.chart).AutoScroll = true;
      ((Chart) this.chart).BarSeriesStyle = BSStyle.Candle;
      this.chart.set_BarStyleButtonsEnabled(true);
      ((Chart) this.chart).BorderColor = Color.Gray;
      ((Chart) this.chart).BottomAxisGridColor = Color.LightGray;
      ((Chart) this.chart).BottomAxisLabelColor = Color.LightGray;
      ((Chart) this.chart).CanceledStopColor = Color.Gray;
      ((Chart) this.chart).CandleDownColor = Color.Black;
      ((Chart) this.chart).CandleUpColor = Color.Lime;
      ((Chart) this.chart).CanvasColor = Color.MidnightBlue;
      ((Chart) this.chart).ChartBackColor = Color.MidnightBlue;
      ((Chart) this.chart).ContextMenuEnabled = true;
      ((Chart) this.chart).CrossColor = Color.DarkGray;
      ((Chart) this.chart).DateTipRectangleColor = Color.LightGray;
      ((Chart) this.chart).DateTipTextColor = Color.Black;
      this.chart.set_DefaultLineColor(Color.White);
      ((Control) this.chart).Dock = DockStyle.Fill;
      ((Chart) this.chart).DrawItems = false;
      ((Chart) this.chart).ExecutedStopColor = Color.MediumSeaGreen;
      ((Control) this.chart).Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      ((Chart) this.chart).ItemTextColor = Color.LightGray;
      ((Chart) this.chart).LabelDigitsCount = 4;
      ((Control) this.chart).Location = new Point(0, 0);
      ((Chart) this.chart).MinNumberOfBars = 80;
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
      ((Control) this.chart).Size = new Size(449, 361);
      ((Chart) this.chart).SmoothingMode = SmoothingMode.HighSpeed;
      ((Chart) this.chart).SplitterColor = Color.LightGray;
      ((Control) this.chart).TabIndex = 0;
      ((Chart) this.chart).UpdateStyle = ChartUpdateStyle.Trailing;
      ((Chart) this.chart).ValTipRectangleColor = Color.LightGray;
      ((Chart) this.chart).ValTipTextColor = Color.Black;
      ((Chart) this.chart).VolumeColor = Color.SteelBlue;
      ((Chart) this.chart).VolumePadVisible = false;
      ((Control) this).AllowDrop = true;
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
      ((Control) this).Controls.Add((Control) this.chart);
      this.set_DefaultDockLocation((ContainerDockLocation) 5);
      ((Control) this).Name = "BarChart";
      ((DockControl) this).set_PersistState(false);
      ((Control) this).Size = new Size(449, 361);
      ((DockControl) this).set_TabImage((Image) Resources.chart);
      ((Control) this).Text = "Chart";
      ((Control) this).ResumeLayout(false);
    }

    public void UpdateUI()
    {
      ((Control) this).Invoke((Delegate) (() => this.UpdateChart()));
    }

    private void UpdateChart()
    {
      ((Chart) this.chart).Reset();
      if (!Global.Flags.UpdateUI && Runner.IsRunning)
        return;
      this.SetSeries();
    }

    private void SetChartSettings()
    {
      if (!(this.strategyRunner is StrategyRunner))
        return;
      this.chart.ApplyDefaultTemplate();
      StrategyRunner strategyRunner = this.strategyRunner as StrategyRunner;
      if (strategyRunner == null || !strategyRunner.get_Strategies().ContainsKey(this.selectedInstrument))
        return;
      Strategy strategy = strategyRunner.get_Strategies()[this.selectedInstrument];
      if (strategy == null)
        return;
      Chart chart = strategy.get_Chart();
      foreach (FieldInfo fieldInfo in ((object) chart).GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField))
      {
        if (fieldInfo.FieldType == typeof (Color))
        {
          Color color = (Color) fieldInfo.GetValue((object) chart);
          if (color != Color.Transparent)
          {
            PropertyInfo property = ((object) this.chart).GetType().GetProperty(fieldInfo.Name.Substring(0, 1).ToUpper() + fieldInfo.Name.Remove(0, 1), BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.SetProperty);
            if (property != (PropertyInfo) null)
              property.SetValue((object) this.chart, (object) color, (object[]) null);
          }
        }
      }
    }

    private void instrumentListSource_SelectedInstrumentChanged(InstrumentEventArgs args)
    {
      if (args.Instrument == null)
        return;
      this.selectedInstrument = args.Instrument;
    }

    private void instrumentListSource_SelectedSeriesChanged(object sender, EventArgs e)
    {
      this.selectedSeries = this.instrumentListSource.get_SelectedSeries();
      ((Chart) this.chart).Reset();
      if (!Global.Flags.UpdateUI && Runner.IsRunning)
        return;
      this.SetSeries();
    }

    protected virtual void OnInit()
    {
      this.strategyRunner = this.GetKeySource();
      if (this.strategyRunner != null)
        this.strategyRunner.add_StopAdded(new StopEventHandler(this.strategyRunner_StopAdded));
      this.Connect();
      if (this.strategyRunner != null)
        this.Reset();
      this.selectedSeries = this.instrumentListSource.get_SelectedSeries();
      this.SetPortfolio();
      this.UpdateChart();
      this.instrumentListSource.add_SelectedInstrumentChanged(new InstrumentEventHandler(this.instrumentListSource_SelectedInstrumentChanged));
      this.instrumentListSource.add_SelectedSeriesChanged(new EventHandler(this.instrumentListSource_SelectedSeriesChanged));
    }

    private void Bars_BarSeriesRenamed(object sender, BarSeriesEventArgs args)
    {
      if (Runner.IsSearchingBestParameters || !this.instrumentListSource.get_InstrumentTable().ContainsKey(args.Instrument) || this.GetKeyInstrument() != null && args.Instrument != this.selectedInstrument)
        return;
      this.instrumentListSource.RenameSeries(args.Instrument, args.BarSeries);
    }

    private void Bars_BarSeriesAdded(object sender, BarSeriesEventArgs args)
    {
      if (Runner.IsSearchingBestParameters || !this.instrumentListSource.get_InstrumentTable().ContainsKey(args.Instrument) || this.GetKeyInstrument() != null && args.Instrument != this.selectedInstrument)
        return;
      this.instrumentListSource.AddSeries(args.Instrument, args.BarSeries);
    }

    private void Configuration_ConfigurationModeChanged(object sender, EventArgs e)
    {
      this.SetPortfolio();
      this.UpdateChart();
    }

    protected virtual void OnClosing(DockControlClosingEventArgs e)
    {
      this.Disconnect();
      if (this.portfolio != null)
        this.portfolio.TransactionAdded -= new TransactionEventHandler(this.portfolio_TransactionAdded);
      ((DockControl) this).OnClosing(e);
    }

    private void Runner_Started(object sender, EventArgs e)
    {
      // ISSUE: explicit non-virtual call
      if (__nonvirtual (((Control) this).InvokeRequired))
      {
        // ISSUE: explicit non-virtual call
        __nonvirtual (((Control) this).Invoke((Delegate) new EventHandler(this.Runner_Started), sender, (object) e));
      }
      else
      {
        if (this.strategyRunner != null)
          this.strategyRunner.remove_StopAdded(new StopEventHandler(this.strategyRunner_StopAdded));
        this.strategyRunner = this.GetKeySource();
        this.strategyRunner.add_StopAdded(new StopEventHandler(this.strategyRunner_StopAdded));
        if (this.portfolio != null)
          this.portfolio.TransactionAdded += new TransactionEventHandler(this.portfolio_TransactionAdded);
        this.instrumentListSource.set_SelectedSeries((BarSeries) null);
        if (Global.ProjectManager.ActiveSolution.Scenario.get_StartOver())
          return;
        this.Reset();
      }
    }

    private void Runner_Stopped(object sender, EventArgs e)
    {
      if (this.portfolio == null)
        return;
      this.portfolio.TransactionAdded -= new TransactionEventHandler(this.portfolio_TransactionAdded);
    }

    private void Reset()
    {
      this.instrumentListSource.Clear();
      if (this.GetKeyInstrument() == null)
      {
        foreach (Instrument instrument in this.strategyRunner.get_Instruments())
          this.instrumentListSource.AddInstrument(instrument);
        if (this.strategyRunner.get_Instruments().Count > 0)
        {
          this.selectedInstrument = this.strategyRunner.get_Instruments()[0];
          this.instrumentListSource.set_SelectedInstrument(this.selectedInstrument);
        }
        if (this.strategyRunner is StrategyRunner)
          ((Control) this).Text = "Chart (" + (this.strategyRunner as StrategyRunner).get_StrategyName() + ")";
        else
          ((Control) this).Text = "Chart";
        foreach (DictionaryEntry dictionaryEntry in DataManager.Bars)
        {
          foreach (BarSeries barSeries in (IEnumerable) dictionaryEntry.Value)
            this.instrumentListSource.AddSeries(dictionaryEntry.Key as Instrument, barSeries);
        }
      }
      else
      {
        this.instrumentListSource.AddInstrument(this.GetKeyInstrument());
        this.instrumentListSource.set_SelectedInstrument(this.GetKeyInstrument());
        this.selectedInstrument = this.instrumentListSource.get_SelectedInstrument();
        if (this.strategyRunner is StrategyRunner)
          ((Control) this).Text = "Chart (" + (this.strategyRunner as StrategyRunner).get_StrategyName() + " [" + this.selectedInstrument.Symbol + "])";
        else
          ((Control) this).Text = "Chart [" + this.selectedInstrument.Symbol + "]";
        foreach (DictionaryEntry dictionaryEntry in DataManager.Bars)
        {
          if (dictionaryEntry.Key as Instrument == this.instrumentListSource.get_SelectedInstrument())
          {
            foreach (BarSeries barSeries in (IEnumerable) dictionaryEntry.Value)
              this.instrumentListSource.AddSeries(dictionaryEntry.Key as Instrument, barSeries);
          }
        }
      }
      this.instrumentListSource.Refresh();
    }

    private void SetSeries()
    {
      if (this.selectedSeries != null)
        ((Chart) this.chart).SetMainSeries((DoubleSeries) this.selectedSeries, true);
      if (this.selectedInstrument != null)
      {
        List<string> list = new List<string>();
        if (this.strategyRunner is StrategyRunner)
        {
          list.Add((this.strategyRunner as StrategyRunner).get_StrategyName());
        }
        else
        {
          using (Dictionary<string, StrategyRunner>.KeyCollection.Enumerator enumerator = (this.strategyRunner as SolutionRunner).get_Runners().Keys.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              string current = enumerator.Current;
              list.Add(current);
            }
          }
        }
        int num1 = 0;
        foreach (string str in list)
        {
          int num2 = num1;
          if (((Hashtable) Map.DrawTable).ContainsKey((object) str))
          {
            Dictionary<Instrument, Dictionary<DoubleSeries, Tuple<int, DrawStyle>>> dictionary = ((Hashtable) Map.DrawTable)[(object) str] as Dictionary<Instrument, Dictionary<DoubleSeries, Tuple<int, DrawStyle>>>;
            if (dictionary.ContainsKey(this.selectedInstrument))
            {
              using (Dictionary<DoubleSeries, Tuple<int, DrawStyle>>.Enumerator enumerator = dictionary[this.selectedInstrument].GetEnumerator())
              {
                while (enumerator.MoveNext())
                {
                  KeyValuePair<DoubleSeries, Tuple<int, DrawStyle>> current = enumerator.Current;
                  int num3 = current.Value.Item1;
                  DrawStyle drawStyle = current.Value.Item2;
                  DoubleSeries key = current.Key;
                  while (num3 > ((Chart) this.chart).PadCount - 1 - num2)
                  {
                    ((Chart) this.chart).AddPad();
                    ++num1;
                  }
                  int padNumber = num3;
                  if (num3 > 1)
                    padNumber += num2;
                  ((Chart) this.chart).DrawSeries(key, padNumber, key.Color, this.ConvertStyle(drawStyle));
                }
              }
            }
          }
        }
        if (this.strategyRunner != null)
        {
          foreach (ATSStop stop in this.strategyRunner.get_Stops())
          {
            if (stop.Instrument == this.selectedInstrument)
              ((Chart) this.chart).DrawStop(stop, 0);
          }
        }
        foreach (Transaction transaction in this.portfolio.Transactions)
        {
          if (transaction.Instrument == this.selectedInstrument)
            ((Chart) this.chart).DrawTransaction(transaction, 0);
        }
      }
      if (this.selectedInstrument == null)
        return;
      this.SetChartSettings();
      ((Chart) this.chart).LabelDigitsCount = PriceFormatHelper.GetDecimalPlaces(this.selectedInstrument);
    }

    private SimpleDSStyle ConvertStyle(DrawStyle drawStyle)
    {
      switch ((int) drawStyle)
      {
        case 0:
          return SimpleDSStyle.Line;
        case 1:
          return SimpleDSStyle.Bar;
        case 2:
          return SimpleDSStyle.Circle;
        default:
          throw new NotSupportedException("DrawStyle " + (object) drawStyle + " is not supported.");
      }
    }

    private void SetPortfolio()
    {
      if (this.portfolio != null)
        this.portfolio.TransactionAdded -= new TransactionEventHandler(this.portfolio_TransactionAdded);
      this.portfolio = this.GetKeySource().get_Portfolio();
      this.portfolio.TransactionAdded += new TransactionEventHandler(this.portfolio_TransactionAdded);
    }

    private void Connect()
    {
      Runner.Started += new EventHandler(this.Runner_Started);
      Runner.Stopped += new EventHandler(this.Runner_Stopped);
      DataManager.Bars.BarSeriesAdded += new BarSeriesEventHandler(this.Bars_BarSeriesAdded);
      DataManager.Bars.BarSeriesRenamed += new BarSeriesEventHandler(this.Bars_BarSeriesRenamed);
      Configuration.add_ConfigurationModeChanged(new EventHandler(this.Configuration_ConfigurationModeChanged));
    }

    private void Disconnect()
    {
      Runner.Started -= new EventHandler(this.Runner_Started);
      Runner.Stopped -= new EventHandler(this.Runner_Stopped);
      DataManager.Bars.BarSeriesAdded -= new BarSeriesEventHandler(this.Bars_BarSeriesAdded);
      DataManager.Bars.BarSeriesRenamed -= new BarSeriesEventHandler(this.Bars_BarSeriesRenamed);
      Configuration.remove_ConfigurationModeChanged(new EventHandler(this.Configuration_ConfigurationModeChanged));
      if (this.strategyRunner != null)
        this.strategyRunner.remove_StopAdded(new StopEventHandler(this.strategyRunner_StopAdded));
      if (this.portfolio == null)
        return;
      this.portfolio.TransactionAdded -= new TransactionEventHandler(this.portfolio_TransactionAdded);
    }

    private void portfolio_TransactionAdded(object sender, TransactionEventArgs args)
    {
      if (Runner.IsSearchingBestParameters || !Global.Flags.UpdateUI || args.Transaction.Instrument != this.selectedInstrument)
        return;
      ((Chart) this.chart).DrawTransaction(args.Transaction, 0);
    }

    private void strategyRunner_StopAdded(StopEventArgs args)
    {
      if (Runner.IsSearchingBestParameters || !Global.Flags.UpdateUI)
        return;
      ATSStop stop = args.Stop as ATSStop;
      if (stop.Instrument != this.selectedInstrument)
        return;
      ((Chart) this.chart).DrawStop(stop, 0);
    }

    private Instrument GetKeyInstrument()
    {
      return ((KeyValuePair<StrategyProject, Instrument>) this.get_Key()).Value;
    }

    private IInstrumentSource GetKeySource()
    {
      KeyValuePair<StrategyProject, Instrument> keyValuePair = (KeyValuePair<StrategyProject, Instrument>) this.get_Key();
      if (keyValuePair.Key == null)
        return (IInstrumentSource) Global.ProjectManager.ActiveSolution.SolutionRunner;
      else
        return (IInstrumentSource) keyValuePair.Key.StrategyRunner;
    }
  }
}

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
	partial class QuickChartForm : FreeQuant.Docking.WinForms.DockControl, IPropertyEditable, IInstrumentListSource, IChartControl
  {
    private List<Color> colors = new List<Color>();
    private Dictionary<string, string> seriesNames = new Dictionary<string, string>();
    private Instrument instrument;
    private ChartTemplate template;
    private DoubleSeries series;
    private InstrumentListSource instrumentListSource;

    public object PropertyObject { get; private set; }

    public InstrumentListSource InstrumentListSource
    {
      get
      {
        return this.instrumentListSource;
      }
    }

    public Chart ChartControl
    {
      get
      {
        return this.chart;
      }
    }

    public QuickChartForm()
    {
      this.InitializeComponent();
      this.chart.IndicatorDropped += new IndicatorEventHandler(this.chart_IndicatorDropped);
      this.chart.TimeFrameChanged += new TimeFrameEventHandler(this.chartToolStrip1_TimeFrameChanged);
      this.chart.TemplateAction += new EventHandler<TemplateActionEventArgs>(this.chartToolStrip1_TemplateAction);
      this.chart.ChartPropertiesCalled += new EventHandler(this.chart_ChartPropertiesCalled);
      this.chart.ApplyDefaultTemplate();
      this.instrumentListSource = new InstrumentListSource();
      this.instrumentListSource.AllowAll = false;
      this.instrumentListSource.ShowSeries = true;
      this.instrumentListSource.SelectedSeriesChanged += new EventHandler(this.instrumentListSource_SelectedSeriesChanged);
    }

    private void chart_ChartPropertiesCalled(object sender, EventArgs e)
    {
      Tuple<object, bool> tuple = sender as Tuple<object, bool>;
      this.PropertyObject = tuple.Item1;
      Global.ToolWindowManager.ShowProperties((IPropertyEditable) this, tuple.Item2);
    }

    private void instrumentListSource_SelectedSeriesChanged(object sender, EventArgs e)
    {
      string name = ((TimeSeries) this.instrumentListSource.SelectedSeries).Name;
      IDataSeries dataSeries = DataManager.Server.GetDataSeries(this.seriesNames[name]);
      BarSeries series = new BarSeries(name);
      foreach (Bar bar in (IEnumerable) dataSeries)
        series.Add(bar);
      this.UpdateMe(series);
    }

    private void chartToolStrip1_TemplateAction(object sender, TemplateActionEventArgs args)
    {
      switch (args.ActionType)
      {
        case TemplateActionType.Load:
          this.template = Global.ChartManager.Templates[args.TemplateName];
          this.ApplyTemplate();
          ((Control) this.chart).Refresh();
          break;
        case TemplateActionType.Save:
        case TemplateActionType.SaveAs:
          SaveTemplateDialog saveTemplateDialog = new SaveTemplateDialog();
          if (saveTemplateDialog.ShowDialog() != DialogResult.OK)
            break;
          Global.ChartManager.Templates.Add(saveTemplateDialog.TemplateName, this.template);
          break;
        case TemplateActionType.ChooseEmpty:
          this.template = Global.ChartManager.Templates.EmptyTemplate;
          this.ApplyTemplate();
          ((Control) this.chart).Refresh();
          break;
        case TemplateActionType.ChooseDefault:
          this.template = Global.ChartManager.Templates["Default Template"];
          this.ApplyTemplate();
          ((Control) this.chart).Refresh();
          break;
        case TemplateActionType.SetDefault:
          Global.ChartManager.Templates.Replace("Default Template", this.template);
          break;
      }
    }

    private void chartToolStrip1_TimeFrameChanged(ChartTimeFrame timeFrame)
    {
      BarSeries barSeries = new BarSeries();
			((TimeSeries) barSeries).DataSeries = ((TimeSeries) this.instrument.GetDailySeries()).DataSeries;
      BarSeries series = null;
      switch (timeFrame)
      {
        case ChartTimeFrame.Day:
          series = barSeries;
		  series.Name = ((FIXInstrument) this.instrument).Symbol + " - Daily";
          break;
        case ChartTimeFrame.Week:
          series = barSeries.Compress(604800L);
		 series.Name = ((FIXInstrument) this.instrument).Symbol + " - Weely";
          break;
        case ChartTimeFrame.Month:
          series = barSeries.Compress(2419200L);
	 	series.Name = ((FIXInstrument) this.instrument).Symbol + " - Monthly";
          break;
        case ChartTimeFrame.Year:
          series = barSeries.Compress(29030400L);
		series.Name = ((FIXInstrument) this.instrument).Symbol + " - Annual";
          break;
      }
      this.UpdateMe(series);
    }

    protected override void OnInit()
    {
      this.instrument = this.Key as Instrument;
      DataSeriesList dataSeries = this.instrument.GetDataSeries();
      this.template = Global.ChartManager.Templates["Default Template"];
      this.Text = "Chart [" + ((FIXInstrument) this.instrument).Symbol + "]";
      this.instrumentListSource.AddInstrument(this.instrument);
      this.instrumentListSource.SelectedInstrument = this.instrument;
      IEnumerator enumerator = dataSeries.GetEnumerator();
      try
      {
        while (enumerator.MoveNext())
        {
          IDataSeries idataSeries = (IDataSeries) enumerator.Current;
          string key = DataSeriesHelper.SeriesNameToString(idataSeries.Name);
          if (key.StartsWith("Bar") || key == "Daily")
          {
            this.seriesNames.Add(key, idataSeries.Name);
            this.instrumentListSource.AddSeries(this.instrument, new BarSeries(key));
          }
        }
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        if (disposable != null)
          disposable.Dispose();
      }
      this.instrumentListSource.Refresh();
    }

    private void UpdateMe(BarSeries series)
    {
      this.series = (DoubleSeries) series;
      this.ApplyTemplate();
    }

    private void ApplyTemplate()
    {
      this.chart.Reset();
			this.chart.LabelDigitsCount = PriceFormatHelper.GetDecimalPlaces(this.instrument);
      this.chart.SetMainSeries(this.series, true);
      this.template.Create(this.series);
      using (Dictionary<int, List<Indicator>>.Enumerator enumerator1 = this.template.GetIndicators().GetEnumerator())
      {
        while (enumerator1.MoveNext())
        {
          KeyValuePair<int, List<Indicator>> current1 = enumerator1.Current;
          if (current1.Key > 1)
            this.chart.AddPad();
          using (List<Indicator>.Enumerator enumerator2 = current1.Value.GetEnumerator())
          {
            while (enumerator2.MoveNext())
            {
              Indicator current2 = enumerator2.Current;
              this.chart.DrawSeries((DoubleSeries) current2, current1.Key, ((TimeSeries) current2).Color);
            }
          }
        }
      }
    }

    private void chart_IndicatorDropped(System.Type indicatorType, Point point)
    {
      AddIndicatorForm addIndicatorForm = new AddIndicatorForm(indicatorType, this.chart.PadCount, this.series, this.template.GetIndicatorList(), this.chart.GetPadNumber(point), this.GetNextColor());
      if (addIndicatorForm.ShowDialog() != DialogResult.OK)
        return;
      int pad = addIndicatorForm.PadNumber;
      if (pad == -1)
      {
        this.chart.AddPad();
        pad = this.chart.PadCount - 1;
      }
      this.chart.DrawSeries((DoubleSeries) addIndicatorForm.Indicator, pad, ((TimeSeries) addIndicatorForm.Indicator).Color);
      if (addIndicatorForm.SeriesItem.Series == this.series)
        this.template.AddIndicator(pad, addIndicatorForm.Indicator);
      else
        this.template.AddIndicator(pad, addIndicatorForm.Indicator, addIndicatorForm.SeriesItem.Series as Indicator);
      ((Control) this.chart).Refresh();
    }

    private Color GetNextColor()
    {
      if (this.colors.Count == 0)
      {
        this.colors.Add(Color.Yellow);
        this.colors.Add(Color.Pink);
        this.colors.Add(Color.Brown);
        this.colors.Add(Color.LightBlue);
        this.colors.Add(Color.Wheat);
        this.colors.Add(Color.LightGreen);
        this.colors.Add(Color.MistyRose);
        this.colors.Add(Color.LightGray);
      }
      Color color = this.colors[0];
      this.colors.RemoveAt(0);
      return color;
    }

  }
}

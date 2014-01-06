// Type: OpenQuant.API.Indicators.PERF
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class PERF : Indicator
  {
    [Category("Parameters")]
    [Description("K")]
    public double K
    {
      get
      {
        return (this.indicator as PERF).get_K();
      }
      set
      {
        (this.indicator as PERF).set_K(value);
      }
    }

    private PERF()
    {
      this.indicator = (Indicator) new PERF();
    }

    public PERF(OpenQuant.API.BarSeries series, double k)
    {
      this.indicator = (Indicator) new PERF((SmartQuant.Series.TimeSeries) series.series, k);
    }

    public PERF(Indicator indicator, double k)
    {
      this.indicator = (Indicator) new PERF((SmartQuant.Series.TimeSeries) indicator.indicator, k);
    }

    public PERF(OpenQuant.API.BarSeries series, double k, BarData option)
    {
      this.indicator = (Indicator) new PERF((SmartQuant.Series.TimeSeries) series.series, k, OpenQuant.API.EnumConverter.Convert(option));
    }

    public PERF(Indicator indicator, double k, BarData option)
    {
      this.indicator = (Indicator) new PERF((SmartQuant.Series.TimeSeries) indicator.indicator, k, OpenQuant.API.EnumConverter.Convert(option));
    }

    public PERF(OpenQuant.API.BarSeries series, double k, Color color)
    {
      this.indicator = (Indicator) new PERF((SmartQuant.Series.TimeSeries) series.series, k, color);
    }

    public PERF(Indicator indicator, double k, Color color)
    {
      this.indicator = (Indicator) new PERF((SmartQuant.Series.TimeSeries) indicator.indicator, k, color);
    }

    public PERF(OpenQuant.API.BarSeries series, double k, BarData option, Color color)
    {
      this.indicator = (Indicator) new PERF((SmartQuant.Series.TimeSeries) series.series, k, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public PERF(Indicator indicator, double k, BarData option, Color color)
    {
      this.indicator = (Indicator) new PERF((SmartQuant.Series.TimeSeries) indicator.indicator, k, OpenQuant.API.EnumConverter.Convert(option), color);
    }
  }
}

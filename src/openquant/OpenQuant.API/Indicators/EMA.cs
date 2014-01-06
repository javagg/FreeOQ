// Type: OpenQuant.API.Indicators.EMA
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class EMA : Indicator
  {
    [Category("Parameters")]
    [Description("Length")]
    public int Length
    {
      get
      {
        return (this.indicator as EMA).get_Length();
      }
      set
      {
        (this.indicator as EMA).set_Length(value);
      }
    }

    private EMA()
    {
      this.indicator = (Indicator) new EMA();
    }

    public EMA(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new EMA((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public EMA(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new EMA((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public EMA(OpenQuant.API.BarSeries series, int length, BarData option)
    {
      this.indicator = (Indicator) new EMA((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public EMA(Indicator indicator, int length, BarData option)
    {
      this.indicator = (Indicator) new EMA((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public EMA(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new EMA((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public EMA(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new EMA((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }

    public EMA(OpenQuant.API.BarSeries series, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new EMA((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public EMA(Indicator indicator, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new EMA((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public EMA(OpenQuant.API.TimeSeries series, int length)
    {
      this.indicator = (Indicator) new EMA((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public EMA(OpenQuant.API.TimeSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new EMA((SmartQuant.Series.TimeSeries) series.series, length, color);
    }
  }
}

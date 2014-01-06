// Type: OpenQuant.API.Indicators.WMA
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class WMA : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as WMA).get_Length();
      }
      set
      {
        (this.indicator as WMA).set_Length(value);
      }
    }

    private WMA()
    {
      this.indicator = (Indicator) new WMA();
    }

    public WMA(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new WMA((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public WMA(OpenQuant.API.TimeSeries series, int length)
    {
      this.indicator = (Indicator) new WMA((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public WMA(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new WMA((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public WMA(OpenQuant.API.BarSeries series, int length, BarData option)
    {
      this.indicator = (Indicator) new WMA((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public WMA(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new WMA((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public WMA(OpenQuant.API.TimeSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new WMA((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public WMA(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new WMA((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public WMA(OpenQuant.API.BarSeries series, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new WMA((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }
  }
}

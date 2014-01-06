// Type: OpenQuant.API.Indicators.SMA
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class SMA : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as SMA).get_Length();
      }
      set
      {
        (this.indicator as SMA).set_Length(value);
      }
    }

    private SMA()
    {
      this.indicator = (Indicator) new SMA();
    }

    public SMA(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new SMA((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public SMA(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new SMA((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public SMA(OpenQuant.API.BarSeries series, int length, BarData option)
    {
      this.indicator = (Indicator) new SMA((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public SMA(Indicator indicator, int length, BarData option)
    {
      this.indicator = (Indicator) new SMA((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public SMA(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new SMA((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public SMA(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new SMA((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }

    public SMA(OpenQuant.API.BarSeries series, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new SMA((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public SMA(Indicator indicator, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new SMA((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public SMA(OpenQuant.API.TimeSeries series, int length)
    {
      this.indicator = (Indicator) new SMA((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public SMA(OpenQuant.API.TimeSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new SMA((SmartQuant.Series.TimeSeries) series.series, length, color);
    }
  }
}

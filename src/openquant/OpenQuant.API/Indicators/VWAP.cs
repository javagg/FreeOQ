// Type: OpenQuant.API.Indicators.VWAP
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class VWAP : Indicator
  {
    [Category("Parameters")]
    [Description("Length")]
    public int Length
    {
      get
      {
        return (this.indicator as VWAP).get_Length();
      }
      set
      {
        (this.indicator as VWAP).set_Length(value);
      }
    }

    private VWAP()
    {
      this.indicator = (Indicator) new VWAP();
    }

    public VWAP(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new VWAP((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public VWAP(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new VWAP((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public VWAP(OpenQuant.API.BarSeries series, int length, BarData option)
    {
      this.indicator = (Indicator) new VWAP((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public VWAP(Indicator indicator, int length, BarData option)
    {
      this.indicator = (Indicator) new VWAP((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public VWAP(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new VWAP((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public VWAP(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new VWAP((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }

    public VWAP(OpenQuant.API.BarSeries series, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new VWAP((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public VWAP(Indicator indicator, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new VWAP((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }
  }
}

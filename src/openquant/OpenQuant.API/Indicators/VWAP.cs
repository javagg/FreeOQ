using OpenQuant.API;
using FreeQuant.Indicators;
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

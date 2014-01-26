using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class MACD : Indicator
  {
    [Category("Parameters")]
    [Description("Length1")]
    public int Length1
    {
      get
      {
        return (this.indicator as MACD).get_Length1();
      }
      set
      {
        (this.indicator as MACD).set_Length1(value);
      }
    }

    [Category("Parameters")]
    [Description("Length2")]
    public int Length2
    {
      get
      {
        return (this.indicator as MACD).get_Length2();
      }
      set
      {
        (this.indicator as MACD).set_Length2(value);
      }
    }

    private MACD()
    {
      this.indicator = (Indicator) new MACD();
    }

    public MACD(OpenQuant.API.BarSeries series, int length1, int length2)
    {
      this.indicator = (Indicator) new MACD((SmartQuant.Series.TimeSeries) series.series, length1, length2);
    }

    public MACD(Indicator indicator, int length1, int length2)
    {
      this.indicator = (Indicator) new MACD((SmartQuant.Series.TimeSeries) indicator.indicator, length1, length2);
    }

    public MACD(OpenQuant.API.TimeSeries series, int length1, int length2)
    {
      this.indicator = (Indicator) new MACD((SmartQuant.Series.TimeSeries) series.series, length1, length2);
    }

    public MACD(OpenQuant.API.BarSeries series, int length1, int length2, BarData option)
    {
      this.indicator = (Indicator) new MACD((SmartQuant.Series.TimeSeries) series.series, length1, length2, OpenQuant.API.EnumConverter.Convert(option));
    }

    public MACD(Indicator indicator, int length1, int length2, BarData option)
    {
      this.indicator = (Indicator) new MACD((SmartQuant.Series.TimeSeries) indicator.indicator, length1, length2, OpenQuant.API.EnumConverter.Convert(option));
    }

    public MACD(OpenQuant.API.BarSeries series, int length1, int length2, Color color)
    {
      this.indicator = (Indicator) new MACD((SmartQuant.Series.TimeSeries) series.series, length1, length2, color);
    }

    public MACD(Indicator indicator, int length1, int length2, Color color)
    {
      this.indicator = (Indicator) new MACD((SmartQuant.Series.TimeSeries) indicator.indicator, length1, length2, color);
    }

    public MACD(OpenQuant.API.TimeSeries series, int length1, int length2, Color color)
    {
      this.indicator = (Indicator) new MACD((SmartQuant.Series.TimeSeries) series.series, length1, length2, color);
    }

    public MACD(OpenQuant.API.BarSeries series, int length1, int length2, BarData option, Color color)
    {
      this.indicator = (Indicator) new MACD((SmartQuant.Series.TimeSeries) series.series, length1, length2, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public MACD(Indicator indicator, int length1, int length2, BarData option, Color color)
    {
      this.indicator = (Indicator) new MACD((SmartQuant.Series.TimeSeries) indicator.indicator, length1, length2, OpenQuant.API.EnumConverter.Convert(option), color);
    }
  }
}

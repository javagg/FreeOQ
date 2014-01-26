using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class OSC : Indicator
  {
    [Category("Parameters")]
    [Description("Length1")]
    public int Length1
    {
      get
      {
        return (this.indicator as OSC).get_Length1();
      }
      set
      {
        (this.indicator as OSC).set_Length1(value);
      }
    }

    [Category("Parameters")]
    [Description("Length2")]
    public int Length2
    {
      get
      {
        return (this.indicator as OSC).get_Length2();
      }
      set
      {
        (this.indicator as OSC).set_Length2(value);
      }
    }

    private OSC()
    {
      this.indicator = (Indicator) new OSC();
    }

    public OSC(OpenQuant.API.BarSeries series, int length1, int length2)
    {
      this.indicator = (Indicator) new OSC((SmartQuant.Series.TimeSeries) series.series, length1, length2);
    }

    public OSC(Indicator indicator, int length1, int length2)
    {
      this.indicator = (Indicator) new OSC((SmartQuant.Series.TimeSeries) indicator.indicator, length1, length2);
    }

    public OSC(OpenQuant.API.BarSeries series, int length1, int length2, BarData option)
    {
      this.indicator = (Indicator) new OSC((SmartQuant.Series.TimeSeries) series.series, length1, length2, OpenQuant.API.EnumConverter.Convert(option));
    }

    public OSC(Indicator indicator, int length1, int length2, BarData option)
    {
      this.indicator = (Indicator) new OSC((SmartQuant.Series.TimeSeries) indicator.indicator, length1, length2, OpenQuant.API.EnumConverter.Convert(option));
    }

    public OSC(OpenQuant.API.BarSeries series, int length1, int length2, Color color)
    {
      this.indicator = (Indicator) new OSC((SmartQuant.Series.TimeSeries) series.series, length1, length2, color);
    }

    public OSC(Indicator indicator, int length1, int length2, Color color)
    {
      this.indicator = (Indicator) new OSC((SmartQuant.Series.TimeSeries) indicator.indicator, length1, length2, color);
    }

    public OSC(OpenQuant.API.BarSeries series, int length1, int length2, BarData option, Color color)
    {
      this.indicator = (Indicator) new OSC((SmartQuant.Series.TimeSeries) series.series, length1, length2, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public OSC(Indicator indicator, int length1, int length2, BarData option, Color color)
    {
      this.indicator = (Indicator) new OSC((SmartQuant.Series.TimeSeries) indicator.indicator, length1, length2, OpenQuant.API.EnumConverter.Convert(option), color);
    }
  }
}

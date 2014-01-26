using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class B : Indicator
  {
    [Category("Parameters")]
    [Description("Length")]
    public int Length
    {
      get
      {
        return (this.indicator as B).get_Length();
      }
      set
      {
        (this.indicator as B).set_Length(value);
      }
    }

    [Description("K")]
    [Category("Parameters")]
    public double K
    {
      get
      {
        return (this.indicator as B).get_K();
      }
      set
      {
        (this.indicator as B).set_K(value);
      }
    }

    private B()
    {
      this.indicator = (Indicator) new B();
    }

    public B(OpenQuant.API.BarSeries series, int length, double k)
    {
      this.indicator = (Indicator) new B((SmartQuant.Series.TimeSeries) series.series, length, k);
    }

    public B(Indicator indicator, int length, double k)
    {
      this.indicator = (Indicator) new B((SmartQuant.Series.TimeSeries) indicator.indicator, length, k);
    }

    public B(OpenQuant.API.BarSeries series, int length, double k, BarData option)
    {
      this.indicator = (Indicator) new B((SmartQuant.Series.TimeSeries) series.series, length, k, OpenQuant.API.EnumConverter.Convert(option));
    }

    public B(Indicator indicator, int length, double k, BarData option)
    {
      this.indicator = (Indicator) new B((SmartQuant.Series.TimeSeries) indicator.indicator, length, k, OpenQuant.API.EnumConverter.Convert(option));
    }

    public B(OpenQuant.API.BarSeries series, int length, double k, Color color)
    {
      this.indicator = (Indicator) new B((SmartQuant.Series.TimeSeries) series.series, length, k, color);
    }

    public B(Indicator indicator, int length, double k, Color color)
    {
      this.indicator = (Indicator) new B((SmartQuant.Series.TimeSeries) indicator.indicator, length, k, color);
    }

    public B(OpenQuant.API.BarSeries series, int length, double k, BarData option, Color color)
    {
      this.indicator = (Indicator) new B((SmartQuant.Series.TimeSeries) series.series, length, k, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public B(Indicator indicator, int length, double k, BarData option, Color color)
    {
      this.indicator = (Indicator) new B((SmartQuant.Series.TimeSeries) indicator.indicator, length, k, OpenQuant.API.EnumConverter.Convert(option), color);
    }
  }
}

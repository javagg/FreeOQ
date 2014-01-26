using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class R : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as R).get_Length();
      }
      set
      {
        (this.indicator as R).set_Length(value);
      }
    }

    private R()
    {
      this.indicator = (Indicator) new R();
    }

    public R(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new R((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public R(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new R((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public R(OpenQuant.API.TimeSeries series, int length)
    {
      this.indicator = (Indicator) new R((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public R(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new R((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public R(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new R((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }

    public R(OpenQuant.API.TimeSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new R((SmartQuant.Series.TimeSeries) series.series, length, color);
    }
  }
}

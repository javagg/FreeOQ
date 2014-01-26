using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class Range : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as Range).get_Length();
      }
      set
      {
        (this.indicator as Range).set_Length(value);
      }
    }

    private Range()
    {
      this.indicator = (Indicator) new Range();
    }

    public Range(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new Range((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public Range(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new Range((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public Range(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new Range((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public Range(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new Range((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }
  }
}

using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class VROC : Indicator
  {
    [Category("Parameters")]
    [Description("Length")]
    public int Length
    {
      get
      {
        return (this.indicator as VROC).get_Length();
      }
      set
      {
        (this.indicator as VROC).set_Length(value);
      }
    }

    private VROC()
    {
      this.indicator = (Indicator) new VROC();
    }

    public VROC(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new VROC((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public VROC(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new VROC((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public VROC(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new VROC((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public VROC(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new VROC((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }
  }
}

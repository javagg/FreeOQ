using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class PCL : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as PCL).get_Length();
      }
      set
      {
        (this.indicator as PCL).set_Length(value);
      }
    }

    private PCL()
    {
      this.indicator = (Indicator) new PCL();
    }

    public PCL(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new PCL((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public PCL(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new PCL((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public PCL(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new PCL((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public PCL(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new PCL((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }
  }
}

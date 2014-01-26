using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class PCU : Indicator
  {
    [Category("Parameters")]
    [Description("Length")]
    public int Length
    {
      get
      {
        return (this.indicator as PCU).get_Length();
      }
      set
      {
        (this.indicator as PCU).set_Length(value);
      }
    }

    private PCU()
    {
      this.indicator = (Indicator) new PCU();
    }

    public PCU(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new PCU((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public PCU(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new PCU((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public PCU(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new PCU((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public PCU(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new PCU((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }
  }
}

using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class K_Fast : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as K_Fast).get_Length();
      }
      set
      {
        (this.indicator as K_Fast).set_Length(value);
      }
    }

    private K_Fast()
    {
      this.indicator = (Indicator) new K_Fast();
    }

    public K_Fast(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new K_Fast((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public K_Fast(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new K_Fast((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public K_Fast(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new K_Fast((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public K_Fast(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new K_Fast((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }
  }
}

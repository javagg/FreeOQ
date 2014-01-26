using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class K_Slow : Indicator
  {
    [Category("Parameters")]
    [Description("Length")]
    public int Length
    {
      get
      {
        return (this.indicator as K_Slow).get_Length();
      }
      set
      {
        (this.indicator as K_Slow).set_Length(value);
      }
    }

    [Description("Order")]
    [Category("Parameters")]
    public int Order
    {
      get
      {
        return (this.indicator as K_Slow).get_Order();
      }
      set
      {
        (this.indicator as K_Slow).set_Order(value);
      }
    }

    private K_Slow()
    {
      this.indicator = (Indicator) new K_Slow();
    }

    public K_Slow(OpenQuant.API.BarSeries series, int length, int order)
    {
      this.indicator = (Indicator) new K_Slow((SmartQuant.Series.TimeSeries) series.series, length, order);
    }

    public K_Slow(Indicator indicator, int length, int order)
    {
      this.indicator = (Indicator) new K_Slow((SmartQuant.Series.TimeSeries) indicator.indicator, length, order);
    }

    public K_Slow(OpenQuant.API.BarSeries series, int length, int order, Color color)
    {
      this.indicator = (Indicator) new K_Slow((SmartQuant.Series.TimeSeries) series.series, length, order, color);
    }

    public K_Slow(Indicator indicator, int length, int order, Color color)
    {
      this.indicator = (Indicator) new K_Slow((SmartQuant.Series.TimeSeries) indicator.indicator, length, order, color);
    }
  }
}

using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class D_Fast : Indicator
  {
    [Category("Parameters")]
    [Description("Length")]
    public int Length
    {
      get
      {
        return (this.indicator as D_Fast).get_Length();
      }
      set
      {
        (this.indicator as D_Fast).set_Length(value);
      }
    }

    [Category("Parameters")]
    [Description("Order")]
    public int Order
    {
      get
      {
        return (this.indicator as D_Fast).get_Order();
      }
      set
      {
        (this.indicator as D_Fast).set_Order(value);
      }
    }

    private D_Fast()
    {
      this.indicator = (Indicator) new D_Fast();
    }

    public D_Fast(OpenQuant.API.BarSeries series, int length, int order)
    {
      this.indicator = (Indicator) new D_Fast((SmartQuant.Series.TimeSeries) series.series, length, order);
    }

    public D_Fast(Indicator indicator, int length, int order)
    {
      this.indicator = (Indicator) new D_Fast((SmartQuant.Series.TimeSeries) indicator.indicator, length, order);
    }

    public D_Fast(OpenQuant.API.BarSeries series, int length, int order, Color color)
    {
      this.indicator = (Indicator) new D_Fast((SmartQuant.Series.TimeSeries) series.series, length, order, color);
    }

    public D_Fast(Indicator indicator, int length, int order, Color color)
    {
      this.indicator = (Indicator) new D_Fast((SmartQuant.Series.TimeSeries) indicator.indicator, length, order, color);
    }
  }
}

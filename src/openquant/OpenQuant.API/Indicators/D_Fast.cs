// Type: OpenQuant.API.Indicators.D_Fast
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
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

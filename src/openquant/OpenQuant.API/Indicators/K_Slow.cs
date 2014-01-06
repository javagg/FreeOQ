// Type: OpenQuant.API.Indicators.K_Slow
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
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

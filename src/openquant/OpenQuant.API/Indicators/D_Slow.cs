// Type: OpenQuant.API.Indicators.D_Slow
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class D_Slow : Indicator
  {
    [Category("Parameters")]
    [Description("Length")]
    public int Length
    {
      get
      {
        return (this.indicator as D_Slow).get_Length();
      }
      set
      {
        (this.indicator as D_Slow).set_Length(value);
      }
    }

    [Description("Order1")]
    [Category("Parameters")]
    public int Order1
    {
      get
      {
        return (this.indicator as D_Slow).get_Order1();
      }
      set
      {
        (this.indicator as D_Slow).set_Order1(value);
      }
    }

    [Category("Parameters")]
    [Description("Order2")]
    public int Order2
    {
      get
      {
        return (this.indicator as D_Slow).get_Order2();
      }
      set
      {
        (this.indicator as D_Slow).set_Order2(value);
      }
    }

    private D_Slow()
    {
      this.indicator = (Indicator) new D_Slow();
    }

    public D_Slow(OpenQuant.API.BarSeries series, int length, int order1, int order2)
    {
      this.indicator = (Indicator) new D_Slow((SmartQuant.Series.TimeSeries) series.series, length, order1, order2);
    }

    public D_Slow(Indicator indicator, int length, int order1, int order2)
    {
      this.indicator = (Indicator) new D_Slow((SmartQuant.Series.TimeSeries) indicator.indicator, length, order1, order2);
    }

    public D_Slow(OpenQuant.API.BarSeries series, int length, int order1, int order2, Color color)
    {
      this.indicator = (Indicator) new D_Slow((SmartQuant.Series.TimeSeries) series.series, length, order1, order2, color);
    }

    public D_Slow(Indicator indicator, int length, int order1, int order2, Color color)
    {
      this.indicator = (Indicator) new D_Slow((SmartQuant.Series.TimeSeries) indicator.indicator, length, order1, order2, color);
    }
  }
}

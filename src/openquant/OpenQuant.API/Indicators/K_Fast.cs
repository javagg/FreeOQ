// Type: OpenQuant.API.Indicators.K_Fast
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
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

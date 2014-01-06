// Type: OpenQuant.API.Indicators.R
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class R : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as R).get_Length();
      }
      set
      {
        (this.indicator as R).set_Length(value);
      }
    }

    private R()
    {
      this.indicator = (Indicator) new R();
    }

    public R(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new R((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public R(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new R((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public R(OpenQuant.API.TimeSeries series, int length)
    {
      this.indicator = (Indicator) new R((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public R(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new R((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public R(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new R((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }

    public R(OpenQuant.API.TimeSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new R((SmartQuant.Series.TimeSeries) series.series, length, color);
    }
  }
}

// Type: OpenQuant.API.Indicators.AroonL
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class AroonL : Indicator
  {
    [Category("Parameters")]
    [Description("Length")]
    public int Length
    {
      get
      {
        return (this.indicator as AroonL).get_Length();
      }
      set
      {
        (this.indicator as AroonL).set_Length(value);
      }
    }

    private AroonL()
    {
      this.indicator = (Indicator) new AroonL();
    }

    public AroonL(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new AroonL((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public AroonL(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new AroonL((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public AroonL(OpenQuant.API.TimeSeries series, int length)
    {
      this.indicator = (Indicator) new AroonL((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public AroonL(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new AroonL((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public AroonL(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new AroonL((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }

    public AroonL(OpenQuant.API.TimeSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new AroonL((SmartQuant.Series.TimeSeries) series.series, length, color);
    }
  }
}

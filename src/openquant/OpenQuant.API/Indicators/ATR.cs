using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class ATR : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as ATR).get_Length();
      }
      set
      {
        (this.indicator as ATR).set_Length(value);
      }
    }

    public IndicatorStyle Style
    {
      get
      {
        return OpenQuant.API.EnumConverter.Convert((this.indicator as ATR).get_Style());
      }
      set
      {
        (this.indicator as ATR).set_Style(OpenQuant.API.EnumConverter.Convert(value));
      }
    }

    private ATR()
    {
      this.indicator = (Indicator) new ATR();
    }

    public ATR(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new ATR((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public ATR(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new ATR((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public ATR(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new ATR((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public ATR(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new ATR((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }
  }
}

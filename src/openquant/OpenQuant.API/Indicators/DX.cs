using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class DX : Indicator
  {
    [Category("Parameters")]
    [Description("Length")]
    public int Length
    {
      get
      {
        return (this.indicator as DX).get_Length();
      }
      set
      {
        (this.indicator as DX).set_Length(value);
      }
    }

    public IndicatorStyle Style
    {
      get
      {
        return OpenQuant.API.EnumConverter.Convert((this.indicator as DX).get_Style());
      }
      set
      {
        (this.indicator as DX).set_Style(OpenQuant.API.EnumConverter.Convert(value));
      }
    }

    private DX()
    {
      this.indicator = (Indicator) new DX();
    }

    public DX(BarSeries series, int length)
    {
      this.indicator = (Indicator) new DX((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public DX(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new DX((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public DX(BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new DX((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public DX(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new DX((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }
  }
}

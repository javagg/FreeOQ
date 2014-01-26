using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class PDI : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as PDI).get_Length();
      }
      set
      {
        (this.indicator as PDI).set_Length(value);
      }
    }

    public IndicatorStyle Style
    {
      get
      {
        return OpenQuant.API.EnumConverter.Convert((this.indicator as PDI).get_Style());
      }
      set
      {
        (this.indicator as PDI).set_Style(OpenQuant.API.EnumConverter.Convert(value));
      }
    }

    private PDI()
    {
      this.indicator = (Indicator) new PDI();
    }

    public PDI(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new PDI((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public PDI(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new PDI((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public PDI(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new PDI((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public PDI(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new PDI((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }
  }
}

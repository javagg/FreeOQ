using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class MDI : Indicator
  {
    [Category("Parameters")]
    [Description("Length")]
    public int Length
    {
      get
      {
        return (this.indicator as MDI).get_Length();
      }
      set
      {
        (this.indicator as MDI).set_Length(value);
      }
    }

    public IndicatorStyle Style
    {
      get
      {
        return OpenQuant.API.EnumConverter.Convert((this.indicator as MDI).get_Style());
      }
      set
      {
        (this.indicator as MDI).set_Style(OpenQuant.API.EnumConverter.Convert(value));
      }
    }

    private MDI()
    {
      this.indicator = (Indicator) new MDI();
    }

    public MDI(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new MDI((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public MDI(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new MDI((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public MDI(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new MDI((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public MDI(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new MDI((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }
  }
}

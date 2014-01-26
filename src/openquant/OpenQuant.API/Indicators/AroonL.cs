using OpenQuant.API;
using FreeQuant.Indicators;
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

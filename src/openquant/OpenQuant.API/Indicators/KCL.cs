using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class KCL : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as KCL).get_Length();
      }
      set
      {
        (this.indicator as KCL).set_Length(value);
      }
    }

    private KCL()
    {
      this.indicator = (Indicator) new KCL();
    }

    public KCL(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new KCL((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public KCL(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new KCL((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public KCL(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new KCL((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public KCL(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new KCL((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }

    public KCL(OpenQuant.API.TimeSeries series, int length)
    {
      this.indicator = (Indicator) new KCL((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public KCL(OpenQuant.API.TimeSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new KCL((SmartQuant.Series.TimeSeries) series.series, length, color);
    }
  }
}

using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class KCU : Indicator
  {
    [Category("Parameters")]
    [Description("Length")]
    public int Length
    {
      get
      {
        return (this.indicator as KCU).get_Length();
      }
      set
      {
        (this.indicator as KCU).set_Length(value);
      }
    }

    private KCU()
    {
      this.indicator = (Indicator) new KCU();
    }

    public KCU(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new KCU((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public KCU(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new KCU((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public KCU(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new KCU((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public KCU(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new KCU((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }

    public KCU(OpenQuant.API.TimeSeries series, int length)
    {
      this.indicator = (Indicator) new KCU((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public KCU(OpenQuant.API.TimeSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new KCU((SmartQuant.Series.TimeSeries) series.series, length, color);
    }
  }
}

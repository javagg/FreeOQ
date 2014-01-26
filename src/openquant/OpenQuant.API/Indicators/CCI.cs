using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class CCI : Indicator
  {
    [Category("Parameters")]
    [Description("Length")]
    public int Length
    {
      get
      {
        return (this.indicator as CCI).get_Length();
      }
      set
      {
        (this.indicator as CCI).set_Length(value);
      }
    }

    private CCI()
    {
      this.indicator = (Indicator) new CCI();
    }

    public CCI(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new CCI((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public CCI(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new CCI((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public CCI(OpenQuant.API.TimeSeries series, int length)
    {
      this.indicator = (Indicator) new CCI((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public CCI(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new CCI((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public CCI(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new CCI((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }

    public CCI(OpenQuant.API.TimeSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new CCI((SmartQuant.Series.TimeSeries) series.series, length, color);
    }
  }
}

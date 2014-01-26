using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class NVI : Indicator
  {
    private NVI()
    {
      this.indicator = (Indicator) new NVI();
    }

    public NVI(OpenQuant.API.BarSeries series)
    {
      this.indicator = (Indicator) new NVI((SmartQuant.Series.TimeSeries) series.series);
    }

    public NVI(Indicator indicator)
    {
      this.indicator = (Indicator) new NVI((SmartQuant.Series.TimeSeries) indicator.indicator);
    }

    public NVI(OpenQuant.API.BarSeries series, Color color)
    {
      this.indicator = (Indicator) new NVI((SmartQuant.Series.TimeSeries) series.series, color);
    }

    public NVI(Indicator indicator, Color color)
    {
      this.indicator = (Indicator) new NVI((SmartQuant.Series.TimeSeries) indicator.indicator, color);
    }
  }
}

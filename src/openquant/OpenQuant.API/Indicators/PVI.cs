using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class PVI : Indicator
  {
    private PVI()
    {
      this.indicator = (Indicator) new PVI();
    }

    public PVI(OpenQuant.API.BarSeries series)
    {
      this.indicator = (Indicator) new PVI((SmartQuant.Series.TimeSeries) series.series);
    }

    public PVI(Indicator indicator)
    {
      this.indicator = (Indicator) new PVI((SmartQuant.Series.TimeSeries) indicator.indicator);
    }

    public PVI(OpenQuant.API.BarSeries series, Color color)
    {
      this.indicator = (Indicator) new PVI((SmartQuant.Series.TimeSeries) series.series, color);
    }

    public PVI(Indicator indicator, Color color)
    {
      this.indicator = (Indicator) new PVI((SmartQuant.Series.TimeSeries) indicator.indicator, color);
    }
  }
}

using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class TR : Indicator
  {
    private TR()
    {
      this.indicator = (Indicator) new TR();
    }

    public TR(OpenQuant.API.BarSeries series)
    {
      this.indicator = (Indicator) new TR((SmartQuant.Series.TimeSeries) series.series);
    }

    public TR(Indicator indicator)
    {
      this.indicator = (Indicator) new TR((SmartQuant.Series.TimeSeries) indicator.indicator);
    }

    public TR(OpenQuant.API.BarSeries series, Color color)
    {
      this.indicator = (Indicator) new TR((SmartQuant.Series.TimeSeries) series.series, color);
    }

    public TR(Indicator indicator, Color color)
    {
      this.indicator = (Indicator) new TR((SmartQuant.Series.TimeSeries) indicator.indicator, color);
    }
  }
}

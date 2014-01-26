using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class PDM : Indicator
  {
    private PDM()
    {
      this.indicator = (Indicator) new PDM();
    }

    public PDM(OpenQuant.API.BarSeries series)
    {
      this.indicator = (Indicator) new PDM((SmartQuant.Series.TimeSeries) series.series);
    }

    public PDM(Indicator indicator)
    {
      this.indicator = (Indicator) new PDM((SmartQuant.Series.TimeSeries) indicator.indicator);
    }

    public PDM(OpenQuant.API.BarSeries series, Color color)
    {
      this.indicator = (Indicator) new PDM((SmartQuant.Series.TimeSeries) series.series, color);
    }

    public PDM(Indicator indicator, Color color)
    {
      this.indicator = (Indicator) new PDM((SmartQuant.Series.TimeSeries) indicator.indicator, color);
    }
  }
}

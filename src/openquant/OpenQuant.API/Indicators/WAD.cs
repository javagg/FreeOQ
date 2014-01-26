using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class WAD : Indicator
  {
    private WAD()
    {
      this.indicator = (Indicator) new WAD();
    }

    public WAD(OpenQuant.API.BarSeries series)
    {
      this.indicator = (Indicator) new WAD((SmartQuant.Series.TimeSeries) series.series);
    }

    public WAD(Indicator indicator)
    {
      this.indicator = (Indicator) new WAD((SmartQuant.Series.TimeSeries) indicator.indicator);
    }

    public WAD(OpenQuant.API.BarSeries series, Color color)
    {
      this.indicator = (Indicator) new WAD((SmartQuant.Series.TimeSeries) series.series, color);
    }

    public WAD(Indicator indicator, Color color)
    {
      this.indicator = (Indicator) new WAD((SmartQuant.Series.TimeSeries) indicator.indicator, color);
    }
  }
}

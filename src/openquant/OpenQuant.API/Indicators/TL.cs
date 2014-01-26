using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class TL : Indicator
  {
    private TL()
    {
      this.indicator = (Indicator) new TL();
    }

    public TL(OpenQuant.API.BarSeries series)
    {
      this.indicator = (Indicator) new TL((SmartQuant.Series.TimeSeries) series.series);
    }

    public TL(Indicator indicator)
    {
      this.indicator = (Indicator) new TL((SmartQuant.Series.TimeSeries) indicator.indicator);
    }

    public TL(OpenQuant.API.BarSeries series, Color color)
    {
      this.indicator = (Indicator) new TL((SmartQuant.Series.TimeSeries) series.series, color);
    }

    public TL(Indicator indicator, Color color)
    {
      this.indicator = (Indicator) new TL((SmartQuant.Series.TimeSeries) indicator.indicator, color);
    }
  }
}

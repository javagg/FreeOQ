using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class MarketFI : Indicator
  {
    private MarketFI()
    {
      this.indicator = (Indicator) new MarketFI();
    }

    public MarketFI(OpenQuant.API.BarSeries series)
    {
      this.indicator = (Indicator) new MarketFI((SmartQuant.Series.TimeSeries) series.series);
    }

    public MarketFI(Indicator indicator)
    {
      this.indicator = (Indicator) new MarketFI((SmartQuant.Series.TimeSeries) indicator.indicator);
    }

    public MarketFI(OpenQuant.API.BarSeries series, Color color)
    {
      this.indicator = (Indicator) new MarketFI((SmartQuant.Series.TimeSeries) series.series, color);
    }

    public MarketFI(Indicator indicator, Color color)
    {
      this.indicator = (Indicator) new MarketFI((SmartQuant.Series.TimeSeries) indicator.indicator, color);
    }
  }
}

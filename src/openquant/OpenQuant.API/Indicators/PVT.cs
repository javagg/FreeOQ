using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class PVT : Indicator
  {
    private PVT()
    {
      this.indicator = (Indicator) new PVT();
    }

    public PVT(OpenQuant.API.BarSeries series)
    {
      this.indicator = (Indicator) new PVT((SmartQuant.Series.TimeSeries) series.series);
    }

    public PVT(Indicator indicator)
    {
      this.indicator = (Indicator) new PVT((SmartQuant.Series.TimeSeries) indicator.indicator);
    }

    public PVT(OpenQuant.API.BarSeries series, Color color)
    {
      this.indicator = (Indicator) new PVT((SmartQuant.Series.TimeSeries) series.series, color);
    }

    public PVT(Indicator indicator, Color color)
    {
      this.indicator = (Indicator) new PVT((SmartQuant.Series.TimeSeries) indicator.indicator, color);
    }
  }
}

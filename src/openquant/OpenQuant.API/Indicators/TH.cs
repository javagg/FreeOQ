using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class TH : Indicator
  {
    private TH()
    {
      this.indicator = (Indicator) new TH();
    }

    public TH(OpenQuant.API.BarSeries series)
    {
      this.indicator = (Indicator) new TH((SmartQuant.Series.TimeSeries) series.series);
    }

    public TH(Indicator indicator)
    {
      this.indicator = (Indicator) new TH((SmartQuant.Series.TimeSeries) indicator.indicator);
    }

    public TH(OpenQuant.API.BarSeries series, Color color)
    {
      this.indicator = (Indicator) new TH((SmartQuant.Series.TimeSeries) series.series, color);
    }

    public TH(Indicator indicator, Color color)
    {
      this.indicator = (Indicator) new TH((SmartQuant.Series.TimeSeries) indicator.indicator, color);
    }
  }
}

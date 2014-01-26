using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class EMV : Indicator
  {
    private EMV()
    {
      this.indicator = (Indicator) new EMV();
    }

    public EMV(OpenQuant.API.BarSeries series)
    {
      this.indicator = (Indicator) new EMV((SmartQuant.Series.TimeSeries) series.series);
    }

    public EMV(Indicator indicator)
    {
      this.indicator = (Indicator) new EMV((SmartQuant.Series.TimeSeries) indicator.indicator);
    }

    public EMV(OpenQuant.API.BarSeries series, Color color)
    {
      this.indicator = (Indicator) new EMV((SmartQuant.Series.TimeSeries) series.series, color);
    }

    public EMV(Indicator indicator, Color color)
    {
      this.indicator = (Indicator) new EMV((SmartQuant.Series.TimeSeries) indicator.indicator, color);
    }
  }
}

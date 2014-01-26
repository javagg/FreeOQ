using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class MDM : Indicator
  {
    private MDM()
    {
      this.indicator = (Indicator) new MDM();
    }

    public MDM(OpenQuant.API.BarSeries series)
    {
      this.indicator = (Indicator) new MDM((SmartQuant.Series.TimeSeries) series.series);
    }

    public MDM(Indicator indicator)
    {
      this.indicator = (Indicator) new MDM((SmartQuant.Series.TimeSeries) indicator.indicator);
    }

    public MDM(OpenQuant.API.BarSeries series, Color color)
    {
      this.indicator = (Indicator) new MDM((SmartQuant.Series.TimeSeries) series.series, color);
    }

    public MDM(Indicator indicator, Color color)
    {
      this.indicator = (Indicator) new MDM((SmartQuant.Series.TimeSeries) indicator.indicator, color);
    }
  }
}

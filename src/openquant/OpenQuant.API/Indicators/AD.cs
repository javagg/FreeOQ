using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class AD : Indicator
  {
    private AD()
    {
      this.indicator = (Indicator) new AD();
    }

    public AD(OpenQuant.API.BarSeries series)
    {
      this.indicator = (Indicator) new AD((SmartQuant.Series.TimeSeries) series.series);
    }

    public AD(Indicator indicator)
    {
      this.indicator = (Indicator) new AD((SmartQuant.Series.TimeSeries) indicator.indicator);
    }

    public AD(OpenQuant.API.TimeSeries series)
    {
      this.indicator = (Indicator) new AD((SmartQuant.Series.TimeSeries) series.series);
    }

    public AD(OpenQuant.API.BarSeries series, Color color)
    {
      this.indicator = (Indicator) new AD((SmartQuant.Series.TimeSeries) series.series, color);
    }

    public AD(Indicator indicator, Color color)
    {
      this.indicator = (Indicator) new AD((SmartQuant.Series.TimeSeries) indicator.indicator, color);
    }

    public AD(OpenQuant.API.TimeSeries series, Color color)
    {
      this.indicator = (Indicator) new AD((SmartQuant.Series.TimeSeries) series.series, color);
    }
  }
}

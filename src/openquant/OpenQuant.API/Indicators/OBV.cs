using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class OBV : Indicator
  {
    private OBV()
    {
      this.indicator = (Indicator) new OBV();
    }

    public OBV(OpenQuant.API.BarSeries series)
    {
      this.indicator = (Indicator) new OBV((SmartQuant.Series.TimeSeries) series.series);
    }

    public OBV(Indicator indicator)
    {
      this.indicator = (Indicator) new OBV((SmartQuant.Series.TimeSeries) indicator.indicator);
    }

    public OBV(OpenQuant.API.BarSeries series, Color color)
    {
      this.indicator = (Indicator) new OBV((SmartQuant.Series.TimeSeries) series.series, color);
    }

    public OBV(Indicator indicator, Color color)
    {
      this.indicator = (Indicator) new OBV((SmartQuant.Series.TimeSeries) indicator.indicator, color);
    }
  }
}

// Type: OpenQuant.API.Indicators.PDM
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
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

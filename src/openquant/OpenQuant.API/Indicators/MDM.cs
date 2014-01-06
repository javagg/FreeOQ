// Type: OpenQuant.API.Indicators.MDM
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
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

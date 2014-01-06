// Type: OpenQuant.API.Indicators.TH
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
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

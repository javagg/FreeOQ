// Type: OpenQuant.API.Indicators.PCU
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class PCU : Indicator
  {
    [Category("Parameters")]
    [Description("Length")]
    public int Length
    {
      get
      {
        return (this.indicator as PCU).get_Length();
      }
      set
      {
        (this.indicator as PCU).set_Length(value);
      }
    }

    private PCU()
    {
      this.indicator = (Indicator) new PCU();
    }

    public PCU(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new PCU((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public PCU(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new PCU((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public PCU(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new PCU((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public PCU(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new PCU((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }
  }
}

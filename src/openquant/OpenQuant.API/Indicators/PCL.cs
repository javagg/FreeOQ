// Type: OpenQuant.API.Indicators.PCL
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class PCL : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as PCL).get_Length();
      }
      set
      {
        (this.indicator as PCL).set_Length(value);
      }
    }

    private PCL()
    {
      this.indicator = (Indicator) new PCL();
    }

    public PCL(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new PCL((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public PCL(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new PCL((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public PCL(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new PCL((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public PCL(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new PCL((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }
  }
}

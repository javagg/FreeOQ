// Type: OpenQuant.API.Indicators.VOSC
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class VOSC : Indicator
  {
    [Category("Parameters")]
    [Description("Length1")]
    public int Length1
    {
      get
      {
        return (this.indicator as VOSC).get_Length1();
      }
      set
      {
        (this.indicator as VOSC).set_Length1(value);
      }
    }

    [Description("Length2")]
    [Category("Parameters")]
    public int Length2
    {
      get
      {
        return (this.indicator as VOSC).get_Length2();
      }
      set
      {
        (this.indicator as VOSC).set_Length2(value);
      }
    }

    private VOSC()
    {
      this.indicator = (Indicator) new VOSC();
    }

    public VOSC(OpenQuant.API.BarSeries series, int length1, int length2)
    {
      this.indicator = (Indicator) new VOSC((SmartQuant.Series.TimeSeries) series.series, length1, length2);
    }

    public VOSC(Indicator indicator, int length1, int length2)
    {
      this.indicator = (Indicator) new VOSC((SmartQuant.Series.TimeSeries) indicator.indicator, length1, length2);
    }

    public VOSC(OpenQuant.API.BarSeries series, int length1, int length2, Color color)
    {
      this.indicator = (Indicator) new VOSC((SmartQuant.Series.TimeSeries) series.series, length1, length2, color);
    }

    public VOSC(Indicator indicator, int length1, int length2, Color color)
    {
      this.indicator = (Indicator) new VOSC((SmartQuant.Series.TimeSeries) indicator.indicator, length1, length2, color);
    }
  }
}

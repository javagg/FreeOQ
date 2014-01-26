using OpenQuant.API;
using FreeQuant.Indicators;
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

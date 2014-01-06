// Type: OpenQuant.API.Indicators.UltOsc
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class UltOsc : Indicator
  {
    [Category("Parameters")]
    [Description("N1")]
    public int N1
    {
      get
      {
        return (this.indicator as UltOsc).get_N1();
      }
      set
      {
        (this.indicator as UltOsc).set_N1(value);
      }
    }

    [Category("Parameters")]
    [Description("N2")]
    public int N2
    {
      get
      {
        return (this.indicator as UltOsc).get_N2();
      }
      set
      {
        (this.indicator as UltOsc).set_N2(value);
      }
    }

    [Description("N3")]
    [Category("Parameters")]
    public int N3
    {
      get
      {
        return (this.indicator as UltOsc).get_N3();
      }
      set
      {
        (this.indicator as UltOsc).set_N3(value);
      }
    }

    private UltOsc()
    {
      this.indicator = (Indicator) new UltOsc();
    }

    public UltOsc(OpenQuant.API.BarSeries series, int n1, int n2, int n3)
    {
      this.indicator = (Indicator) new UltOsc((SmartQuant.Series.TimeSeries) series.series, n1, n2, n3);
    }

    public UltOsc(Indicator indicator, int n1, int n2, int n3)
    {
      this.indicator = (Indicator) new UltOsc((SmartQuant.Series.TimeSeries) indicator.indicator, n1, n2, n3);
    }

    public UltOsc(OpenQuant.API.BarSeries series, int n1, int n2, int n3, Color color)
    {
      this.indicator = (Indicator) new UltOsc((SmartQuant.Series.TimeSeries) series.series, n1, n2, n3, color);
    }

    public UltOsc(Indicator indicator, int n1, int n2, int n3, Color color)
    {
      this.indicator = (Indicator) new UltOsc((SmartQuant.Series.TimeSeries) indicator.indicator, n1, n2, n3, color);
    }
  }
}

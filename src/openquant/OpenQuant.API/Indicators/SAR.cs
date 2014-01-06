// Type: OpenQuant.API.Indicators.SAR
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class SAR : Indicator
  {
    public double InitialAcc
    {
      get
      {
        return (this.indicator as SAR).get_InitialAcc();
      }
      set
      {
        (this.indicator as SAR).set_InitialAcc(value);
      }
    }

    public double UpperBound
    {
      get
      {
        return (this.indicator as SAR).get_UpperBound();
      }
      set
      {
        (this.indicator as SAR).set_UpperBound(value);
      }
    }

    public double Step
    {
      get
      {
        return (this.indicator as SAR).get_Step();
      }
      set
      {
        (this.indicator as SAR).set_Step(value);
      }
    }

    private SAR()
    {
      this.indicator = (Indicator) new SAR();
    }

    public SAR(OpenQuant.API.BarSeries series, double upperBound, double step, double initialAcc)
    {
      this.indicator = (Indicator) new SAR((SmartQuant.Series.TimeSeries) series.series, upperBound, step, initialAcc);
    }

    public SAR(Indicator indicator, double upperBound, double step, double initialAcc)
    {
      this.indicator = (Indicator) new SAR((SmartQuant.Series.TimeSeries) indicator.indicator, upperBound, step, initialAcc);
    }

    public SAR(OpenQuant.API.BarSeries series, double upperBound, double step, double initialAcc, Color color)
    {
      this.indicator = (Indicator) new SAR((SmartQuant.Series.TimeSeries) series.series, upperBound, step, initialAcc, color);
    }

    public SAR(Indicator indicator, double upperBound, double step, double initialAcc, Color color)
    {
      this.indicator = (Indicator) new SAR((SmartQuant.Series.TimeSeries) indicator.indicator, upperBound, step, initialAcc, color);
    }
  }
}

// Type: OpenQuant.API.Indicators.AroonU
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class AroonU : Indicator
  {
    [Category("Parameters")]
    [Description("Length")]
    public int Length
    {
      get
      {
        return (this.indicator as AroonU).get_Length();
      }
      set
      {
        (this.indicator as AroonU).set_Length(value);
      }
    }

    private AroonU()
    {
      this.indicator = (Indicator) new AroonU();
    }

    public AroonU(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new AroonU((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public AroonU(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new AroonU((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public AroonU(OpenQuant.API.TimeSeries series, int length)
    {
      this.indicator = (Indicator) new AroonU((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public AroonU(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new AroonU((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public AroonU(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new AroonU((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }

    public AroonU(OpenQuant.API.TimeSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new AroonU((SmartQuant.Series.TimeSeries) series.series, length, color);
    }
  }
}

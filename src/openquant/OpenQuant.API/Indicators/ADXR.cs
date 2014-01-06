// Type: OpenQuant.API.Indicators.ADXR
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class ADXR : Indicator
  {
    [Category("Parameters")]
    [Description("Length")]
    public int Length
    {
      get
      {
        return (this.indicator as ADXR).get_Length();
      }
      set
      {
        (this.indicator as ADXR).set_Length(value);
      }
    }

    public IndicatorStyle Style
    {
      get
      {
        return OpenQuant.API.EnumConverter.Convert((this.indicator as ADXR).get_Style());
      }
      set
      {
        (this.indicator as ADXR).set_Style(OpenQuant.API.EnumConverter.Convert(value));
      }
    }

    private ADXR()
    {
      this.indicator = (Indicator) new ADXR();
    }

    public ADXR(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new ADXR((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public ADXR(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new ADXR((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public ADXR(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new ADXR((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public ADXR(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new ADXR((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }
  }
}

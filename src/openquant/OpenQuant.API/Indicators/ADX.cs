// Type: OpenQuant.API.Indicators.ADX
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class ADX : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as ADX).get_Length();
      }
      set
      {
        (this.indicator as ADX).set_Length(value);
      }
    }

    public IndicatorStyle Style
    {
      get
      {
        return OpenQuant.API.EnumConverter.Convert((this.indicator as ADX).get_Style());
      }
      set
      {
        (this.indicator as ADX).set_Style(OpenQuant.API.EnumConverter.Convert(value));
      }
    }

    private ADX()
    {
      this.indicator = (Indicator) new ADX();
    }

    public ADX(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new ADX((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public ADX(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new ADX((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public ADX(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new ADX((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public ADX(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new ADX((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }
  }
}

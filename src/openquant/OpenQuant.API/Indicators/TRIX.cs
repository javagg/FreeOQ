// Type: OpenQuant.API.Indicators.TRIX
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class TRIX : Indicator
  {
    [Category("Parameters")]
    [Description("Length")]
    public int Length
    {
      get
      {
        return (this.indicator as TRIX).get_Length();
      }
      set
      {
        (this.indicator as TRIX).set_Length(value);
      }
    }

    private TRIX()
    {
      this.indicator = (Indicator) new TRIX();
    }

    public TRIX(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new TRIX((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public TRIX(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new TRIX((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public TRIX(OpenQuant.API.BarSeries series, int length, BarData option)
    {
      this.indicator = (Indicator) new TRIX((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public TRIX(Indicator indicator, int length, BarData option)
    {
      this.indicator = (Indicator) new TRIX((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public TRIX(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new TRIX((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public TRIX(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new TRIX((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }

    public TRIX(OpenQuant.API.BarSeries series, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new TRIX((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public TRIX(Indicator indicator, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new TRIX((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }
  }
}

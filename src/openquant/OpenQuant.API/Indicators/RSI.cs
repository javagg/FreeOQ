// Type: OpenQuant.API.Indicators.RSI
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class RSI : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as RSI).get_Length();
      }
      set
      {
        (this.indicator as RSI).set_Length(value);
      }
    }

    public IndicatorStyle Style
    {
      get
      {
        return OpenQuant.API.EnumConverter.Convert((this.indicator as RSI).get_Style());
      }
      set
      {
        (this.indicator as RSI).set_Style(OpenQuant.API.EnumConverter.Convert(value));
      }
    }

    private RSI()
    {
      this.indicator = (Indicator) new RSI();
    }

    public RSI(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new RSI((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public RSI(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new RSI((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public RSI(OpenQuant.API.TimeSeries series, int length)
    {
      this.indicator = (Indicator) new RSI((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public RSI(OpenQuant.API.BarSeries series, int length, BarData option)
    {
      this.indicator = (Indicator) new RSI((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public RSI(Indicator indicator, int length, BarData option)
    {
      this.indicator = (Indicator) new RSI((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public RSI(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new RSI((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public RSI(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new RSI((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }

    public RSI(OpenQuant.API.TimeSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new RSI((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public RSI(OpenQuant.API.BarSeries series, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new RSI((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option), (EIndicatorStyle) 0, color);
    }

    public RSI(Indicator indicator, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new RSI((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option), (EIndicatorStyle) 0, color);
    }
  }
}

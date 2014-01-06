// Type: OpenQuant.API.Indicators.ROC
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class ROC : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as ROC).get_Length();
      }
      set
      {
        (this.indicator as ROC).set_Length(value);
      }
    }

    private ROC()
    {
      this.indicator = (Indicator) new ROC();
    }

    public ROC(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new ROC((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public ROC(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new ROC((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public ROC(OpenQuant.API.BarSeries series, int length, BarData option)
    {
      this.indicator = (Indicator) new ROC((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public ROC(Indicator indicator, int length, BarData option)
    {
      this.indicator = (Indicator) new ROC((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public ROC(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new ROC((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public ROC(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new ROC((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }

    public ROC(OpenQuant.API.BarSeries series, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new ROC((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public ROC(Indicator indicator, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new ROC((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }
  }
}

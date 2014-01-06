// Type: OpenQuant.API.Indicators.SMV
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;

namespace OpenQuant.API.Indicators
{
  public class SMV : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as SMV).get_Length();
      }
      set
      {
        (this.indicator as SMV).set_Length(value);
      }
    }

    private SMV()
    {
      this.indicator = (Indicator) new SMV();
    }

    public SMV(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new SMV((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public SMV(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new SMV((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public SMV(OpenQuant.API.BarSeries series, int length, BarData option)
    {
      this.indicator = (Indicator) new SMV((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public SMV(Indicator indicator, int length, BarData option)
    {
      this.indicator = (Indicator) new SMV((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option));
    }
  }
}

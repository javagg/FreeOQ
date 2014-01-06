// Type: OpenQuant.API.Indicators.VHF
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class VHF : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as VHF).get_Length();
      }
      set
      {
        (this.indicator as VHF).set_Length(value);
      }
    }

    private VHF()
    {
      this.indicator = (Indicator) new VHF();
    }

    public VHF(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new VHF((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public VHF(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new VHF((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public VHF(OpenQuant.API.BarSeries series, int length, BarData option)
    {
      this.indicator = (Indicator) new VHF((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public VHF(Indicator indicator, int length, BarData option)
    {
      this.indicator = (Indicator) new VHF((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public VHF(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new VHF((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public VHF(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new VHF((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }

    public VHF(OpenQuant.API.BarSeries series, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new VHF((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public VHF(Indicator indicator, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new VHF((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }
  }
}

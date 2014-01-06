// Type: OpenQuant.API.Indicators.DPO
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class DPO : Indicator
  {
    [Category("Parameters")]
    [Description("Length")]
    public int Length
    {
      get
      {
        return (this.indicator as DPO).get_Length();
      }
      set
      {
        (this.indicator as DPO).set_Length(value);
      }
    }

    private DPO()
    {
      this.indicator = (Indicator) new DPO();
    }

    public DPO(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new DPO((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public DPO(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new DPO((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public DPO(OpenQuant.API.TimeSeries series, int length)
    {
      this.indicator = (Indicator) new DPO((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public DPO(OpenQuant.API.BarSeries series, int length, BarData option)
    {
      this.indicator = (Indicator) new DPO((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public DPO(Indicator indicator, int length, BarData option)
    {
      this.indicator = (Indicator) new DPO((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public DPO(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new DPO((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public DPO(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new DPO((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }

    public DPO(OpenQuant.API.TimeSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new DPO((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public DPO(OpenQuant.API.BarSeries series, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new DPO((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }
  }
}

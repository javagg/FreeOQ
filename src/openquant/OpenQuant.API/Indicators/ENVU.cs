using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class ENVU : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as ENVU).get_Length();
      }
      set
      {
        (this.indicator as ENVU).set_Length(value);
      }
    }

    [Description("Shift")]
    [Category("Parameters")]
    public double Shift
    {
      get
      {
        return (this.indicator as ENVU).get_Shift();
      }
      set
      {
        (this.indicator as ENVU).set_Shift(value);
      }
    }

    private ENVU()
    {
      this.indicator = (Indicator) new ENVU();
    }

    public ENVU(OpenQuant.API.BarSeries series, int length, int shift)
    {
      this.indicator = (Indicator) new ENVU((SmartQuant.Series.TimeSeries) series.series, length, (double) shift);
    }

    public ENVU(Indicator indicator, int length, int shift)
    {
      this.indicator = (Indicator) new ENVU((SmartQuant.Series.TimeSeries) indicator.indicator, length, (double) shift);
    }

    public ENVU(OpenQuant.API.BarSeries series, int length, int shift, BarData option)
    {
      this.indicator = (Indicator) new ENVU((SmartQuant.Series.TimeSeries) series.series, length, (double) shift, OpenQuant.API.EnumConverter.Convert(option));
    }

    public ENVU(Indicator indicator, int length, int shift, BarData option)
    {
      this.indicator = (Indicator) new ENVU((SmartQuant.Series.TimeSeries) indicator.indicator, length, (double) shift, OpenQuant.API.EnumConverter.Convert(option));
    }

    public ENVU(OpenQuant.API.BarSeries series, int length, int shift, Color color)
    {
      this.indicator = (Indicator) new ENVU((SmartQuant.Series.TimeSeries) series.series, length, (double) shift, color);
    }

    public ENVU(Indicator indicator, int length, int shift, Color color)
    {
      this.indicator = (Indicator) new ENVU((SmartQuant.Series.TimeSeries) indicator.indicator, length, (double) shift, color);
    }

    public ENVU(OpenQuant.API.BarSeries series, int length, int shift, BarData option, Color color)
    {
      this.indicator = (Indicator) new ENVU((SmartQuant.Series.TimeSeries) series.series, length, (double) shift, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public ENVU(Indicator indicator, int length, int shift, BarData option, Color color)
    {
      this.indicator = (Indicator) new ENVU((SmartQuant.Series.TimeSeries) indicator.indicator, length, (double) shift, OpenQuant.API.EnumConverter.Convert(option), color);
    }
  }
}

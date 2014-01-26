using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class CMO : Indicator
  {
    [Category("Parameters")]
    [Description("Length")]
    public int Length
    {
      get
      {
        return (this.indicator as CMO).get_Length();
      }
      set
      {
        (this.indicator as CMO).set_Length(value);
      }
    }

    private CMO()
    {
      this.indicator = (Indicator) new CMO();
    }

    public CMO(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new CMO((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public CMO(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new CMO((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public CMO(OpenQuant.API.BarSeries series, int length, BarData option)
    {
      this.indicator = (Indicator) new CMO((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public CMO(Indicator indicator, int length, BarData option)
    {
      this.indicator = (Indicator) new CMO((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public CMO(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new CMO((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public CMO(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new CMO((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }

    public CMO(OpenQuant.API.BarSeries series, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new CMO((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public CMO(Indicator indicator, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new CMO((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }
  }
}

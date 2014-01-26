using OpenQuant.API;
using FreeQuant.Indicators;
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

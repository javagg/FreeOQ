using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class SMD : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as SMD).get_Length();
      }
      set
      {
        (this.indicator as SMD).set_Length(value);
      }
    }

    private SMD()
    {
      this.indicator = (Indicator) new SMD();
    }

    public SMD(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new SMD((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public SMD(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new SMD((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public SMD(OpenQuant.API.BarSeries series, int length, BarData option)
    {
      this.indicator = (Indicator) new SMD((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public SMD(Indicator indicator, int length, BarData option)
    {
      this.indicator = (Indicator) new SMD((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public SMD(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new SMD((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public SMD(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new SMD((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }

    public SMD(OpenQuant.API.BarSeries series, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new SMD((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public SMD(Indicator indicator, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new SMD((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public SMD(OpenQuant.API.TimeSeries series, int length)
    {
      this.indicator = (Indicator) new SMD((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public SMD(OpenQuant.API.TimeSeries series, int length, BarData option)
    {
      this.indicator = (Indicator) new SMD((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public SMD(OpenQuant.API.TimeSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new SMD((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public SMD(OpenQuant.API.TimeSeries series, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new SMD((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }
  }
}

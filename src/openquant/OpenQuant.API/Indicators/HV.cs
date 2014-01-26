using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class HV : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as HV).get_Length();
      }
      set
      {
        (this.indicator as HV).set_Length(value);
      }
    }

    [Description("Span")]
    [Category("Parameters")]
    public double Span
    {
      get
      {
        return (this.indicator as HV).get_Span();
      }
      set
      {
        (this.indicator as HV).set_Span(value);
      }
    }

    private HV()
    {
      this.indicator = (Indicator) new HV();
    }

    public HV(OpenQuant.API.BarSeries series, int length, int span)
    {
      this.indicator = (Indicator) new HV((SmartQuant.Series.TimeSeries) series.series, length, (double) span);
    }

    public HV(Indicator indicator, int length, int span)
    {
      this.indicator = (Indicator) new HV((SmartQuant.Series.TimeSeries) indicator.indicator, length, (double) span);
    }

    public HV(OpenQuant.API.BarSeries series, int length, int span, BarData option)
    {
      this.indicator = (Indicator) new HV((SmartQuant.Series.TimeSeries) series.series, length, (double) span, OpenQuant.API.EnumConverter.Convert(option));
    }

    public HV(Indicator indicator, int length, int span, BarData option)
    {
      this.indicator = (Indicator) new HV((SmartQuant.Series.TimeSeries) indicator.indicator, length, (double) span, OpenQuant.API.EnumConverter.Convert(option));
    }

    public HV(OpenQuant.API.BarSeries series, int length, int span, Color color)
    {
      this.indicator = (Indicator) new HV((SmartQuant.Series.TimeSeries) series.series, length, (double) span, color);
    }

    public HV(Indicator indicator, int length, int span, Color color)
    {
      this.indicator = (Indicator) new HV((SmartQuant.Series.TimeSeries) indicator.indicator, length, (double) span, color);
    }

    public HV(OpenQuant.API.BarSeries series, int length, int span, BarData option, Color color)
    {
      this.indicator = (Indicator) new HV((SmartQuant.Series.TimeSeries) series.series, length, (double) span, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public HV(Indicator indicator, int length, int span, BarData option, Color color)
    {
      this.indicator = (Indicator) new HV((SmartQuant.Series.TimeSeries) indicator.indicator, length, (double) span, OpenQuant.API.EnumConverter.Convert(option), color);
    }
  }
}

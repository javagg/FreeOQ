using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class BBU : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as BBU).get_Length();
      }
      set
      {
        (this.indicator as BBU).set_Length(value);
      }
    }

    [Category("Parameters")]
    [Description("K")]
    public double K
    {
      get
      {
        return (this.indicator as BBU).get_K();
      }
      set
      {
        (this.indicator as BBU).set_K(value);
      }
    }

    private BBU()
    {
      this.indicator = (Indicator) new BBU();
    }

    public BBU(OpenQuant.API.BarSeries series, int length, double k)
    {
      this.indicator = (Indicator) new BBU((SmartQuant.Series.TimeSeries) series.series, length, k);
    }

    public BBU(Indicator indicator, int length, double k)
    {
      this.indicator = (Indicator) new BBU((SmartQuant.Series.TimeSeries) indicator.indicator, length, k);
    }

    public BBU(OpenQuant.API.BarSeries series, int length, double k, BarData option)
    {
      this.indicator = (Indicator) new BBU((SmartQuant.Series.TimeSeries) series.series, length, k, OpenQuant.API.EnumConverter.Convert(option));
    }

    public BBU(Indicator indicator, int length, double k, BarData option)
    {
      this.indicator = (Indicator) new BBU((SmartQuant.Series.TimeSeries) indicator.indicator, length, k, OpenQuant.API.EnumConverter.Convert(option));
    }

    public BBU(OpenQuant.API.BarSeries series, int length, double k, Color color)
    {
      this.indicator = (Indicator) new BBU((SmartQuant.Series.TimeSeries) series.series, length, k, color);
    }

    public BBU(Indicator indicator, int length, double k, Color color)
    {
      this.indicator = (Indicator) new BBU((SmartQuant.Series.TimeSeries) indicator.indicator, length, k, color);
    }

    public BBU(OpenQuant.API.BarSeries series, int length, double k, BarData option, Color color)
    {
      this.indicator = (Indicator) new BBU((SmartQuant.Series.TimeSeries) series.series, length, k, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public BBU(Indicator indicator, int length, double k, BarData option, Color color)
    {
      this.indicator = (Indicator) new BBU((SmartQuant.Series.TimeSeries) indicator.indicator, length, k, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public BBU(OpenQuant.API.TimeSeries series, int length, double k)
    {
      this.indicator = (Indicator) new BBU((SmartQuant.Series.TimeSeries) series.series, length, k);
    }

    public BBU(OpenQuant.API.TimeSeries series, int length, double k, Color color)
    {
      this.indicator = (Indicator) new BBU((SmartQuant.Series.TimeSeries) series.series, length, k, color);
    }
  }
}

using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class BBL : Indicator
  {
    [Category("Parameters")]
    [Description("Length")]
    public int Length
    {
      get
      {
        return (this.indicator as BBL).get_Length();
      }
      set
      {
        (this.indicator as BBL).set_Length(value);
      }
    }

    [Category("Parameters")]
    [Description("K")]
    public double K
    {
      get
      {
        return (this.indicator as BBL).get_K();
      }
      set
      {
        (this.indicator as BBL).set_K(value);
      }
    }

    private BBL()
    {
      this.indicator = (Indicator) new BBL();
    }

    public BBL(OpenQuant.API.BarSeries series, int length, double k)
    {
      this.indicator = (Indicator) new BBL((SmartQuant.Series.TimeSeries) series.series, length, k);
    }

    public BBL(Indicator indicator, int length, double k)
    {
      this.indicator = (Indicator) new BBL((SmartQuant.Series.TimeSeries) indicator.indicator, length, k);
    }

    public BBL(OpenQuant.API.BarSeries series, int length, double k, BarData option)
    {
      this.indicator = (Indicator) new BBL((SmartQuant.Series.TimeSeries) series.series, length, k, OpenQuant.API.EnumConverter.Convert(option));
    }

    public BBL(Indicator indicator, int length, double k, BarData option)
    {
      this.indicator = (Indicator) new BBL((SmartQuant.Series.TimeSeries) indicator.indicator, length, k, OpenQuant.API.EnumConverter.Convert(option));
    }

    public BBL(OpenQuant.API.BarSeries series, int length, double k, Color color)
    {
      this.indicator = (Indicator) new BBL((SmartQuant.Series.TimeSeries) series.series, length, k, color);
    }

    public BBL(Indicator indicator, int length, double k, Color color)
    {
      this.indicator = (Indicator) new BBL((SmartQuant.Series.TimeSeries) indicator.indicator, length, k, color);
    }

    public BBL(OpenQuant.API.BarSeries series, int length, double k, BarData option, Color color)
    {
      this.indicator = (Indicator) new BBL((SmartQuant.Series.TimeSeries) series.series, length, k, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public BBL(Indicator indicator, int length, double k, BarData option, Color color)
    {
      this.indicator = (Indicator) new BBL((SmartQuant.Series.TimeSeries) indicator.indicator, length, k, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public BBL(OpenQuant.API.TimeSeries series, int length, double k)
    {
      this.indicator = (Indicator) new BBL((SmartQuant.Series.TimeSeries) series.series, length, k);
    }

    public BBL(OpenQuant.API.TimeSeries series, int length, double k, Color color)
    {
      this.indicator = (Indicator) new BBL((SmartQuant.Series.TimeSeries) series.series, length, k, color);
    }
  }
}

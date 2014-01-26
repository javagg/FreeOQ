using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class FO : Indicator
  {
    [Category("Parameters")]
    [Description("Length")]
    public int Length
    {
      get
      {
        return (this.indicator as FO).get_Length();
      }
      set
      {
        (this.indicator as FO).set_Length(value);
      }
    }

    [Description("Distance Mode")]
    [Category("Parameters")]
    public RegressionDistanceMode DistanceMode
    {
      get
      {
        return OpenQuant.API.EnumConverter.Convert((this.indicator as FO).get_DistanceMode());
      }
      set
      {
        (this.indicator as FO).set_DistanceMode(OpenQuant.API.EnumConverter.Convert(value));
      }
    }

    private FO()
    {
      this.indicator = (Indicator) new FO();
    }

    public FO(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new FO((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public FO(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new FO((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public FO(OpenQuant.API.TimeSeries series, int length)
    {
      this.indicator = (Indicator) new FO((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public FO(OpenQuant.API.BarSeries series, int length, BarData option)
    {
      this.indicator = (Indicator) new FO((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public FO(Indicator indicator, int length, BarData option)
    {
      this.indicator = (Indicator) new FO((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public FO(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new FO((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public FO(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new FO((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }

    public FO(OpenQuant.API.BarSeries series, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new FO((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }
  }
}

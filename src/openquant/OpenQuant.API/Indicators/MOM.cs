using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class MOM : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as MOM).get_Length();
      }
      set
      {
        (this.indicator as MOM).set_Length(value);
      }
    }

    private MOM()
    {
      this.indicator = (Indicator) new MOM();
    }

    public MOM(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new MOM((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public MOM(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new MOM((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public MOM(OpenQuant.API.TimeSeries series, int length)
    {
      this.indicator = (Indicator) new MOM((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public MOM(OpenQuant.API.BarSeries series, int length, BarData option)
    {
      this.indicator = (Indicator) new MOM((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public MOM(Indicator indicator, int length, BarData option)
    {
      this.indicator = (Indicator) new MOM((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public MOM(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new MOM((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public MOM(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new MOM((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }

    public MOM(OpenQuant.API.TimeSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new MOM((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public MOM(OpenQuant.API.BarSeries series, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new MOM((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }
  }
}

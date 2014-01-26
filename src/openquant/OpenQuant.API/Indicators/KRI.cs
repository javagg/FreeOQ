using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class KRI : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as KRI).get_Length();
      }
      set
      {
        (this.indicator as KRI).set_Length(value);
      }
    }

    private KRI()
    {
      this.indicator = (Indicator) new KRI();
    }

    public KRI(BarSeries series, int length)
    {
			this.indicator = (Indicator) new KRI((FreeQuant.Series.TimeSeries) series.series, length);
    }

    public KRI(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new KRI((FreeQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public KRI(BarSeries series, int length, BarData option)
    {
      this.indicator = (Indicator) new KRI((FreeQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public KRI(Indicator indicator, int length, BarData option)
    {
      this.indicator = (Indicator) new KRI((FreeQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public KRI(BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new KRI((FreeQuant.Series.TimeSeries) series.series, length, color);
    }

    public KRI(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new KRI((FreeQuant.Series.TimeSeries) indicator.indicator, length, color);
    }

    public KRI(BarSeries series, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new KRI((FreeQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public KRI(Indicator indicator, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new KRI((FreeQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }
  }
}

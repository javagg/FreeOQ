using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class DPO : Indicator
  {
    [Category("Parameters")]
    [Description("Length")]
    public int Length
    {
      get
      {
        return (this.indicator as DPO).get_Length();
      }
      set
      {
        (this.indicator as DPO).set_Length(value);
      }
    }

    private DPO()
    {
      this.indicator = (Indicator) new DPO();
    }

    public DPO(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new DPO((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public DPO(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new DPO((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public DPO(OpenQuant.API.TimeSeries series, int length)
    {
      this.indicator = (Indicator) new DPO((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public DPO(OpenQuant.API.BarSeries series, int length, BarData option)
    {
      this.indicator = (Indicator) new DPO((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public DPO(Indicator indicator, int length, BarData option)
    {
      this.indicator = (Indicator) new DPO((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public DPO(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new DPO((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public DPO(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new DPO((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }

    public DPO(OpenQuant.API.TimeSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new DPO((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public DPO(OpenQuant.API.BarSeries series, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new DPO((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }
  }
}

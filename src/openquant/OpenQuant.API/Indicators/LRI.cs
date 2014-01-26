// Type: OpenQuant.API.Indicators.LRI
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class LRI : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as LRI).get_Length();
      }
      set
      {
        (this.indicator as LRI).set_Length(value);
      }
    }

    [Category("Parameters")]
    [Description("Distance Mode")]
    public RegressionDistanceMode DistanceMode
    {
      get
      {
        return OpenQuant.API.EnumConverter.Convert((this.indicator as LRI).get_DistanceMode());
      }
      set
      {
        (this.indicator as LRI).set_DistanceMode(OpenQuant.API.EnumConverter.Convert(value));
      }
    }

    private LRI()
    {
      this.indicator = (Indicator) new LRI();
    }

    public LRI(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new LRI((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public LRI(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new LRI((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public LRI(OpenQuant.API.BarSeries series, int length, BarData option)
    {
      this.indicator = (Indicator) new LRI((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public LRI(Indicator indicator, int length, BarData option)
    {
      this.indicator = (Indicator) new LRI((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public LRI(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new LRI((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public LRI(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new LRI((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }

    public LRI(OpenQuant.API.BarSeries series, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new LRI((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public LRI(Indicator indicator, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new LRI((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public LRI(OpenQuant.API.BarSeries series, int length, RegressionDistanceMode distanceMode)
    {
      this.indicator = (Indicator) new LRI((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public LRI(Indicator indicator, int length, RegressionDistanceMode distanceMode)
    {
      this.indicator = (Indicator) new LRI((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public LRI(OpenQuant.API.BarSeries series, int length, RegressionDistanceMode distanceMode, BarData option)
    {
      this.indicator = (Indicator) new LRI((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public LRI(Indicator indicator, int length, RegressionDistanceMode distanceMode, BarData option)
    {
      this.indicator = (Indicator) new LRI((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public LRI(OpenQuant.API.BarSeries series, int length, RegressionDistanceMode distanceMode, Color color)
    {
      this.indicator = (Indicator) new LRI((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public LRI(Indicator indicator, int length, RegressionDistanceMode distanceMode, Color color)
    {
      this.indicator = (Indicator) new LRI((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }

    public LRI(OpenQuant.API.BarSeries series, int length, RegressionDistanceMode distanceMode, BarData option, Color color)
    {
      this.indicator = (Indicator) new LRI((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public LRI(Indicator indicator, int length, RegressionDistanceMode distanceMode, BarData option, Color color)
    {
      this.indicator = (Indicator) new LRI((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }
  }
}

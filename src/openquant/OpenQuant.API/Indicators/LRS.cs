// Type: OpenQuant.API.Indicators.LRS
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class LRS : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as LRS).get_Length();
      }
      set
      {
        (this.indicator as LRS).set_Length(value);
      }
    }

    [Category("Parameters")]
    [Description("Distance Mode")]
    public RegressionDistanceMode DistanceMode
    {
      get
      {
        return OpenQuant.API.EnumConverter.Convert((this.indicator as LRS).get_DistanceMode());
      }
      set
      {
        (this.indicator as LRS).set_DistanceMode(OpenQuant.API.EnumConverter.Convert(value));
      }
    }

    private LRS()
    {
      this.indicator = (Indicator) new LRS();
    }

    public LRS(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new LRS((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public LRS(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new LRS((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public LRS(OpenQuant.API.BarSeries series, int length, BarData option)
    {
      this.indicator = (Indicator) new LRS((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public LRS(Indicator indicator, int length, BarData option)
    {
      this.indicator = (Indicator) new LRS((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option));
    }

    public LRS(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new LRS((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public LRS(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new LRS((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }

    public LRS(OpenQuant.API.BarSeries series, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new LRS((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public LRS(Indicator indicator, int length, BarData option, Color color)
    {
      this.indicator = (Indicator) new LRS((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public LRS(OpenQuant.API.BarSeries series, int length, RegressionDistanceMode distanceMode)
    {
      this.indicator = (Indicator) new LRS((SmartQuant.Series.TimeSeries) series.series, length);
      (this.indicator as LRS).set_DistanceMode(OpenQuant.API.EnumConverter.Convert(distanceMode));
    }

    public LRS(Indicator indicator, int length, RegressionDistanceMode distanceMode)
    {
      this.indicator = (Indicator) new LRS((SmartQuant.Series.TimeSeries) indicator.indicator, length);
      (this.indicator as LRS).set_DistanceMode(OpenQuant.API.EnumConverter.Convert(distanceMode));
    }

    public LRS(OpenQuant.API.BarSeries series, int length, RegressionDistanceMode distanceMode, BarData option)
    {
      this.indicator = (Indicator) new LRS((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option));
      (this.indicator as LRS).set_DistanceMode(OpenQuant.API.EnumConverter.Convert(distanceMode));
    }

    public LRS(Indicator indicator, int length, RegressionDistanceMode distanceMode, BarData option)
    {
      this.indicator = (Indicator) new LRS((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option));
      (this.indicator as LRS).set_DistanceMode(OpenQuant.API.EnumConverter.Convert(distanceMode));
    }

    public LRS(OpenQuant.API.BarSeries series, int length, RegressionDistanceMode distanceMode, Color color)
    {
      this.indicator = (Indicator) new LRS((SmartQuant.Series.TimeSeries) series.series, length, color);
      (this.indicator as LRS).set_DistanceMode(OpenQuant.API.EnumConverter.Convert(distanceMode));
    }

    public LRS(Indicator indicator, int length, RegressionDistanceMode distanceMode, Color color)
    {
      this.indicator = (Indicator) new LRS((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
      (this.indicator as LRS).set_DistanceMode(OpenQuant.API.EnumConverter.Convert(distanceMode));
    }

    public LRS(OpenQuant.API.BarSeries series, int length, RegressionDistanceMode distanceMode, BarData option, Color color)
    {
      this.indicator = (Indicator) new LRS((SmartQuant.Series.TimeSeries) series.series, length, OpenQuant.API.EnumConverter.Convert(option), color);
      (this.indicator as LRS).set_DistanceMode(OpenQuant.API.EnumConverter.Convert(distanceMode));
    }

    public LRS(Indicator indicator, int length, RegressionDistanceMode distanceMode, BarData option, Color color)
    {
      this.indicator = (Indicator) new LRS((SmartQuant.Series.TimeSeries) indicator.indicator, length, OpenQuant.API.EnumConverter.Convert(option), color);
      (this.indicator as LRS).set_DistanceMode(OpenQuant.API.EnumConverter.Convert(distanceMode));
    }
  }
}

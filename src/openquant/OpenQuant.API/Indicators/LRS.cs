using OpenQuant.API;
using FreeQuant.Indicators;
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
				return (this.indicator as FreeQuant.Indicators.LRS).Length;
      }
      set
      {
				(this.indicator as FreeQuant.Indicators.LRS).Length = value;
      }
    }

    [Category("Parameters")]
    [Description("Distance Mode")]
    public RegressionDistanceMode DistanceMode
    {
      get
      {
				return EnumConverter.Convert((this.indicator as FreeQuant.Indicators.LRS).DistanceMode);
      }
      set
      {
				(this.indicator as FreeQuant.Indicators.LRS).DistanceMode = EnumConverter.Convert(value);
      }
    }

    private LRS()
    {
			this.indicator = new FreeQuant.Indicators.LRS();
    }

    public LRS(BarSeries series, int length)
    {
			this.indicator = new FreeQuant.Indicators.LRS(series.series, length);
    }

    public LRS(Indicator indicator, int length)
    {
			this.indicator = new FreeQuant.Indicators.LRS(indicator.indicator, length);
    }

    public LRS(BarSeries series, int length, BarData option)
    {
			this.indicator = new FreeQuant.Indicators.LRS(series.series, length, EnumConverter.Convert(option));
    }

    public LRS(Indicator indicator, int length, BarData option)
    {
			this.indicator = new FreeQuant.Indicators.LRS(indicator.indicator, length, EnumConverter.Convert(option));
    }

    public LRS(BarSeries series, int length, Color color)
    {
			this.indicator = new FreeQuant.Indicators.LRS(series.series, length, color);
    }

    public LRS(Indicator indicator, int length, Color color)
    {
			this.indicator = new FreeQuant.Indicators.LRS(indicator.indicator, length, color);
    }

    public LRS(BarSeries series, int length, BarData option, Color color)
    {
			this.indicator = new FreeQuant.Indicators.LRS(series.series, length, EnumConverter.Convert(option), color);
    }

    public LRS(Indicator indicator, int length, BarData option, Color color)
    {
			this.indicator = new FreeQuant.Indicators.LRS(indicator.indicator, length, EnumConverter.Convert(option), color);
    }

    public LRS(BarSeries series, int length, RegressionDistanceMode distanceMode)
    {
			this.indicator = new FreeQuant.Indicators.LRS(series.series, length);
			(this.indicator as FreeQuant.Indicators.LRS).DistanceMode = EnumConverter.Convert(distanceMode);
    }

    public LRS(Indicator indicator, int length, RegressionDistanceMode distanceMode)
    {
			this.indicator = new FreeQuant.Indicators.LRS(indicator.indicator, length);
			(this.indicator as FreeQuant.Indicators.LRS).DistanceMode = EnumConverter.Convert(distanceMode);
    }

    public LRS(BarSeries series, int length, RegressionDistanceMode distanceMode, BarData option)
    {
			this.indicator = new FreeQuant.Indicators.LRS(series.series, length, EnumConverter.Convert(option));
			(this.indicator as FreeQuant.Indicators.LRS).DistanceMode = EnumConverter.Convert(distanceMode);
    }

    public LRS(Indicator indicator, int length, RegressionDistanceMode distanceMode, BarData option)
    {
			this.indicator = new FreeQuant.Indicators.LRS(indicator.indicator, length, EnumConverter.Convert(option));
			(this.indicator as FreeQuant.Indicators.LRS).DistanceMode = EnumConverter.Convert(distanceMode);
    }

    public LRS(BarSeries series, int length, RegressionDistanceMode distanceMode, Color color)
    {
			this.indicator = new FreeQuant.Indicators.LRS(series.series, length, color);
			(this.indicator as FreeQuant.Indicators.LRS).DistanceMode = EnumConverter.Convert(distanceMode);
    }

    public LRS(Indicator indicator, int length, RegressionDistanceMode distanceMode, Color color)
    {
			this.indicator = new FreeQuant.Indicators.LRS(indicator.indicator, length, color);
			(this.indicator as FreeQuant.Indicators.LRS).DistanceMode = EnumConverter.Convert(distanceMode);
    }

    public LRS(BarSeries series, int length, RegressionDistanceMode distanceMode, BarData option, Color color)
    {
			this.indicator = new FreeQuant.Indicators.LRS(series.series, length, EnumConverter.Convert(option), color);
			(this.indicator as FreeQuant.Indicators.LRS).DistanceMode = EnumConverter.Convert(distanceMode);
    }

    public LRS(Indicator indicator, int length, RegressionDistanceMode distanceMode, BarData option, Color color)
    {
			this.indicator = new FreeQuant.Indicators.LRS(indicator.indicator, length, EnumConverter.Convert(option), color);
			(this.indicator as FreeQuant.Indicators.LRS).DistanceMode = EnumConverter.Convert(distanceMode);
    }
  }
}

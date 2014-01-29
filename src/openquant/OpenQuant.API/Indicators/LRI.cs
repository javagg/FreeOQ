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
				return (this.indicator as FreeQuant.Indicators.LRI).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.LRI).Length = value;
			}
		}

		[Category("Parameters")]
		[Description("Distance Mode")]
		public RegressionDistanceMode DistanceMode
		{
			get
			{
				return EnumConverter.Convert((this.indicator as FreeQuant.Indicators.LRI).DistanceMode);
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.LRI).DistanceMode = EnumConverter.Convert(value);
			}
		}

		private LRI()
		{
			this.indicator = new FreeQuant.Indicators.LRI();
		}

		public LRI(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.LRI(series.series, length);
		}

		public LRI(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.LRI(indicator.indicator, length);
		}

		public LRI(BarSeries series, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.LRI(series.series, length, EnumConverter.Convert(option));
		}

		public LRI(Indicator indicator, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.LRI(indicator.indicator, length, EnumConverter.Convert(option));
		}

		public LRI(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.LRI(series.series, length, color);
		}

		public LRI(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.LRI(indicator.indicator, length, color);
		}

		public LRI(BarSeries series, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.LRI(series.series, length, EnumConverter.Convert(option), color);
		}

		public LRI(Indicator indicator, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.LRI(indicator.indicator, length, EnumConverter.Convert(option), color);
		}

		public LRI(BarSeries series, int length, RegressionDistanceMode distanceMode)
		{
			this.indicator = new FreeQuant.Indicators.LRI(series.series, length);
		}

		public LRI(Indicator indicator, int length, RegressionDistanceMode distanceMode)
		{
			this.indicator = new FreeQuant.Indicators.LRI(indicator.indicator, length);
		}

		public LRI(BarSeries series, int length, RegressionDistanceMode distanceMode, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.LRI(series.series, length, EnumConverter.Convert(option));
		}

		public LRI(Indicator indicator, int length, RegressionDistanceMode distanceMode, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.LRI(indicator.indicator, length, EnumConverter.Convert(option));
		}

		public LRI(BarSeries series, int length, RegressionDistanceMode distanceMode, Color color)
		{
			this.indicator = new FreeQuant.Indicators.LRI(series.series, length, color);
		}

		public LRI(Indicator indicator, int length, RegressionDistanceMode distanceMode, Color color)
		{
			this.indicator = new FreeQuant.Indicators.LRI(indicator.indicator, length, color);
		}

		public LRI(BarSeries series, int length, RegressionDistanceMode distanceMode, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.LRI(series.series, length, EnumConverter.Convert(option), color);
		}

		public LRI(Indicator indicator, int length, RegressionDistanceMode distanceMode, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.LRI(indicator.indicator, length, EnumConverter.Convert(option), color);
		}
	}
}

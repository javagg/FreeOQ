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
				return (this.indicator as FreeQuant.Indicators.FO).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.FO).Length = value;
			}
		}

		[Description("Distance Mode")]
		[Category("Parameters")]
		public RegressionDistanceMode DistanceMode
		{
			get
			{
				return EnumConverter.Convert((this.indicator as FreeQuant.Indicators.FO).DistanceMode);
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.FO).DistanceMode = EnumConverter.Convert(value);
			}
		}

		private FO()
		{
			this.indicator = new FreeQuant.Indicators.FO();
		}

		public FO(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.FO(series.series, length);
		}

		public FO(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.FO(indicator.indicator, length);
		}

		public FO(TimeSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.FO(series.series, length);
		}

		public FO(BarSeries series, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.FO(series.series, length, EnumConverter.Convert(option));
		}

		public FO(Indicator indicator, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.FO(indicator.indicator, length, EnumConverter.Convert(option));
		}

		public FO(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.FO(series.series, length, color);
		}

		public FO(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.FO(indicator.indicator, length, color);
		}

		public FO(BarSeries series, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.FO(series.series, length, EnumConverter.Convert(option), color);
		}
	}
}

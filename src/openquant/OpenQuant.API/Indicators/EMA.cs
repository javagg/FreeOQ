using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class EMA : Indicator
	{
		[Category("Parameters")]
		[Description("Length")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.EMA).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.EMA).Length = value;
			}
		}

		private EMA()
		{
			this.indicator = new FreeQuant.Indicators.EMA();
		}

		public EMA(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.EMA(series.series, length);
		}

		public EMA(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.EMA(indicator.indicator, length);
		}

		public EMA(BarSeries series, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.EMA(series.series, length, EnumConverter.Convert(option));
		}

		public EMA(Indicator indicator, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.EMA(indicator.indicator, length, EnumConverter.Convert(option));
		}

		public EMA(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.EMA(series.series, length, color);
		}

		public EMA(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.EMA(indicator.indicator, length, color);
		}

		public EMA(BarSeries series, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.EMA(series.series, length, EnumConverter.Convert(option), color);
		}

		public EMA(Indicator indicator, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.EMA(indicator.indicator, length, EnumConverter.Convert(option), color);
		}

		public EMA(TimeSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.EMA(series.series, length);
		}

		public EMA(TimeSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.EMA(series.series, length, color);
		}
	}
}

using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class SMA : Indicator
	{
		[Description("Length")]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.SMA).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.SMA).Length = value;
			}
		}

		private SMA()
		{
			this.indicator = new FreeQuant.Indicators.SMA();
		}

		public SMA(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.SMA(series.series, length);
		}

		public SMA(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.SMA(indicator.indicator, length);
		}

		public SMA(BarSeries series, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.SMA(series.series, length, EnumConverter.Convert(option));
		}

		public SMA(Indicator indicator, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.SMA(indicator.indicator, length, EnumConverter.Convert(option));
		}

		public SMA(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.SMA(series.series, length, color);
		}

		public SMA(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.SMA(indicator.indicator, length, color);
		}

		public SMA(BarSeries series, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.SMA(series.series, length, EnumConverter.Convert(option), color);
		}

		public SMA(Indicator indicator, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.SMA(indicator.indicator, length, EnumConverter.Convert(option), color);
		}

		public SMA(TimeSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.SMA(series.series, length);
		}

		public SMA(TimeSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.SMA(series.series, length, color);
		}
	}
}
using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class RSI : Indicator
	{
		[Description("Length")]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.RSI).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.RSI).Length = value;
			}
		}

		public IndicatorStyle Style
		{
			get
			{
				return EnumConverter.Convert((this.indicator as FreeQuant.Indicators.RSI).Style);
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.RSI).Style = EnumConverter.Convert(value);
			}
		}

		private RSI()
		{
			this.indicator = new FreeQuant.Indicators.RSI();
		}

		public RSI(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.RSI(series.series, length);
		}

		public RSI(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.RSI(indicator.indicator, length);
		}

		public RSI(TimeSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.RSI(series.series, length);
		}

		public RSI(BarSeries series, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.RSI(series.series, length, EnumConverter.Convert(option));
		}

		public RSI(Indicator indicator, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.RSI(indicator.indicator, length, EnumConverter.Convert(option));
		}

		public RSI(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.RSI(series.series, length, color);
		}

		public RSI(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.RSI(indicator.indicator, length, color);
		}

		public RSI(TimeSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.RSI(series.series, length, color);
		}

		public RSI(BarSeries series, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.RSI(series.series, length, EnumConverter.Convert(option), (EIndicatorStyle)0, color);
		}

		public RSI(Indicator indicator, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.RSI(indicator.indicator, length, EnumConverter.Convert(option), (EIndicatorStyle)0, color);
		}
	}
}

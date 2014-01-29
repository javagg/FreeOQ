using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class WMA : Indicator
	{
		[Description("Length")]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.WMA).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.WMA).Length = value;
			}
		}

		private WMA()
		{
			this.indicator = new FreeQuant.Indicators.WMA();
		}

		public WMA(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.WMA((FreeQuant.Series.TimeSeries)(series.series), length);
		}

		public WMA(TimeSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.WMA((FreeQuant.Series.TimeSeries)(series.series), length);
		}

		public WMA(Indicator indicator, int length)
		{
			this.indicator = new WMA((FreeQuant.Series.TimeSeries)indicator.indicator, length);
		}

		public WMA(BarSeries series, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.WMA((FreeQuant.Series.TimeSeries)(series.series), length, EnumConverter.Convert(option));
		}

		public WMA(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.WMA((FreeQuant.Series.TimeSeries)(series.series), length);
		}

		public WMA(TimeSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.WMA((FreeQuant.Series.TimeSeries)(series.series), length);
		}

		public WMA(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.WMA((FreeQuant.Series.TimeSeries)indicator.indicator, length);
		}

		public WMA(BarSeries series, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.WMA((FreeQuant.Series.TimeSeries)(series.series), length, EnumConverter.Convert(option), color);
		}
	}
}

using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class VWAP : Indicator
	{
		[Category("Parameters")]
		[Description("Length")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.VWAP).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.VWAP).Length = value;
			}
		}

		private VWAP()
		{
			this.indicator = new FreeQuant.Indicators.VWAP();
		}

		public VWAP(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.VWAP(series.series, length);
		}

		public VWAP(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.VWAP(indicator.indicator, length);
		}

		public VWAP(BarSeries series, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.VWAP(series.series, length, EnumConverter.Convert(option));
		}

		public VWAP(Indicator indicator, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.VWAP(indicator.indicator, length, EnumConverter.Convert(option));
		}

		public VWAP(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.VWAP(series.series, length, color);
		}

		public VWAP(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.VWAP(indicator.indicator, length, color);
		}

		public VWAP(BarSeries series, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.VWAP(series.series, length, EnumConverter.Convert(option), color);
		}

		public VWAP(Indicator indicator, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.VWAP(indicator.indicator, length, EnumConverter.Convert(option), color);
		}
	}
}

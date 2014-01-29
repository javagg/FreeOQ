using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class MACD : Indicator
	{
		[Category("Parameters")]
		[Description("Length1")]
		public int Length1
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.MACD).Length1;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.MACD).Length1 = value;
			}
		}

		[Category("Parameters")]
		[Description("Length2")]
		public int Length2
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.MACD).Length2;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.MACD).Length2 = value;
			}
		}

		private MACD()
		{
			this.indicator = new FreeQuant.Indicators.MACD();
		}

		public MACD(BarSeries series, int length1, int length2)
		{
			this.indicator = new FreeQuant.Indicators.MACD(series.series, length1, length2);
		}

		public MACD(Indicator indicator, int length1, int length2)
		{
			this.indicator = new FreeQuant.Indicators.MACD(indicator.indicator, length1, length2);
		}

		public MACD(TimeSeries series, int length1, int length2)
		{
			this.indicator = new FreeQuant.Indicators.MACD(series.series, length1, length2);
		}

		public MACD(BarSeries series, int length1, int length2, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.MACD(series.series, length1, length2, EnumConverter.Convert(option));
		}

		public MACD(Indicator indicator, int length1, int length2, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.MACD(indicator.indicator, length1, length2, EnumConverter.Convert(option));
		}

		public MACD(BarSeries series, int length1, int length2, Color color)
		{
			this.indicator = new FreeQuant.Indicators.MACD(series.series, length1, length2, color);
		}

		public MACD(Indicator indicator, int length1, int length2, Color color)
		{
			this.indicator = new FreeQuant.Indicators.MACD(indicator.indicator, length1, length2, color);
		}

		public MACD(TimeSeries series, int length1, int length2, Color color)
		{
			this.indicator = new FreeQuant.Indicators.MACD(series.series, length1, length2, color);
		}

		public MACD(BarSeries series, int length1, int length2, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.MACD(series.series, length1, length2, EnumConverter.Convert(option), color);
		}

		public MACD(Indicator indicator, int length1, int length2, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.MACD(indicator.indicator, length1, length2, EnumConverter.Convert(option), color);
		}
	}
}

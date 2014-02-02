using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class TRIX : Indicator
	{
		[Category("Parameters")]
		[Description("Length")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.TRIX).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.TRIX).Length = value;
			}
		}

		private TRIX()
		{
			this.indicator = new FreeQuant.Indicators.TRIX();
		}

		public TRIX(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.TRIX(series.series, length);
		}

		public TRIX(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.TRIX(indicator.indicator, length);
		}

		public TRIX(BarSeries series, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.TRIX(series.series, length, EnumConverter.Convert(option));
		}

		public TRIX(Indicator indicator, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.TRIX(indicator.indicator, length, EnumConverter.Convert(option));
		}

		public TRIX(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.TRIX(series.series, length, color);
		}

		public TRIX(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.TRIX(indicator.indicator, length, color);
		}

		public TRIX(BarSeries series, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.TRIX(series.series, length, EnumConverter.Convert(option), color);
		}

		public TRIX(Indicator indicator, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.TRIX(indicator.indicator, length, EnumConverter.Convert(option), color);
		}
	}
}

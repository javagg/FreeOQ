using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class ATR : Indicator
	{
		[Description("Length")]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.ATR).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.ATR).Length = value;
			}
		}

		public IndicatorStyle Style
		{
			get
			{
				return EnumConverter.Convert((this.indicator as FreeQuant.Indicators.ATR).Style);
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.ATR).Style = EnumConverter.Convert(value);
			}
		}

		private ATR()
		{
			this.indicator = new FreeQuant.Indicators.ATR();
		}

		public ATR(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.ATR(series.series, length);
		}

		public ATR(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.ATR(indicator.indicator, length);
		}

		public ATR(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.ATR(series.series, length, color);
		}

		public ATR(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.ATR(indicator.indicator, length, color);
		}
	}
}

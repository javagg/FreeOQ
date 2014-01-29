using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class ADX : Indicator
	{
		[Description("Length")]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.ADX).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.ADX).Length = value;
			}
		}

		public IndicatorStyle Style
		{
			get
			{
				return EnumConverter.Convert((this.indicator as FreeQuant.Indicators.ADX).Style);
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.ADX).Style = EnumConverter.Convert(value);
			}
		}

		private ADX()
		{
			this.indicator = new FreeQuant.Indicators.ADX();
		}

		public ADX(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.ADX(series.series, length);
		}

		public ADX(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.ADX(indicator.indicator, length);
		}

		public ADX(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.ADX(series.series, length, color);
		}

		public ADX(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.ADX(indicator.indicator, length, color);
		}
	}
}

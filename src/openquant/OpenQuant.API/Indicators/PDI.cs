using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class PDI : Indicator
	{
		[Description("Length")]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.PDI).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.PDI).Length = value;
			}
		}

		public IndicatorStyle Style
		{
			get
			{
				return EnumConverter.Convert((this.indicator as FreeQuant.Indicators.PDI).Style);
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.PDI).Style(EnumConverter.Convert(value));
			}
		}

		private PDI()
		{
			this.indicator = new FreeQuant.Indicators.PDI();
		}

		public PDI(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.PDI(series.series, length);
		}

		public PDI(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.PDI(indicator.indicator, length);
		}

		public PDI(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.PDI(series.series, length, color);
		}

		public PDI(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.PDI(indicator.indicator, length, color);
		}
	}
}

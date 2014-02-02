using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class MDI : Indicator
	{
		[Category("Parameters")]
		[Description("Length")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.MDI).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.MDI).Length = value;
			}
		}

		public IndicatorStyle Style
		{
			get
			{
				return EnumConverter.Convert((this.indicator as FreeQuant.Indicators.MDI).Style);
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.MDI).Style = EnumConverter.Convert(value);
			}
		}

		private MDI()
		{
			this.indicator = new FreeQuant.Indicators.MDI();
		}

		public MDI(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.MDI(series.series, length);
		}

		public MDI(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.MDI(indicator.indicator, length);
		}

		public MDI(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.MDI(series.series, length, color);
		}

		public MDI(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.MDI(indicator.indicator, length, color);
		}
	}
}

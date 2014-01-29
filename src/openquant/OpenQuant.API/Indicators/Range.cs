using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class Range : Indicator
	{
		[Description("Length")]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.Range).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.Rang).Length = value;
			}
		}

		private Range()
		{
			this.indicator = new FreeQuant.Indicators.Rang();
		}

		public Range(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.Rang(series.series, length);
		}

		public Range(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.Rang(indicator.indicator, length);
		}

		public Range(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.Rang(series.series, length, color);
		}

		public Range(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.Rang(indicator.indicator, length, color);
		}
	}
}

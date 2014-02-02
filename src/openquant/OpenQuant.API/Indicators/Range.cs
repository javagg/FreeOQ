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
				(this.indicator as FreeQuant.Indicators.Range).Length = value;
			}
		}

		private Range()
		{
			this.indicator = new FreeQuant.Indicators.Range();
		}

		public Range(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.Range(series.series, length);
		}

		public Range(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.Range(indicator.indicator, length);
		}

		public Range(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.Range(series.series, length, color);
		}

		public Range(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.Range(indicator.indicator, length, color);
		}
	}
}

using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class VROC : Indicator
	{
		[Category("Parameters")]
		[Description("Length")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.VROC).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.VROC).Length = value;
			}
		}

		private VROC()
		{
			this.indicator = new FreeQuant.Indicators.VROC();
		}

		public VROC(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.VROC(series.series, length);
		}

		public VROC(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.VROC(indicator.indicator, length);
		}

		public VROC(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.VROC(series.series, length, color);
		}

		public VROC(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.VROC(indicator.indicator, length, color);
		}
	}
}

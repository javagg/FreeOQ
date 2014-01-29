using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class AroonL : Indicator
	{
		[Category("Parameters")]
		[Description("Length")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.AroonL).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.AroonL).Length = value;
			}
		}

		private AroonL()
		{
			this.indicator = new FreeQuant.Indicators.AroonL();
		}

		public AroonL(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.AroonL(series.series, length);
		}

		public AroonL(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.AroonL(indicator.indicator, length);
		}

		public AroonL(TimeSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.AroonL(series.series, length);
		}

		public AroonL(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.AroonL(series.series, length, color);
		}

		public AroonL(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.AroonL(indicator.indicator, length, color);
		}

		public AroonL(TimeSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.AroonL(series.series, length, color);
		}
	}
}

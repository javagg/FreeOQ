using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class R : Indicator
	{
		[Description("Length")]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.R).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.R).Length = value;
			}
		}

		private R()
		{
			this.indicator = new FreeQuant.Indicators.R();
		}

		public R(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.R(series.series, length);
		}

		public R(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.R(indicator.indicator, length);
		}

		public R(TimeSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.R(series.series, length);
		}

		public R(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.R(series.series, length, color);
		}

		public R(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.R(indicator.indicator, length, color);
		}

		public R(TimeSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.R(series.series, length, color);
		}
	}
}

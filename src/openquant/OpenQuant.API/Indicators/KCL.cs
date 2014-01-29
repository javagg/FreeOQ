using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class KCL : Indicator
	{
		[Description("Length")]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.KCL).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.KCL).Length = value;
			}
		}

		private KCL()
		{
			this.indicator = new FreeQuant.Indicators.KCL();
		}

		public KCL(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.KCL(series.series, length);
		}

		public KCL(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.KCL(indicator.indicator, length);
		}

		public KCL(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.KCL(series.series, length, color);
		}

		public KCL(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.KCL(indicator.indicator, length, color);
		}

		public KCL(TimeSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.KCL(series.series, length);
		}

		public KCL(TimeSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.KCL(series.series, length, color);
		}
	}
}

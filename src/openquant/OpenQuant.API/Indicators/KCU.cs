using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class KCU : Indicator
	{
		[Category("Parameters")]
		[Description("Length")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.KCU).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.KCU).Length = value;
			}
		}

		private KCU()
		{
			this.indicator = new FreeQuant.Indicators.KCU();
		}

		public KCU(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.KCU(series.series, length);
		}

		public KCU(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.KCU(indicator.indicator, length);
		}

		public KCU(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.KCU(series.series, length, color);
		}

		public KCU(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.KCU(indicator.indicator, length, color);
		}

		public KCU(TimeSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.KCU(series.series, length);
		}

		public KCU(TimeSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.KCU(series.series, length, color);
		}
	}
}

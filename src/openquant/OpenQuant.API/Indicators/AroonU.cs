using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class AroonU : Indicator
	{
		[Category("Parameters")]
		[Description("Length")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.AroonU).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.AroonU).Length = value;
			}
		}

		private AroonU()
		{
			this.indicator = new FreeQuant.Indicators.AroonU();
		}

		public AroonU(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.AroonU(series.series, length);
		}

		public AroonU(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.AroonU(indicator.indicator, length);
		}

		public AroonU(TimeSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.AroonU(series.series, length);
		}

		public AroonU(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.AroonU(series.series, length, color);
		}

		public AroonU(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.AroonU(indicator.indicator, length, color);
		}

		public AroonU(TimeSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.AroonU(series.series, length, color);
		}
	}
}

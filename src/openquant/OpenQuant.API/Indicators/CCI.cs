using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class CCI : Indicator
	{
		[Category("Parameters")]
		[Description("Length")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.CCI).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.CCI).Length = value;
			}
		}

		private CCI()
		{
			this.indicator = new FreeQuant.Indicators.CCI();
		}

		public CCI(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.CCI(series.series, length);
		}

		public CCI(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.CCI(indicator.indicator, length);
		}

		public CCI(TimeSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.CCI(series.series, length);
		}

		public CCI(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.CCI(series.series, length, color);
		}

		public CCI(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.CCI(indicator.indicator, length, color);
		}

		public CCI(TimeSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.CCI(series.series, length, color);
		}
	}
}

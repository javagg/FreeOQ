using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class PCU : Indicator
	{
		[Category("Parameters")]
		[Description("Length")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.PCU).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.PCU).Length = value;
			}
		}

		private PCU()
		{
			this.indicator = new FreeQuant.Indicators.PCU();
		}

		public PCU(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.PCU(series.series, length);
		}

		public PCU(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.PCU(indicator.indicator, length);
		}

		public PCU(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.PCU(series.series, length, color);
		}

		public PCU(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.PCU(indicator.indicator, length, color);
		}
	}
}

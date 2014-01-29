using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class PCL : Indicator
	{
		[Description("Length")]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.PCL).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.PCL).Length = value;
			}
		}

		private PCL()
		{
			this.indicator = new FreeQuant.Indicators.PCL();
		}

		public PCL(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.PCL(series.series, length);
		}

		public PCL(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.PCL(indicator.indicator, length);
		}

		public PCL(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.PCL(series.series, length, color);
		}

		public PCL(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.PCL(indicator.indicator, length, color);
		}
	}
}

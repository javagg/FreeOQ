using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class K_Fast : Indicator
	{
		[Description("Length")]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.K_Fast).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.K_Fast).Length = value;
			}
		}

		private K_Fast()
		{
			this.indicator = new FreeQuant.Indicators.K_Fast();
		}

		public K_Fast(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.K_Fast(series.series, length);
		}

		public K_Fast(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.K_Fast(indicator.indicator, length);
		}

		public K_Fast(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.K_Fast(series.series, length, color);
		}

		public K_Fast(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.K_Fast(indicator.indicator, length, color);
		}
	}
}

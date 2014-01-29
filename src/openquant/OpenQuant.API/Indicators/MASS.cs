using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class MASS : Indicator
	{
		[Category("Parameters")]
		[Description("Length")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.MASS).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.MASS).Length = value;
			}
		}

		[Category("Parameters")]
		[Description("Order")]
		public int Order
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.MASS).Order;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.MASS).Order = value;
			}
		}

		private MASS()
		{
			this.indicator = new FreeQuant.Indicators.MASS();
		}

		public MASS(BarSeries series, int length, int order)
		{
			this.indicator = new FreeQuant.Indicators.MASS(series.series, length, order);
		}

		public MASS(Indicator indicator, int length, int order)
		{
			this.indicator = new FreeQuant.Indicators.MASS(indicator.indicator, length, order);
		}

		public MASS(BarSeries series, int length, int order, Color color)
		{
			this.indicator = new FreeQuant.Indicators.MASS(series.series, length, order, color);
		}

		public MASS(Indicator indicator, int length, int order, Color color)
		{
			this.indicator = new FreeQuant.Indicators.MASS(indicator.indicator, length, order, color);
		}
	}
}

using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class D_Fast : Indicator
	{
		[Category("Parameters")]
		[Description("Length")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.D_Fast).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.D_Fast).Length = value;
			}
		}

		[Category("Parameters")]
		[Description("Order")]
		public int Order
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.D_Fast).Order;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.D_Fast).Order = value;
			}
		}

		private D_Fast()
		{
			this.indicator = new FreeQuant.Indicators.D_Fast();
		}

		public D_Fast(BarSeries series, int length, int order)
		{
			this.indicator = new FreeQuant.Indicators.D_Fast(series.series, length, order);
		}

		public D_Fast(Indicator indicator, int length, int order)
		{
			this.indicator = new FreeQuant.Indicators.D_Fast(indicator.indicator, length, order);
		}

		public D_Fast(BarSeries series, int length, int order, Color color)
		{
			this.indicator = new FreeQuant.Indicators.D_Fast(series.series, length, order, color);
		}

		public D_Fast(Indicator indicator, int length, int order, Color color)
		{
			this.indicator = new FreeQuant.Indicators.D_Fast(indicator.indicator, length, order, color);
		}
	}
}

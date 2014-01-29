using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class D_Slow : Indicator
	{
		[Category("Parameters")]
		[Description("Length")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.D_Slow).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.D_Slow).Length = value;
			}
		}

		[Description("Order1")]
		[Category("Parameters")]
		public int Order1
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.D_Slow).Order1;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.D_Slow).Order1 = value;
			}
		}

		[Category("Parameters")]
		[Description("Order2")]
		public int Order2
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.D_Slow).Order2;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.D_Slow).Order2 = value;
			}
		}

		private D_Slow()
		{
			this.indicator = new FreeQuant.Indicators.D_Slow();
		}

		public D_Slow(BarSeries series, int length, int order1, int order2)
		{
			this.indicator = new FreeQuant.Indicators.D_Slow(series.series, length, order1, order2);
		}

		public D_Slow(Indicator indicator, int length, int order1, int order2)
		{
			this.indicator = new FreeQuant.Indicators.D_Slow(indicator.indicator, length, order1, order2);
		}

		public D_Slow(BarSeries series, int length, int order1, int order2, Color color)
		{
			this.indicator = new FreeQuant.Indicators.D_Slow(series.series, length, order1, order2, color);
		}

		public D_Slow(Indicator indicator, int length, int order1, int order2, Color color)
		{
			this.indicator = new FreeQuant.Indicators.D_Slow(indicator.indicator, length, order1, order2, color);
		}
	}
}

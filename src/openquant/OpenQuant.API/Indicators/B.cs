using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class B : Indicator
	{
		[Category("Parameters")]
		[Description("Length")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.B).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.B).Length = value;
			}
		}

		[Description("K")]
		[Category("Parameters")]
		public double K
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.B).K;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.B).K = value;
			}
		}

		private B()
		{
			this.indicator = new FreeQuant.Indicators.B();
		}

		public B(BarSeries series, int length, double k)
		{
			this.indicator = new FreeQuant.Indicators.B(series.series, length, k);
		}

		public B(Indicator indicator, int length, double k)
		{
			this.indicator = new FreeQuant.Indicators.B(indicator.indicator, length, k);
		}

		public B(BarSeries series, int length, double k, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.B(series.series, length, k, EnumConverter.Convert(option));
		}

		public B(Indicator indicator, int length, double k, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.B(indicator.indicator, length, k, EnumConverter.Convert(option));
		}

		public B(BarSeries series, int length, double k, Color color)
		{
			this.indicator = new FreeQuant.Indicators.B(series.series, length, k, color);
		}

		public B(Indicator indicator, int length, double k, Color color)
		{
			this.indicator = new FreeQuant.Indicators.B(indicator.indicator, length, k, color);
		}

		public B(BarSeries series, int length, double k, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.B(series.series, length, k, EnumConverter.Convert(option), color);
		}

		public B(Indicator indicator, int length, double k, BarData option, Color color)
		{
			this.indicator = new B(indicator.indicator, length, k, EnumConverter.Convert(option), color);
		}
	}
}

using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class BBL : Indicator
	{
		[Category("Parameters")]
		[Description("Length")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.BBL).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.BBL).Length = value;
			}
		}

		[Category("Parameters")]
		[Description("K")]
		public double K
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.BBL).K;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.BBL).K = value;
			}
		}

		private BBL()
		{
			this.indicator = new FreeQuant.Indicators.BBL();
		}

		public BBL(BarSeries series, int length, double k)
		{
			this.indicator = new FreeQuant.Indicators.BBL(series.series, length, k);
		}

		public BBL(Indicator indicator, int length, double k)
		{
			this.indicator = new FreeQuant.Indicators.BBL(indicator.indicator, length, k);
		}

		public BBL(BarSeries series, int length, double k, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.BBL(series.series, length, k, OpenQuant.API.EnumConverter.Convert(option));
		}

		public BBL(Indicator indicator, int length, double k, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.BBL(indicator.indicator, length, k, OpenQuant.API.EnumConverter.Convert(option));
		}

		public BBL(BarSeries series, int length, double k, Color color)
		{
			this.indicator = new FreeQuant.Indicators.BBL(series.series, length, k, color);
		}

		public BBL(Indicator indicator, int length, double k, Color color)
		{
			this.indicator = new FreeQuant.Indicators.BBL(indicator.indicator, length, k, color);
		}

		public BBL(BarSeries series, int length, double k, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.BBL(series.series, length, k, EnumConverter.Convert(option), color);
		}

		public BBL(Indicator indicator, int length, double k, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.BBL(indicator.indicator, length, k, EnumConverter.Convert(option), color);
		}

		public BBL(TimeSeries series, int length, double k)
		{
			this.indicator = new FreeQuant.Indicators.BBL(series.series, length, k);
		}

		public BBL(TimeSeries series, int length, double k, Color color)
		{
			this.indicator = new FreeQuant.Indicators.BBL(series.series, length, k, color);
		}
	}
}

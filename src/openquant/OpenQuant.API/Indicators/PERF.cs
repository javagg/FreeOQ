using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class PERF : Indicator
	{
		[Category("Parameters")]
		[Description("K")]
		public double K
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.PERF).K;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.PERF).K = value;
			}
		}

		private PERF()
		{
			this.indicator = new FreeQuant.Indicators.PERF();
		}

		public PERF(BarSeries series, double k)
		{
			this.indicator = new FreeQuant.Indicators.PERF(series.series, k);
		}

		public PERF(Indicator indicator, double k)
		{
			this.indicator = new FreeQuant.Indicators.PERF(indicator.indicator, k);
		}

		public PERF(BarSeries series, double k, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.PERF(series.series, k, EnumConverter.Convert(option));
		}

		public PERF(Indicator indicator, double k, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.PERF(indicator.indicator, k, EnumConverter.Convert(option));
		}

		public PERF(BarSeries series, double k, Color color)
		{
			this.indicator = new FreeQuant.Indicators.PERF(series.series, k, color);
		}

		public PERF(Indicator indicator, double k, Color color)
		{
			this.indicator = new FreeQuant.Indicators.PERF(indicator.indicator, k, color);
		}

		public PERF(BarSeries series, double k, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.PERF(series.series, k, EnumConverter.Convert(option), color);
		}

		public PERF(Indicator indicator, double k, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.PERF(indicator.indicator, k, EnumConverter.Convert(option), color);
		}
	}
}

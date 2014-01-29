using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class BBU : Indicator
	{
		[Description("Length")]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.BBU).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.BBU).Length = value;
			}
		}

		[Category("Parameters")]
		[Description("K")]
		public double K
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.BBU).K;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.BBU).K = value;
			}
		}

		private BBU()
		{
			this.indicator = new FreeQuant.Indicators.BBU();
		}

		public BBU(BarSeries series, int length, double k)
		{
			this.indicator = new FreeQuant.Indicators.BBU(series.series, length, k);
		}

		public BBU(Indicator indicator, int length, double k)
		{
			this.indicator = new FreeQuant.Indicators.BBU(indicator.indicator, length, k);
		}

		public BBU(BarSeries series, int length, double k, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.BBU(series.series, length, k, EnumConverter.Convert(option));
		}

		public BBU(Indicator indicator, int length, double k, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.BBU(indicator.indicator, length, k, EnumConverter.Convert(option));
		}

		public BBU(BarSeries series, int length, double k, Color color)
		{
			this.indicator = new FreeQuant.Indicators.BBU(series.series, length, k, color);
		}

		public BBU(Indicator indicator, int length, double k, Color color)
		{
			this.indicator = new FreeQuant.Indicators.BBU(indicator.indicator, length, k, color);
		}

		public BBU(BarSeries series, int length, double k, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.BBU(series.series, length, k, EnumConverter.Convert(option), color);
		}

		public BBU(Indicator indicator, int length, double k, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.BBU(indicator.indicator, length, k, EnumConverter.Convert(option), color);
		}

		public BBU(TimeSeries series, int length, double k)
		{
			this.indicator = new FreeQuant.Indicators.BBU(series.series, length, k);
		}

		public BBU(TimeSeries series, int length, double k, Color color)
		{
			this.indicator = new FreeQuant.Indicators.BBU(series.series, length, k, color);
		}
	}
}

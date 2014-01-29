using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class ROC : Indicator
	{
		[Description("Length")]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.ROC).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.ROC).Length = value;
			}
		}

		private ROC()
		{
			this.indicator = new FreeQuant.Indicators.ROC();
		}

		public ROC(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.ROC(series.series, length);
		}

		public ROC(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.ROC(indicator.indicator, length);
		}

		public ROC(BarSeries series, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.ROC(series.series, length, EnumConverter.Convert(option));
		}

		public ROC(Indicator indicator, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.ROC(indicator.indicator, length, EnumConverter.Convert(option));
		}

		public ROC(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.ROC(series.series, length, color);
		}

		public ROC(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.ROC(indicator.indicator, length, color);
		}

		public ROC(BarSeries series, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.ROC(series.series, length, EnumConverter.Convert(option), color);
		}

		public ROC(Indicator indicator, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.ROC(indicator.indicator, length, EnumConverter.Convert(option), color);
		}
	}
}

using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class ADXR : Indicator
	{
		[Category("Parameters")]
		[Description("Length")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.ADXR).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.ADXR).Length = value;
			}
		}

		public IndicatorStyle Style
		{
			get
			{
				return EnumConverter.Convert((this.indicator as FreeQuant.Indicators.ADXR).Style);
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.ADXR).Style = EnumConverter.Convert(value);
			}
		}

		private ADXR()
		{
			this.indicator = new FreeQuant.Indicators.ADXR();
		}

		public ADXR(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.ADXR(series.series, length);
		}

		public ADXR(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.ADXR(indicator.indicator, length);
		}

		public ADXR(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.ADXR(series.series, length, color);
		}

		public ADXR(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.ADXR(indicator.indicator, length, color);
		}
	}
}

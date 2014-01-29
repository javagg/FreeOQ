using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class ENVL : Indicator
	{
		[Description("Length")]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.ENVL).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.ENVL).Length = value;
			}
		}

		[Category("Parameters")]
		[Description("Shift")]
		public double Shift
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.ENVL).Shift;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.ENVL).Shift = value;
			}
		}

		private ENVL()
		{
			this.indicator = new FreeQuant.Indicators.ENVL();
		}

		public ENVL(BarSeries series, int length, int shift)
		{
			this.indicator = new FreeQuant.Indicators.ENVL(series.series, length, shift);
		}

		public ENVL(Indicator indicator, int length, int shift)
		{
			this.indicator = new FreeQuant.Indicators.ENVL(indicator.indicator, length, shift);
		}

		public ENVL(BarSeries series, int length, int shift, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.ENVL(series.series, length, shift, EnumConverter.Convert(option));
		}

		public ENVL(Indicator indicator, int length, int shift, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.ENVL(indicator.indicator, length, shift, EnumConverter.Convert(option));
		}

		public ENVL(BarSeries series, int length, int shift, Color color)
		{
			this.indicator = new FreeQuant.Indicators.ENVL(series.series, length, shift, color);
		}

		public ENVL(Indicator indicator, int length, int shift, Color color)
		{
			this.indicator = new FreeQuant.Indicators.ENVL(indicator.indicator, length, shift, color);
		}

		public ENVL(BarSeries series, int length, int shift, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.ENVL(series.series, length, shift, EnumConverter.Convert(option), color);
		}

		public ENVL(Indicator indicator, int length, int shift, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.ENVL(indicator.indicator, length, shift, EnumConverter.Convert(option), color);
		}
	}
}

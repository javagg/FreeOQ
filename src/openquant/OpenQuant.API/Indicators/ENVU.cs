using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class ENVU : Indicator
	{
		[Description("Length")]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.ENVU).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.ENVU).Length = value;
			}
		}

		[Description("Shift")]
		[Category("Parameters")]
		public double Shift
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.ENVU).Shift;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.ENVU).Shift = value;
			}
		}

		private ENVU()
		{
			this.indicator = new FreeQuant.Indicators.ENVU();
		}

		public ENVU(BarSeries series, int length, int shift)
		{
			this.indicator = new FreeQuant.Indicators.ENVU(series.series, length, shift);
		}

		public ENVU(Indicator indicator, int length, int shift)
		{
			this.indicator = new FreeQuant.Indicators.ENVU(indicator.indicator, length, shift);
		}

		public ENVU(BarSeries series, int length, int shift, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.ENVU(series.series, length, shift, EnumConverter.Convert(option));
		}

		public ENVU(Indicator indicator, int length, int shift, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.ENVU(indicator.indicator, length, shift, EnumConverter.Convert(option));
		}

		public ENVU(BarSeries series, int length, int shift, Color color)
		{
			this.indicator = new FreeQuant.Indicators.ENVU(series.series, length, shift, color);
		}

		public ENVU(Indicator indicator, int length, int shift, Color color)
		{
			this.indicator = new FreeQuant.Indicators.ENVU(indicator.indicator, length, shift, color);
		}

		public ENVU(BarSeries series, int length, int shift, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.ENVU(series.series, length, shift, EnumConverter.Convert(option), color);
		}

		public ENVU(Indicator indicator, int length, int shift, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.ENVU(indicator.indicator, length, shift, EnumConverter.Convert(option), color);
		}
	}
}

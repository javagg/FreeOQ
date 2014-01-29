using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class HV : Indicator
	{
		[Description("Length")]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.HV).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.HV).Length = value;
			}
		}

		[Description("Span")]
		[Category("Parameters")]
		public double Span
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.HV).Span;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.HV).Span = value;
			}
		}

		private HV()
		{
			this.indicator = new FreeQuant.Indicators.HV();
		}

		public HV(BarSeries series, int length, int span)
		{
			this.indicator = new FreeQuant.Indicators.HV(series.series, length, span);
		}

		public HV(Indicator indicator, int length, int span)
		{
			this.indicator = new FreeQuant.Indicators.HV(indicator.indicator, length, span);
		}

		public HV(BarSeries series, int length, int span, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.HV(series.series, length, span, EnumConverter.Convert(option));
		}

		public HV(Indicator indicator, int length, int span, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.HV(indicator.indicator, length, span, EnumConverter.Convert(option));
		}

		public HV(BarSeries series, int length, int span, Color color)
		{
			this.indicator = new FreeQuant.Indicators.HV(series.series, length, span, color);
		}

		public HV(Indicator indicator, int length, int span, Color color)
		{
			this.indicator = new FreeQuant.Indicators.HV(indicator.indicator, length, span, color);
		}

		public HV(BarSeries series, int length, int span, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.HV(series.series, length, span, EnumConverter.Convert(option), color);
		}

		public HV(Indicator indicator, int length, int span, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.HV(indicator.indicator, length, span, EnumConverter.Convert(option), color);
		}
	}
}

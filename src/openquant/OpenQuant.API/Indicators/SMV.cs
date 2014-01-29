using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;

namespace OpenQuant.API.Indicators
{
	public class SMV : Indicator
	{
		[Description("Length")]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.SMV).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.SMV).Length = value;
			}
		}

		private SMV()
		{
			this.indicator = new FreeQuant.Indicators.SMV();
		}

		public SMV(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.SMV(series.series, length);
		}

		public SMV(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.SMV(indicator.indicator, length);
		}

		public SMV(BarSeries series, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.SMV(series.series, length, EnumConverter.Convert(option));
		}

		public SMV(Indicator indicator, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.SMV(indicator.indicator, length, EnumConverter.Convert(option));
		}
	}
}

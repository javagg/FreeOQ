using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class CMO : Indicator
	{
		[Category("Parameters")]
		[Description("Length")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.CMO).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.CMO).Length = value;
			}
		}

		private CMO()
		{
			this.indicator = new FreeQuant.Indicators.CMO();
		}

		public CMO(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.CMO(series.series, length);
		}

		public CMO(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.CMO(indicator.indicator, length);
		}

		public CMO(BarSeries series, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.CMO(series.series, length, EnumConverter.Convert(option));
		}

		public CMO(Indicator indicator, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.CMO(indicator.indicator, length, EnumConverter.Convert(option));
		}

		public CMO(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.CMO(series.series, length, color);
		}

		public CMO(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.CMO(indicator.indicator, length, color);
		}

		public CMO(BarSeries series, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.CMO(series.series, length, EnumConverter.Convert(option), color);
		}

		public CMO(Indicator indicator, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.CMO(indicator.indicator, length, EnumConverter.Convert(option), color);
		}
	}
}

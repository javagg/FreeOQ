using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class VHF : Indicator
	{
		[Description("Length")]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.VHF).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.VHF).Length = value;
			}
		}

		private VHF()
		{
			this.indicator = new FreeQuant.Indicators.VHF();
		}

		public VHF(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.VHF(series.series, length);
		}

		public VHF(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.VHF(indicator.indicator, length);
		}

		public VHF(BarSeries series, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.VHF(series.series, length, EnumConverter.Convert(option));
		}

		public VHF(Indicator indicator, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.VHF(indicator.indicator, length, EnumConverter.Convert(option));
		}

		public VHF(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.VHF(series.series, length, color);
		}

		public VHF(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.VHF(indicator.indicator, length, color);
		}

		public VHF(BarSeries series, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.VHF(series.series, length, EnumConverter.Convert(option), color);
		}

		public VHF(Indicator indicator, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.VHF(indicator.indicator, length, EnumConverter.Convert(option), color);
		}
	}
}

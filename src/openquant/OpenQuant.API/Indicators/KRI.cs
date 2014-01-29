using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class KRI : Indicator
	{
		[Description("Length")]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.KRI).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.KRI).Length = value;
			}
		}

		private KRI()
		{
			this.indicator = new FreeQuant.Indicators.KRI();
		}

		public KRI(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.KRI(series.series, length);
		}

		public KRI(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.KRI(indicator.indicator, length);
		}

		public KRI(BarSeries series, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.KRI(series.series, length, EnumConverter.Convert(option));
		}

		public KRI(Indicator indicator, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.KRI(indicator.indicator, length, EnumConverter.Convert(option));
		}

		public KRI(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.KRI(series.series, length, color);
		}

		public KRI(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.KRI(indicator.indicator, length, color);
		}

		public KRI(BarSeries series, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.KRI(series.series, length, EnumConverter.Convert(option), color);
		}

		public KRI(Indicator indicator, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.KRI(indicator.indicator, length, EnumConverter.Convert(option), color);
		}
	}
}

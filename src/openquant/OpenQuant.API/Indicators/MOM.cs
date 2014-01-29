using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class MOM : Indicator
	{
		[Description("Length")]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.MOM).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.MOM).Length = value;
			}
		}

		private MOM()
		{
			this.indicator = new FreeQuant.Indicators.MOM();
		}

		public MOM(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.MOM(series.series, length);
		}

		public MOM(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.MOM(indicator.indicator, length);
		}

		public MOM(TimeSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.MOM(series.series, length);
		}

		public MOM(BarSeries series, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.MOM(series.series, length, EnumConverter.Convert(option));
		}

		public MOM(Indicator indicator, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.MOM(indicator.indicator, length, EnumConverter.Convert(option));
		}

		public MOM(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.MOM(series.series, length, color);
		}

		public MOM(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.MOM(indicator.indicator, length, color);
		}

		public MOM(TimeSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.MOM(series.series, length, color);
		}

		public MOM(BarSeries series, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.MOM(series.series, length, EnumConverter.Convert(option), color);
		}
	}
}

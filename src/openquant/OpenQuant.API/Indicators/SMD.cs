using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class SMD : Indicator
	{
		[Description("Length")]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.SMD).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.SMD).Length = value;
			}
		}

		private SMD()
		{
			this.indicator = new FreeQuant.Indicators.SMD();
		}

		public SMD(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.SMD(series.series, length);
		}

		public SMD(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.SMD(indicator.indicator, length);
		}

		public SMD(BarSeries series, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.SMD(series.series, length, EnumConverter.Convert(option));
		}

		public SMD(Indicator indicator, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.SMD(indicator.indicator, length, EnumConverter.Convert(option));
		}

		public SMD(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.SMD(series.series, length, color);
		}

		public SMD(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.SMD(indicator.indicator, length, color);
		}

		public SMD(BarSeries series, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.SMD(series.series, length, EnumConverter.Convert(option), color);
		}

		public SMD(Indicator indicator, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.SMD(indicator.indicator, length, EnumConverter.Convert(option), color);
		}

		public SMD(TimeSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.SMD(series.series, length);
		}

		public SMD(TimeSeries series, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.SMD(series.series, length, EnumConverter.Convert(option));
		}

		public SMD(TimeSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.SMD(series.series, length, color);
		}

		public SMD(TimeSeries series, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.SMD(series.series, length, EnumConverter.Convert(option), color);
		}
	}
}

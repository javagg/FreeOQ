using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class DPO : Indicator
	{
		[Category("Parameters")]
		[Description("Length")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.DPO).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.DPO).Length = value;
			}
		}

		private DPO()
		{
			this.indicator = new FreeQuant.Indicators.DPO();
		}

		public DPO(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.DPO(series.series, length);
		}

		public DPO(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.DPO(indicator.indicator, length);
		}

		public DPO(TimeSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.DPO(series.series, length);
		}

		public DPO(BarSeries series, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.DPO(series.series, length, EnumConverter.Convert(option));
		}

		public DPO(Indicator indicator, int length, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.DPO(indicator.indicator, length, EnumConverter.Convert(option));
		}

		public DPO(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.DPO(series.series, length, color);
		}

		public DPO(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.DPO(indicator.indicator, length, color);
		}

		public DPO(TimeSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.DPO(series.series, length, color);
		}

		public DPO(BarSeries series, int length, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.DPO(series.series, length, EnumConverter.Convert(option), color);
		}
	}
}

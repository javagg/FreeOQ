using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class OSC : Indicator
	{
		[Category("Parameters")]
		[Description("Length1")]
		public int Length1
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.OSC).Length1;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.OSC).Length1 = value;
			}
		}

		[Category("Parameters")]
		[Description("Length2")]
		public int Length2
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.OSC).Length2;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.OSC).Length2 = value;
			}
		}

		private OSC()
		{
			this.indicator = new FreeQuant.Indicators.OSC();
		}

		public OSC(BarSeries series, int length1, int length2)
		{
			this.indicator = new FreeQuant.Indicators.OSC(series.series, length1, length2);
		}

		public OSC(Indicator indicator, int length1, int length2)
		{
			this.indicator = new FreeQuant.Indicators.OSC(indicator.indicator, length1, length2);
		}

		public OSC(BarSeries series, int length1, int length2, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.OSC(series.series, length1, length2, EnumConverter.Convert(option));
		}

		public OSC(Indicator indicator, int length1, int length2, BarData option)
		{
			this.indicator = new FreeQuant.Indicators.OSC(indicator.indicator, length1, length2, EnumConverter.Convert(option));
		}

		public OSC(BarSeries series, int length1, int length2, Color color)
		{
			this.indicator = new FreeQuant.Indicators.OSC(series.series, length1, length2, color);
		}

		public OSC(Indicator indicator, int length1, int length2, Color color)
		{
			this.indicator = new FreeQuant.Indicators.OSC(indicator.indicator, length1, length2, color);
		}

		public OSC(BarSeries series, int length1, int length2, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.OSC(series.series, length1, length2, EnumConverter.Convert(option), color);
		}

		public OSC(Indicator indicator, int length1, int length2, BarData option, Color color)
		{
			this.indicator = new FreeQuant.Indicators.OSC(indicator.indicator, length1, length2, EnumConverter.Convert(option), color);
		}
	}
}

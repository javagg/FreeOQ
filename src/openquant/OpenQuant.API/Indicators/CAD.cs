using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class CAD : Indicator
	{
		[Category("Parameters")]
		[Description("Length1")]
		public int Length1
		{
			get
			{
				return (this.indicator as CAD).get_Length1();
			}
			set
			{
				(this.indicator as CAD).set_Length1(value);
			}
		}

		[Category("Parameters")]
		[Description("Length2")]
		public int Length2
		{
			get
			{
				return (this.indicator as CAD).get_Length2();
			}
			set
			{
				(this.indicator as CAD).set_Length2(value);
			}
		}

		private CAD()
		{
			this.indicator = (Indicator)new CAD();
		}

		public CAD(OpenQuant.API.BarSeries series, int length1, int lenght2)
		{
			this.indicator = (Indicator)new CAD((SmartQuant.Series.TimeSeries)series.series, length1, lenght2);
		}

		public CAD(Indicator indicator, int length1, int lenght2)
		{
			this.indicator = (Indicator)new CAD((SmartQuant.Series.TimeSeries)indicator.indicator, length1, lenght2);
		}

		public CAD(OpenQuant.API.BarSeries series, int length1, int lenght2, Color color)
		{
			this.indicator = (Indicator)new CAD((SmartQuant.Series.TimeSeries)series.series, length1, lenght2, color);
		}

		public CAD(Indicator indicator, int length1, int lenght2, Color color)
		{
			this.indicator = (Indicator)new CAD((SmartQuant.Series.TimeSeries)indicator.indicator, length1, lenght2, color);
		}
	}
}

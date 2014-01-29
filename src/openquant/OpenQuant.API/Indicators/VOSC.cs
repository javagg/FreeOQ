using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class VOSC : Indicator
	{
		[Category("Parameters")]
		[Description("Length1")]
		public int Length1
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.VOSC).Length1;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.VOSC).Length1 = value;
			}
		}

		[Description("Length2")]
		[Category("Parameters")]
		public int Length2
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.VOSC).Length2;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.VOSC).Length2 = value;
			}
		}

		private VOSC()
		{
			this.indicator = new FreeQuant.Indicators.VOSC();
		}

		public VOSC(BarSeries series, int length1, int length2)
		{
			this.indicator = new FreeQuant.Indicators.VOSC(series.series, length1, length2);
		}

		public VOSC(Indicator indicator, int length1, int length2)
		{
			this.indicator = new FreeQuant.Indicators.VOSC(indicator.indicator, length1, length2);
		}

		public VOSC(BarSeries series, int length1, int length2, Color color)
		{
			this.indicator = new FreeQuant.Indicators.VOSC(series.series, length1, length2, color);
		}

		public VOSC(Indicator indicator, int length1, int length2, Color color)
		{
			this.indicator = new FreeQuant.Indicators.VOSC(indicator.indicator, length1, length2, color);
		}
	}
}

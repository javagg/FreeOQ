using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class MFI : Indicator
	{
		[Description("Length")]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.MFI).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.MFI).Length = value;
			}
		}

		private MFI()
		{
			this.indicator = new FreeQuant.Indicators.MFI();
		}

		public MFI(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.MFI(series.series, length);
		}

		public MFI(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.MFI(indicator.indicator, length);
		}

		public MFI(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.MFI(series.series, length, color);
		}

		public MFI(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.MFI(indicator.indicator, length, color);
		}
	}
}

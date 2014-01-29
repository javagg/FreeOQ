using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class UltOsc : Indicator
	{
		[Category("Parameters")]
		[Description("N1")]
		public int N1
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.UltOsc).N1;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.UltOsc).N1 = value;
			}
		}

		[Category("Parameters")]
		[Description("N2")]
		public int N2
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.UltOsc).N2;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.UltOsc).N2 = value;
			}
		}

		[Description("N3")]
		[Category("Parameters")]
		public int N3
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.UltOsc).N3;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.UltOsc).N3 = value;
			}
		}

		private UltOsc()
		{
			this.indicator = new FreeQuant.Indicators.UltOsc();
		}

		public UltOsc(BarSeries series, int n1, int n2, int n3)
		{
			this.indicator = new FreeQuant.Indicators.UltOsc(series.series, n1, n2, n3);
		}

		public UltOsc(Indicator indicator, int n1, int n2, int n3)
		{
			this.indicator = new FreeQuant.Indicators.UltOsc(indicator.indicator, n1, n2, n3);
		}

		public UltOsc(BarSeries series, int n1, int n2, int n3, Color color)
		{
			this.indicator = new FreeQuant.Indicators.UltOsc(series.series, n1, n2, n3, color);
		}

		public UltOsc(Indicator indicator, int n1, int n2, int n3, Color color)
		{
			this.indicator = new FreeQuant.Indicators.UltOsc(indicator.indicator, n1, n2, n3, color);
		}
	}
}

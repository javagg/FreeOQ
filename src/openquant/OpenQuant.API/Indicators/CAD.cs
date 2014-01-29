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
				return (this.indicator as FreeQuant.Indicators.CAD).Length1;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.CAD).Length1 = value;
			}
		}

		[Category("Parameters")]
		[Description("Length2")]
		public int Length2
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.CAD).Length2;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.CAD).Length2 = value;
			}
		}

		private CAD()
		{
			this.indicator = new FreeQuant.Indicators.CAD();
		}

		public CAD(BarSeries series, int length1, int lenght2)
		{
			this.indicator = new FreeQuant.Indicators.CAD(series.series, length1, lenght2);
		}

		public CAD(Indicator indicator, int length1, int lenght2)
		{
			this.indicator = new FreeQuant.Indicators.CAD(indicator.indicator, length1, lenght2);
		}

		public CAD(BarSeries series, int length1, int lenght2, Color color)
		{
			this.indicator = new FreeQuant.Indicators.CAD(series.series, length1, lenght2, color);
		}

		public CAD(Indicator indicator, int length1, int lenght2, Color color)
		{
			this.indicator = new FreeQuant.Indicators.CAD(indicator.indicator, length1, lenght2, color);
		}
	}
}

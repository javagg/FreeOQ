using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class EMV : Indicator
	{
		private EMV()
		{
			this.indicator = new FreeQuant.Indicators.EMV();
		}

		public EMV(BarSeries series)
		{
			this.indicator = new FreeQuant.Indicators.EMV(series.series);
		}

		public EMV(Indicator indicator)
		{
			this.indicator = new FreeQuant.Indicators.EMV(indicator.indicator);
		}

		public EMV(BarSeries series, Color color)
		{
			this.indicator = new FreeQuant.Indicators.EMV(series.series, color);
		}

		public EMV(Indicator indicator, Color color)
		{
			this.indicator = new FreeQuant.Indicators.EMV(indicator.indicator, color);
		}
	}
}

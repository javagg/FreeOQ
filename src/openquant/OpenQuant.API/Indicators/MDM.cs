using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class MDM : Indicator
	{
		private MDM()
		{
			this.indicator = new FreeQuant.Indicators.MDM();
		}

		public MDM(BarSeries series)
		{
			this.indicator = new FreeQuant.Indicators.MDM(series.series);
		}

		public MDM(Indicator indicator)
		{
			this.indicator = new FreeQuant.Indicators.MDM(indicator.indicator);
		}

		public MDM(BarSeries series, Color color)
		{
			this.indicator = new FreeQuant.Indicators.MDM(series.series, color);
		}

		public MDM(Indicator indicator, Color color)
		{
			this.indicator = new FreeQuant.Indicators.MDM(indicator.indicator, color);
		}
	}
}

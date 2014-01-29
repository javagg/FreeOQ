using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class PVI : Indicator
	{
		private PVI()
		{
			this.indicator = new FreeQuant.Indicators.PVI();
		}

		public PVI(BarSeries series)
		{
			this.indicator = new FreeQuant.Indicators.PVI(series.series);
		}

		public PVI(Indicator indicator)
		{
			this.indicator = new FreeQuant.Indicators.PVI(indicator.indicator);
		}

		public PVI(BarSeries series, Color color)
		{
			this.indicator = new FreeQuant.Indicators.PVI(series.series, color);
		}

		public PVI(Indicator indicator, Color color)
		{
			this.indicator = new FreeQuant.Indicators.PVI(indicator.indicator, color);
		}
	}
}

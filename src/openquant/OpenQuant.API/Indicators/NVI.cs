using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class NVI : Indicator
	{
		private NVI()
		{
			this.indicator = new FreeQuant.IndicatorsNVI();
		}

		public NVI(BarSeries series)
		{
			this.indicator = new FreeQuant.IndicatorsNVI(series.series);
		}

		public NVI(Indicator indicator)
		{
			this.indicator = new FreeQuant.IndicatorsNVI(indicator.indicator);
		}

		public NVI(BarSeries series, Color color)
		{
			this.indicator = new FreeQuant.IndicatorsNVI(series.series, color);
		}

		public NVI(Indicator indicator, Color color)
		{
			this.indicator = new FreeQuant.IndicatorsNVI(indicator.indicator, color);
		}
	}
}

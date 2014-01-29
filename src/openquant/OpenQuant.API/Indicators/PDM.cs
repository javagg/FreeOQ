using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class PDM : Indicator
	{
		private PDM()
		{
			this.indicator = new FreeQuant.Indicators.PDM();
		}

		public PDM(BarSeries series)
		{
			this.indicator = new FreeQuant.Indicators.PDM(series.series);
		}

		public PDM(Indicator indicator)
		{
			this.indicator = new FreeQuant.Indicators.PDM(indicator.indicator);
		}

		public PDM(BarSeries series, Color color)
		{
			this.indicator = new FreeQuant.Indicators.PDM(series.series, color);
		}

		public PDM(Indicator indicator, Color color)
		{
			this.indicator = new FreeQuant.Indicators.PDM(indicator.indicator, color);
		}
	}
}

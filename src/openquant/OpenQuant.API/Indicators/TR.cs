using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class TR : Indicator
	{
		private TR()
		{
			this.indicator = new FreeQuant.Indicators.TR();
		}

		public TR(BarSeries series)
		{
			this.indicator = new FreeQuant.Indicators.TR(series.series);
		}

		public TR(Indicator indicator)
		{
			this.indicator = new FreeQuant.Indicators.TR(indicator.indicator);
		}

		public TR(BarSeries series, Color color)
		{
			this.indicator = new FreeQuant.Indicators.TR(series.series, color);
		}

		public TR(Indicator indicator, Color color)
		{
			this.indicator = new FreeQuant.Indicators.TR(indicator.indicator, color);
		}
	}
}

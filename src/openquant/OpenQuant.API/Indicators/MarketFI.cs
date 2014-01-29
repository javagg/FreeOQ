using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class MarketFI : Indicator
	{
		private MarketFI()
		{
			this.indicator = new FreeQuant.Indicators.MarketFI();
		}

		public MarketFI(BarSeries series)
		{
			this.indicator = new FreeQuant.Indicators.MarketFI(series.series);
		}

		public MarketFI(Indicator indicator)
		{
			this.indicator = new FreeQuant.Indicators.MarketFI(indicator.indicator);
		}

		public MarketFI(BarSeries series, Color color)
		{
			this.indicator = new FreeQuant.Indicators.MarketFI(series.series, color);
		}

		public MarketFI(Indicator indicator, Color color)
		{
			this.indicator = new FreeQuant.Indicators.MarketFI(indicator.indicator, color);
		}
	}
}

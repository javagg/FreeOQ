using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class TL : Indicator
	{
		private TL()
		{
			this.indicator = new FreeQuant.Indicators.TL();
		}

		public TL(BarSeries series)
		{
			this.indicator = new FreeQuant.Indicators.TL(series.series);
		}

		public TL(Indicator indicator)
		{
			this.indicator = new FreeQuant.Indicators.TL(indicator.indicator);
		}

		public TL(BarSeries series, Color color)
		{
			this.indicator = new FreeQuant.Indicators.TL(series.series, color);
		}

		public TL(Indicator indicator, Color color)
		{
			this.indicator = new FreeQuant.Indicators.TL(indicator.indicator, color);
		}
	}
}

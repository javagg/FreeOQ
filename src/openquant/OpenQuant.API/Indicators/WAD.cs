using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class WAD : Indicator
	{
		private WAD()
		{
			this.indicator = new FreeQuant.Indicators.WAD();
		}

		public WAD(BarSeries series)
		{
			this.indicator = new FreeQuant.Indicators.WAD(series.series);
		}

		public WAD(Indicator indicator)
		{
			this.indicator = new FreeQuant.Indicators.WAD(indicator.indicator);
		}

		public WAD(BarSeries series, Color color)
		{
			this.indicator = new FreeQuant.Indicators.WAD(series.series, color);
		}

		public WAD(Indicator indicator, Color color)
		{
			this.indicator = new FreeQuant.Indicators.WAD(indicator.indicator, color);
		}
	}
}

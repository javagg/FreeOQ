using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class PVT : Indicator
	{
		private PVT()
		{
			this.indicator = new FreeQuant.Indicators.PVT();
		}

		public PVT(BarSeries series)
		{
			this.indicator = new FreeQuant.Indicators.PVT(series.series);
		}

		public PVT(Indicator indicator)
		{
			this.indicator = new FreeQuant.Indicators.PVT(indicator.indicator);
		}

		public PVT(BarSeries series, Color color)
		{
			this.indicator = new FreeQuant.Indicators.PVT(series.series, color);
		}

		public PVT(Indicator indicator, Color color)
		{
			this.indicator = new FreeQuant.Indicators.PVT(indicator.indicator, color);
		}
	}
}

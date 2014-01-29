using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class TH : Indicator
	{
		private TH()
		{
			this.indicator = new FreeQuant.Indicators.TH();
		}

		public TH(BarSeries series)
		{
			this.indicator = new FreeQuant.Indicators.TH(series.series);
		}

		public TH(Indicator indicator)
		{
			this.indicator = new FreeQuant.Indicators.TH(indicator.indicator);
		}

		public TH(BarSeries series, Color color)
		{
			this.indicator = new FreeQuant.Indicators.TH(series.series, color);
		}

		public TH(Indicator indicator, Color color)
		{
			this.indicator = new FreeQuant.Indicators.TH(indicator.indicator, color);
		}
	}
}

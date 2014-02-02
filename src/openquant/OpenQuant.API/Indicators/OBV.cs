using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class OBV : Indicator
	{
		private OBV()
		{
			this.indicator = new FreeQuant.Indicators.OBV();
		}

		public OBV(BarSeries series)
		{
			this.indicator = new FreeQuant.Indicators.OBV(series.series);
		}

		public OBV(Indicator indicator)
		{
			this.indicator = new FreeQuant.Indicators.OBV(indicator.indicator);
		}

		public OBV(BarSeries series, Color color)
		{
			this.indicator = new FreeQuant.Indicators.OBV(series.series, color);
		}

		public OBV(Indicator indicator, Color color)
		{
			this.indicator = new FreeQuant.Indicators.OBV(indicator.indicator, color);
		}
	}
}

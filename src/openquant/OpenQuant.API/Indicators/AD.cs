using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class AD : Indicator
	{
		private AD()
		{
			this.indicator = new FreeQuant.Indicators.AD();
		}

		public AD(BarSeries series)
		{
			this.indicator = new FreeQuant.Indicators.AD(series.series);
		}

		public AD(Indicator indicator)
		{
			this.indicator = new FreeQuant.Indicators.AD(indicator.indicator);
		}

		public AD(TimeSeries series)
		{
			this.indicator = new FreeQuant.Indicators.AD(series.series);
		}

		public AD(BarSeries series, Color color)
		{
			this.indicator = new FreeQuant.Indicators.AD(series.series, color);
		}

		public AD(Indicator indicator, Color color)
		{
			this.indicator = new FreeQuant.Indicators.AD(indicator.indicator, color);
		}

		public AD(TimeSeries series, Color color)
		{
			this.indicator = new FreeQuant.Indicators.AD(series.series, color);
		}
	}
}

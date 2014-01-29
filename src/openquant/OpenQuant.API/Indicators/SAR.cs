using OpenQuant.API;
using FreeQuant.Indicators;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class SAR : Indicator
	{
		public double InitialAcc
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.SAR).InitialAcc;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.SAR).InitialAcc = value;
			}
		}

		public double UpperBound
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.SAR).UpperBound;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.SAR).UpperBound = value;
			}
		}

		public double Step
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.SAR).Step;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.SAR).Step = value;
			}
		}

		private SAR()
		{
			this.indicator = new FreeQuant.Indicators.SAR();
		}

		public SAR(BarSeries series, double upperBound, double step, double initialAcc)
		{
			this.indicator = new FreeQuant.Indicators.SAR(series.series, upperBound, step, initialAcc);
		}

		public SAR(Indicator indicator, double upperBound, double step, double initialAcc)
		{
			this.indicator = new FreeQuant.Indicators.SAR(indicator.indicator, upperBound, step, initialAcc);
		}

		public SAR(BarSeries series, double upperBound, double step, double initialAcc, Color color)
		{
			this.indicator = new FreeQuant.Indicators.SAR(series.series, upperBound, step, initialAcc, color);
		}

		public SAR(Indicator indicator, double upperBound, double step, double initialAcc, Color color)
		{
			this.indicator = new FreeQuant.Indicators.SAR(indicator.indicator, upperBound, step, initialAcc, color);
		}
	}
}

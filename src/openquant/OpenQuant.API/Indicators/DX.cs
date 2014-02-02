using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
	public class DX : Indicator
	{
		[Category("Parameters")]
		[Description("Length")]
		public int Length
		{
			get
			{
				return (this.indicator as FreeQuant.Indicators.DX).Length;
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.DX).Length = value;
			}
		}

		public IndicatorStyle Style
		{
			get
			{
				return EnumConverter.Convert((this.indicator as FreeQuant.Indicators.DX).Style);
			}
			set
			{
				(this.indicator as FreeQuant.Indicators.DX).Style = EnumConverter.Convert(value);
			}
		}

		private DX()
		{
			this.indicator = new FreeQuant.Indicators.DX();
		}

		public DX(BarSeries series, int length)
		{
			this.indicator = new FreeQuant.Indicators.DX(series.series, length);
		}

		public DX(Indicator indicator, int length)
		{
			this.indicator = new FreeQuant.Indicators.DX(indicator.indicator, length);
		}

		public DX(BarSeries series, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.DX(series.series, length, color);
		}

		public DX(Indicator indicator, int length, Color color)
		{
			this.indicator = new FreeQuant.Indicators.DX(indicator.indicator, length, color);
		}
	}
}

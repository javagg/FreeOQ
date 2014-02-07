using FreeQuant.Data;
using FreeQuant.Series;
using System.Text;

namespace FreeQuant.FinChart
{
	public abstract class BSView : SeriesView
	{
		public BSView(Pad pad) : base(pad)
		{
		}

		public override PadRange GetPadRangeY(Pad pad)
		{
			double max = this.MainSeries.GetMax(this.firstDate, this.lastDate);
			double min = this.MainSeries.GetMin(this.firstDate, this.lastDate);
			if (max >= min)
			{
				double num = max / 10.0;
				max -= num;
				min += num;
			}
			return new PadRange(max, min);
		}

		public override Distance Distance(int x, double y)
		{
			Distance distance = new Distance();
			Bar bar = this.MainSeries[this.pad.GetDateTime(x)] as Bar;
			distance.DX = 0.0;
			if (bar.Low <= y && y <= bar.High)
			{
				distance.DY = 0.0;
			}
			if (distance.DX == double.MaxValue || distance.DY == double.MaxValue)
				return null;

			StringBuilder sb = new StringBuilder();
			sb.AppendFormat(this.toolTipFormat, new object[]
			{
				this.MainSeries.Name,
				this.MainSeries.Title,
				bar.DateTime.ToString((this.MainSeries as BarSeries).ToolTipDateTimeFormat),
				bar.High,
				bar.Low,
				bar.Open,
				bar.Close,
				bar.Volume
			});			
			distance.ToolTipText = sb.ToString();
			return distance;
		}
	}
}

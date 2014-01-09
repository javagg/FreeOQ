using System;
using System.Windows.Forms;

namespace OpenQuant.API
{
	public class Canvas
	{
		private FreeQuant.Charting.Canvas canvas;

		public Canvas(string name)
		{
			this.canvas = new FreeQuant.Charting.Canvas(name);
		}

		public void Clear()
		{
			this.canvas.Clear();
		}

		public void Divide(int x, int y)
		{
			this.canvas.Divide(x, y);
		}

		public void Add(TimeSeries series)
		{
			series.series.Draw();
		}

		public void Add(BarSeries series)
		{
			series.series.Draw();
		}

		public void Add(Indicator indicator)
		{
			((FreeQuant.Series.TimeSeries)indicator.indicator).Draw();
		}

		public void Add(TradeSeries tradeSeries)
		{
			tradeSeries.series.Draw();
		}

		public void Add(QuoteSeries quoteSeries)
		{
			quoteSeries.series.Draw();
		}

		public void Add(Order order)
		{
			new OrderMarker(order.order).Draw();
		}

		public void Add(Transaction transaction)
		{
			transaction.transaction.Draw();
		}

		public void Run()
		{
			Application.Run((Form)this.canvas);
		}

		public void Cd(int pad)
		{
			this.canvas.cd(pad);
		}

		public void Update()
		{
			this.canvas.UpdateChart();
		}

		public void SetRangeX(DateTime dateTime1, DateTime dateTime2)
		{
			this.canvas.Chart.SetRangeX(dateTime1, dateTime2);
		}

		public void SetRangeX(double minX, double maxX)
		{
			this.canvas.Chart.SetRangeX(minX, maxX);
		}

		public void SetRangeY(double minY, double maxY)
		{
			this.canvas.Chart.SetRangeY(minY, maxY);
		}
	}
}

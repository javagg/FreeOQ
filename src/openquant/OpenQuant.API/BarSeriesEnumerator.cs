using System;
using System.Collections;

namespace OpenQuant.API
{
	class BarSeriesEnumerator : IEnumerator
	{
		private FreeQuant.Series.BarSeries series;
		private IEnumerator enumerator;

		public object Current
		{
			get
			{
				return (object)new Bar(this.enumerator.Current as FreeQuant.Data.Bar);
			}
		}

		internal BarSeriesEnumerator(FreeQuant.Series.BarSeries series)
		{
			this.series = series;
			this.enumerator = series.GetEnumerator();
		}

		public bool MoveNext()
		{
			return this.enumerator.MoveNext();
		}

		public void Reset()
		{
			this.enumerator.Reset();
		}

		public double CloseD(DateTime dateTime)
		{
			return this.series.CloseD(dateTime);
		}

		public double CloseW(DateTime dateTime)
		{
			return this.series.CloseW(dateTime);
		}

		public double CloseM(DateTime dateTime)
		{
			return this.series.CloseM(dateTime);
		}

		public double CloseY(DateTime dateTime)
		{
			return this.series.CloseY(dateTime);
		}

		public double CloseD(int index, int daysAgo)
		{
			return this.series.CloseD(index, daysAgo);
		}

		public double CloseW(int index, int weeksAgo)
		{
			return this.series.CloseW(index, weeksAgo);
		}

		public double CloseM(int index, int monthsAgo)
		{
			return this.series.CloseM(index, monthsAgo);
		}

		public double CloseY(int index, int yearsAgo)
		{
			return this.series.CloseY(index, yearsAgo);
		}

		public double CloseD(DateTime dateTime, int daysAgo)
		{
			return this.series.CloseD(dateTime, daysAgo);
		}

		public double CloseW(DateTime dateTime, int weeksAgo)
		{
			return this.series.CloseW(dateTime, weeksAgo);
		}

		public double CloseM(DateTime dateTime, int monthsAgo)
		{
			return this.series.CloseM(dateTime, monthsAgo);
		}

		public double CloseY(DateTime dateTime, int yearsAgo)
		{
			return this.series.CloseY(dateTime, yearsAgo);
		}

		public double CloseD(Bar bar, int daysAgo)
		{
			return this.series.CloseD(bar.bar, daysAgo);
		}

		public double CloseW(Bar bar, int weeksAgo)
		{
			return this.series.CloseW(bar.bar, weeksAgo);
		}

		public double CloseM(Bar bar, int monthsAgo)
		{
			return this.series.CloseM(bar.bar, monthsAgo);
		}

		public double CloseY(Bar bar, int yearsAgo)
		{
			return this.series.CloseY(bar.bar, yearsAgo);
		}

		public double CloseD(Bar bar)
		{
			return this.series.CloseD(bar.bar);
		}

		public double CloseW(Bar bar)
		{
			return this.series.CloseW(bar.bar);
		}

		public double CloseM(Bar bar)
		{
			return this.series.CloseM(bar.bar);
		}

		public double CloseY(Bar bar)
		{
			return this.series.CloseY(bar.bar);
		}

		public double OpenD(DateTime dateTime)
		{
			return this.series.OpenD(dateTime);
		}

		public double OpenW(DateTime dateTime)
		{
			return this.series.OpenW(dateTime);
		}

		public double OpenM(DateTime dateTime)
		{
			return this.series.OpenM(dateTime);
		}

		public double OpenY(DateTime dateTime)
		{
			return this.series.OpenY(dateTime);
		}

		public double OpenD(int index, int daysAgo)
		{
			return this.series.OpenD(index, daysAgo);
		}

		public double OpenW(int index, int weeksAgo)
		{
			return this.series.OpenW(index, weeksAgo);
		}

		public double OpenM(int index, int monthsAgo)
		{
			return this.series.OpenM(index, monthsAgo);
		}

		public double OpenY(int index, int yearsAgo)
		{
			return this.series.OpenY(index, yearsAgo);
		}

		public double OpenD(DateTime dateTime, int daysAgo)
		{
			return this.series.OpenD(dateTime, daysAgo);
		}

		public double OpenW(DateTime dateTime, int weeksAgo)
		{
			return this.series.OpenW(dateTime, weeksAgo);
		}

		public double OpenM(DateTime dateTime, int monthsAgo)
		{
			return this.series.OpenM(dateTime, monthsAgo);
		}

		public double OpenY(DateTime dateTime, int yearsAgo)
		{
			return this.series.OpenY(dateTime, yearsAgo);
		}

		public double OpenD(Bar bar, int daysAgo)
		{
			return this.series.OpenD(bar.bar, daysAgo);
		}

		public double OpenW(Bar bar, int weeksAgo)
		{
			return this.series.OpenW(bar.bar, weeksAgo);
		}

		public double OpenM(Bar bar, int monthsAgo)
		{
			return this.series.OpenM(bar.bar, monthsAgo);
		}

		public double OpenY(Bar bar, int yearsAgo)
		{
			return this.series.OpenY(bar.bar, yearsAgo);
		}

		public double OpenD(Bar bar)
		{
			return this.series.OpenD(bar.bar);
		}

		public double OpenW(Bar bar)
		{
			return this.series.OpenW(bar.bar);
		}

		public double OpenM(Bar bar)
		{
			return this.series.OpenM(bar.bar);
		}

		public double OpenY(Bar bar)
		{
			return this.series.OpenY(bar.bar);
		}

		public double HighD(DateTime dateTime)
		{
			return this.series.HighD(dateTime);
		}

		public double HighW(DateTime dateTime)
		{
			return this.series.HighW(dateTime);
		}

		public double HighM(DateTime dateTime)
		{
			return this.series.HighM(dateTime);
		}

		public double HighY(DateTime dateTime)
		{
			return this.series.HighY(dateTime);
		}

		public double HighD(int index, int daysAgo)
		{
			return this.series.HighD(index, daysAgo);
		}

		public double HighW(int index, int weeksAgo)
		{
			return this.series.HighW(index, weeksAgo);
		}

		public double HighM(int index, int monthsAgo)
		{
			return this.series.HighM(index, monthsAgo);
		}

		public double HighY(int index, int yearsAgo)
		{
			return this.series.HighY(index, yearsAgo);
		}

		public double HighD(DateTime dateTime, int daysAgo)
		{
			return this.series.HighD(dateTime, daysAgo);
		}

		public double HighW(DateTime dateTime, int weeksAgo)
		{
			return this.series.HighW(dateTime, weeksAgo);
		}

		public double HighM(DateTime dateTime, int monthsAgo)
		{
			return this.series.HighM(dateTime, monthsAgo);
		}

		public double HighY(DateTime dateTime, int yearsAgo)
		{
			return this.series.HighY(dateTime, yearsAgo);
		}

		public double HighD(Bar bar, int daysAgo)
		{
			return this.series.HighD(bar.bar, daysAgo);
		}

		public double HighW(Bar bar, int weeksAgo)
		{
			return this.series.HighW(bar.bar, weeksAgo);
		}

		public double HighM(Bar bar, int monthsAgo)
		{
			return this.series.HighM(bar.bar, monthsAgo);
		}

		public double HighY(Bar bar, int yearsAgo)
		{
			return this.series.HighY(bar.bar, yearsAgo);
		}

		public double HighD(Bar bar)
		{
			return this.series.HighD(bar.bar);
		}

		public double HighW(Bar bar)
		{
			return this.series.HighW(bar.bar);
		}

		public double HighM(Bar bar)
		{
			return this.series.HighM(bar.bar);
		}

		public double HighY(Bar bar)
		{
			return this.series.HighY(bar.bar);
		}

		public double LowD(DateTime dateTime)
		{
			return this.series.LowD(dateTime);
		}

		public double LowW(DateTime dateTime)
		{
			return this.series.LowW(dateTime);
		}

		public double LowM(DateTime dateTime)
		{
			return this.series.LowM(dateTime);
		}

		public double LowY(DateTime dateTime)
		{
			return this.series.LowY(dateTime);
		}

		public double LowD(int index, int daysAgo)
		{
			return this.series.LowD(index, daysAgo);
		}

		public double LowW(int index, int weeksAgo)
		{
			return this.series.LowW(index, weeksAgo);
		}

		public double LowM(int index, int monthsAgo)
		{
			return this.series.LowM(index, monthsAgo);
		}

		public double LowY(int index, int yearsAgo)
		{
			return this.series.LowY(index, yearsAgo);
		}

		public double LowD(DateTime dateTime, int daysAgo)
		{
			return this.series.LowD(dateTime, daysAgo);
		}

		public double LowW(DateTime dateTime, int weeksAgo)
		{
			return this.series.LowW(dateTime, weeksAgo);
		}

		public double LowM(DateTime dateTime, int monthsAgo)
		{
			return this.series.LowM(dateTime, monthsAgo);
		}

		public double LowY(DateTime dateTime, int yearsAgo)
		{
			return this.series.LowY(dateTime, yearsAgo);
		}

		public double LowD(Bar bar, int daysAgo)
		{
			return this.series.LowD(bar.bar, daysAgo);
		}

		public double LowW(Bar bar, int weeksAgo)
		{
			return this.series.LowW(bar.bar, weeksAgo);
		}

		public double LowM(Bar bar, int monthsAgo)
		{
			return this.series.LowM(bar.bar, monthsAgo);
		}

		public double LowY(Bar bar, int yearsAgo)
		{
			return this.series.LowY(bar.bar, yearsAgo);
		}

		public double LowD(Bar bar)
		{
			return this.series.LowD(bar.bar);
		}

		public double LowW(Bar bar)
		{
			return this.series.LowW(bar.bar);
		}

		public double LowM(Bar bar)
		{
			return this.series.LowM(bar.bar);
		}

		public double LowY(Bar bar)
		{
			return this.series.LowY(bar.bar);
		}
	}
}

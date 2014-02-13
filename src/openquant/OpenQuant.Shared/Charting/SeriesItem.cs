using FreeQuant.Series;

namespace OpenQuant.Shared.Charting
{
	class SeriesItem
	{
		internal DoubleSeries Series { get; private set; }

		internal SeriesItem(DoubleSeries series)
		{
			this.Series = series;
		}

		public override string ToString()
		{
			return this.Series.Name;
		}
	}
}

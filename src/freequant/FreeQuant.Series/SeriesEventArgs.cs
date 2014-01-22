using System;

namespace FreeQuant.Series
{
	public class SeriesEventArgs : EventArgs
	{
		public TimeSeries Series {	get; private set; }
		public SeriesEventArgs(TimeSeries series) : base()
		{
			this.Series = series;
		}
	}
}

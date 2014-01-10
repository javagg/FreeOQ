using System;

namespace FreeQuant.Series
{
	public class SeriesEventArgs : EventArgs
	{
		private TimeSeries timeSeries;

		public TimeSeries Series
		{
			get
			{
				return this.timeSeries; 
			}
		}

		public SeriesEventArgs(TimeSeries series) : base()
		{

			this.timeSeries = series;
		}
	}
}

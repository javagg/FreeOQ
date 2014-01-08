using System;

namespace FreeQuant.File
{
	public class SeriesEventArgs : EventArgs
	{
		private FileSeries series;

		public FileSeries Series
		{
			get
			{
				return this.series; 
			}
		}

		public SeriesEventArgs(FileSeries series)
		{
			this.series = series;
		}
	}
}

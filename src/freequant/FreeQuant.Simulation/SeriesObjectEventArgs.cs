using FreeQuant.Data;
using System;

namespace FreeQuant.Simulation
{
	public class SeriesObjectEventArgs : EventArgs
	{
		public IDataObject Object { get; private set; }
		public IDataSeries Series { get; private set; }

		public SeriesObjectEventArgs(IDataSeries series, IDataObject obj) : base()
		{
			this.Series = series;
			this.Object = obj;
		}
	}
}

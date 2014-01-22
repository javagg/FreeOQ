using System;
using System.Runtime.CompilerServices;
using FreeQuant.Series;

namespace FreeQuant.Instruments
{
	public class BarSeriesEventArgs : EventArgs
	{
		public BarSeries BarSeries { get; private set; }
		public Instrument Instrument { get; private set; }

		public BarSeriesEventArgs(BarSeries barSeries, Instrument instrument) : base()
		{
			this.BarSeries = barSeries;
			this.Instrument = instrument;
		}
	}
}

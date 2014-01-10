using System;
using System.Runtime.CompilerServices;
using FreeQuant.Series;

namespace FreeQuant.Instruments
{
	public class BarSeriesEventArgs : EventArgs
	{
		private BarSeries barSeries;
		private Instrument instrument;

		public BarSeries BarSeries
		{
			get
			{
				return this.barSeries;
			}
		}

		public Instrument Instrument
		{
			get
			{
				return this.instrument; 
			}
		}

		public BarSeriesEventArgs(BarSeries barSeries, Instrument instrument) : base()
		{
			this.barSeries = barSeries;
			this.instrument = instrument;
		}
	}
}

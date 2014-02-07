using System;
using FreeQuant.Data;
using FreeQuant.Instruments;

namespace FreeQuant.Trading
{
	public class EntryEventArgs : EventArgs
	{
		public Instrument Instrument { get; private set; }
		public char Side { get; private set; }
		public Bar Bar { get; private set; }

		public EntryEventArgs(Instrument instrument, char side, Bar bar) : base()
		{
			this.Instrument = instrument;
			this.Side = side;
			this.Bar = bar;
		}
	}
}

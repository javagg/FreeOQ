using System;

namespace FreeQuant.Instruments
{
	public class InstrumentEventArgs : EventArgs
	{
		public Instrument Instrument { get; private set; }

		public InstrumentEventArgs(Instrument instrument) : base()
		{
			this.Instrument = instrument;
		}
	}
}

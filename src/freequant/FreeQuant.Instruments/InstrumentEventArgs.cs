using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
	public class InstrumentEventArgs : EventArgs
	{
		private Instrument instrument;

		public Instrument Instrument
		{
			get
			{
				return this.instrument;
			}
		}

		public InstrumentEventArgs(Instrument instrument) : base()
		{
			this.instrument = instrument;
		}
	}
}

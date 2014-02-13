using FreeQuant.FIX;

namespace OpenQuant.Shared.Diagnostics
{
	class InstrumentCounter : EventCounter
	{
		public IFIXInstrument Instrument { get; private set; }

		public InstrumentCounter(IFIXInstrument instrument)
		{
			this.Instrument = instrument;
		}

		public InstrumentCounter Clone()
		{
			InstrumentCounter instrumentCounter = new InstrumentCounter(this.Instrument);
			this.CopyTo(instrumentCounter);
			return instrumentCounter;
		}
	}
}

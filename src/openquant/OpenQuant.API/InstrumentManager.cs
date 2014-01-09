namespace OpenQuant.API
{
	public static class InstrumentManager
	{
		public static InstrumentList Instruments
		{
			get
			{
				return OpenQuant.Instruments;
			}
		}

		public static void Remove(Instrument instrument)
		{
			OpenQuant.Instruments.Remove(instrument);
			FreeQuant.Instruments.InstrumentManager.Remove(instrument.instrument);
		}

		public static void Remove(string symbol)
		{
			OpenQuant.Instruments.Remove(symbol);
			FreeQuant.Instruments.InstrumentManager.Remove(symbol);
		}
	}
}

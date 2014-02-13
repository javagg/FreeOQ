using FreeQuant.FIX;
using FreeQuant.Providers;
using System.Collections.Generic;

namespace OpenQuant.Shared.Diagnostics
{
	class ProviderCounter : EventCounter
	{
		private Dictionary<IFIXInstrument, InstrumentCounter> instrumentCounters;

		public IProvider Provider { get; private set; }

		public ICollection<InstrumentCounter> InstrumentCounters
		{
			get
			{
				return this.instrumentCounters.Values;
			}
		}

		public ProviderCounter(IProvider provider)
		{
			this.Provider = provider;
			this.instrumentCounters = new Dictionary<IFIXInstrument, InstrumentCounter>();
		}

		public void AddTrade(IFIXInstrument instrument)
		{
			this.GetInstrumentCounter(instrument).Trades.Increment();
			this.Trades.Increment();
		}

		public void AddQuote(IFIXInstrument instrument)
		{
			this.GetInstrumentCounter(instrument).Quotes.Increment();
			this.Quotes.Increment();
		}

		public ProviderCounter Clone()
		{
			ProviderCounter providerCounter = new ProviderCounter(this.Provider);
			this.CopyTo((EventCounter)providerCounter);
			foreach (InstrumentCounter instrumentCounter in (IEnumerable<InstrumentCounter>) this.InstrumentCounters)
				providerCounter.instrumentCounters.Add(instrumentCounter.Instrument, instrumentCounter.Clone());
			return providerCounter;
		}

		private InstrumentCounter GetInstrumentCounter(IFIXInstrument instrument)
		{
			InstrumentCounter instrumentCounter;
			if (!this.instrumentCounters.TryGetValue(instrument, out instrumentCounter))
			{
				instrumentCounter = new InstrumentCounter(instrument);
				this.instrumentCounters.Add(instrument, instrumentCounter);
			}
			return instrumentCounter;
		}
	}
}

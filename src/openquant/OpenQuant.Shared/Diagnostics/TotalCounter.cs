using FreeQuant.Providers;
using System.Collections.Generic;

namespace OpenQuant.Shared.Diagnostics
{
	class TotalCounter : EventCounter
	{
		private Dictionary<IProvider, ProviderCounter> providerCounters;
		private object lockObject;

		public ICollection<ProviderCounter> ProviderCounters
		{
			get
			{
				return (ICollection<ProviderCounter>)this.providerCounters.Values;
			}
		}

		public TotalCounter()
		{
			this.providerCounters = new Dictionary<IProvider, ProviderCounter>();
			this.lockObject = new object();
		}

		public void Add(TradeEventArgs args)
		{
			lock (this.lockObject)
			{
				this.GetProviderCounter((IProvider)((IntradayEventArgs)args).Provider).AddTrade(((IntradayEventArgs)args).Instrument);
				this.Trades.Increment();
			}
		}

		public void Add(QuoteEventArgs args)
		{
			lock (this.lockObject)
			{
				this.GetProviderCounter((IProvider)((IntradayEventArgs)args).Provider).AddQuote(((IntradayEventArgs)args).Instrument);
				this.Quotes.Increment();
			}
		}

		public TotalCounter GetSnapshot()
		{
			TotalCounter totalCounter = new TotalCounter();
			lock (this.lockObject)
			{
				this.CopyTo((EventCounter)totalCounter);
				foreach (ProviderCounter item_0 in (IEnumerable<ProviderCounter>) this.ProviderCounters)
					totalCounter.providerCounters.Add(item_0.Provider, item_0.Clone());
			}
			return totalCounter;
		}

		public override void Reset()
		{
			lock (this.lockObject)
			{
				base.Reset();
				this.providerCounters.Clear();
			}
		}

		private ProviderCounter GetProviderCounter(IProvider provider)
		{
			ProviderCounter providerCounter;
			if (!this.providerCounters.TryGetValue(provider, out providerCounter))
			{
				providerCounter = new ProviderCounter(provider);
				this.providerCounters.Add(provider, providerCounter);
			}
			return providerCounter;
		}
	}
}

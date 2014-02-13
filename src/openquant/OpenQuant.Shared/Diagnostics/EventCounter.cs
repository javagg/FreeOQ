namespace OpenQuant.Shared.Diagnostics
{
	class EventCounter
	{
		public CounterData Trades { get; private set; }

		public CounterData Quotes { get; private set; }

		public EventCounter()
		{
			this.Trades = new CounterData();
			this.Quotes = new CounterData();
		}

		protected void CopyTo(EventCounter other)
		{
			other.Trades = (CounterData)this.Trades.Clone();
			other.Quotes = (CounterData)this.Quotes.Clone();
		}

		public virtual void Reset()
		{
			this.Trades.Reset();
			this.Quotes.Reset();
		}
	}
}

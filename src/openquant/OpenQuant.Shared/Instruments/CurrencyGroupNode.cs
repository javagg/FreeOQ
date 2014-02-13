using FreeQuant.Instruments;

namespace OpenQuant.Shared.Instruments
{
	class CurrencyGroupNode : GroupNode
	{
		private string currency;

		public CurrencyGroupNode(string currency)
		{
			this.currency = currency;
			this.SetText(currency);
		}

		public override bool IsInstrumentValid(Instrument instrument)
		{
			return instrument.Currency == this.currency;
		}
	}
}

using FreeQuant.Data;
using FreeQuant.FIX;

namespace FreeQuant.Providers
{
	public interface ISimulationMarketDataProvider
	{
		void EmitTrade(IFIXInstrument instrument, Trade trade);
		void EmitQuote(IFIXInstrument instrument, Quote quote);
	}
}

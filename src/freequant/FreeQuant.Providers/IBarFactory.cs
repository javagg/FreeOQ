using FreeQuant.Data;
using FreeQuant.FIX;
using System.ComponentModel;

namespace FreeQuant.Providers
{
	public interface IBarFactory
	{
		bool Enabled { get; set; }
		BarFactoryInput Input { get; set; }
		BarFactoryItemList Items { get; }
		event BarEventHandler NewBar;
		event BarEventHandler NewBarOpen;
		event BarSliceEventHandler NewBarSlice;
		void OnNewTrade(IFIXInstrument instrument, Trade trade);
		void OnNewQuote(IFIXInstrument instrument, Quote quote);
		void Reset();
	}
}

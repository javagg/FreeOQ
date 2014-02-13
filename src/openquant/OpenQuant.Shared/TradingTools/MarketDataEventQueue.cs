using OpenQuant.Shared;

namespace OpenQuant.Shared.TradingTools
{
	class MarketDataEventQueue : EventQueue<MarketDataUpdateItem>
	{
		public bool Enabled { get; set; }

		public MarketDataEventQueue()
		{
			this.Enabled = false;
		}
	}
}

using FreeQuant.Data;
using FreeQuant.FIX;

namespace FreeQuant.Providers
{
	public class HistoricalBarEventArgs : HistoricalDataEventArgs
	{
		public Bar Bar { get; private set; }

		public HistoricalBarEventArgs(Bar bar, string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength) : base(requestId, instrument, provider, dataLength)
		{
			this.Bar = bar; 
		}
	}
}

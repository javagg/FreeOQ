using FreeQuant.Data;
using FreeQuant.FIX;

namespace FreeQuant.Providers
{
	public class HistoricalBarEventArgs : HistoricalDataEventArgs
	{
		private FreeQuant.Data.Bar bar;

		public FreeQuant.Data.Bar Bar
		{
			get
			{
				return this.bar;
			}
		}

		public HistoricalBarEventArgs(FreeQuant.Data.Bar bar, string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength) : base(requestId, instrument, provider, dataLength)
		{

			this.bar = bar; 
		}
	}
}

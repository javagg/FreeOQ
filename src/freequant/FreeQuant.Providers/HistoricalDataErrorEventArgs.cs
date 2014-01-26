using FreeQuant.FIX;

namespace FreeQuant.Providers
{
	public class HistoricalDataErrorEventArgs : HistoricalDataEventArgs
	{
		public string Message { get; private set; }


		public HistoricalDataErrorEventArgs(string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength, string message)
			: base(requestId, instrument, provider, dataLength)
		{
			this.Message = message; 
		}
	}
}

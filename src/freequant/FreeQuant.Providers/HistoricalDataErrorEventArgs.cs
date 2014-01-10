using FreeQuant.FIX;

namespace FreeQuant.Providers
{
	public class HistoricalDataErrorEventArgs : HistoricalDataEventArgs
	{
		private string message;

		public string Message
		{
			get
			{
				return this.message;
			}
		}

		public HistoricalDataErrorEventArgs(string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength, string message)
			: base(requestId, instrument, provider, dataLength)
		{

			this.message = message; 
		}
	}
}

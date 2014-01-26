using FreeQuant.FIX;
using System;

namespace FreeQuant.Providers
{
	public class HistoricalDataEventArgs : EventArgs
	{
		public string RequestId { get; private set; }
		public IFIXInstrument Instrument { get; private set; }
		public IHistoricalDataProvider Provider { get; private set; }
		public int DataLength { get; private set; }

		public HistoricalDataEventArgs(string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength) : base()
		{
			this.RequestId = requestId;
			this.Instrument = instrument;
			this.Provider = provider;
			this.DataLength = dataLength;
		}
	}
}

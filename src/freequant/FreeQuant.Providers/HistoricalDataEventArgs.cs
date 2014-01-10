using FreeQuant.FIX;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
	public class HistoricalDataEventArgs : EventArgs
	{
		private string requestId;
		private IFIXInstrument instrument;
		private IHistoricalDataProvider provider;
		private int dataLength;

		public string RequestId
		{
			get
			{
				return this.requestId; 
			}
		}

		public IFIXInstrument Instrument
		{
			get
			{
				return this.instrument; 
			}
		}

		public IHistoricalDataProvider Provider
		{
			get
			{
				return this.provider; 
			}
		}

		public int DataLength
		{
			get
			{
				return this.dataLength; 
			}
		}

		public HistoricalDataEventArgs(string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength) : base()
		{
			this.requestId = requestId;
			this.instrument = instrument;
			this.provider = provider;
			this.dataLength = dataLength;
		}
	}
}

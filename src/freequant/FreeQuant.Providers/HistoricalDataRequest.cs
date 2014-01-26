using FreeQuant.FIX;
using System;

namespace FreeQuant.Providers
{
	public class HistoricalDataRequest
	{
		private static int counter;

		public string RequestId { get; private set; }
		public IFIXInstrument Instrument { get; set; }
		public HistoricalDataType DataType { get; set; }
		public DateTime BeginDate { get; set; }
		public DateTime EndDate { get; set; }
		public int DaysAgo { get; set; }
		public int BarsAgo { get; set; }
		public long BarSize { get; set; }

		static HistoricalDataRequest()
		{
			HistoricalDataRequest.counter = 0;
		}

		public HistoricalDataRequest()
		{
			lock(typeof(HistoricalDataRequest)) {
				this.RequestId = string.Format("", DateTime.Now, HistoricalDataRequest.counter++);
			}
		}
	}
}

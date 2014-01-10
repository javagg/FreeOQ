using System;

namespace FreeQuant.QuantBaseLib
{
	[Serializable]
	public class InstrumentFilter
	{
		public string Symbol { get; set; }
		public string SecurityType { get; set; }
		public string SecurityExchange { get; set; }
	}
}

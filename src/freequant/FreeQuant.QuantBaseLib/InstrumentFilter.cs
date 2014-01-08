using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.QuantBaseLib
{
  [Serializable]
  public class InstrumentFilter
  {
		public string Symbol { get;  set; }

		public string SecurityType {   get; set; }

		public string SecurityExchange {  get;  set; }

    public InstrumentFilter()
    {
      this.Symbol = (string) null;
      this.SecurityType = (string) null;
      this.SecurityExchange = (string) null;
    }
  }
}

using System;

namespace FreeQuant.QuantRouterLib.Data
{
  public class BrokerInfoEventArgs : EventArgs
  {
		public BrokerInfo BrokerInfo {   get;  private set; }

    public BrokerInfoEventArgs(BrokerInfo brokerInfo)
    {
      this.BrokerInfo = brokerInfo;
    }
  }
}

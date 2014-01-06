namespace OpenQuant.API
{
  public class BrokerInfo
  {
    internal SmartQuant.Providers.BrokerInfo brokerInfo;

    public BrokerAccountList Accounts
    {
      get
      {
        return new BrokerAccountList(this.brokerInfo.Accounts);
      }
    }

    internal BrokerInfo(SmartQuant.Providers.BrokerInfo brokerInfo)
    {
      this.brokerInfo = brokerInfo;
    }

    public BrokerInfo()
      : this(new SmartQuant.Providers.BrokerInfo())
    {
    }

    public BrokerAccount AddAccount(string name)
    {
      SmartQuant.Providers.BrokerAccount brokerAccount = new SmartQuant.Providers.BrokerAccount(name);
      this.brokerInfo.Accounts.Add(brokerAccount);
      return new BrokerAccount(brokerAccount);
    }
  }
}

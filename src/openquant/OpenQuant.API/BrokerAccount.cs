namespace OpenQuant.API
{
  public class BrokerAccount
  {
    private SmartQuant.Providers.BrokerAccount brokerAccount;

    public string Name
    {
      get
      {
        return this.brokerAccount.Name;
      }
    }

    public double BuyingPower
    {
      get
      {
        return this.brokerAccount.BuyingPower;
      }
      set
      {
        this.brokerAccount.BuyingPower = value;
      }
    }

    public BrokerAccountFieldList Fields
    {
      get
      {
        return new BrokerAccountFieldList(this.brokerAccount.GetFields());
      }
    }

    public BrokerPositionList Positions
    {
      get
      {
        return new BrokerPositionList(this.brokerAccount.GetPositions());
      }
    }

    public BrokerOrderList Orders
    {
      get
      {
        return new BrokerOrderList(this.brokerAccount.GetOrders());
      }
    }

    internal BrokerAccount(SmartQuant.Providers.BrokerAccount brokerAccount)
    {
      this.brokerAccount = brokerAccount;
    }

    public BrokerPosition AddPosition()
    {
      SmartQuant.Providers.BrokerPosition brokerPosition = new SmartQuant.Providers.BrokerPosition();
      this.brokerAccount.AddPosition(brokerPosition);
      return new BrokerPosition(brokerPosition);
    }

    public BrokerOrder AddOrder()
    {
      SmartQuant.Providers.BrokerOrder brokerOrder = new SmartQuant.Providers.BrokerOrder();
      this.brokerAccount.AddOrder(brokerOrder);
      return new BrokerOrder(brokerOrder);
    }

    public void AddField(string name, string currency, string value)
    {
      this.brokerAccount.AddField(name, currency, value);
    }

    public void AddField(string name, string value)
    {
      this.AddField(name, string.Empty, value);
    }
  }
}

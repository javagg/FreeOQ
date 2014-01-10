using System.Collections.Generic;

namespace FreeQuant.Providers
{
  public class BrokerAccount
  {
    private string name;
    private SortedList<string, SortedList<string, string>> eIBLfHO4iH;
    private List<BrokerPosition> positions;
    private List<BrokerOrder> orders;
    private double buyingPower;

    public string Name
    {
       get
      {
				return this.name; 
      }
    }

    public double BuyingPower
    {
       get
      {
				return this.buyingPower; 
      }
       set
      {
        this.buyingPower = value;
      }
    }

    
    public BrokerAccount(string name)
    {
      this.name = name;
      this.eIBLfHO4iH = new SortedList<string, SortedList<string, string>>();
      this.positions = new List<BrokerPosition>();
      this.orders = new List<BrokerOrder>();
      this.buyingPower = 0.0;
    }

    
    public void AddField(string name, string currency, string value)
    {
      SortedList<string, string> sortedList;
      if (!this.eIBLfHO4iH.TryGetValue(name, out sortedList))
      {
        sortedList = new SortedList<string, string>();
        this.eIBLfHO4iH.Add(name, sortedList);
      }
      sortedList.Add(currency, value);
    }

    public void AddField(string name, string value)
    {
      this.AddField(name, "", value);
    }

    public BrokerAccountField[] GetFields()
    {
			List<BrokerAccountField>  fields = new List<BrokerAccountField>();
      foreach (KeyValuePair<string, SortedList<string, string>> keyValuePair1 in this.eIBLfHO4iH)
      {
        string key = keyValuePair1.Key;
        foreach (KeyValuePair<string, string> keyValuePair2 in keyValuePair1.Value)
          fields.Add(new BrokerAccountField(key, keyValuePair2.Key, keyValuePair2.Value));
      }
      return fields.ToArray();
    }

    
    public void AddPosition(BrokerPosition position)
    {
			this.positions.Add(position); 
    }

    
    public BrokerPosition[] GetPositions()
    {
      return this.positions.ToArray();
    }

    
    public void AddOrder(BrokerOrder order)
    {
			this.orders.Add(order); 
    }

    
    public BrokerOrder[] GetOrders()
    {
      return this.orders.ToArray();
    }
  }
}

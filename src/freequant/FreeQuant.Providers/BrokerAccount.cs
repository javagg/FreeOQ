using dW79p7NPlS6ZxObcx3;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  public class BrokerAccount
  {
    private string yWkLGkkFsH;
    private SortedList<string, SortedList<string, string>> eIBLfHO4iH;
    private List<BrokerPosition> FPPL3slcLK;
    private List<BrokerOrder> r8qLlVxuc0;
    private double nwHL7l8nv8;

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.yWkLGkkFsH;
      }
    }

    public double BuyingPower
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nwHL7l8nv8;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.nwHL7l8nv8 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BrokerAccount(string name)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.yWkLGkkFsH = name;
      this.eIBLfHO4iH = new SortedList<string, SortedList<string, string>>();
      this.FPPL3slcLK = new List<BrokerPosition>();
      this.r8qLlVxuc0 = new List<BrokerOrder>();
      this.nwHL7l8nv8 = 0.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddField(string name, string value)
    {
      this.AddField(name, "", value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BrokerAccountField[] GetFields()
    {
      List<BrokerAccountField> list = new List<BrokerAccountField>();
      foreach (KeyValuePair<string, SortedList<string, string>> keyValuePair1 in this.eIBLfHO4iH)
      {
        string key = keyValuePair1.Key;
        foreach (KeyValuePair<string, string> keyValuePair2 in keyValuePair1.Value)
          list.Add(new BrokerAccountField(key, keyValuePair2.Key, keyValuePair2.Value));
      }
      return list.ToArray();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddPosition(BrokerPosition position)
    {
      this.FPPL3slcLK.Add(position);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BrokerPosition[] GetPositions()
    {
      return this.FPPL3slcLK.ToArray();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddOrder(BrokerOrder order)
    {
      this.r8qLlVxuc0.Add(order);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BrokerOrder[] GetOrders()
    {
      return this.r8qLlVxuc0.ToArray();
    }
  }
}

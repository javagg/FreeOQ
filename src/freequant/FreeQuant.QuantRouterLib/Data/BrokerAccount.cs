// Type: SmartQuant.QuantRouterLib.Data.BrokerAccount
// Assembly: SmartQuant.QuantRouterLib, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: FDF277D6-C8FB-45C3-A0BD-1C1035F3B027
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.QuantRouterLib.dll

using NI8YCE6tH4BIeIEcEy;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SmartQuant.QuantRouterLib.Data
{
  public class BrokerAccount
  {
    private string sCOhwmDiPj;
    private SortedList<string, SortedList<string, string>> Ob4hqZ0PeT;
    private List<BrokerPosition> xHhhrp2mwI;
    private List<BrokerOrder> Lwfh2mMr9L;
    private double cHnhpWqnGV;

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.sCOhwmDiPj;
      }
    }

    public double BuyingPower
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.cHnhpWqnGV;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.cHnhpWqnGV = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BrokerAccount(string name)
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.sCOhwmDiPj = name;
      this.Ob4hqZ0PeT = new SortedList<string, SortedList<string, string>>();
      this.xHhhrp2mwI = new List<BrokerPosition>();
      this.Lwfh2mMr9L = new List<BrokerOrder>();
      this.cHnhpWqnGV = 0.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddField(string name, string currency, string value)
    {
      SortedList<string, string> sortedList;
      if (!this.Ob4hqZ0PeT.TryGetValue(name, out sortedList))
      {
        sortedList = new SortedList<string, string>();
        this.Ob4hqZ0PeT.Add(name, sortedList);
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
      foreach (KeyValuePair<string, SortedList<string, string>> keyValuePair1 in this.Ob4hqZ0PeT)
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
      this.xHhhrp2mwI.Add(position);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BrokerPosition[] GetPositions()
    {
      return this.xHhhrp2mwI.ToArray();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddOrder(BrokerOrder order)
    {
      this.Lwfh2mMr9L.Add(order);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BrokerOrder[] GetOrders()
    {
      return this.Lwfh2mMr9L.ToArray();
    }
  }
}

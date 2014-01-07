using dW79p7NPlS6ZxObcx3;
using FreeQuant.FIX;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  public class BrokerOrder
  {
    private SortedList<string, string> JRYguyvkyS;

    public string OrderID { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public string Symbol { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public string SecurityType { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public string SecurityExchange { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public string Currency { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public Side Side { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public OrdType OrdType { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public OrdStatus OrdStatus { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public double OrderQty { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public double Price { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public double StopPx { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BrokerOrder()
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrderID = string.Empty;
      this.Symbol = string.Empty;
      this.SecurityType = string.Empty;
      this.SecurityExchange = string.Empty;
      this.Currency = string.Empty;
      this.Side = Side.Buy;
      this.OrdType = OrdType.Market;
      this.OrdStatus = OrdStatus.New;
      this.OrderQty = 0.0;
      this.Price = 0.0;
      this.StopPx = 0.0;
      this.JRYguyvkyS = new SortedList<string, string>();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddCustomField(string name, string value)
    {
      this.JRYguyvkyS.Add(name, value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BrokerOrderField[] GetCustomFields()
    {
      List<BrokerOrderField> list = new List<BrokerOrderField>();
      foreach (KeyValuePair<string, string> keyValuePair in this.JRYguyvkyS)
        list.Add(new BrokerOrderField(keyValuePair.Key, keyValuePair.Value));
      return list.ToArray();
    }
  }
}

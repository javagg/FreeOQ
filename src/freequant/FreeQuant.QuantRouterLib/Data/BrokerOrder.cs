using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Data
{
  public class BrokerOrder
  {
    private SortedList<string, string> mldu40NvwX;

    public string OrderID { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public string Symbol { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public string SecurityType { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public string SecurityExchange { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public string Currency { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public char Side { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public char OrdType { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public char OrdStatus { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public double OrderQty { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public double Price { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public double StopPx { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public BrokerOrder()
    {
	 this.OrderID = string.Empty;
      this.Symbol = string.Empty;
      this.SecurityType = string.Empty;
      this.SecurityExchange = string.Empty;
      this.Currency = string.Empty;
      this.OrderQty = 0.0;
      this.Price = 0.0;
      this.StopPx = 0.0;
      this.mldu40NvwX = new SortedList<string, string>();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddCustomField(string name, string value)
    {
      this.mldu40NvwX.Add(name, value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BrokerOrderField[] GetCustomFields()
    {
      List<BrokerOrderField> list = new List<BrokerOrderField>();
      foreach (KeyValuePair<string, string> keyValuePair in this.mldu40NvwX)
        list.Add(new BrokerOrderField(keyValuePair.Key, keyValuePair.Value));
      return list.ToArray();
    }
  }
}

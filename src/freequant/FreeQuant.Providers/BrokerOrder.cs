using FreeQuant.FIX;
using System.Collections.Generic;

namespace FreeQuant.Providers
{
	public class BrokerOrder
	{
		private SortedList<string, string> JRYguyvkyS;

		public string OrderID { get; set; }

		public string Symbol { get; set; }

		public string SecurityType { get; set; }

		public string SecurityExchange { get; set; }

		public string Currency { get; set; }

		public Side Side { get; set; }

		public OrdType OrdType { get; set; }

		public OrdStatus OrdStatus { get; set; }

		public double OrderQty { get; set; }

		public double Price { get; set; }

		public double StopPx { get; set; }

		public BrokerOrder()
		{
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

		public void AddCustomField(string name, string value)
		{
			this.JRYguyvkyS.Add(name, value);
		}

		public BrokerOrderField[] GetCustomFields()
		{
			List<BrokerOrderField> list = new List<BrokerOrderField>();
			foreach (KeyValuePair<string, string> keyValuePair in this.JRYguyvkyS)
				list.Add(new BrokerOrderField(keyValuePair.Key, keyValuePair.Value));
			return list.ToArray();
		}
	}
}

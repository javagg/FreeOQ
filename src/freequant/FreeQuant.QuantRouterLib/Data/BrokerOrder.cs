using System.Collections.Generic;

namespace FreeQuant.QuantRouterLib.Data
{
    public class BrokerOrder
    {
        private SortedList<string, string> mldu40NvwX;

        public string OrderID { get; set; }

        public string Symbol { get; set; }

        public string SecurityType { get; set; }

        public string SecurityExchange { get; set; }

        public string Currency { get; set; }

        public char Side { get; set; }

        public char OrdType { get; set; }

        public char OrdStatus { get; set; }

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
            this.OrderQty = 0.0;
            this.Price = 0.0;
            this.StopPx = 0.0;
            this.mldu40NvwX = new SortedList<string, string>();
        }

        public void AddCustomField(string name, string value)
        {
            this.mldu40NvwX.Add(name, value);
        }

        public BrokerOrderField[] GetCustomFields()
        {
            List<BrokerOrderField> list = new List<BrokerOrderField>();
            foreach (KeyValuePair<string, string> keyValuePair in this.mldu40NvwX)
                list.Add(new BrokerOrderField(keyValuePair.Key, keyValuePair.Value));
            return list.ToArray();
        }
    }
}

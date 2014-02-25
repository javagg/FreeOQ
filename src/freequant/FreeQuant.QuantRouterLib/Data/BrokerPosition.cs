using System;
using System.Collections.Generic;

namespace FreeQuant.QuantRouterLib.Data
{
    public class BrokerPosition
    {
        private string symbol;
        private string securityType;
        private string securityExchange;
        private string currency;
        private DateTime maturityDate;
        private int putOrCall;
        private double strike;
        private double qty;
        private double longQty;
        private double shortQty;
        private SortedList<string, string> positions;

        public string Symbol { get; set; }

        public string SecurityType { get; set; }


        public string SecurityExchange { get; set; }

        public string Currency { get; set; }

        public DateTime MaturityDate { get; set; }


        public int PutOrCall { get; set; }

        public double Strike { get; set; }

        public double Qty { get; set; }


        public double LongQty { get; set; }

        public double ShortQty { get; set; }

        public BrokerPosition() : base()
        {
            this.Symbol = string.Empty;
            this.SecurityType = string.Empty;
            this.SecurityExchange = string.Empty;
            this.Currency = string.Empty;
            this.MaturityDate = DateTime.MinValue;
            this.PutOrCall = 0;
            this.Strike = 0.0;
            this.Qty = 0.0;
            this.LongQty = 0.0;
            this.ShortQty = 0.0;
            this.positions = new SortedList<string, string>();
        }

        
        public void AddCustomField(string name, string value)
        {
            this.positions.Add(name, value);
        }

        
        public BrokerPositionField[] GetCustomFields()
        {
            List<BrokerPositionField> list = new List<BrokerPositionField>();
            foreach (KeyValuePair<string, string> keyValuePair in this.positions)
                list.Add(new BrokerPositionField(keyValuePair.Key, keyValuePair.Value));
            return list.ToArray();
        }
    }
}

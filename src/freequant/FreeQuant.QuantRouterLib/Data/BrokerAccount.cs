using System.Collections.Generic;

namespace FreeQuant.QuantRouterLib.Data
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
            get
            {
                return this.sCOhwmDiPj;
            }
        }

        public double BuyingPower
        {
            get
            {
                return this.cHnhpWqnGV;
            }
            set
            {
                this.cHnhpWqnGV = value;
            }
        }

        public BrokerAccount(string name) : base()
        {
            this.sCOhwmDiPj = name;
            this.Ob4hqZ0PeT = new SortedList<string, SortedList<string, string>>();
            this.xHhhrp2mwI = new List<BrokerPosition>();
            this.Lwfh2mMr9L = new List<BrokerOrder>();
            this.cHnhpWqnGV = 0.0;
        }

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

        public void AddField(string name, string value)
        {
            this.AddField(name, "", value);
        }

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

        public void AddPosition(BrokerPosition position)
        {
            this.xHhhrp2mwI.Add(position);
        }

        public BrokerPosition[] GetPositions()
        {
            return this.xHhhrp2mwI.ToArray();
        }

        public void AddOrder(BrokerOrder order)
        {
            this.Lwfh2mMr9L.Add(order);
        }

        public BrokerOrder[] GetOrders()
        {
            return this.Lwfh2mMr9L.ToArray();
        }
    }
}

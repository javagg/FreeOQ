using System;
using System.Collections;
using System.Collections.Generic;

namespace FreeQuant.QuantRouterLib.Data
{
    public class BrokerAccountList : ICollection, IEnumerable
    {
        private SortedList<string, BrokerAccount> yJ5u1odcpC;
        private List<BrokerAccount> ufGuL3AIDY;

        public int Count
        {
            get
            {
                return this.ufGuL3AIDY.Count;
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return false;
            }
        }

        public object SyncRoot
        {
            get
            {
                return (object)null;
            }
        }

        public BrokerAccount this [int index]
        {
            get
            {
                return this.ufGuL3AIDY[index];
            }
        }

        public BrokerAccount this [string name]
        {
            get
            {
                return this.yJ5u1odcpC[name];
            }
        }

        internal BrokerAccountList() : base()
        {
            this.yJ5u1odcpC = new SortedList<string, BrokerAccount>();
            this.ufGuL3AIDY = new List<BrokerAccount>();
        }

        public void CopyTo(Array array, int index)
        {
            this.ufGuL3AIDY.ToArray().CopyTo(array, index);
        }

        public IEnumerator GetEnumerator()
        {
            return this.ufGuL3AIDY.GetEnumerator();
        }

        public void Add(BrokerAccount account)
        {
            this.yJ5u1odcpC.Add(account.Name, account);
            this.ufGuL3AIDY.Add(account);
        }
    }
}

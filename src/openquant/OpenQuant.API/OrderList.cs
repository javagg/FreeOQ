using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.API
{
    public class OrderList : IEnumerable
    {
        private List<Order> list = new List<Order>();

        public int Count
        {
            get
            {
                return this.list.Count;
            }
        }

        public Order this[int index]
        {
            get
            {
                return this.list[index];
            }
        }

        internal void Add(Order order)
        {
            this.list.Add(order);
        }

        internal void Remove(Order order)
        {
            this.list.Remove(order);
        }

        internal void Clear()
        {
            this.list.Clear();
        }

        public IEnumerator GetEnumerator()
        {
            return this.list.GetEnumerator();
        }
    }
}

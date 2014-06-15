using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;
using FreeQuant.Data;
using FreeQuant.Providers.Design;

namespace FreeQuant.Providers
{
    [Editor(typeof(BarFactoryItemListEditor), typeof(UITypeEditor))]
    public class BarFactoryItemList : IList
    {
        private ArrayList items;

        public bool IsReadOnly
        {
            get
            {
                return this.items.IsReadOnly;
            }
        }

        public bool IsFixedSize
        {
            get
            {
                return this.items.IsFixedSize;
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return this.items.IsSynchronized;
            }
        }

        public int Count
        {
            get
            {
                return this.items.Count;
            }
        }

        public object SyncRoot
        {
            get
            {
                return this.items.SyncRoot;
            }
        }

        public BarFactoryItem this[int index]
        {
            get
            {
                return this.items[index] as BarFactoryItem;
            }
        }

        object IList.this [int index]
        {
            get
            {
                return this.items[index];
            }
            set
            {
                throw new NotSupportedException();
            }
        }

        public BarFactoryItemList()
        {
            this.items = new ArrayList();
        }

        public void RemoveAt(int index)
        {
            this.items.RemoveAt(index);
        }

        public void Insert(int index, object value)
        {
            this.items.Insert(index, value);
        }

        public void Remove(object value)
        {
            this.items.Remove(value);
        }

        public bool Contains(object value)
        {
            return this.items.Contains(value);
        }

        public void Clear()
        {
            this.items.Clear();
        }

        public int IndexOf(object value)
        {
            return this.items.IndexOf(value);
        }

        int IList.Add(object value)
        {
            return this.Add(value as BarFactoryItem);
        }

        public void CopyTo(Array array, int index)
        {
            this.items.CopyTo(array, index);
        }

        public IEnumerator GetEnumerator()
        {
            return this.items.GetEnumerator();
        }

        public int Add(BarFactoryItem item)
        {
            this.items.Add(item);
            this.items.Sort();
            return this.items.IndexOf(item);
        }

        public int Add(BarType barType, long barSize, bool enabled)
        {
            return this.Add(new BarFactoryItem(barType, barSize, enabled));
        }
    }
}

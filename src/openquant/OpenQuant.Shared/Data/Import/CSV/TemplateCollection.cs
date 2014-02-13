using System;
using System.Collections;

namespace OpenQuant.Shared.Data.Import.CSV
{
	internal class TemplateCollection : ICollection, IEnumerable
	{
		private SortedList collection;

		public bool IsSynchronized
		{
			get
			{
				return this.collection.IsSynchronized;
			}
		}

		public int Count
		{
			get
			{
				return this.collection.Count;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this.collection.SyncRoot;
			}
		}

		public Template this [string name]
		{
			get
			{
				return this.collection[name] as Template;
			}
			set
			{
				this.collection[value.Name] = value;
			}
		}

		public string[] Names
		{
			get
			{
				return new ArrayList(this.collection.Keys).ToArray(typeof(string)) as string[];
			}
		}

		public TemplateCollection()
		{
			this.collection = new SortedList();
		}

		public void CopyTo(Array array, int index)
		{
			this.collection.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.collection.Values.GetEnumerator();
		}

		public void Add(Template template)
		{
			this.collection.Add(template.Name, template);
		}
	}
}

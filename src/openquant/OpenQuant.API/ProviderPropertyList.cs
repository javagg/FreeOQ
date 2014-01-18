using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.API
{
	/// <summary>
	/// ProviderPropertyList 
	/// </summary>
	public class ProviderPropertyList : IEnumerable<ProviderProperty>, IEnumerable
	{
		private Dictionary<string, ProviderProperty> properties;

		/// <summary>
		/// Gets number of providers in the list
		/// </summary>
		/// <value>The count.</value>
		public int Count
		{
			get
			{
				return this.properties.Count;
			}
		}

		/// <summary>
		/// Gets ProviderProperty by name
		/// </summary>
		public ProviderProperty this[string name]
		{
			get
			{
				return this.properties[name];
			}
		}

		internal ProviderPropertyList()
		{
			this.properties = new Dictionary<string, ProviderProperty>();
		}

		/// <summary>
		/// Gets enumerator
		/// </summary>
		public IEnumerator<ProviderProperty> GetEnumerator()
		{
			return (IEnumerator<ProviderProperty>)this.properties.Values.GetEnumerator();
		}

		internal void Add(ProviderProperty property)
		{
			this.properties.Add(property.Name, property);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)this.properties.GetEnumerator();
		}
	}
}

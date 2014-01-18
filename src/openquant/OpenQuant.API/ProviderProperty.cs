using FreeQuant.Providers;
using System;
using System.Reflection;

namespace OpenQuant.API
{
	/// <summary>
	/// A Provider Property
	/// </summary>
	public class ProviderProperty
	{
		private PropertyInfo property;
		private IProvider provider;

		/// <summary>
		/// Gets Provider Property name
		/// </summary>
		public string Name
		{
			get
			{
				return this.property.Name;
			}
		}

		/// <summary>
		/// Gets Provider Property value
		/// </summary>
		public object Value
		{
			get
			{
				return this.property.GetValue((object)this.provider, (object[])null);
			}
			set
			{
				this.property.SetValue((object)this.provider, value, (object[])null);
			}
		}

		/// <summary>
		/// Gets Provider Property type
		/// </summary>
		public Type Type
		{
			get
			{
				return this.property.PropertyType;
			}
		}

		internal ProviderProperty(PropertyInfo property, IProvider provider)
		{
			this.property = property;
			this.provider = provider;
		}
	}
}

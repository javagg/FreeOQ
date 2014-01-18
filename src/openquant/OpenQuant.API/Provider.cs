using OpenQuant.ObjectMap;
using FreeQuant.Providers;
using System.Reflection;

namespace OpenQuant.API
{
	/// <summary>
	/// Provider
	/// </summary>
	public class Provider
	{
		internal IProvider provider;

		/// <summary>
		/// Gets value indicating if this provider is Market Data Provider
		/// </summary>
		public bool IsMarketDataProvider
		{
			get
			{
				return this.provider is IMarketDataProvider;
			}
		}

		/// <summary>
		///  Gets value indicating if this provider is Execution Provider 
		/// </summary>
		public bool IsExecutionProvider
		{
			get
			{
				return this.provider is IExecutionProvider;
			}
		}

		/// <summary>
		///  Gets value indicating if this provider is Historical Data Provider
		/// </summary>
		public bool IsHistoricalDataProvider
		{
			get
			{
				return this.provider is IHistoricalDataProvider;
			}
		}

		/// <summary>
		///  Gets value indicating if this provider is Instrument Provider
		/// </summary>
		public bool IsInstrumentProvider
		{
			get
			{
				return this.provider is IInstrumentProvider;
			}
		}

		/// <summary>
		/// Gets Provider properties
		/// </summary>
		public ProviderPropertyList Properties { get; private set; }

		/// <summary>
		/// Gets Provider id
		/// </summary>
		public byte Id
		{
			get
			{
				return this.provider.Id;
			}
		}

		/// <summary>
		/// Gets Provider name
		/// </summary>
		public string Name
		{
			get
			{
				return this.provider.Name;
			}
		}

		/// <summary>
		///  Gets value indicating if the Provider is connected
		/// </summary>
		public bool IsConnected
		{
			get
			{
				return this.provider.IsConnected;
			}
		}

		internal Provider(IProvider provider)
		{
			this.provider = provider;
			this.Properties = new ProviderPropertyList();
			foreach (PropertyInfo property in provider.GetType().GetProperties())
			{
				if (property.CanRead && property.CanWrite && (property.PropertyType.IsValueType || property.PropertyType == typeof(string)))
					this.Properties.Add(new ProviderProperty(property, provider));
			}
		}

		/// <summary>
		/// Connects the provider
		/// </summary>
		public void Connect()
		{
			Map.RequestProviderConnect((object)this.provider);
		}

		/// <summary>
		/// Disconnects the provider
		/// </summary>
		public void Disconnect()
		{
			Map.RequestProviderDisconnect((object)this.provider);
		}
	}
}

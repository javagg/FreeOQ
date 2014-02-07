using FreeQuant.Providers;
using System;
using System.Collections.Generic;

namespace OpenQuant.Config
{
	public static class Configuration
	{
		private static ConfigurationInfoList infoList = new ConfigurationInfoList();
		private static ConfigurationMode activeMode;

		public static ConfigurationMode ActiveMode
		{
			get
			{
				return Configuration.activeMode;
			}
			set
			{
				if (Configuration.activeMode == value)
					return;
				ConfigurationModeChangingEventArgs args = new ConfigurationModeChangingEventArgs(Configuration.activeMode, value);
				if (Configuration.ConfigurationModeChanging != null)
					Configuration.ConfigurationModeChanging(typeof(Configuration), args);
				if (args.Cancel)
					return;
				if (Configuration.Active.MarketDataProvider != null && Configuration.GetConfiguration(value).MarketDataProvider != Configuration.Active.MarketDataProvider && Configuration.GetConfiguration(value).ExecutionProvider != Configuration.Active.MarketDataProvider)
					Configuration.Active.MarketDataProvider.Disconnect();
				if (Configuration.Active.ExecutionProvider != null && Configuration.GetConfiguration(value).MarketDataProvider != Configuration.Active.ExecutionProvider && Configuration.GetConfiguration(value).ExecutionProvider != Configuration.Active.ExecutionProvider)
					Configuration.Active.ExecutionProvider.Disconnect();
				Configuration.activeMode = value;
				if (Configuration.ConfigurationModeChanged == null)
					return;
				Configuration.ConfigurationModeChanged(typeof(Configuration), EventArgs.Empty);
			}
		}

		public static ConfigurationInfo Active
		{
			get
			{
				return Configuration.GetConfiguration(Configuration.activeMode);
			}
		}

		public static event ConfigurationModeChangingEventHandler ConfigurationModeChanging;
		public static event EventHandler ConfigurationModeChanged;

		static Configuration()
		{
		}

		public static void Init(ConfigurationMode activeMode, ConfigurationInfoList infoList)
		{
			Configuration.activeMode = activeMode;
			foreach (KeyValuePair<ConfigurationMode, ConfigurationInfo> keyValuePair in (Dictionary<ConfigurationMode, ConfigurationInfo>) infoList)
				Configuration.infoList.Add(keyValuePair.Key, keyValuePair.Value);
			ProviderManager.Added += (args) => 
			{
				foreach (ConfigurationInfo configurationInfo in Configuration.infoList.Values)
					configurationInfo.Refresh();
			};
//				new ProviderEventHandler(Configuration.ProviderManager_Added);
		}

		public static ConfigurationInfo GetConfiguration(ConfigurationMode mode)
		{
			return Configuration.infoList[mode];
		}

		public static ConfigurationInfoList GetConfigurations()
		{
			return Configuration.infoList;
		}

//		private static void ProviderManager_Added(ProviderEventArgs args)
//		{
//			foreach (ConfigurationInfo configurationInfo in Configuration.infoList.Values)
//				configurationInfo.Refresh();
//		}
	}
}

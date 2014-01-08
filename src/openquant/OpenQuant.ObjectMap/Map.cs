using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace OpenQuant.ObjectMap
{
	public class Map
	{
		public static Dictionary<string, List<string>> Instruments = new Dictionary<string, List<string>>();
		public static Hashtable SQ_OQ_Order = new Hashtable();
		public static Hashtable OQ_SQ_Order = new Hashtable();
		public static Hashtable SQ_OQ_Instrument = new Hashtable();
		public static Hashtable OQ_SQ_Instrument = new Hashtable();
		public static Hashtable SQ_OQ_Portfolio = new Hashtable();
		public static Hashtable OQ_SQ_Portfolio = new Hashtable();
		public static Hashtable DrawTable = new Hashtable();
		public static Dictionary<string, OrderedDictionary> PrintTable = new Dictionary<string, OrderedDictionary>();
		public static Hashtable SQ_OQ_Stop = new Hashtable();
		public static Hashtable OQ_SQ_Stop = new Hashtable();

		public static event EventHandler StopAdded;
		public static event EventHandler StrategyStopRequested;
		public static event EventHandler ProviderConnectRequested;
		public static event EventHandler ProviderDisconnectRequested;
		public static event EventHandler CustomCommandedRaised;

		static Map()
		{
		}

		public static void RaiseCommand(string strategyName, string symbol, object[] parameters)
		{
			if (Map.CustomCommandedRaised == null)
				return;
			Map.CustomCommandedRaised((object)new Tuple<string, string, object[]>(strategyName, symbol, parameters), EventArgs.Empty);
		}

		public static void AddStop(object sq_stop, string strategyName)
		{
			if (Map.StopAdded == null)
				return;
			Map.StopAdded((object)new object[2]
			{
				sq_stop,
				(object)strategyName
			}, EventArgs.Empty);
		}

		public static void RequestStrategyStop(object strategy)
		{
			if (Map.StrategyStopRequested == null)
				return;
			Map.StrategyStopRequested(strategy, EventArgs.Empty);
		}

		public static void RequestProviderConnect(object provider)
		{
			if (Map.ProviderConnectRequested == null)
				return;
			Map.ProviderConnectRequested(provider, EventArgs.Empty);
		}

		public static void RequestProviderDisconnect(object provider)
		{
			if (Map.ProviderDisconnectRequested == null)
				return;
			Map.ProviderDisconnectRequested(provider, EventArgs.Empty);
		}
	}
}

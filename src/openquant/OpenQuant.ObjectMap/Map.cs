using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace OpenQuant.ObjectMap
{
	public class Map
	{
		public static Dictionary<string, List<string>> Instruments = new Dictionary<string, List<string>>();
		public static Hashtable FQ_OQ_Order = new Hashtable();
		public static Hashtable OQ_FQ_Order = new Hashtable();
		public static Hashtable FQ_OQ_Instrument = new Hashtable();
		public static Hashtable OQ_FQ_Instrument = new Hashtable();
		public static Hashtable FQ_OQ_Portfolio = new Hashtable();
		public static Hashtable OQ_FQ_Portfolio = new Hashtable();
		public static Hashtable DrawTable = new Hashtable();
		public static Dictionary<string, OrderedDictionary> PrintTable = new Dictionary<string, OrderedDictionary>();
		public static Hashtable FQ_OQ_Stop = new Hashtable();
		public static Hashtable OQ_FQ_Stop = new Hashtable();

		public static event EventHandler StopAdded;
		public static event EventHandler StrategyStopRequested;
		public static event EventHandler ProviderConnectRequested;
		public static event EventHandler ProviderDisconnectRequested;
		public static event EventHandler CustomCommandedRaised;

		public static void RaiseCommand(string strategyName, string symbol, object[] parameters)
		{
			if (Map.CustomCommandedRaised != null)
				Map.CustomCommandedRaised(new Tuple<string, string, object[]>(strategyName, symbol, parameters), EventArgs.Empty);
		}

		public static void AddStop(object sq_stop, string strategyName)
		{
			if (Map.StopAdded != null)
				Map.StopAdded(new object[2] {	sq_stop,	strategyName }, EventArgs.Empty);
		}

		public static void RequestStrategyStop(object strategy)
		{
			if (Map.StrategyStopRequested != null)
				Map.StrategyStopRequested(strategy, EventArgs.Empty);
		}

		public static void RequestProviderConnect(object provider)
		{
			if (Map.ProviderConnectRequested != null)
				Map.ProviderConnectRequested(provider, EventArgs.Empty);
		}

		public static void RequestProviderDisconnect(object provider)
		{
			if (Map.ProviderDisconnectRequested != null)
				Map.ProviderDisconnectRequested(provider, EventArgs.Empty);
		}
	}
}

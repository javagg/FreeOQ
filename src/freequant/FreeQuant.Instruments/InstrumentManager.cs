using FreeQuant;
using FreeQuant.FIX;
using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace FreeQuant.Instruments
{
	public class InstrumentManager
	{
		private static Hashtable instrumentLists;

		public static InstrumentList Instruments { get; private set; }
		public static IInstrumentServer Server { get; set; }
		public static event InstrumentEventHandler InstrumentAdded;
		public static event InstrumentEventHandler InstrumentRemoved;

		static InstrumentManager()
		{
			InstrumentManager.Server = new InstrumentDbServer();
			InstrumentManager.Instruments = new InstrumentList();
			InstrumentManager.instrumentLists = new Hashtable();
			Type connectionType = null;
			string connectionString = String.Empty;
			switch (Framework.Storage.ServerType)
			{
				case DbServerType.MS_ACCESS:
					connectionType = Type.GetType("rr");
					connectionString = string.Format("", Framework.Installation.DataDir.FullName);
					break;
				case DbServerType.SQL_SERVER_COMPACT_EDITION_35:
					connectionType = Type.GetType("typename");
					connectionString = string.Format("", Framework.Installation.DataDir.FullName);
					break;
				case DbServerType.MYSQL:
					connectionType = Type.GetType("typename");
					connectionString = string.Format("", Framework.Installation.DataDir.FullName);
					break;
				case DbServerType.PGSQL:
					connectionType = Type.GetType("typename");
					connectionString = string.Format("", Framework.Installation.DataDir.FullName);
					break;
			}
			InstrumentManager.Server.Open(connectionType, connectionString);
			InstrumentManager.Instruments.Clear();
			foreach (Instrument instrument in InstrumentManager.Server.Load())
				InstrumentManager.Instruments.Add(instrument);
		}

		public static void Init()
		{
		}

		public static void Remove(Instrument instrument)
		{
			InstrumentManager.Server.Remove(instrument);
			InstrumentManager.Instruments.Remove(instrument);
			if (InstrumentManager.InstrumentRemoved == null)
				return;
			InstrumentManager.InstrumentRemoved(new InstrumentEventArgs(instrument));
		}

		public static void Remove(string symbol)
		{
			var instrument = InstrumentManager.Instruments[symbol];
			if (instrument == null)
				return;
			InstrumentManager.Remove(instrument);
		}

		public static void AddList(InstrumentList list)
		{
			if (InstrumentManager.instrumentLists.Contains(list.Name))
				InstrumentManager.RemoveList(list.Name);
			InstrumentManager.instrumentLists.Add(list.Name, list);
		}

		public static void RemoveList(string name)
		{
			InstrumentManager.instrumentLists.Remove(name);
		}

		public static InstrumentList GetList(string name)
		{
			return InstrumentManager.instrumentLists[name] as InstrumentList;
		}

		internal static void Add([In] Instrument instrument)
		{
			InstrumentManager.Instruments.Add(instrument);
			if (InstrumentManager.InstrumentAdded == null)
				return;
			InstrumentManager.InstrumentAdded(new InstrumentEventArgs(instrument));
		}

		internal static void Save([In] Instrument obj0)
		{
			InstrumentManager.Server.Save(obj0);
			if (InstrumentManager.Instruments.Contains(obj0.Id))
				return;
			InstrumentManager.Instruments.RegisterById(obj0);
		}
	}
}

using FreeQuant;
using FreeQuant.FIX;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Instruments
{
  public class InstrumentManager
  {
    private static IInstrumentServer server;
    private static InstrumentList instruments;
    private static Hashtable fQ3Efwxl5A;

    public static InstrumentList Instruments
    {
       get
      {
				return InstrumentManager.instruments; 
      }
    }

    public static IInstrumentServer Server
    {
        get
      {
				return InstrumentManager.server; 
      }
       set
      {
        InstrumentManager.server = value;
      }
    }

    public static event InstrumentEventHandler InstrumentAdded;

    public static event InstrumentEventHandler InstrumentRemoved;

     
    static InstrumentManager()
    {
      InstrumentManager.server = (IInstrumentServer) new InstrumentDbServer();
      InstrumentManager.instruments = new InstrumentList();
      InstrumentManager.fQ3Efwxl5A = new Hashtable();
      Type connectionType = (Type) null;
      string connectionString = string.Empty;
      switch (Framework.Storage.ServerType)
      {
        case DbServerType.MS_ACCESS:
					connectionType = Type.GetType("rr");
					connectionString = string.Format("", (object) Framework.Installation.DataDir.FullName);
          break;
        case DbServerType.SQL_SERVER_COMPACT_EDITION_35:
					connectionType = Type.GetType("typename");
					connectionString = string.Format("", (object) Framework.Installation.DataDir.FullName);
          break;
      }
      InstrumentManager.server.Open(connectionType, connectionString);
      InstrumentManager.instruments.Clear();
      foreach (Instrument instrument in (FIXGroupList) InstrumentManager.server.Load())
        InstrumentManager.instruments.Add(instrument);
    }

     public static void Init()
    {
    }

     public static void Remove(Instrument instrument)
    {
      InstrumentManager.server.Remove(instrument);
      InstrumentManager.instruments.Remove(instrument);
//      if (InstrumentManager.KmpEvph5v6 == null)
//        return;
//      InstrumentManager.KmpEvph5v6(new InstrumentEventArgs(instrument));
    }

     public static void Remove(string symbol)
    {
      Instrument instrument = InstrumentManager.instruments[symbol];
      if (instrument == null)
        return;
      InstrumentManager.Remove(instrument);
    }

     public static void AddList(InstrumentList list)
    {
      if (InstrumentManager.fQ3Efwxl5A.Contains((object) list.Name))
        InstrumentManager.RemoveList(list.Name);
      InstrumentManager.fQ3Efwxl5A.Add((object) list.Name, (object) list);
    }

     public static void RemoveList(string name)
    {
      InstrumentManager.fQ3Efwxl5A.Remove((object) name);
    }

     public static InstrumentList GetList(string name)
    {
      return InstrumentManager.fQ3Efwxl5A[(object) name] as InstrumentList;
    }

     internal static void VljEVFlVHf([In] Instrument obj0)
    {
      InstrumentManager.instruments.Add(obj0);
//      if (InstrumentManager.FN9EpXCpRx == null)
//        return;
//      InstrumentManager.FN9EpXCpRx(new InstrumentEventArgs(obj0));
    }

     internal static void DdbEFF4dAg([In] Instrument obj0)
    {
      InstrumentManager.server.Save(obj0);
      if (((FIXGroupList) InstrumentManager.instruments).Contains(obj0.Id))
        return;
      InstrumentManager.instruments.RegisterById((FIXGroup) obj0);
    }
  }
}

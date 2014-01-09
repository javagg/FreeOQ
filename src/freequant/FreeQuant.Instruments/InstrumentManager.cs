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
    private static IInstrumentServer st7EyF8wLV;
    private static InstrumentList axGEqcNulf;
    private static Hashtable fQ3Efwxl5A;

    public static InstrumentList Instruments
    {
       get
      {
        return InstrumentManager.axGEqcNulf;
      }
    }

    public static IInstrumentServer Server
    {
        get
      {
        return InstrumentManager.st7EyF8wLV;
      }
       set
      {
        InstrumentManager.st7EyF8wLV = value;
      }
    }

    public static event InstrumentEventHandler InstrumentAdded;

    public static event InstrumentEventHandler InstrumentRemoved;

     
    static InstrumentManager()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      InstrumentManager.st7EyF8wLV = (IInstrumentServer) new InstrumentDbServer();
      InstrumentManager.axGEqcNulf = new InstrumentList();
      InstrumentManager.fQ3Efwxl5A = new Hashtable();
      Type connectionType = (Type) null;
      string connectionString = string.Empty;
      switch (Framework.Storage.ServerType)
      {
        case DbServerType.MS_ACCESS:
          connectionType = Type.GetType(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(5654));
          connectionString = string.Format(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(5884), (object) Framework.Installation.DataDir.FullName);
          break;
        case DbServerType.SQL_SERVER_COMPACT_EDITION_35:
          connectionType = Type.GetType(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(6014));
          connectionString = string.Format(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(6280), (object) Framework.Installation.DataDir.FullName);
          break;
      }
      InstrumentManager.st7EyF8wLV.Open(connectionType, connectionString);
      InstrumentManager.axGEqcNulf.Clear();
      foreach (Instrument instrument in (FIXGroupList) InstrumentManager.st7EyF8wLV.Load())
        InstrumentManager.axGEqcNulf.Add(instrument);
    }

     public InstrumentManager()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

     public static void Init()
    {
    }

     public static void Remove(Instrument instrument)
    {
      InstrumentManager.st7EyF8wLV.Remove(instrument);
      InstrumentManager.axGEqcNulf.Remove(instrument);
      if (InstrumentManager.KmpEvph5v6 == null)
        return;
      InstrumentManager.KmpEvph5v6(new InstrumentEventArgs(instrument));
    }

     public static void Remove(string symbol)
    {
      Instrument instrument = InstrumentManager.axGEqcNulf[symbol];
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
      InstrumentManager.axGEqcNulf.Add(obj0);
      if (InstrumentManager.FN9EpXCpRx == null)
        return;
      InstrumentManager.FN9EpXCpRx(new InstrumentEventArgs(obj0));
    }

     internal static void DdbEFF4dAg([In] Instrument obj0)
    {
      InstrumentManager.st7EyF8wLV.Save(obj0);
      if (((FIXGroupList) InstrumentManager.axGEqcNulf).Contains(obj0.Id))
        return;
      InstrumentManager.axGEqcNulf.RegisterById((FIXGroup) obj0);
    }
  }
}

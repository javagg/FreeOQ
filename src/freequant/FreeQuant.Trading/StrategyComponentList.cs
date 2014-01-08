
using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Trading
{
  public class StrategyComponentList : ICollection, IEnumerable
  {
    private ArrayList NJl6XLSgmP;

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.NJl6XLSgmP.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.NJl6XLSgmP.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.NJl6XLSgmP.SyncRoot;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StrategyComponentList()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.NJl6XLSgmP = new ArrayList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.NJl6XLSgmP.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.NJl6XLSgmP.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ComponentRecord FindRecord(Guid guid)
    {
      foreach (ComponentRecord componentRecord in this.NJl6XLSgmP)
      {
        if (componentRecord.GUID == guid)
          return componentRecord;
      }
      return (ComponentRecord) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ComponentRecord[] FindRecords(FileInfo file)
    {
      ArrayList arrayList = new ArrayList();
      foreach (ComponentRecord componentRecord in this.NJl6XLSgmP)
      {
        if (!componentRecord.BuiltIn && componentRecord.File.FullName.ToLower() == file.FullName.ToLower())
          arrayList.Add((object) componentRecord);
      }
      return arrayList.ToArray(typeof (ComponentRecord)) as ComponentRecord[];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void ROm6C46rfm([In] ComponentRecord obj0)
    {
      this.NJl6XLSgmP.Add((object) obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void fc56KRbFEA([In] ComponentRecord obj0)
    {
      this.NJl6XLSgmP.Remove((object) obj0);
    }
  }
}

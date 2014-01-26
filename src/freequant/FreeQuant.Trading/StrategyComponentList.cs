
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
       get
      {
        return this.NJl6XLSgmP.IsSynchronized;
      }
    }

    public int Count
    {
       get
      {
        return this.NJl6XLSgmP.Count;
      }
    }

    public object SyncRoot
    {
       get
      {
        return this.NJl6XLSgmP.SyncRoot;
      }
    }

    
		public StrategyComponentList():base()
    {

      this.NJl6XLSgmP = new ArrayList();
    }

    
    public void CopyTo(Array array, int index)
    {
      this.NJl6XLSgmP.CopyTo(array, index);
    }

    
    public IEnumerator GetEnumerator()
    {
      return this.NJl6XLSgmP.GetEnumerator();
    }

    
    public ComponentRecord FindRecord(Guid guid)
    {
      foreach (ComponentRecord componentRecord in this.NJl6XLSgmP)
      {
        if (componentRecord.GUID == guid)
          return componentRecord;
      }
      return (ComponentRecord) null;
    }

    
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

    
    internal void ROm6C46rfm([In] ComponentRecord obj0)
    {
      this.NJl6XLSgmP.Add((object) obj0);
    }

    
    internal void fc56KRbFEA([In] ComponentRecord obj0)
    {
      this.NJl6XLSgmP.Remove((object) obj0);
    }
  }
}

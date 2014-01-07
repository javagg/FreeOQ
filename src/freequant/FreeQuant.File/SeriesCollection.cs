// Type: SmartQuant.File.SeriesCollection
// Assembly: SmartQuant.File, Version=2.1.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 800E5EC7-67A0-489F-9F8A-77FDD5BCC547
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.File.dll

using ewT8148K2kiaMR21B7;
using SmartQuant.File.Indexing;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using XnjwSLRMyI3UA3fEbD;

namespace SmartQuant.File
{
  public class SeriesCollection : ICollection, IEnumerable
  {
    private SortedList fE3x1KvvUM;
    private DataFile JVxx8pUc1v;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fE3x1KvvUM.Count;
      }
    }

    public FileSeries this[string name]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fE3x1KvvUM[(object) name] as FileSeries;
      }
    }

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fE3x1KvvUM.IsSynchronized;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fE3x1KvvUM.SyncRoot;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal SeriesCollection(DataFile file)
    {
      F45ZyD1Qi4NklFUbBa.aTsHghczyNAhO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.JVxx8pUc1v = file;
      this.fE3x1KvvUM = new SortedList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(string name)
    {
      return this.fE3x1KvvUM.ContainsKey((object) name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(string name)
    {
      FileSeries fileSeries = this[name];
      this.fE3x1KvvUM.Remove((object) fileSeries.Name);
      this.JVxx8pUc1v.kBox0k2EsS().KgSKBZK4t(fileSeries);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FileSeries Add(string name)
    {
      if (name.Length == 0 || name.Length > (int) sbyte.MaxValue)
        throw new ArgumentException(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2104), BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2228));
      FileSeries fileSeries = new FileSeries(this.JVxx8pUc1v.kBox0k2EsS(), name, "", this.JVxx8pUc1v.DefaultZipLevel, this.JVxx8pUc1v.DefaultBlockSize, this.JVxx8pUc1v.DefaultIndexer);
      this.fE3x1KvvUM.Add((object) fileSeries.Name, (object) fileSeries);
      this.JVxx8pUc1v.kBox0k2EsS().VmKuLwiT3(fileSeries);
      return fileSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Rename(string oldName, string newName)
    {
      if (oldName == null)
        throw new ArgumentNullException(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2240));
      if (newName == null)
        throw new ArgumentNullException(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2258));
      if (newName.Length == 0 || newName.Length > (int) sbyte.MaxValue)
        throw new ArgumentException(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2276));
      FileSeries fileSeries = this[oldName];
      if (fileSeries == null)
        throw new ArgumentException(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2392) + oldName + BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2418));
      if (this.Contains(newName))
        throw new ArgumentException(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2444) + newName + BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2470));
      fileSeries.TaaFdlDDd(newName);
      this.fE3x1KvvUM.Remove((object) oldName);
      this.fE3x1KvvUM.Add((object) newName, (object) fileSeries);
      this.JVxx8pUc1v.kBox0k2EsS().VmKuLwiT3(fileSeries);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal FileSeries zL2xM8qdRl([In] string obj0, [In] string obj1, [In] int obj2, [In] int obj3, [In] Indexer obj4)
    {
      FileSeries fileSeries = new FileSeries(this.JVxx8pUc1v.kBox0k2EsS(), obj0, obj1, obj2, obj3, obj4);
      this.fE3x1KvvUM.Add((object) fileSeries.Name, (object) fileSeries);
      return fileSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.fE3x1KvvUM.Values.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.fE3x1KvvUM.Values.GetEnumerator();
    }
  }
}

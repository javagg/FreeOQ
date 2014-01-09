using FreeQuant.File.Indexing;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


namespace FreeQuant.File
{
  public class SeriesCollection : ICollection, IEnumerable
  {
		private SortedList fE3x1KvvUM; 
		private DataFile dataFile; 

    public int Count
    {
       get
      {
        return this.fE3x1KvvUM.Count;
      }
    }

    public FileSeries this[string name]
    {
       get
      {
        return this.fE3x1KvvUM[(object) name] as FileSeries;
      }
    }

    public bool IsSynchronized
    {
       get
      {
        return this.fE3x1KvvUM.IsSynchronized;
      }
    }

    public object SyncRoot
    {
      get
      {
        return this.fE3x1KvvUM.SyncRoot;
      }
    }

    internal SeriesCollection(DataFile file)
    {
      this.dataFile = file;
      this.fE3x1KvvUM = new SortedList();
    }

    public bool Contains(string name)
    {
      return this.fE3x1KvvUM.ContainsKey((object) name);
    }

    public void Remove(string name)
    {
      FileSeries fileSeries = this[name];
      this.fE3x1KvvUM.Remove((object) fileSeries.Name);
      this.dataFile.kBox0k2EsS().KgSKBZK4t(fileSeries);
    }

    public FileSeries Add(string name)
    {
      FileSeries fileSeries = new FileSeries(this.dataFile.kBox0k2EsS(), name, "", this.dataFile.DefaultZipLevel, this.dataFile.DefaultBlockSize, this.dataFile.DefaultIndexer);
      this.fE3x1KvvUM.Add((object) fileSeries.Name, (object) fileSeries);
      this.dataFile.kBox0k2EsS().VmKuLwiT3(fileSeries);
      return fileSeries;
    }

    public void Rename(string oldName, string newName)
    {
      FileSeries fileSeries = this[oldName];
      if (fileSeries == null)
        throw new ArgumentException(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2392) + oldName + BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2418));
      if (this.Contains(newName))
        throw new ArgumentException(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2444) + newName + BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2470));
      fileSeries.TaaFdlDDd(newName);
      this.fE3x1KvvUM.Remove((object) oldName);
      this.fE3x1KvvUM.Add((object) newName, (object) fileSeries);
      this.dataFile.kBox0k2EsS().VmKuLwiT3(fileSeries);
    }

    internal FileSeries zL2xM8qdRl([In] string obj0, [In] string obj1, [In] int obj2, [In] int obj3, [In] Indexer obj4)
    {
      FileSeries fileSeries = new FileSeries(this.dataFile.kBox0k2EsS(), obj0, obj1, obj2, obj3, obj4);
      this.fE3x1KvvUM.Add((object) fileSeries.Name, (object) fileSeries);
      return fileSeries;
    }

    public void CopyTo(Array array, int index)
    {
      this.fE3x1KvvUM.Values.CopyTo(array, index);
    }

    public IEnumerator GetEnumerator()
    {
      return this.fE3x1KvvUM.Values.GetEnumerator();
    }
  }
}

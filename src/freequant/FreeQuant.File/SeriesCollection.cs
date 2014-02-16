using FreeQuant.File.Indexing;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.File
{
	public class SeriesCollection : ICollection, IEnumerable
	{
		private SortedList list;
		private DataFile dataFile;

		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		public FileSeries this[string name]
		{
			get
			{
				return this.list[name] as FileSeries;
			}
		}

		public bool IsSynchronized
		{
			get
			{
				return this.list.IsSynchronized;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this.list.SyncRoot;
			}
		}

		internal SeriesCollection(DataFile file)
		{
			this.dataFile = file;
			this.list = new SortedList();
		}

		public bool Contains(string name)
		{
			return this.list.ContainsKey((object)name);
		}

		public void Remove(string name)
		{
			FileSeries fileSeries = this[name];
			this.list.Remove(fileSeries.Name);
//			this.dataFile.kBox0k2EsS().Remove(fileSeries);
		}

		public FileSeries Add(string name)
		{
//			FileSeries fs = new FileSeries(this.dataFile.kBox0k2EsS(), name, "", this.dataFile.DefaultZipLevel, this.dataFile.DefaultBlockSize, this.dataFile.DefaultIndexer);
			FileSeries fs = new FileSeries(name, "", this.dataFile.DefaultZipLevel, this.dataFile.DefaultBlockSize, this.dataFile.DefaultIndexer);

			this.list.Add(fs.Name, fs);
//			this.dataFile.kBox0k2EsS().Add(fs);
			return fs;
		}

		public void Rename(string oldName, string newName)
		{
			FileSeries fs = this[oldName];
			if (fs == null)
				throw new ArgumentException("" + oldName);
			if (this.Contains(newName))
				throw new ArgumentException("" + newName);
			fs.TaaFdlDDd(newName);
			this.list.Remove(oldName);
			this.list.Add(newName, fs);
//			this.dataFile.kBox0k2EsS().VmKuLwiT3(fs);
		}

		internal FileSeries zL2xM8qdRl(string obj0, string obj1, int obj2, int obj3, Indexer obj4)
		{
//			FileSeries fs = new FileSeries(this.dataFile.kBox0k2EsS(), obj0, obj1, obj2, obj3, obj4);
			FileSeries fs = new FileSeries(obj0, obj1, obj2, obj3, obj4);
			this.list.Add(fs.Name, fs);
			return fs;
		}

		public void CopyTo(Array array, int index)
		{
			this.list.Values.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.list.Values.GetEnumerator();
		}
	}
}

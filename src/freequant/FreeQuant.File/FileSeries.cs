using FreeQuant.Data;
using FreeQuant.File.Indexing;
using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.File
{
  public class FileSeries : IDataSeries, IEnumerable
  {
    private const string TY1XmiAtV = "Settings";
    private const string TLQbrkLw3 = "Naming";
    internal long gJBOw3afc;
    internal long dC0L5SwaN;
    internal long hnKhMyEgT;
    internal DateTime firstDateTime;
    internal DateTime lastDateTime;
    internal int count;
    internal long lyMkX4DEV;
//    private FRJ1FMOwU8CAwJuZZf streamer;
    private string name;
    private string description;
    private int maxBlockSize;
    private int zipLevel;
    private Indexer indexer;

    [Description("Gets the name of the series")]
    [Category("Naming")]
    [Browsable(true)]
    public string Name
    {
       get
      {
				return this.name; 
      }
    }

    [Browsable(true)]
    [Category("Naming")]
    [Description("Gets or sets the description")]
    public string Description
    {
       get
      {
				return this.description; 
      }
       set
      {
//        if (value.Length > (int) sbyte.MaxValue)
//          throw new ArgumentException(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(0), BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(120));
        this.description = value;
//        this.streamer.VmKuLwiT3(this);
      }
    }

    [Category("Settings")]
    [DefaultValue(1000)]
    [Browsable(true)]
    [Description("Gets or sets the maximum block's size")]
    public int MaxBlockSize
    {
       get
      {
				return this.maxBlockSize; 
      }
       set
      {
//        if (value < 2)
//          throw new ArgumentOutOfRangeException(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(146), (object) value, BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(174));
				this.maxBlockSize = value; 
//				this.streamer.VmKuLwiT3(this); 
      }
    }

    [Browsable(true)]
    [Category("Settings")]
    [DefaultValue(1)]
    [Description("Gets or sets the zip level")]
    public int ZipLevel
    {
       get
      {
				return this.zipLevel;  
      }
       set
      {
//        if (value < 0 || value > 9)
//          throw new ArgumentOutOfRangeException(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(242), (object) value, BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(262));
        this.zipLevel = value;
//        this.streamer.VmKuLwiT3(this);
      }
    }

    [Browsable(false)]
    public Indexer Indexer
    {
       get
      {
				return this.indexer; 
      }
    }

    [Browsable(false)]
    public IndexStatus IndexStatus
    {
       get
      {
        if (this.indexer == Indexer.None)
          return IndexStatus.None;
        return this.lyMkX4DEV == -1L ? IndexStatus.Old : IndexStatus.Valid;
      }
    }

    [Browsable(false)]
    public int Count
    {
       get
      {
				return this.count; 
      }
    }

    [Browsable(false)]
    public DateTime FirstDateTime
    {
       get
      {
//        if (this.count == 0)
//          throw new InvalidOperationException(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(328));
//        else
					return this.firstDateTime; 
      }
    }

    [Browsable(false)]
    public DateTime LastDateTime
    {
       get
      {
//        if (this.count == 0)
//          throw new InvalidOperationException(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(370));
//        else
					return this.lastDateTime; 
      }
    }
	
		public object this[DateTime datetime] { 
			get {
				return this[datetime, SearchOption.Exact];
			} 
			set
			{
			}
		 }
		public object this[int index] 
		{ 
			get
			{
				return null;
			} 
		}

//    [Browsable(false)]
//    public ISeriesObject this[int index]
//    {
//      get
//      {
////        return this.streamer.mKEzFCE4r(this, index);
//				return null;
//      }
//    }

//    [Browsable(false)]
//		public object this[DateTime datetime]
//    {
//      get
//      {
//        return this[datetime, SearchOption.Exact];
//      }
//    }

    [Browsable(false)]
    public ISeriesObject this[DateTime datetime, SearchOption option]
    {
      get
      {
//        return this.streamer.CTsxsPQA1A(this, datetime, option);
				return null;
      }
    }

    [Browsable(false)]
    public int Position
    {
        get
      {
//        return this.streamer.LIixxmGnRR(this);
				return 0;
      }
       set
      {
//        this.streamer.fnHxdL12qe(this, value);
      }
    }

		internal FileSeries(/*FRJ1FMOwU8CAwJuZZf streamer,*/ string name, string description, int zipLevel, int maxBlockSize, Indexer indexer)
    {
      this.gJBOw3afc = -1L;
      this.dC0L5SwaN = -1L;
      this.hnKhMyEgT = -1L;
      this.firstDateTime = DateTime.MaxValue;
      this.lastDateTime = DateTime.MinValue;
      this.lyMkX4DEV = -1L;
//			this.streamer = streamer; 
			this.name = name; 
      this.description = description;
			this.zipLevel = zipLevel; 
			this.maxBlockSize = maxBlockSize; 
			this.indexer = indexer; 
    }

//    object IDataSeries.get_Item(int index)
//    {
//      return (object) this[index];
//    }

//    object IDataSeries.get_Item(DateTime datetime)
//    {
//      return (object) this[datetime];
//    }

//    void IDataSeries.set_Item(DateTime datetime, object value)
//    {
//    }

    
    public ISeriesObject[] GetArray()
    {
      return this.GetArray(DateTime.MinValue, DateTime.MaxValue);
    }

    public ISeriesObject[] GetArray(DateTime start, DateTime end)
    {
//      return this.streamer.TPxeRVXsG(this, start, end);
			return null;
    }

    public ISeriesObject[] GetArray(int beginIndex, int endIndex)
    {
//      return this.streamer.lcNUtVLQa(this, beginIndex, endIndex);
			return null;

   }

    public void Add(ISeriesObject obj)
    {
//      this.streamer.jGN7PFamp(this, obj);
    }

    public void Add(DateTime datetime, object obj)
    {
//      if (!(obj is ISeriesObject))
//        throw new ArgumentException(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(412));
      this.Add(obj as ISeriesObject);
    }

    public void Update(DateTime datetime, object obj)
    {
//      this.streamer.mrranh0iN(this, obj as ISeriesObject);
    }

    public void Update(int index, object obj)
    {
//      this.streamer.eb63Ogbkv(this, obj as ISeriesObject, index);
    }

    public void Flush()
    {
      this.Flush(false);
    }

    
    public void Flush(bool flushIndex)
    {
//      this.streamer.Dbgg6r6Wu(this, flushIndex);
    }

    public void Reindex(Indexer indexer)
    {
      this.indexer = indexer;
//      this.streamer.A3iIpmIeh(this);
    }

    public ISeriesObject Read()
    {
//      return this.streamer.e7bxHVj446(this);
			return null;
		}

    public int IndexOf(DateTime datetime, SearchOption option)
    {
//      return this.streamer.Ry8jC7als(this, datetime, option);
			return 0;
  }

    public int IndexOf(DateTime datetime)
    {
      return this.IndexOf(datetime, SearchOption.Exact);
    }

    public bool Contains(DateTime datetime)
    {
      return this.IndexOf(datetime) != -1;
    }

    public void Remove(DateTime datetime)
    {
//      this.streamer.loZx5NFiaR(this, datetime);
    }

    public void RemoveAt(int index)
    {
//      this.streamer.xZFxPvvctV(this, index);
    }

    public void Clear()
    {
//      this.streamer.POZxB2ZfIx(this);
    }

    public void CopyTo(FileSeries dstSeries, ISeriesFilter filter)
    {
      if (dstSeries == this)
				throw new ArgumentException("itself");
      if (filter == null)
      {
        foreach (ISeriesObject seriesObject in this)
          dstSeries.Add(seriesObject);
      }
      else
        filter.Copy(this, dstSeries);
    }

    public DateTime DateTimeAt(int index)
    {
//			return this[index].DateTime;
			return DateTime.Now;
    }

    public IEnumerator GetEnumerator()
    {
//      return (IEnumerator) new LPr0ffVt3PxRVXsGbc(this);
			return (IEnumerator)null;
		  
  }

    internal void TaaFdlDDd([In] string obj0)
    {
      this.name = obj0;
    }

//    private void DbvJxJl8B()
//    {
////      this.streamer.YEAxNKIbiu(this);
//    }
  }
}

// Type: SmartQuant.File.FileSeries
// Assembly: SmartQuant.File, Version=2.1.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 800E5EC7-67A0-489F-9F8A-77FDD5BCC547
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.File.dll

using ewT8148K2kiaMR21B7;
using Gtas8GL6N1OOIFdIHW;
using otVLQawybg6r6WuQ3i;
using SmartQuant.Data;
using SmartQuant.File.Indexing;
using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using XnjwSLRMyI3UA3fEbD;

namespace SmartQuant.File
{
  public class FileSeries : IDataSeries, IEnumerable
  {
    private const string TY1XmiAtV = "Settings";
    private const string TLQbrkLw3 = "Naming";
    internal long gJBOw3afc;
    internal long dC0L5SwaN;
    internal long hnKhMyEgT;
    internal DateTime WNpN6XDK2;
    internal DateTime DBX4Hgoww;
    internal int mv6pc1QUO;
    internal long lyMkX4DEV;
    private FRJ1FMOwU8CAwJuZZf FBmCPvV43;
    private string oBkENyUF4;
    private string k3F62jL6i;
    private int Ha4oIKnrY;
    private int M3ifyxP4m;
    private Indexer aHdVYLTHp;

    [Description("Gets the name of the series")]
    [Category("Naming")]
    [Browsable(true)]
    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.oBkENyUF4;
      }
    }

    [Browsable(true)]
    [Category("Naming")]
    [Description("Gets or sets the description")]
    public string Description
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.k3F62jL6i;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (value.Length > (int) sbyte.MaxValue)
          throw new ArgumentException(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(0), BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(120));
        this.k3F62jL6i = value;
        this.FBmCPvV43.VmKuLwiT3(this);
      }
    }

    [Category("Settings")]
    [DefaultValue(1000)]
    [Browsable(true)]
    [Description("Gets or sets the maximum block's size")]
    public int MaxBlockSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Ha4oIKnrY;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (value < 2)
          throw new ArgumentOutOfRangeException(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(146), (object) value, BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(174));
        this.Ha4oIKnrY = value;
        this.FBmCPvV43.VmKuLwiT3(this);
      }
    }

    [Browsable(true)]
    [Category("Settings")]
    [DefaultValue(1)]
    [Description("Gets or sets the zip level")]
    public int ZipLevel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.M3ifyxP4m;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (value < 0 || value > 9)
          throw new ArgumentOutOfRangeException(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(242), (object) value, BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(262));
        this.M3ifyxP4m = value;
        this.FBmCPvV43.VmKuLwiT3(this);
      }
    }

    [Browsable(false)]
    public Indexer Indexer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aHdVYLTHp;
      }
    }

    [Browsable(false)]
    public IndexStatus IndexStatus
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.aHdVYLTHp == Indexer.None)
          return IndexStatus.None;
        return this.lyMkX4DEV == -1L ? IndexStatus.Old : IndexStatus.Valid;
      }
    }

    [Browsable(false)]
    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.mv6pc1QUO;
      }
    }

    [Browsable(false)]
    public DateTime FirstDateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.mv6pc1QUO == 0)
          throw new InvalidOperationException(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(328));
        else
          return this.WNpN6XDK2;
      }
    }

    [Browsable(false)]
    public DateTime LastDateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.mv6pc1QUO == 0)
          throw new InvalidOperationException(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(370));
        else
          return this.DBX4Hgoww;
      }
    }

    [Browsable(false)]
    public ISeriesObject this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.FBmCPvV43.mKEzFCE4r(this, index);
      }
    }

    [Browsable(false)]
    public ISeriesObject this[DateTime datetime]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this[datetime, SearchOption.Exact];
      }
    }

    [Browsable(false)]
    public ISeriesObject this[DateTime datetime, SearchOption option]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.FBmCPvV43.CTsxsPQA1A(this, datetime, option);
      }
    }

    [Browsable(false)]
    public int Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.FBmCPvV43.LIixxmGnRR(this);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.FBmCPvV43.fnHxdL12qe(this, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal FileSeries(FRJ1FMOwU8CAwJuZZf streamer, string name, string description, int zipLevel, int maxBlockSize, Indexer indexer)
    {
      F45ZyD1Qi4NklFUbBa.aTsHghczyNAhO();
      this.gJBOw3afc = -1L;
      this.dC0L5SwaN = -1L;
      this.hnKhMyEgT = -1L;
      this.WNpN6XDK2 = DateTime.MaxValue;
      this.DBX4Hgoww = DateTime.MinValue;
      this.lyMkX4DEV = -1L;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.FBmCPvV43 = streamer;
      this.oBkENyUF4 = name;
      this.k3F62jL6i = description;
      this.M3ifyxP4m = zipLevel;
      this.Ha4oIKnrY = maxBlockSize;
      this.aHdVYLTHp = indexer;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    object IDataSeries.get_Item(int index)
    {
      return (object) this[index];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    object IDataSeries.get_Item(DateTime datetime)
    {
      return (object) this[datetime];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IDataSeries.set_Item(DateTime datetime, object value)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ISeriesObject[] GetArray()
    {
      return this.GetArray(DateTime.MinValue, DateTime.MaxValue);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ISeriesObject[] GetArray(DateTime start, DateTime end)
    {
      return this.FBmCPvV43.TPxeRVXsG(this, start, end);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ISeriesObject[] GetArray(int beginIndex, int endIndex)
    {
      return this.FBmCPvV43.lcNUtVLQa(this, beginIndex, endIndex);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(ISeriesObject obj)
    {
      this.FBmCPvV43.jGN7PFamp(this, obj);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(DateTime datetime, object obj)
    {
      if (!(obj is ISeriesObject))
        throw new ArgumentException(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(412));
      this.Add(obj as ISeriesObject);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update(DateTime datetime, object obj)
    {
      this.FBmCPvV43.mrranh0iN(this, obj as ISeriesObject);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update(int index, object obj)
    {
      this.FBmCPvV43.eb63Ogbkv(this, obj as ISeriesObject, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Flush()
    {
      this.Flush(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Flush(bool flushIndex)
    {
      this.FBmCPvV43.Dbgg6r6Wu(this, flushIndex);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reindex(Indexer indexer)
    {
      this.aHdVYLTHp = indexer;
      this.FBmCPvV43.A3iIpmIeh(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ISeriesObject Read()
    {
      return this.FBmCPvV43.e7bxHVj446(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int IndexOf(DateTime datetime, SearchOption option)
    {
      return this.FBmCPvV43.Ry8jC7als(this, datetime, option);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int IndexOf(DateTime datetime)
    {
      return this.IndexOf(datetime, SearchOption.Exact);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(DateTime datetime)
    {
      return this.IndexOf(datetime) != -1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(DateTime datetime)
    {
      this.FBmCPvV43.loZx5NFiaR(this, datetime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAt(int index)
    {
      this.FBmCPvV43.xZFxPvvctV(this, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.FBmCPvV43.POZxB2ZfIx(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(FileSeries dstSeries, ISeriesFilter filter)
    {
      if (dstSeries == this)
        throw new ArgumentException(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(564));
      if (filter == null)
      {
        foreach (ISeriesObject seriesObject in this)
          dstSeries.Add(seriesObject);
      }
      else
        filter.Copy(this, dstSeries);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTime DateTimeAt(int index)
    {
      return this[index].DateTime;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) new LPr0ffVt3PxRVXsGbc(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void TaaFdlDDd([In] string obj0)
    {
      this.oBkENyUF4 = obj0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DbvJxJl8B()
    {
      this.FBmCPvV43.YEAxNKIbiu(this);
    }
  }
}

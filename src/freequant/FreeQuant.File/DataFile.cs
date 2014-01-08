// Type: SmartQuant.File.DataFile
// Assembly: SmartQuant.File, Version=2.1.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 800E5EC7-67A0-489F-9F8A-77FDD5BCC547
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.File.dll

using ewT8148K2kiaMR21B7;
using Gtas8GL6N1OOIFdIHW;
using mrrnh0fiNPb6OgbkvN;
using mTHpUybYR3FeoBvmDB;
using SmartQuant.File.Indexing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using We5uQhNvsdYws8n5By;
using XnjwSLRMyI3UA3fEbD;

namespace FreeQuant.File
{
  public class DataFile
  {
    public const int DEFAULT_BLOCK_SIZE = 1000;
    public const int DEFAULT_ZIP_LEVEL = 1;
    private const string IKpx74PG28 = "file.xml";
    private const string sXOxauJbuu = "Defaults";
    private const string XNSx3dlhed = "Names";
    private const string CXyxc4Gx8u = "Status";
    private const string ANCxeHg9L1 = "Misc";
    private const string sVqxUQjMD3 = "config";
    private const string EdixgUvBGX = "properties";
    private const string nrTxIrLMcD = "description";
    private const string H2mxY8RfDl = "zip_level";
    private const string BWlxjFs2WR = "max_block_size";
    private const string FHyxzbKkrb = "indexer";
    private SeriesCollection series;
    private int defaultBlockSize;
    private int defaultZipLevel;
    private string name;
    private string description;
    private string location;
    private Indexer defaultIndexer;
    private string T2CdqZ3S6a;
    private XKnrYnX3iyxP4mxHdY cZGdvu7wXe;
    private EQJFquhB2QLQLSaG0F UQAdA9yU8P;
    private FRJ1FMOwU8CAwJuZZf TGQdFvfQ8H;
    private bool isOpen;

    [Browsable(true)]
    [Category("Names")]
    [Description("The name of the file")]
    public string Name
    {
        get
      {
				return this.name; 
      }
    }

    [Browsable(true)]
    [Description("Gets or sets the description")]
    [Category("Names")]
    public string Description
    {
      get
      {
				return this.description; 
      }
      set
      {
        this.description = value;
        this.DXbxTDioKH();
      }
    }

    [Description("Data files location")]
    [Browsable(true)]
    [Category("Misc")]
    public string Location
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
				return this.location; 
      }
    }

    [Browsable(false)]
    public SeriesCollection Series
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
				return this.series; 
      }
    }

    [Browsable(true)]
    [DefaultValue(1000)]
    [Category("Defaults")]
    [Description("Gets or sets the default block's size for the new series")]
    public int DefaultBlockSize
    {
       get
      {
				return this.defaultBlockSize; 
      }
       set
      {
        if (value < 2)
          throw new ArgumentOutOfRangeException(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2540), (object) value, BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2576));
        this.defaultBlockSize = value;
        this.DXbxTDioKH();
      }
    }

    [Description("Gets or sets the default zip level for the new series")]
    [Category("Defaults")]
    [DefaultValue(1)]
    [Browsable(true)]
    public int DefaultZipLevel
    {
       get
      {
				return this.defaultZipLevel; 
      }
        set
      {
        if (value < 0 || value > 9)
          throw new ArgumentOutOfRangeException(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2644), (object) value, BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2678));
        this.defaultZipLevel = value;
        this.DXbxTDioKH();
      }
    }

    [Category("Defaults")]
    [Browsable(false)]
    [Description("Gets or sets the indexing method for the new series")]
    public Indexer DefaultIndexer
    {
      get
      {
				return this.defaultIndexer; 
      }
      set
      {
        this.defaultIndexer = value;
        this.DXbxTDioKH();
      }
    }

    [Browsable(false)]
    public IDictionary<Type, byte> RegisteredTypes
    {
      get
      {
        return this.cZGdvu7wXe.Ss8QG6N1O();
      }
    }

    [Browsable(false)]
    public long DataFileSize
    {
      get
      {
        return this.TGQdFvfQ8H.B3hx4osn2A();
      }
    }

    [Browsable(false)]
    public long HeaderFileSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.TGQdFvfQ8H.povxkCCnpF();
      }
    }

    [Browsable(false)]
    public long IndexFileSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.TGQdFvfQ8H.vSVxEc7okY();
      }
    }

    [Browsable(false)]
    public bool IsOpen
    {
       get
      {
				return this.isOpen; 
      }
    }

    public event SeriesEventHandler SeriesDefragmentStarted;

    public event SeriesEventHandler SeriesDefragmentFinished;

    public event DefragmentCancelEventHandler DefragmentCancelRequest;

    public DataFile(string name, string location)
    {
      F45ZyD1Qi4NklFUbBa.aTsHghczyNAhO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      BigSBZoK4tJGNPFamp.NmWdePCboZ();
      this.location = new DirectoryInfo(location).FullName;
      this.name = name;
      this.description = "";
      this.T2CdqZ3S6a = this.Location + BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2506);
      this.Dewxid4agx();
    }

    public static DataFile Open(string location)
    {
      return new DataFile(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2528), location);
    }

    private void Dewxid4agx()
    {
      this.cZGdvu7wXe = new XKnrYnX3iyxP4mxHdY(this.Location);
      this.UQAdA9yU8P = new EQJFquhB2QLQLSaG0F(this.cZGdvu7wXe);
      this.TGQdFvfQ8H = new FRJ1FMOwU8CAwJuZZf(this.Location, (IFormatter) this.UQAdA9yU8P);
      this.defaultBlockSize = 1000;
      this.defaultZipLevel = 1;
      this.cAgxmaSvP5();
      this.series = new SeriesCollection(this);
      this.TGQdFvfQ8H.fg5iZaP12(this.series);
      this.isOpen = true;
    }

    public void Close()
    {
      if (!this.isOpen)
        return;
      foreach (FileSeries fileSeries in this.series)
        fileSeries.Flush();
      this.TGQdFvfQ8H.LCQ84w08t();
      this.series = new SeriesCollection(this);
      this.isOpen = false;
    }

    public void Defragment(int zipLevel, int maxBlockSize)
    {
      string path = this.Location + BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2744);
      Directory.CreateDirectory(path);
      this.TGQdFvfQ8H.PUnY2sLXa(path, this, zipLevel, maxBlockSize);
      Directory.Delete(path, true);
    }

    public void Defragment()
    {
      this.Defragment(this.defaultZipLevel, this.defaultBlockSize);
    }

    [SpecialName]
    internal FRJ1FMOwU8CAwJuZZf kBox0k2EsS()
    {
      return this.TGQdFvfQ8H;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void PwExuFCdRV([In] FileSeries obj0)
    {
      if (this.lIEdXL2Qo2 == null)
        return;
      this.lIEdXL2Qo2(new SeriesEventArgs(obj0));
    }

    internal void qoHxS5EmLT([In] FileSeries obj0)
    {
      if (this.KEEdbs3yRr == null)
        return;
      this.KEEdbs3yRr(new SeriesEventArgs(obj0));
    }

    internal void IsTxnSj3Fr([In] DefragmentCancelEventArgs obj0)
    {
      if (this.k72dOZBJZA == null)
        return;
      this.k72dOZBJZA(obj0);
    }

    private void cAgxmaSvP5()
    {
      try
      {
        if (File.Exists(this.T2CdqZ3S6a))
        {
          DataSet dataSet = new DataSet(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2758));
          DataTable dataTable = dataSet.Tables.Add(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2774));
          dataTable.Columns.Add(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2798), typeof (string));
          dataTable.Columns.Add(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2824), typeof (int));
          dataTable.Columns.Add(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2846), typeof (int));
          dataTable.Columns.Add(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2878), typeof (Indexer));
          int num = (int) dataSet.ReadXml(this.T2CdqZ3S6a, XmlReadMode.IgnoreSchema);
          DataRow dataRow = dataSet.Tables[BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2896)].Rows[0];
          this.description = (string) dataRow[BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2920)];
          this.defaultZipLevel = (int) dataRow[BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2946)];
          this.defaultBlockSize = (int) dataRow[BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(2968)];
          this.defaultIndexer = (Indexer) dataRow[BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(3000)];
        }
        else
          this.DXbxTDioKH();
      }
      catch (Exception ex)
      {
      }
    }

    private void DXbxTDioKH()
    {
      DataSet dataSet = new DataSet(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(3018));
      DataTable dataTable = dataSet.Tables.Add(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(3034));
      dataTable.Columns.Add(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(3058), typeof (string));
      dataTable.Columns.Add(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(3084), typeof (int));
      dataTable.Columns.Add(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(3106), typeof (int));
      dataTable.Columns.Add(BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(3138), typeof (Indexer));
      DataRow row = dataTable.NewRow();
      dataTable.Rows.Add(row);
      row[BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(3156)] = (object) this.description;
      row[BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(3182)] = (object) this.defaultZipLevel;
      row[BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(3204)] = (object) this.defaultBlockSize;
      row[BlZFvv9ctV0OZ2ZfIx.tWWdYtgAt1(3236)] = (object) this.defaultIndexer;
      dataSet.WriteXml(this.T2CdqZ3S6a, XmlWriteMode.WriteSchema);
    }
  }
}

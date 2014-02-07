using FreeQuant.File.Indexing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;

namespace FreeQuant.File
{
	public class DataFile
	{
		public const int DEFAULT_BLOCK_SIZE = 1000;
		public const int DEFAULT_ZIP_LEVEL = 1;

		private const string SCHEMA_FILE = "file.xml";
		private const string sXOxauJbuu = "Defaults";
		private const string XNSx3dlhed = "Names";
		private const string CXyxc4Gx8u = "Status";
		private const string ANCxeHg9L1 = "Misc";
		private const string sVqxUQjMD3 = "config";
		private const string EdixgUvBGX = "properties";
		private const string DESCRIPTION = "description";
		private const string ZIP_LEVEL = "zip_level";
		private const string MAX_BLOCK_SIZE = "max_block_size";
		private const string INDEXER = "indexer";
		private SeriesCollection series;
		private int defaultBlockSize;
		private int defaultZipLevel;
		private string description;
		private Indexer defaultIndexer;
		private string schemaFile;
//		private XKnrYnX3iyxP4mxHdY cZGdvu7wXe;
//		private EQJFquhB2QLQLSaG0F UQAdA9yU8P;
//		private FRJ1FMOwU8CAwJuZZf TGQdFvfQ8H;
		private bool isOpen;

		[Browsable(true)]
		[Category("Names")]
		[Description("The name of the file")]
		public string Name { get; private set; }

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
				this.WriteSchema();
			}
		}

		[Description("Data files location")]
		[Browsable(true)]
		[Category("Misc")]
		public string Location { get; private set; }

		[Browsable(false)]
		public SeriesCollection Series
		{
			get
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
					throw new ArgumentOutOfRangeException("value < 2: {0}", "");
				this.defaultBlockSize = value;
				this.WriteSchema();
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
					throw new ArgumentOutOfRangeException("value < 0 || value > 9 {0}", "");
				this.defaultZipLevel = value;
				this.WriteSchema();
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
				this.WriteSchema();
			}
		}

		[Browsable(false)]
		public IDictionary<Type, byte> RegisteredTypes
		{
			get
			{
//				return this.cZGdvu7wXe.Ss8QG6N1O();
				return null;
			}
		}

		[Browsable(false)]
		public long DataFileSize
		{
			get
			{
//				return this.TGQdFvfQ8H.B3hx4osn2A();
				return 0;
			}
		}

		[Browsable(false)]
		public long HeaderFileSize
		{
			 get
			{
//				return this.TGQdFvfQ8H.povxkCCnpF();
				return 0;
			}
		}

		[Browsable(false)]
		public long IndexFileSize
		{
			 get
			{
//				return this.TGQdFvfQ8H.vSVxEc7okY();
				return 0;
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
			this.Location = new DirectoryInfo(location).FullName;
			this.Name = name;
			this.description = string.Empty;
			this.schemaFile = this.Location + SCHEMA_FILE;
			this.Init();
		}

		public static DataFile Open(string location)
		{
			return new DataFile("name", location);
		}

		private void Init()
		{
//			this.cZGdvu7wXe = new XKnrYnX3iyxP4mxHdY(this.Location);
//			this.UQAdA9yU8P = new EQJFquhB2QLQLSaG0F(this.cZGdvu7wXe);
//			this.TGQdFvfQ8H = new FRJ1FMOwU8CAwJuZZf(this.Location, (IFormatter)this.UQAdA9yU8P);
			this.defaultBlockSize = 1000;
			this.defaultZipLevel = 1;
			this.LoadSchema();
			this.series = new SeriesCollection(this);
//			this.TGQdFvfQ8H.fg5iZaP12(this.series);
			this.isOpen = true;
		}

		public void Close()
		{
			if (!this.isOpen)
				return;
			foreach (FileSeries fileSeries in this.series)
				fileSeries.Flush();
//			this.TGQdFvfQ8H.LCQ84w08t();
			this.series = new SeriesCollection(this);
			this.isOpen = false;
		}

		public void Defragment(int zipLevel, int maxBlockSize)
		{
			string path = this.Location + "dd";
			Directory.CreateDirectory(path);
//			this.TGQdFvfQ8H.PUnY2sLXa(path, this, zipLevel, maxBlockSize);
			Directory.Delete(path, true);
		}

		public void Defragment()
		{
			this.Defragment(this.defaultZipLevel, this.defaultBlockSize);
		}

//		internal FRJ1FMOwU8CAwJuZZf kBox0k2EsS()
//		{
//			return this.TGQdFvfQ8H;
//		}

		
		internal void PwExuFCdRV(FileSeries obj0)
		{
//			if (this.lIEdXL2Qo2 == null)
//				return;
//			this.lIEdXL2Qo2(new SeriesEventArgs(obj0));
		}

		internal void qoHxS5EmLT(FileSeries obj0)
		{
//			if (this.KEEdbs3yRr == null)
//				return;
//			this.KEEdbs3yRr(new SeriesEventArgs(obj0));
		}

		internal void IsTxnSj3Fr(DefragmentCancelEventArgs e)
		{
			if (this.DefragmentCancelRequest != null) {
				this.DefragmentCancelRequest(e);
			}
		}

		private void LoadSchema()
		{
			try
			{
				if (System.IO.File.Exists(this.schemaFile))
				{
					DataSet dataSet = new DataSet("dataet");
					DataTable dataTable = dataSet.Tables.Add("tablename");
					dataTable.Columns.Add(DESCRIPTION, typeof(string));
					dataTable.Columns.Add(ZIP_LEVEL, typeof(int));
					dataTable.Columns.Add(MAX_BLOCK_SIZE, typeof(int));
					dataTable.Columns.Add(INDEXER, typeof(Indexer));
					dataSet.ReadXml(this.schemaFile, XmlReadMode.IgnoreSchema);
					DataRow row = dataSet.Tables["tablename"].Rows[0];
					this.description = (string)row[DESCRIPTION];
					this.defaultZipLevel = (int)row[ZIP_LEVEL];
					this.defaultBlockSize = (int)row[MAX_BLOCK_SIZE];
					this.defaultIndexer = (Indexer)row[INDEXER];
				}
				else
					this.WriteSchema();
			}
			catch
			{
			}
		}

		private void WriteSchema()
		{
			DataSet dataSet = new DataSet("adateset");
			DataTable dataTable = dataSet.Tables.Add("dataTable");
			dataTable.Columns.Add(DESCRIPTION, typeof(string));
			dataTable.Columns.Add(ZIP_LEVEL, typeof(int));
			dataTable.Columns.Add(MAX_BLOCK_SIZE, typeof(int));
			dataTable.Columns.Add(INDEXER, typeof(Indexer));
			DataRow row = dataTable.NewRow();
			dataTable.Rows.Add(row);
			row[DESCRIPTION] = this.description;
			row[ZIP_LEVEL] = this.defaultZipLevel;
			row[MAX_BLOCK_SIZE] = this.defaultBlockSize;
			row[INDEXER] = this.defaultIndexer;
			dataSet.WriteXml(this.schemaFile, XmlWriteMode.WriteSchema);
		}
	}
}

// Type: OpenQuant.Shared.Data.Import.TAQ.ImportSettings
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using OpenQuant.Shared.Data;
using System.IO;

namespace OpenQuant.Shared.Data.Import.TAQ
{
  internal class ImportSettings
  {
    private FileInfo taqDataFile;
    private FileInfo taqIndexFile;
    private DataFormatVersion dataFormatVersion;
    private DataType dataType;
    private SymbolOption symbolOption;
    private string[] symbols;

    public FileInfo TAQDataFile
    {
      get
      {
        return this.taqDataFile;
      }
      set
      {
        this.taqDataFile = value;
      }
    }

    public FileInfo TAQIndexFile
    {
      get
      {
        return this.taqIndexFile;
      }
      set
      {
        this.taqIndexFile = value;
      }
    }

    public DataFormatVersion DataFormatVersion
    {
      get
      {
        return this.dataFormatVersion;
      }
      set
      {
        this.dataFormatVersion = value;
      }
    }

    public DataType DataType
    {
      get
      {
        return this.dataType;
      }
      set
      {
        this.dataType = value;
      }
    }

    public SymbolOption SymbolOption
    {
      get
      {
        return this.symbolOption;
      }
      set
      {
        this.symbolOption = value;
      }
    }

    public string[] Symbols
    {
      get
      {
        return this.symbols;
      }
      set
      {
        this.symbols = value;
      }
    }

    public ImportSettings()
    {
      this.taqDataFile = (FileInfo) null;
      this.taqIndexFile = (FileInfo) null;
      this.dataFormatVersion = DataFormatVersion.Version1;
      this.dataType = DataType.Quote;
      this.symbolOption = SymbolOption.Existents;
      this.symbols = (string[]) null;
    }
  }
}

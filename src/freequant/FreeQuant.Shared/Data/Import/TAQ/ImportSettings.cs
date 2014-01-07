// Type: SmartQuant.Shared.Data.Import.TAQ.ImportSettings
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System.IO;
using System.Runtime.CompilerServices;

namespace SmartQuant.Shared.Data.Import.TAQ
{
  public class ImportSettings
  {
    private FileInfo OoZn9gfXp;
    private FileInfo cgB729ckl;
    private DataFormatVersion GuqLARiYy;
    private DataType cQuiVdlGs;
    private SymbolOption Y4E9oe16h;
    private string[] XIc3J9S4f;

    public FileInfo TAQDataFile
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OoZn9gfXp;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.OoZn9gfXp = value;
      }
    }

    public FileInfo TAQIndexFile
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.cgB729ckl;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.cgB729ckl = value;
      }
    }

    public DataFormatVersion DataFormatVersion
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GuqLARiYy;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.GuqLARiYy = value;
      }
    }

    public DataType DataType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.cQuiVdlGs;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.cQuiVdlGs = value;
      }
    }

    public SymbolOption SymbolOption
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Y4E9oe16h;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Y4E9oe16h = value;
      }
    }

    public string[] Symbols
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.XIc3J9S4f;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.XIc3J9S4f = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ImportSettings()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OoZn9gfXp = (FileInfo) null;
      this.cgB729ckl = (FileInfo) null;
      this.GuqLARiYy = DataFormatVersion.Version1;
      this.cQuiVdlGs = DataType.Quotes;
      this.Y4E9oe16h = SymbolOption.Existents;
      this.XIc3J9S4f = (string[]) null;
    }
  }
}

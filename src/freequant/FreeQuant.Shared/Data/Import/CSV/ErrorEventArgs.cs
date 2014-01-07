// Type: SmartQuant.Shared.Data.Import.CSV.ErrorEventArgs
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class ErrorEventArgs : EventArgs
  {
    private FileInfo sgPbbTAxY3;
    private string Sc2bVy2VcD;
    private string P8QbRbjsRQ;
    private int vU7bHGSVjt;
    private int kbubkXg8Tk;

    public FileInfo File
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.sgPbbTAxY3;
      }
    }

    public string Line
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Sc2bVy2VcD;
      }
    }

    public string Message
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.P8QbRbjsRQ;
      }
    }

    public int Row
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.vU7bHGSVjt;
      }
    }

    public int Column
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.kbubkXg8Tk;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ErrorEventArgs(FileInfo file, string line, string message, int row, int column)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.sgPbbTAxY3 = file;
      this.Sc2bVy2VcD = line;
      this.P8QbRbjsRQ = message;
      this.vU7bHGSVjt = row;
      this.kbubkXg8Tk = column;
    }
  }
}

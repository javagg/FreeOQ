// Type: SmartQuant.Shared.Data.Import.CSV.FileEventArgs
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class FileEventArgs : EventArgs
  {
    private FileInfo ATYdgQ6h0H;
    private FileStatus Q7OdM6TVN3;
    private int awIdJYrTF0;

    public FileInfo File
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ATYdgQ6h0H;
      }
    }

    public FileStatus Status
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Q7OdM6TVN3;
      }
    }

    public int ObjectCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.awIdJYrTF0;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FileEventArgs(FileInfo file, FileStatus status, int objectCount)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.ATYdgQ6h0H = file;
      this.Q7OdM6TVN3 = status;
      this.awIdJYrTF0 = objectCount;
    }
  }
}

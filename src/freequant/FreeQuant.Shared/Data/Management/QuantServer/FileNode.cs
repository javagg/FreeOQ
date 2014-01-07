// Type: SmartQuant.Shared.Data.Management.QuantServer.FileNode
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using SmartQuant.File;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SmartQuant.Shared.Data.Management.QuantServer
{
  public class FileNode : TreeNode
  {
    private DataFile Ao6uVnnZSa;

    public DataFile File
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Ao6uVnnZSa;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FileNode(DataFile file, int iconIndex)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector(file.Name, iconIndex, iconIndex);
      this.Ao6uVnnZSa = file;
    }
  }
}

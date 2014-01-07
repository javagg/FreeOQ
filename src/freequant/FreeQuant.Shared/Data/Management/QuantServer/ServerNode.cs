// Type: SmartQuant.Shared.Data.Management.QuantServer.ServerNode
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SmartQuant.Shared.Data.Management.QuantServer
{
  public class ServerNode : TreeNode
  {
    private int NXhu8FPooV;
    private int iyGu5fX37x;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ServerNode(string text, int collapsedIconIndex, int expandedIconIndex)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector(text);
      this.NXhu8FPooV = collapsedIconIndex;
      this.iyGu5fX37x = expandedIconIndex;
      this.UpdateIcon();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateIcon()
    {
      this.ImageIndex = this.SelectedImageIndex = this.IsExpanded ? this.iyGu5fX37x : this.NXhu8FPooV;
    }
  }
}

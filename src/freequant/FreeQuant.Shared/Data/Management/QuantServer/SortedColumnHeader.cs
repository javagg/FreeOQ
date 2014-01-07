// Type: SmartQuant.Shared.Data.Management.QuantServer.SortedColumnHeader
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SmartQuant.Shared.Data.Management.QuantServer
{
  public class SortedColumnHeader : ColumnHeader
  {
    private SortOrder SUYFSdXBj9;

    public SortOrder SortOrder
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.SUYFSdXBj9;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SortedColumnHeader(string text, int width, HorizontalAlignment alignment)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Text = text;
      this.Width = width;
      this.TextAlign = alignment;
      this.SUYFSdXBj9 = SortOrder.Ascending;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ChangeOrder()
    {
      switch (this.SUYFSdXBj9)
      {
        case SortOrder.Ascending:
          this.SUYFSdXBj9 = SortOrder.Descending;
          break;
        case SortOrder.Descending:
          this.SUYFSdXBj9 = SortOrder.Ascending;
          break;
      }
    }
  }
}

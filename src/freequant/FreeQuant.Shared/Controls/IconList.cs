// Type: SmartQuant.Shared.Controls.IconList
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SmartQuant.Shared.Controls
{
  [ToolboxBitmap(typeof (ImageList))]
  public class IconList : Component
  {
    private IconCollection NjgxpL8dmP;
    private Container BrWxNWdim6;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public IconCollection Icons
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.NjgxpL8dmP;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IconList(IContainer container)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      container.Add((IComponent) this);
      this.Tngx0hfVmZ();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IconList()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Tngx0hfVmZ();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.BrWxNWdim6 != null)
        this.BrWxNWdim6.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Tngx0hfVmZ()
    {
      this.BrWxNWdim6 = new Container();
      this.NjgxpL8dmP = new IconCollection();
    }
  }
}

// Type: SmartQuant.Shared.Controls.IconCollection
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.CompilerServices;

namespace SmartQuant.Shared.Controls
{
  [Editor(typeof (IconCollectionEditor), typeof (UITypeEditor))]
  public class IconCollection : CollectionBase
  {
    public Icon this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.List[index] as Icon;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IconCollection()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(Icon icon)
    {
      this.List.Add((object) icon);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddRange(Icon[] icons)
    {
      foreach (Icon icon in icons)
        this.Add(icon);
    }
  }
}

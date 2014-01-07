// Type: SmartQuant.Shared.Configuration.ReferenceViewItem
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using SmartQuant;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SmartQuant.Shared.Configuration
{
  public class ReferenceViewItem : ListViewItem
  {
    private Reference DkuxB5HrTK;

    public Reference Reference
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.DkuxB5HrTK;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ReferenceViewItem(Reference reference)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector(new string[3]);
      this.DkuxB5HrTK = reference;
      this.SubItems[0].Text = reference.AssemblyName.Name;
      this.SubItems[1].Text = ((object) reference.AssemblyName.Version).ToString();
      this.SubItems[2].Text = reference.Path;
      this.Checked = reference.Enabled;
      this.UpdateIcon();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateIcon()
    {
      if (this.DkuxB5HrTK.Valid)
        this.ImageIndex = this.DkuxB5HrTK.Enabled ? 0 : 1;
      else
        this.ImageIndex = 2;
    }
  }
}

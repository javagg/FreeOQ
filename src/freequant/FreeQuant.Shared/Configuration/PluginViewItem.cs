// Type: SmartQuant.Shared.Configuration.PluginViewItem
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using SmartQuant;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SmartQuant.Shared.Configuration
{
  public class PluginViewItem : ListViewItem
  {
    private Plugin nkUdm6YgxP;

    public Plugin Plugin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nkUdm6YgxP;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PluginViewItem(Plugin plugin)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector(new string[3]);
      this.nkUdm6YgxP = plugin;
      this.SubItems[0].Text = plugin.TypeName;
      this.SubItems[1].Text = plugin.AssemblyName;
      this.SubItems[2].Text = plugin.X64Supported.ToString();
      this.Checked = plugin.Enabled;
      this.UpdateIcon();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateIcon()
    {
      this.ImageIndex = this.nkUdm6YgxP.Loaded ? 0 : 1;
    }
  }
}

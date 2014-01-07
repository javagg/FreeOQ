// Type: SmartQuant.Shared.Configuration.GacViewItem
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SmartQuant.Shared.Configuration
{
  public class GacViewItem : ListViewItem
  {
    private AssemblyName ldeFvkRQ4R;

    public AssemblyName AssemblyName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ldeFvkRQ4R;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GacViewItem(AssemblyName assemblyName)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector(new string[3]);
      this.ldeFvkRQ4R = assemblyName;
      this.SubItems[0].Text = assemblyName.Name;
      this.SubItems[1].Text = ((object) assemblyName.Version).ToString();
      this.SubItems[2].Text = ((object) assemblyName.ProcessorArchitecture).ToString();
    }
  }
}

// Type: SmartQuant.Shared.Data.Management.QuantServer.FileViewItem
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using SmartQuant.File;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Management.QuantServer
{
  public class FileViewItem : ListViewItem
  {
    private DataFile a1td0l5P0x;

    public DataFile File
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.a1td0l5P0x;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FileViewItem(DataFile file, int iconIndex)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector(file.Name, iconIndex);
      this.a1td0l5P0x = file;
      this.SubItems.Add(file.Description);
      this.SubItems.Add(this.YlBdwdd96R((long) file.Series.Count));
      this.SubItems.Add(this.YlBdwdd96R(file.DataFileSize));
      this.SubItems.Add(this.YlBdwdd96R(file.HeaderFileSize));
      this.SubItems.Add(this.YlBdwdd96R(file.IndexFileSize));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string YlBdwdd96R([In] long obj0)
    {
      string str = obj0.ToString();
      int startIndex = str.Length - 3;
      while (startIndex > 0)
      {
        str = str.Insert(startIndex, RNaihRhYEl0wUmAftnB.aYu7exFQKN(11320));
        startIndex -= 3;
      }
      return str;
    }
  }
}

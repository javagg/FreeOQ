// Type: SmartQuant.Shared.Data.Import.CSV.FileViewItem
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class FileViewItem : ListViewItem
  {
    private FileInfo gDgFt4cfNr;

    public FileInfo File
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.gDgFt4cfNr;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FileViewItem(FileInfo file)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector(new string[3]);
      this.gDgFt4cfNr = file;
      this.SubItems[0].Text = file.Name;
      this.SubItems[1].Text = "";
      this.SubItems[2].Text = "";
      this.ImageIndex = -1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFileStatus(FileStatus status)
    {
      switch (status)
      {
        case FileStatus.Waiting:
          this.h9kFNwRSkp(RNaihRhYEl0wUmAftnB.aYu7exFQKN(12286), 0);
          break;
        case FileStatus.Importing:
          this.h9kFNwRSkp(RNaihRhYEl0wUmAftnB.aYu7exFQKN(12304), 1);
          break;
        case FileStatus.Testing:
          this.h9kFNwRSkp(RNaihRhYEl0wUmAftnB.aYu7exFQKN(12326), 4);
          break;
        case FileStatus.DoneOk:
          this.h9kFNwRSkp(RNaihRhYEl0wUmAftnB.aYu7exFQKN(12344), 2);
          break;
        case FileStatus.DoneError:
          this.h9kFNwRSkp(RNaihRhYEl0wUmAftnB.aYu7exFQKN(12356), 3);
          break;
        case FileStatus.Aborted:
          this.h9kFNwRSkp(RNaihRhYEl0wUmAftnB.aYu7exFQKN(12392), 5);
          break;
        default:
          throw new NotSupportedException(RNaihRhYEl0wUmAftnB.aYu7exFQKN(12410) + ((object) status).ToString());
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetObjectCount(int count)
    {
      if (count == -1)
      {
        this.SubItems[2].Text = "";
      }
      else
      {
        NumberFormatInfo numberFormatInfo = NumberFormatInfo.CurrentInfo.Clone() as NumberFormatInfo;
        numberFormatInfo.NumberDecimalDigits = 0;
        this.SubItems[2].Text = count.ToString(RNaihRhYEl0wUmAftnB.aYu7exFQKN(12448), (IFormatProvider) numberFormatInfo);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void h9kFNwRSkp([In] string obj0, [In] int obj1)
    {
      this.SubItems[1].Text = obj0;
      this.ImageIndex = obj1;
    }
  }
}

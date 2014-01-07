// Type: SmartQuant.Shared.Data.Management.QuantServer.SeriesViewItem
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using SmartQuant.File;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Management.QuantServer
{
  public class SeriesViewItem : ListViewItem
  {
    private FileSeries ndVlC7diZN;

    public FileSeries Series
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ndVlC7diZN;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SeriesViewItem(FileSeries series, int iconIndex)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector(series.Name, iconIndex);
      this.ndVlC7diZN = series;
      this.SubItems.Add(series.Count.ToString());
      if (series.Count == 0)
      {
        this.SubItems.Add(RNaihRhYEl0wUmAftnB.aYu7exFQKN(22050));
        this.SubItems.Add(RNaihRhYEl0wUmAftnB.aYu7exFQKN(22056));
      }
      else
      {
        this.SubItems.Add(series.FirstDateTime.ToShortDateString() + RNaihRhYEl0wUmAftnB.aYu7exFQKN(22062) + series.FirstDateTime.ToLongTimeString());
        this.SubItems.Add(series.LastDateTime.ToShortDateString() + RNaihRhYEl0wUmAftnB.aYu7exFQKN(22068) + series.LastDateTime.ToLongTimeString());
      }
      this.SubItems.Add(((object) series.Indexer).ToString());
      this.SubItems.Add(((object) series.IndexStatus).ToString());
    }
  }
}

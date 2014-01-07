// Type: OpenQuant.QuantBase.DataSeriesViewItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System.Windows.Forms;

namespace OpenQuant.QuantBase
{
  internal class DataSeriesViewItem : ListViewItem
  {
    public DataSeriesItem Item { get; private set; }

    public DataSeriesViewItem(DataSeriesItem item)
      : base(new string[4], 0)
    {
      this.Item = item;
      this.SubItems[0].Text = item.SH_Info.get_Symbol();
      this.SubItems[1].Text = item.QB_Info.Count.ToString("n0");
      if (item.QB_Info.Begin.HasValue)
        this.SubItems[2].Text = item.QB_Info.Begin.ToString();
      if (!item.QB_Info.End.HasValue)
        return;
      this.SubItems[3].Text = item.QB_Info.End.ToString();
    }
  }
}

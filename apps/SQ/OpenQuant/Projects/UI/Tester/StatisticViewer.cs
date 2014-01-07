// Type: OpenQuant.Projects.UI.Tester.StatisticViewer
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant;
using SmartQuant.Charting;
using SmartQuant.ExcelLib;
using System.Collections;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace OpenQuant.Projects.UI.Tester
{
  public abstract class StatisticViewer : Control
  {
    protected bool updateEnabled = true;
    protected string viewerName;
    protected ArrayList components;

    public bool UpdateEnabled
    {
      get
      {
        return this.updateEnabled;
      }
      set
      {
        this.updateEnabled = value;
      }
    }

    public string ViewerName
    {
      get
      {
        return this.viewerName;
      }
    }

    protected void CopyChartToWorksheet(Worksheet sheet, Chart chart)
    {
      string str = Framework.Installation.TempDir.FullName + "\\chart.bmp";
      chart.SaveImage(str, ImageFormat.Bmp);
      sheet.Activate();
      sheet.InsertPicture(str);
      File.Delete(str);
    }

    protected void CopyDataToWorksheet(Worksheet sheet, ListView view)
    {
      for (int index = 0; index < view.Columns.Count; ++index)
      {
        ColumnHeader columnHeader = view.Columns[index];
        Range range = sheet.GetRange(1, index + 1);
        range.set_Bold(true);
        range.set_Value((object) columnHeader.Text);
      }
      for (int index1 = 0; index1 < view.Items.Count; ++index1)
      {
        ListViewItem listViewItem = view.Items[index1];
        for (int index2 = 0; index2 < listViewItem.SubItems.Count; ++index2)
        {
          Range range = sheet.GetRange(index1 + 2, index2 + 1);
          if (listViewItem.SubItems[index2].Font.Italic)
            range.set_Italic(true);
          if (listViewItem.SubItems[index2].Font.Bold)
            range.set_Bold(true);
          if (listViewItem.SubItems[index2].Font.Underline)
            range.set_Underline(true);
          range.set_Value((object) listViewItem.SubItems[index2].Text);
        }
      }
    }

    public abstract void WriteToExcel(Worksheet sheet);

    public abstract void Disconnect();

    public abstract void Reset();

    public abstract void UpdateContent();
  }
}

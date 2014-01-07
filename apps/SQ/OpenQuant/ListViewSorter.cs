// Type: OpenQuant.ListViewSorter
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System;
using System.Collections;
using System.Windows.Forms;

namespace OpenQuant
{
  internal class ListViewSorter
  {
    private ListView listView;
    private ListViewSorter.ListViewItemComparer comparer;

    public ListViewSorter(ListView listView)
    {
      this.listView = listView;
      this.comparer = new ListViewSorter.ListViewItemComparer();
      listView.ListViewItemSorter = (IComparer) this.comparer;
      listView.ColumnClick += new ColumnClickEventHandler(this.listView_ColumnClick);
    }

    private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
    {
      if (this.comparer.Column != e.Column)
      {
        this.comparer.Column = e.Column;
        this.comparer.Ascending = true;
      }
      else
        this.comparer.Ascending = !this.comparer.Ascending;
      this.listView.Sort();
    }

    private class ListViewItemComparer : IComparer
    {
      public int Column;
      public bool Ascending;

      public ListViewItemComparer()
      {
        this.Column = 0;
        this.Ascending = true;
      }

      public int Compare(object x, object y)
      {
        string text1 = ((ListViewItem) x).SubItems[this.Column].Text;
        string text2 = ((ListViewItem) y).SubItems[this.Column].Text;
        double result1;
        double result2;
        DateTime result3;
        DateTime result4;
        return (this.Ascending ? 1 : -1) * (!double.TryParse(text1, out result1) || !double.TryParse(text2, out result2) ? (!DateTime.TryParse(text1, out result3) || !DateTime.TryParse(text2, out result4) ? text1.CompareTo(text2) : result3.CompareTo(result4)) : result1.CompareTo(result2));
      }
    }
  }
}

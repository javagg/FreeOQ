// Type: SmartQuant.Shared.Data.Management.QuantServer.ListViewItemComparer
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Management.QuantServer
{
  public class ListViewItemComparer : IComparer
  {
    private SortedColumnHeader VOBYVR4sSg;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ListViewItemComparer(SortedColumnHeader column)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.VOBYVR4sSg = column;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int Compare(object x, object y)
    {
      string text1 = ((ListViewItem) x).SubItems[this.VOBYVR4sSg.Index].Text;
      string text2 = ((ListViewItem) y).SubItems[this.VOBYVR4sSg.Index].Text;
      if (this.VOBYVR4sSg is StringColumn)
      {
        switch (this.VOBYVR4sSg.SortOrder)
        {
          case SortOrder.Ascending:
            return string.Compare(text1, text2);
          case SortOrder.Descending:
            return string.Compare(text2, text1);
        }
      }
      if (this.VOBYVR4sSg is IntegerColumn)
      {
        int num1 = int.Parse(text1.Replace(RNaihRhYEl0wUmAftnB.aYu7exFQKN(5280), ""));
        int num2 = int.Parse(text2.Replace(RNaihRhYEl0wUmAftnB.aYu7exFQKN(5286), ""));
        if (this.VOBYVR4sSg.SortOrder == SortOrder.Ascending)
        {
          if (num1 > num2)
            return 1;
          if (num1 < num2)
            return -1;
        }
        if (this.VOBYVR4sSg.SortOrder == SortOrder.Descending)
        {
          if (num1 > num2)
            return -1;
          if (num1 < num2)
            return 1;
        }
        return 0;
      }
      else if (this.VOBYVR4sSg is LongColumn)
      {
        long num1 = long.Parse(text1.Replace(RNaihRhYEl0wUmAftnB.aYu7exFQKN(5292), ""));
        long num2 = long.Parse(text2.Replace(RNaihRhYEl0wUmAftnB.aYu7exFQKN(5298), ""));
        if (this.VOBYVR4sSg.SortOrder == SortOrder.Ascending)
        {
          if (num1 > num2)
            return 1;
          if (num1 < num2)
            return -1;
        }
        if (this.VOBYVR4sSg.SortOrder == SortOrder.Descending)
        {
          if (num1 > num2)
            return -1;
          if (num1 < num2)
            return 1;
        }
        return 0;
      }
      else
      {
        if (this.VOBYVR4sSg is DateTimeColumn)
        {
          switch (this.VOBYVR4sSg.SortOrder)
          {
            case SortOrder.Ascending:
              return DateTime.Compare(DateTime.Parse(text1), DateTime.Parse(text2));
            case SortOrder.Descending:
              return DateTime.Compare(DateTime.Parse(text2), DateTime.Parse(text1));
          }
        }
        return 0;
      }
    }
  }
}

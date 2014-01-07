// Type: OpenQuant.BrokerInfo.BrokerPositionViewItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.FIX;
using SmartQuant.Providers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace OpenQuant.BrokerInfo
{
  internal class BrokerPositionViewItem : ListViewItem
  {
    private BrokerPosition position;

    public BrokerPosition Position
    {
      get
      {
        return this.position;
      }
    }

    public BrokerPositionViewItem(BrokerPosition position)
      : base(new string[5], 0)
    {
      this.position = position;
      List<string> list = new List<string>();
      list.Add(position.Symbol);
      switch (position.SecurityType)
      {
        case "FUT":
        case "OPT":
          list.Add(position.MaturityDate.ToString("MMMyy", (IFormatProvider) CultureInfo.InvariantCulture));
          if (position.SecurityType == "OPT")
          {
            list.Add(position.Strike.ToString((IFormatProvider) CultureInfo.InvariantCulture));
            switch (position.PutOrCall)
            {
              case PutOrCall.Put:
                list.Add("P");
                break;
              case PutOrCall.Call:
                list.Add("C");
                break;
            }
          }
          else
            break;
      }
      this.SubItems[0].Text = string.Join(" ", list.ToArray());
      this.SubItems[1].Text = position.SecurityExchange;
      this.SubItems[2].Text = position.Currency;
      this.SubItems[3].Text = position.LongQty.ToString("n0");
      this.SubItems[4].Text = position.ShortQty.ToString("n0");
    }
  }
}

// Type: OpenQuant.Orders.ExecutionReportViewItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Execution;
using SmartQuant.FIX;
using System.Windows.Forms;

namespace OpenQuant.Orders
{
  internal class ExecutionReportViewItem : ListViewItem
  {
    private ExecutionReport report;

    internal ExecutionReport Report
    {
      get
      {
        return this.report;
      }
    }

    internal ExecutionReportViewItem(ExecutionReport report)
      : base(new string[9])
    {
      this.report = report;
      SingleOrder singleOrder = report.ExecType == ExecType.PendingCancel || report.ExecType == ExecType.Cancelled || (report.ExecType == ExecType.PendingReplace || report.ExecType == ExecType.Replace) ? OrderManager.Orders.All[report.OrigClOrdID] as SingleOrder : OrderManager.Orders.All[report.ClOrdID] as SingleOrder;
      string format = singleOrder == null ? "F2" : singleOrder.Instrument.PriceDisplay;
      this.SubItems[0].Text = report.TransactTime.ToString();
      this.SubItems[1].Text = ((object) report.OrdStatus).ToString();
      this.SubItems[2].Text = report.OrderQty.ToString();
      this.SubItems[3].Text = report.CumQty.ToString();
      this.SubItems[4].Text = report.LeavesQty.ToString();
      this.SubItems[5].Text = report.LastQty.ToString();
      this.SubItems[6].Text = report.LastPx.ToString(format);
      this.SubItems[7].Text = report.AvgPx.ToString(format);
      this.SubItems[8].Text = report.Text;
    }
  }
}

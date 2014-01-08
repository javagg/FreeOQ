using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class ExecutionReportEventArgs : EventArgs
  {
    private NewOrderSingle KHOuJmbnBN;
    private ExecutionReport A0NurZyR7T;

    public NewOrderSingle Order
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.KHOuJmbnBN;
      }
    }

    public ExecutionReport ExecutionReport
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.A0NurZyR7T;
      }
    }

    public ExecutionReportEventArgs(NewOrderSingle order, ExecutionReport report)
    {
 
      this.KHOuJmbnBN = order;
      this.A0NurZyR7T = report;
    }

    public ExecutionReportEventArgs(ExecutionReport report)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      this.\u002Ector((NewOrderSingle) null, report);
    }
  }
}

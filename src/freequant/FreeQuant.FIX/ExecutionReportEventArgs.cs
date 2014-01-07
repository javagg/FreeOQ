using QjaKfQ9Jr3AV8F2T87;
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ExecutionReportEventArgs(NewOrderSingle order, ExecutionReport report)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.KHOuJmbnBN = order;
      this.A0NurZyR7T = report;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ExecutionReportEventArgs(ExecutionReport report)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      this.\u002Ector((NewOrderSingle) null, report);
    }
  }
}

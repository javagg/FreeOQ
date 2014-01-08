using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXTradeCaptureReportEventArgs : EventArgs
  {
    private FIXTradeCaptureReport JCeAwUv8cp;

    public FIXTradeCaptureReport TradeCaptureReport
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.JCeAwUv8cp;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.JCeAwUv8cp = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXTradeCaptureReportEventArgs(FIXTradeCaptureReport TradeCaptureReport)
    {
      this.JCeAwUv8cp = TradeCaptureReport;
    }
  }
}

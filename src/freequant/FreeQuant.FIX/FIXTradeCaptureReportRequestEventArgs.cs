using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXTradeCaptureReportRequestEventArgs : EventArgs
  {
    private FIXTradeCaptureReportRequest M0Bbp8088;

    public FIXTradeCaptureReportRequest TradeCaptureReportRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.M0Bbp8088;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.M0Bbp8088 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXTradeCaptureReportRequestEventArgs(FIXTradeCaptureReportRequest TradeCaptureReportRequest)
    {

      this.M0Bbp8088 = TradeCaptureReportRequest;
    }
  }
}

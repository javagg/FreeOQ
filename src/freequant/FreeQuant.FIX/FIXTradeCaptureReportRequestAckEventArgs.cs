using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXTradeCaptureReportRequestAckEventArgs : EventArgs
  {
    private FIXTradeCaptureReportRequestAck hm9ypqsewe;

    public FIXTradeCaptureReportRequestAck TradeCaptureReportRequestAck
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.hm9ypqsewe;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.hm9ypqsewe = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXTradeCaptureReportRequestAckEventArgs(FIXTradeCaptureReportRequestAck TradeCaptureReportRequestAck)
    {

      this.hm9ypqsewe = TradeCaptureReportRequestAck;
    }
  }
}

using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXTradeCaptureReportAckEventArgs : EventArgs
  {
    private FIXTradeCaptureReportAck lwvQL4ITKc;

    public FIXTradeCaptureReportAck TradeCaptureReportAck
    {
       get
      {
        return this.lwvQL4ITKc;
      }
        set
      {
        this.lwvQL4ITKc = value;
      }
    }

    public FIXTradeCaptureReportAckEventArgs(FIXTradeCaptureReportAck TradeCaptureReportAck)
    {
 
      this.lwvQL4ITKc = TradeCaptureReportAck;
    }
  }
}

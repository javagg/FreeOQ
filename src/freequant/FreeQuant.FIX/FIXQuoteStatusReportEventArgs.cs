using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXQuoteStatusReportEventArgs : EventArgs
  {
    private FIXQuoteStatusReport dUHuDElfBg;

    public FIXQuoteStatusReport QuoteStatusReport
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.dUHuDElfBg;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.dUHuDElfBg = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXQuoteStatusReportEventArgs(FIXQuoteStatusReport QuoteStatusReport)
    {
      this.dUHuDElfBg = QuoteStatusReport;
    }
  }
}

using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXCollateralInquiryEventArgs : EventArgs
  {
    private FIXCollateralInquiry qU4A045VVG;

    public FIXCollateralInquiry CollateralInquiry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.qU4A045VVG;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.qU4A045VVG = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXCollateralInquiryEventArgs(FIXCollateralInquiry CollateralInquiry)
    {
      this.qU4A045VVG = CollateralInquiry;
    }
  }
}

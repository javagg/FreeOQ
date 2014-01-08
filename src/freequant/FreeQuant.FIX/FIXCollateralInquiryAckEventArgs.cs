using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXCollateralInquiryAckEventArgs : EventArgs
  {
    private FIXCollateralInquiryAck MLshVPJwmg;

    public FIXCollateralInquiryAck CollateralInquiryAck
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.MLshVPJwmg;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.MLshVPJwmg = value;
      }
    }

    public FIXCollateralInquiryAckEventArgs(FIXCollateralInquiryAck CollateralInquiryAck)
    {
      this.MLshVPJwmg = CollateralInquiryAck;
    }
  }
}

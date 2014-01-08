using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXFinancingDetailsEventArgs : EventArgs
  {
    private FIXFinancingDetails m2j7fSbpQY;

    public FIXFinancingDetails FinancingDetails
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.m2j7fSbpQY;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.m2j7fSbpQY = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXFinancingDetailsEventArgs(FIXFinancingDetails FinancingDetails)
    {
      this.m2j7fSbpQY = FinancingDetails;
    }
  }
}

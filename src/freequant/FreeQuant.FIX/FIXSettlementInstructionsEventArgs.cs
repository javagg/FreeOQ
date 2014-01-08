using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSettlementInstructionsEventArgs : EventArgs
  {
    private FIXSettlementInstructions i4jUSKqmFy;

    public FIXSettlementInstructions SettlementInstructions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.i4jUSKqmFy;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.i4jUSKqmFy = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSettlementInstructionsEventArgs(FIXSettlementInstructions SettlementInstructions)
    {
      this.i4jUSKqmFy = SettlementInstructions;
    }
  }
}

using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSettlementInstructionRequestEventArgs : EventArgs
  {
    private FIXSettlementInstructionRequest naeUZ3hnkn;

    public FIXSettlementInstructionRequest SettlementInstructionRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.naeUZ3hnkn;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.naeUZ3hnkn = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSettlementInstructionRequestEventArgs(FIXSettlementInstructionRequest SettlementInstructionRequest)
    {
      this.naeUZ3hnkn = SettlementInstructionRequest;
    }
  }
}

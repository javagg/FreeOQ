using QjaKfQ9Jr3AV8F2T87;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXAllocationInstructionEventArgs : EventArgs
  {
    private FIXAllocationInstruction y04QRLaFbX;

    public FIXAllocationInstruction AllocationInstruction
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.y04QRLaFbX;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.y04QRLaFbX = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXAllocationInstructionEventArgs(FIXAllocationInstruction AllocationInstruction)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.y04QRLaFbX = AllocationInstruction;
    }
  }
}

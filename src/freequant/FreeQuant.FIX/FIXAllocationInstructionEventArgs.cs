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

    public FIXAllocationInstructionEventArgs(FIXAllocationInstruction AllocationInstruction)
    {
      this.y04QRLaFbX = AllocationInstruction;
    }
  }
}

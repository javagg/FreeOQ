using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXAllocationInstructionAckEventArgs : EventArgs
  {
    private FIXAllocationInstructionAck WGXu3eqZ40;

    public FIXAllocationInstructionAck AllocationInstructionAck
    {
        get
      {
        return this.WGXu3eqZ40;
      }
      set
      {
        this.WGXu3eqZ40 = value;
      }
    }

    public FIXAllocationInstructionAckEventArgs(FIXAllocationInstructionAck AllocationInstructionAck)
    {

      this.WGXu3eqZ40 = AllocationInstructionAck;
    }
  }
}

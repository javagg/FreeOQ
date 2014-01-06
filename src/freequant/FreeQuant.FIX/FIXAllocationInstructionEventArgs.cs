// Type: SmartQuant.FIX.FIXAllocationInstructionEventArgs
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
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

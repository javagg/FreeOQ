using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXHeartbeatEventArgs : EventArgs
  {
    private FIXHeartbeat MRayHxAgyK;

    public FIXHeartbeat Heartbeat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.MRayHxAgyK;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.MRayHxAgyK = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXHeartbeatEventArgs(FIXHeartbeat Heartbeat)
    {
      this.MRayHxAgyK = Heartbeat;
    }
  }
}

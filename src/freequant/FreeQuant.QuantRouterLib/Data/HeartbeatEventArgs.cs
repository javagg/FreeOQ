using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Data
{
  public class HeartbeatEventArgs : EventArgs
  {
    public Heartbeat Heartbeat { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public HeartbeatEventArgs(Heartbeat heartbeat)
    {
      this.Heartbeat = heartbeat;
    }
  }
}

using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Data
{
  public class TickEventArgs : EventArgs
  {
    public Tick Tick { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public TickEventArgs(Tick tick)
    {
      this.Tick = tick;
    }
  }
}

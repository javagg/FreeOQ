using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class SignalEventArgs : EventArgs
  {
    private Signal cKQi5NVTD4;

    public Signal Signal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.cKQi5NVTD4;
      }
    }
		s
    public SignalEventArgs(Signal signal)
    {
      this.cKQi5NVTD4 = signal;
    }
  }
}

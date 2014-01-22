using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class SignalEventArgs : EventArgs
  {
    private Signal cKQi5NVTD4;

    public Signal Signal
    {
       get
      {
        return this.cKQi5NVTD4;
      }
    }
		public SignalEventArgs(Signal signal) :base(signal)
    {
      this.cKQi5NVTD4 = signal;
    }
  }
}

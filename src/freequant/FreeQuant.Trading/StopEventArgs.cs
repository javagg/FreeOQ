
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class StopEventArgs : EventArgs
  {
    private IStop RAG6ls89dA;

    public IStop Stop
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.RAG6ls89dA;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopEventArgs(IStop stop)
    {
      this.RAG6ls89dA = stop;
    }
  }
}

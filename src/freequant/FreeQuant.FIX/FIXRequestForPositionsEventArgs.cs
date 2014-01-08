using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXRequestForPositionsEventArgs : EventArgs
  {
    private FIXRequestForPositions LbettOx4wa;

    public FIXRequestForPositions RequestForPositions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.LbettOx4wa;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.LbettOx4wa = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXRequestForPositionsEventArgs(FIXRequestForPositions RequestForPositions)
    {
      this.LbettOx4wa = RequestForPositions;
    }
  }
}

using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXRequestForPositionsAckEventArgs : EventArgs
  {
    private FIXRequestForPositionsAck jyltG8Tdcr;

    public FIXRequestForPositionsAck RequestForPositionsAck
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.jyltG8Tdcr;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.jyltG8Tdcr = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXRequestForPositionsAckEventArgs(FIXRequestForPositionsAck RequestForPositionsAck)
    {
      this.jyltG8Tdcr = RequestForPositionsAck;
    }
  }
}

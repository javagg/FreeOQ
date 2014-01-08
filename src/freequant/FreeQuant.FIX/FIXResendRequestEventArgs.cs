using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXResendRequestEventArgs : EventArgs
  {
    private FIXResendRequest aL8y0EMOPp;

    public FIXResendRequest ResendRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aL8y0EMOPp;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.aL8y0EMOPp = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXResendRequestEventArgs(FIXResendRequest ResendRequest)
    {
      this.aL8y0EMOPp = ResendRequest;
    }
  }
}

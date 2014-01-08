using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSecurityStatusRequestEventArgs : EventArgs
  {
    private FIXSecurityStatusRequest obfZooPsNY;

    public FIXSecurityStatusRequest SecurityStatusRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.obfZooPsNY;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.obfZooPsNY = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSecurityStatusRequestEventArgs(FIXSecurityStatusRequest SecurityStatusRequest)
    {
      this.obfZooPsNY = SecurityStatusRequest;
    }
  }
}

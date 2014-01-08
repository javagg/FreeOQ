using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSecurityTypeRequestEventArgs : EventArgs
  {
    private FIXSecurityTypeRequest XBZuLicKB8;

    public FIXSecurityTypeRequest SecurityTypeRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.XBZuLicKB8;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.XBZuLicKB8 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSecurityTypeRequestEventArgs(FIXSecurityTypeRequest SecurityTypeRequest)
    {
      this.XBZuLicKB8 = SecurityTypeRequest;
    }
  }
}

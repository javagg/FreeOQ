using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSecurityListRequestEventArgs : EventArgs
  {
    private FIXSecurityListRequest D8S7gZrBFl;

    public FIXSecurityListRequest SecurityListRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.D8S7gZrBFl;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.D8S7gZrBFl = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSecurityListRequestEventArgs(FIXSecurityListRequest SecurityListRequest)
    {
      this.D8S7gZrBFl = SecurityListRequest;
    }
  }
}

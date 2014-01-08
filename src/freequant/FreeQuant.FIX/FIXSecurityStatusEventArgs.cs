using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSecurityStatusEventArgs : EventArgs
  {
    private FIXSecurityStatus VCYt1iUg8B;

    public FIXSecurityStatus SecurityStatus
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.VCYt1iUg8B;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.VCYt1iUg8B = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSecurityStatusEventArgs(FIXSecurityStatus SecurityStatus)
    {
      this.VCYt1iUg8B = SecurityStatus;
    }
  }
}

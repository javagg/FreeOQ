using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXDerivativeSecurityListRequestEventArgs : EventArgs
  {
    private FIXDerivativeSecurityListRequest Mdfu9tegAY;

    public FIXDerivativeSecurityListRequest DerivativeSecurityListRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Mdfu9tegAY;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Mdfu9tegAY = value;
      }
    }

    public FIXDerivativeSecurityListRequestEventArgs(FIXDerivativeSecurityListRequest DerivativeSecurityListRequest)
    {
 
      this.Mdfu9tegAY = DerivativeSecurityListRequest;
    }
  }
}

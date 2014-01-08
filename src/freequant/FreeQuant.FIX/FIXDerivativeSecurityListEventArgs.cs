using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXDerivativeSecurityListEventArgs : EventArgs
  {
    private FIXDerivativeSecurityList EevyVDwmZd;

    public FIXDerivativeSecurityList DerivativeSecurityList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.EevyVDwmZd;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.EevyVDwmZd = value;
      }
    }

    public FIXDerivativeSecurityListEventArgs(FIXDerivativeSecurityList DerivativeSecurityList)
    {
      this.EevyVDwmZd = DerivativeSecurityList;
    }
  }
}

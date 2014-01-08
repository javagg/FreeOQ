using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXDontKnowTradeDKEventArgs : EventArgs
  {
    private FIXDontKnowTradeDK DXUuAFPKBG;

    public FIXDontKnowTradeDK DontKnowTradeDK
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.DXUuAFPKBG;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.DXUuAFPKBG = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXDontKnowTradeDKEventArgs(FIXDontKnowTradeDK DontKnowTradeDK)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.DXUuAFPKBG = DontKnowTradeDK;
    }
  }
}

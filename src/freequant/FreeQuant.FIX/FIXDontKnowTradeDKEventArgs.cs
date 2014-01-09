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

    public FIXDontKnowTradeDKEventArgs(FIXDontKnowTradeDK DontKnowTradeDK):base()
    {
      this.DXUuAFPKBG = DontKnowTradeDK;
    }
  }
}

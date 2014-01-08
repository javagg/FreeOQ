using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXCollateralResponseEventArgs : EventArgs
  {
    private FIXCollateralResponse fIP76YSy2m;

    public FIXCollateralResponse CollateralResponse
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fIP76YSy2m;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fIP76YSy2m = value;
      }
    }

    public FIXCollateralResponseEventArgs(FIXCollateralResponse CollateralResponse)
    {
      this.fIP76YSy2m = CollateralResponse;
    }
  }
}

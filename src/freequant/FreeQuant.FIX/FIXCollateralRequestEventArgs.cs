using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXCollateralRequestEventArgs : EventArgs
  {
    private FIXCollateralRequest Mwi85UHN0j;

    public FIXCollateralRequest CollateralRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Mwi85UHN0j;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Mwi85UHN0j = value;
      }
    }

    public FIXCollateralRequestEventArgs(FIXCollateralRequest CollateralRequest):base()
    {
      this.Mwi85UHN0j = CollateralRequest;
    }
  }
}

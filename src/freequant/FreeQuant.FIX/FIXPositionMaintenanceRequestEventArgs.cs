using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXPositionMaintenanceRequestEventArgs : EventArgs
  {
    private FIXPositionMaintenanceRequest pBR7jPJQHi;

    public FIXPositionMaintenanceRequest PositionMaintenanceRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.pBR7jPJQHi;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.pBR7jPJQHi = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXPositionMaintenanceRequestEventArgs(FIXPositionMaintenanceRequest PositionMaintenanceRequest)
    {
      this.pBR7jPJQHi = PositionMaintenanceRequest;
    }
  }
}

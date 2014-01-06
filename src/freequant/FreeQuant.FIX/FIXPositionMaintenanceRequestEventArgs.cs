// Type: SmartQuant.FIX.FIXPositionMaintenanceRequestEventArgs
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
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
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.pBR7jPJQHi = PositionMaintenanceRequest;
    }
  }
}

// Type: SmartQuant.FIX.FIXSecurityListRequestEventArgs
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
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
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.D8S7gZrBFl = SecurityListRequest;
    }
  }
}

// Type: SmartQuant.FIX.FIXResendRequestEventArgs
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXResendRequestEventArgs : EventArgs
  {
    private FIXResendRequest aL8y0EMOPp;

    public FIXResendRequest ResendRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aL8y0EMOPp;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.aL8y0EMOPp = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXResendRequestEventArgs(FIXResendRequest ResendRequest)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.aL8y0EMOPp = ResendRequest;
    }
  }
}

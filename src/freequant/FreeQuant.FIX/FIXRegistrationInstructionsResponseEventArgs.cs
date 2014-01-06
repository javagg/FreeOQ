// Type: SmartQuant.FIX.FIXRegistrationInstructionsResponseEventArgs
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXRegistrationInstructionsResponseEventArgs : EventArgs
  {
    private FIXRegistrationInstructionsResponse eI47ZR4J0A;

    public FIXRegistrationInstructionsResponse RegistrationInstructionsResponse
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.eI47ZR4J0A;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.eI47ZR4J0A = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXRegistrationInstructionsResponseEventArgs(FIXRegistrationInstructionsResponse RegistrationInstructionsResponse)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.eI47ZR4J0A = RegistrationInstructionsResponse;
    }
  }
}

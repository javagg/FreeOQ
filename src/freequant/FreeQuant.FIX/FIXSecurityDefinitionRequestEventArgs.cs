using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSecurityDefinitionRequestEventArgs : EventArgs
  {
    private FIXSecurityDefinitionRequest YeeYnqdZpm;

    public FIXSecurityDefinitionRequest SecurityDefinitionRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.YeeYnqdZpm;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.YeeYnqdZpm = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSecurityDefinitionRequestEventArgs(FIXSecurityDefinitionRequest SecurityDefinitionRequest)
    {
      this.YeeYnqdZpm = SecurityDefinitionRequest;
    }
  }
}

using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Data
{
  public class ProviderErrorEventArgs : EventArgs
  {
    public ProviderError Error { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public ProviderErrorEventArgs(ProviderError error)
    {
      this.Error = error;
    }
  }
}

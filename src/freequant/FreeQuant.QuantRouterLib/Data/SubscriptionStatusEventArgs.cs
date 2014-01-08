using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Data
{
  public class SubscriptionStatusEventArgs : EventArgs
  {
    public SubscriptionStatus Status { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public SubscriptionStatusEventArgs(SubscriptionStatus status)
    {
      this.Status = status;
    }
  }
}

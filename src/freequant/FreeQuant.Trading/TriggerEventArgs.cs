
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class TriggerEventArgs : EventArgs
  {
    private Trigger AP9RyINyCV;

    public Trigger Trigger
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.AP9RyINyCV;
      }
    }

    public TriggerEventArgs(Trigger trigger)
    {
      this.AP9RyINyCV = trigger;
    }
  }
}

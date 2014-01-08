using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class ComponentEventArgs : EventArgs
  {
    private ComponentRecord YYmW6wEAOK;

    public ComponentRecord Record
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.YYmW6wEAOK;
      }
    }

    public ComponentEventArgs(ComponentRecord record)
    {
      this.YYmW6wEAOK = record;
    }
  }
}

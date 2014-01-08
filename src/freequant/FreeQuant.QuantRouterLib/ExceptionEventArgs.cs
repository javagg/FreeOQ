using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib
{
  public class ExceptionEventArgs : EventArgs
  {
    public Exception Exception { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public ExceptionEventArgs(Exception exception)
    {
      this.Exception = exception;
    }
  }
}

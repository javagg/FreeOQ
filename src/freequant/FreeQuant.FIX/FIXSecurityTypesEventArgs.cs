using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSecurityTypesEventArgs : EventArgs
  {
    private FIXSecurityTypes grQtVhnBWf;

    public FIXSecurityTypes SecurityTypes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.grQtVhnBWf;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.grQtVhnBWf = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSecurityTypesEventArgs(FIXSecurityTypes SecurityTypes)
    {
      this.grQtVhnBWf = SecurityTypes;
    }
  }
}

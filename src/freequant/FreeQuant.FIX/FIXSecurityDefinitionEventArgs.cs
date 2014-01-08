using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSecurityDefinitionEventArgs : EventArgs
  {
    private FIXSecurityDefinition IFqhUJRJHm;

    public FIXSecurityDefinition SecurityDefinition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.IFqhUJRJHm;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.IFqhUJRJHm = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSecurityDefinitionEventArgs(FIXSecurityDefinition SecurityDefinition)
    {
      this.IFqhUJRJHm = SecurityDefinition;
    }
  }
}

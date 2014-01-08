using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSettlPartiesEventArgs : EventArgs
  {
    private FIXSettlParties FYGZtfdqIs;

    public FIXSettlParties SettlParties
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.FYGZtfdqIs;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.FYGZtfdqIs = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSettlPartiesEventArgs(FIXSettlParties SettlParties)
    {
      this.FYGZtfdqIs = SettlParties;
    }
  }
}

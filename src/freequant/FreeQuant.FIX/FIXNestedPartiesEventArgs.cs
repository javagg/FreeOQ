using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXNestedPartiesEventArgs : EventArgs
  {
    private FIXNestedParties OdeDkKhd3;

    public FIXNestedParties NestedParties
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OdeDkKhd3;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.OdeDkKhd3 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNestedPartiesEventArgs(FIXNestedParties NestedParties)
    {

      this.OdeDkKhd3 = NestedParties;
    }
  }
}

using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXNestedParties2EventArgs : EventArgs
  {
    private FIXNestedParties2 mNyQO3Bi62;

    public FIXNestedParties2 NestedParties2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.mNyQO3Bi62;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.mNyQO3Bi62 = value;
      }
    }

    public FIXNestedParties2EventArgs(FIXNestedParties2 NestedParties2)
    {
      this.mNyQO3Bi62 = NestedParties2;
    }
  }
}

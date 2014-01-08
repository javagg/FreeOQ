using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXNestedParties3EventArgs : EventArgs
  {
    private FIXNestedParties3 VrMQtuBK3T;

    public FIXNestedParties3 NestedParties3
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.VrMQtuBK3T;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.VrMQtuBK3T = value;
      }
    }

    public FIXNestedParties3EventArgs(FIXNestedParties3 NestedParties3)
    {
      this.VrMQtuBK3T = NestedParties3;
    }
  }
}

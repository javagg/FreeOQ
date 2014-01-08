using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXListStatusEventArgs : EventArgs
  {
    private FIXListStatus a5VU0I4vd8;

    public FIXListStatus ListStatus
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.a5VU0I4vd8;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.a5VU0I4vd8 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXListStatusEventArgs(FIXListStatus ListStatus)
    {
      this.a5VU0I4vd8 = ListStatus;
    }
  }
}

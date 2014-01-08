using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXListCancelRequestEventArgs : EventArgs
  {
    private FIXListCancelRequest EknQ5IW7Z4;

    public FIXListCancelRequest ListCancelRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.EknQ5IW7Z4;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.EknQ5IW7Z4 = value;
      }
    }

    public FIXListCancelRequestEventArgs(FIXListCancelRequest ListCancelRequest)
    {
      this.EknQ5IW7Z4 = ListCancelRequest;
    }
  }
}

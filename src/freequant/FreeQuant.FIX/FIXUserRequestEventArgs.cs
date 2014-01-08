using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXUserRequestEventArgs : EventArgs
  {
    private FIXUserRequest Y8mAbq1tRW;

    public FIXUserRequest UserRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Y8mAbq1tRW;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Y8mAbq1tRW = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXUserRequestEventArgs(FIXUserRequest UserRequest)
    {
      this.Y8mAbq1tRW = UserRequest;
    }
  }
}

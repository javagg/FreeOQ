using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXUserResponseEventArgs : EventArgs
  {
    private FIXUserResponse aUuyXt8cTr;

    public FIXUserResponse UserResponse
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aUuyXt8cTr;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.aUuyXt8cTr = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXUserResponseEventArgs(FIXUserResponse UserResponse)
    {

      this.aUuyXt8cTr = UserResponse;
    }
  }
}

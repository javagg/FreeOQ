using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXTestRequestEventArgs : EventArgs
  {
    private FIXTestRequest oGW7BTuRbM;

    public FIXTestRequest TestRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.oGW7BTuRbM;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.oGW7BTuRbM = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXTestRequestEventArgs(FIXTestRequest TestRequest)
    {

      this.oGW7BTuRbM = TestRequest;
    }
  }
}

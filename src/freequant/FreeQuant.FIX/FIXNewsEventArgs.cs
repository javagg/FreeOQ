using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXNewsEventArgs : EventArgs
  {
    private FIXNews WQhhYE78C3;

    public FIXNews News
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WQhhYE78C3;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.WQhhYE78C3 = value;
      }
    }

    public FIXNewsEventArgs(FIXNews News)
    {
      this.WQhhYE78C3 = News;
    }
  }
}

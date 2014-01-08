using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXStandardHeaderEventArgs : EventArgs
  {
    private FIXStandardHeader qVI8u8v4q5;

    public FIXStandardHeader StandardHeader
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.qVI8u8v4q5;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.qVI8u8v4q5 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXStandardHeaderEventArgs(FIXStandardHeader StandardHeader)
    {
      this.qVI8u8v4q5 = StandardHeader;
    }
  }
}

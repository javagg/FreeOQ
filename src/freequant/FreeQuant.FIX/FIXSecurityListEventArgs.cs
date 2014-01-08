using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSecurityListEventArgs : EventArgs
  {
    private FIXSecurityList TvJy2NHPkl;

    public FIXSecurityList SecurityList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.TvJy2NHPkl;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.TvJy2NHPkl = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSecurityListEventArgs(FIXSecurityList SecurityList)
    {
      this.TvJy2NHPkl = SecurityList;
    }
  }
}

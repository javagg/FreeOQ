using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXPartiesEventArgs : EventArgs
  {
    private FIXParties kFu6Tk2uN;

    public FIXParties Parties
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.kFu6Tk2uN;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.kFu6Tk2uN = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXPartiesEventArgs(FIXParties Parties)
    {
      this.kFu6Tk2uN = Parties;
    }
  }
}

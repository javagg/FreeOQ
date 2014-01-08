using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXIOIEventArgs : EventArgs
  {
    private FIXIOI xxDhaccKqs;

    public FIXIOI IOI
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.xxDhaccKqs;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.xxDhaccKqs = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXIOIEventArgs(FIXIOI IOI)
    {
      this.xxDhaccKqs = IOI;
    }
  }
}

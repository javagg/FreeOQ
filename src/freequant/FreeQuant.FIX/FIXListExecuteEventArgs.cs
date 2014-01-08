using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXListExecuteEventArgs : EventArgs
  {
    private FIXListExecute MZLUHqD5Uf;

    public FIXListExecute ListExecute
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.MZLUHqD5Uf;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.MZLUHqD5Uf = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXListExecuteEventArgs(FIXListExecute ListExecute)
    {
      this.MZLUHqD5Uf = ListExecute;
    }
  }
}

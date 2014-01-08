using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSequenceResetEventArgs : EventArgs
  {
    private FIXSequenceReset Cjm8Yk2XSG;

    public FIXSequenceReset SequenceReset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Cjm8Yk2XSG;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Cjm8Yk2XSG = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSequenceResetEventArgs(FIXSequenceReset SequenceReset)
    {
      this.Cjm8Yk2XSG = SequenceReset;
    }
  }
}

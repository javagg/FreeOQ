using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXNewOrderMultilegEventArgs : EventArgs
  {
    private FIXNewOrderMultileg aToYoskKrV;

    public FIXNewOrderMultileg NewOrderMultileg
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aToYoskKrV;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.aToYoskKrV = value;
      }
    }

    public FIXNewOrderMultilegEventArgs(FIXNewOrderMultileg NewOrderMultileg)
    {
      this.aToYoskKrV = NewOrderMultileg;
    }
  }
}

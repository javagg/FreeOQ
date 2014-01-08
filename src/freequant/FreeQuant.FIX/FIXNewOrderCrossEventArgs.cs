using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXNewOrderCrossEventArgs : EventArgs
  {
    private FIXNewOrderCross z7mtyhmjKc;

    public FIXNewOrderCross NewOrderCross
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.z7mtyhmjKc;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.z7mtyhmjKc = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNewOrderCrossEventArgs(FIXNewOrderCross NewOrderCross)
    {

      this.z7mtyhmjKc = NewOrderCross;
    }
  }
}

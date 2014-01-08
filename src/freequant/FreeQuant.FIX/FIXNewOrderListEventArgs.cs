using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXNewOrderListEventArgs : EventArgs
  {
    private FIXNewOrderList Fn4QAJeKX3;

    public FIXNewOrderList NewOrderList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Fn4QAJeKX3;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Fn4QAJeKX3 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNewOrderListEventArgs(FIXNewOrderList NewOrderList)
    {
      this.Fn4QAJeKX3 = NewOrderList;
    }
  }
}

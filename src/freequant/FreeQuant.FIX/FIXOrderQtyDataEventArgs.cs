using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXOrderQtyDataEventArgs : EventArgs
  {
    private FIXOrderQtyData QA2Ur8cuNX;

    public FIXOrderQtyData OrderQtyData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.QA2Ur8cuNX;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.QA2Ur8cuNX = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXOrderQtyDataEventArgs(FIXOrderQtyData OrderQtyData)
    {
      this.QA2Ur8cuNX = OrderQtyData;
    }
  }
}

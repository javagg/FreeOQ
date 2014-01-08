using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSettlInstructionsDataEventArgs : EventArgs
  {
    private FIXSettlInstructionsData sIoZ75IWY3;

    public FIXSettlInstructionsData SettlInstructionsData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.sIoZ75IWY3;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.sIoZ75IWY3 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSettlInstructionsDataEventArgs(FIXSettlInstructionsData SettlInstructionsData)
    {
      this.sIoZ75IWY3 = SettlInstructionsData;
    }
  }
}

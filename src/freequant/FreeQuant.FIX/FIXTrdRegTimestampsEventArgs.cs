using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXTrdRegTimestampsEventArgs : EventArgs
  {
    private FIXTrdRegTimestamps LbxtZpW0DN;

    public FIXTrdRegTimestamps TrdRegTimestamps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.LbxtZpW0DN;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.LbxtZpW0DN = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXTrdRegTimestampsEventArgs(FIXTrdRegTimestamps TrdRegTimestamps)
    {
      this.LbxtZpW0DN = TrdRegTimestamps;
    }
  }
}

// Type: SmartQuant.FIX.FIXAllocationReportEventArgs
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXAllocationReportEventArgs : EventArgs
  {
    private FIXAllocationReport y4UIdWAPE;

    public FIXAllocationReport AllocationReport
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.y4UIdWAPE;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.y4UIdWAPE = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXAllocationReportEventArgs(FIXAllocationReport AllocationReport)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.y4UIdWAPE = AllocationReport;
    }
  }
}

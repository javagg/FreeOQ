using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXCommissionDataEventArgs : EventArgs
  {
    private FIXCommissionData RabUm7TTtm;

    public FIXCommissionData CommissionData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.RabUm7TTtm;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.RabUm7TTtm = value;
      }
    }

    public FIXCommissionDataEventArgs(FIXCommissionData CommissionData)
    {
      this.RabUm7TTtm = CommissionData;
    }
  }
}

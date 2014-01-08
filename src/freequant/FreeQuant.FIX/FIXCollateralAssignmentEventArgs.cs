using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXCollateralAssignmentEventArgs : EventArgs
  {
    private FIXCollateralAssignment iGoylQj7F0;

    public FIXCollateralAssignment CollateralAssignment
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.iGoylQj7F0;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.iGoylQj7F0 = value;
      }
    }

	public FIXCollateralAssignmentEventArgs(FIXCollateralAssignment CollateralAssignment) : base()
    {

      this.iGoylQj7F0 = CollateralAssignment;
    }
  }
}

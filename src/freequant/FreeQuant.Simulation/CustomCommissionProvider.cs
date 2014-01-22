using FreeQuant.FIX;
using System.Runtime.CompilerServices;

namespace FreeQuant.Simulation
{
  public class CustomCommissionProvider : CommissionProvider
  {
    
		public CustomCommissionProvider() :base()
    {
      this.fCommType = CommType.PerShare;
      this.fCommission = 100.0;
    }
  }
}

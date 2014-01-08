using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSecurityAltIDGroupList : FIXGroupList
  {
    public FIXSecurityAltIDGroup this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fList[index] as FIXSecurityAltIDGroup;
      }
    }

  }
}

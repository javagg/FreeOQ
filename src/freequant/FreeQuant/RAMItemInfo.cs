using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant
{
  public class RAMItemInfo : InfoItemBase
  {
    public long Capacity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return 0L;
      }
    }
  }
}

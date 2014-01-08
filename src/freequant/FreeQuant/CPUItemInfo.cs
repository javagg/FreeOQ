using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant
{
  public class CPUItemInfo : InfoItemBase
  {
    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (string) null;
      }
    }

  }
}

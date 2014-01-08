using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant
{
  public class CPUInfo : InfoBase<CPUItemInfo>
  {
    public string NameString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (string) null;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal CPUInfo()
    {
    }
  }
}

using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXMDUpdateAction : FIXCharField
  {
    public const char New = '0';
    public const char Change = '1';
    public const char Delete = '2';

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXMDUpdateAction(char val):base(279, val)
    {
     }
  }
}

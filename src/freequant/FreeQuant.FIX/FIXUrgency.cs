using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXUrgency : FIXCharField
  {
    public const char Normal = '0';
    public const char Flash = '1';
    public const char Background = '2';

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXUrgency(char val)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector(61, val);
    }
  }
}

using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXUrgency : FIXCharField
  {
    public const char Normal = '0';
    public const char Flash = '1';
    public const char Background = '2';

    public FIXUrgency(char val) : base(10200, val)
    {
    }
  }
}

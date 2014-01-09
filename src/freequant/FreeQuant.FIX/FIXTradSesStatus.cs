using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXTradSesStatus : FIXIntField
  {
    public const int Halted = 1;
    public const int Open = 2;
    public const int Closed = 3;
    public const int PreOpen = 4;
    public const int PreClose = 5;

    public FIXTradSesStatus(int value):base(340, value)
    {
    }

    public static string ToString(int value)
    {
      switch (value)
      {
        case 1:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3294);
        case 2:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3310);
        case 3:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3322);
        case 4:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3338);
        case 5:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3358);
        default:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3380);
      }
    }
  }
}

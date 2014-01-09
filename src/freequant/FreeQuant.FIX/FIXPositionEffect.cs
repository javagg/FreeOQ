using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXPositionEffect : FIXCharField
  {
    public const char Open = 'O';
    public const char Close = 'C';
    public const char Rolled = 'R';
    public const char FIFO = 'F';

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXPositionEffect(char val):base(77, val)
    {

    }

    public static char Value(string Name)
    {
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(4224))
        return 'O';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(4236))
        return 'C';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(4250))
        return 'R';
      return Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(4266) ? 'F' : char.MinValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ToString(char c)
    {
      switch (c)
      {
        case 'O':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4278);
        case 'R':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4304);
        case 'C':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4290);
        case 'F':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4320);
        default:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4332);
      }
    }
  }
}

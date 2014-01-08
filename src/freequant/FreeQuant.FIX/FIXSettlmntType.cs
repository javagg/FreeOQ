using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSettlmntType : FIXCharField
  {
    public const char Regular = '0';
    public const char Cash = '1';
    public const char NextDay = '2';
    public const char Tplus2 = '3';
    public const char Tplus3 = '4';
    public const char Tplus4 = '5';
    public const char Future = '6';
    public const char WhenAndIfIssued = '7';
    public const char SellersOption = '8';
    public const char Tplus5 = '9';
    public const char Tplus1 = 'A';

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSettlmntType(char val)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector(63, val);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static char Value(string Name)
    {
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(2840))
        return '0';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(2858))
        return '1';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(2870))
        return '2';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(2888) || Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(2904))
        return 'A';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(2914) || Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(2930))
        return '3';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(2940) || Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(2956))
        return '4';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(2966) || Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(2982))
        return '5';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(2992) || Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(3008))
        return '9';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(3018))
        return '6';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(3034))
        return '7';
      return Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(3068) ? '8' : char.MinValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ToString(char c)
    {
      switch (c)
      {
        case '0':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3098);
        case '1':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3116);
        case '2':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3128);
        case '3':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3156);
        case '4':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3166);
        case '5':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3176);
        case '6':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3196);
        case '7':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3212);
        case '8':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3246);
        case '9':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3186);
        case 'A':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3146);
        default:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3276);
      }
    }
  }
}

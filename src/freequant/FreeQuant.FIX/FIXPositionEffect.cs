// Type: SmartQuant.FIX.FIXPositionEffect
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using iL6jh33hEcPk05eVIF;
using QjaKfQ9Jr3AV8F2T87;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXPositionEffect : FIXCharField
  {
    public const char Open = 'O';
    public const char Close = 'C';
    public const char Rolled = 'R';
    public const char FIFO = 'F';

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXPositionEffect(char val)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector(77, val);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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

// Type: SmartQuant.FIX.FIXTimeInForce
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using iL6jh33hEcPk05eVIF;
using QjaKfQ9Jr3AV8F2T87;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXTimeInForce : FIXCharField
  {
    public const char Day = '0';
    public const char GTC = '1';
    public const char OPG = '2';
    public const char IOC = '3';
    public const char FOK = '4';
    public const char GTX = '5';
    public const char GoodTillDate = '6';
    public const char AtTheClose = '7';
    public const char GoodForSeconds = 'X';

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXTimeInForce(char val)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector(59, val);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static char Value(string Name)
    {
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(3766))
        return '0';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(3776))
        return '1';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(3786))
        return '2';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(3796))
        return '3';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(3806))
        return '4';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(3816))
        return '5';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(3826))
        return '6';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(3854))
        return '7';
      return Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(3878) ? 'X' : char.MinValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ToString(char c)
    {
      switch (c)
      {
        case '0':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3910);
        case '1':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3920);
        case '2':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3930);
        case '3':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3940);
        case '4':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3950);
        case '5':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3960);
        case '6':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3970);
        case '7':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3998);
        case 'X':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4022);
        default:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4054);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TimeInForce FromFIX(char timeInForce)
    {
      switch (timeInForce)
      {
        case char.MinValue:
          return TimeInForce.Undefined;
        case '0':
          return TimeInForce.Day;
        case '1':
          return TimeInForce.GTC;
        case '2':
          return TimeInForce.OPG;
        case '3':
          return TimeInForce.IOC;
        case '4':
          return TimeInForce.FOK;
        case '5':
          return TimeInForce.GTX;
        case '6':
          return TimeInForce.GoodTillDate;
        case '7':
          return TimeInForce.AtTheClose;
        case 'X':
          return TimeInForce.GoodForSeconds;
        default:
          throw new ArgumentException(Ugjylcah9mCMM4kO7N.tLah92SpBQ(4072) + (object) timeInForce);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static char ToFIX(TimeInForce timeInForce)
    {
      switch (timeInForce)
      {
        case TimeInForce.Undefined:
          return char.MinValue;
        case TimeInForce.Day:
          return '0';
        case TimeInForce.GTC:
          return '1';
        case TimeInForce.OPG:
          return '2';
        case TimeInForce.IOC:
          return '3';
        case TimeInForce.FOK:
          return '4';
        case TimeInForce.GTX:
          return '5';
        case TimeInForce.GoodTillDate:
          return '6';
        case TimeInForce.AtTheClose:
          return '7';
        case TimeInForce.GoodForSeconds:
          return 'X';
        default:
          throw new ArgumentException(Ugjylcah9mCMM4kO7N.tLah92SpBQ(4124) + ((object) timeInForce).ToString());
      }
    }
  }
}

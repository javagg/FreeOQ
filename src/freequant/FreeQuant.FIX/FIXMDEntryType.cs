// Type: SmartQuant.FIX.FIXMDEntryType
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using iL6jh33hEcPk05eVIF;
using QjaKfQ9Jr3AV8F2T87;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXMDEntryType : FIXCharField
  {
    public const char Bid = '0';
    public const char Offer = '1';
    public const char Trade = '2';
    public const char Index = '3';
    public const char Open = '4';
    public const char Close = '5';
    public const char Settlement = '6';
    public const char High = '7';
    public const char Low = '8';
    public const char VWAP = '9';
    public const char Imbalance = 'A';

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXMDEntryType(char val)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector(269, val);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ToString(char c)
    {
      switch (c)
      {
        case '0':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39158);
        case '1':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39168);
        case '2':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39182);
        case '3':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39196);
        case '4':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39210);
        case '5':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39222);
        case '6':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39236);
        case '7':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39260);
        case '8':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39272);
        case '9':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39282);
        case 'A':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39294);
        default:
          throw new ArgumentException(Ugjylcah9mCMM4kO7N.tLah92SpBQ(39316) + (object) c);
      }
    }
  }
}

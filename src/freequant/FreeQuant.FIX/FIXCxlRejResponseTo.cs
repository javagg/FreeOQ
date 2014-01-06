// Type: SmartQuant.FIX.FIXCxlRejResponseTo
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using iL6jh33hEcPk05eVIF;
using QjaKfQ9Jr3AV8F2T87;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXCxlRejResponseTo : FIXCharField
  {
    public const char CancelRequest = '1';
    public const char CancelReplaceRequest = '2';

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXCxlRejResponseTo(char value)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector(434, value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CxlRejResponseTo FromFIX(char value)
    {
      switch (value)
      {
        case '1':
          return CxlRejResponseTo.CancelRequest;
        case '2':
          return CxlRejResponseTo.CancelReplaceRequest;
        default:
          throw new ArgumentException(string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(39362), (object) value));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static char ToFIX(CxlRejResponseTo response)
    {
      switch (response)
      {
        case CxlRejResponseTo.CancelRequest:
          return '1';
        case CxlRejResponseTo.CancelReplaceRequest:
          return '2';
        default:
          throw new ArgumentException(string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(39410), (object) response));
      }
    }
  }
}

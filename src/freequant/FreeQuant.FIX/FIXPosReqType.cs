// Type: SmartQuant.FIX.FIXPosReqType
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using iL6jh33hEcPk05eVIF;
using QjaKfQ9Jr3AV8F2T87;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXPosReqType : FIXIntField
  {
    public const int Positions = 0;
    public const int Trades = 1;
    public const int Exercises = 2;
    public const int Assignments = 3;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXPosReqType(int value)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector(724, value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PosReqType FromFIX(int value)
    {
      switch (value)
      {
        case 0:
          return PosReqType.Positions;
        case 1:
          return PosReqType.Trades;
        case 2:
          return PosReqType.Exercises;
        case 3:
          return PosReqType.Assignments;
        default:
          throw new ArgumentException(string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(38766), (object) value));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int ToFIX(PosReqType value)
    {
      switch (value)
      {
        case PosReqType.Positions:
          return 0;
        case PosReqType.Trades:
          return 1;
        case PosReqType.Exercises:
          return 2;
        case PosReqType.Assignments:
          return 3;
        default:
          throw new ArgumentException(string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(38840), (object) value));
      }
    }
  }
}

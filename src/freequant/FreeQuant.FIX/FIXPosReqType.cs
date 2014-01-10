using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXPosReqType : FIXIntField
  {
    public const int Positions = 0;
    public const int Trades = 1;
    public const int Exercises = 2;
    public const int Assignments = 3;

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
					throw new ArgumentException(string.Format("", (object) value));
      }
    }

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
					throw new ArgumentException(string.Format("", (object) value));
      }
    }
  }
}

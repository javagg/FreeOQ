using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSessionRejectReason : FIXIntField
  {
    public const int InvalidTagNumber = 0;
    public const int RequiredTagMissing = 1;
    public const int TagNotDefined = 2;
    public const int UndefinedTag = 3;
    public const int TagSpecifiedWithoutAValue = 4;
    public const int ValueIsIncorrect = 5;
    public const int IncorrectDataFormat = 6;
    public const int DecryptionProblem = 7;
    public const int SignatureProblem = 8;
    public const int CompIDProblem = 9;
    public const int SendingTimeAccuracyProblem = 10;
    public const int InvalidMsgType = 11;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSessionRejectReason(int value)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector(373, value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SessionRejectReason FromFIX(int value)
    {
      switch (value)
      {
        case 0:
          return SessionRejectReason.InvalidTagNumber;
        case 1:
          return SessionRejectReason.RequiredTagMissing;
        case 2:
          return SessionRejectReason.TagNotDefined;
        case 3:
          return SessionRejectReason.UndefinedTag;
        case 4:
          return SessionRejectReason.TagSpecifiedWithoutAValue;
        case 5:
          return SessionRejectReason.ValueIsIncorrect;
        case 6:
          return SessionRejectReason.IncorrectDataFormat;
        case 7:
          return SessionRejectReason.DecryptionProblem;
        case 8:
          return SessionRejectReason.SignatureProblem;
        case 9:
          return SessionRejectReason.CompIDProblem;
        case 10:
          return SessionRejectReason.SendingTimeAccuracyProblem;
        case 11:
          return SessionRejectReason.InvalidMsgType;
        default:
          throw new ArgumentException(string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(38540), (object) value));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int ToFIX(SessionRejectReason value)
    {
      switch (value)
      {
        case SessionRejectReason.InvalidTagNumber:
          return 0;
        case SessionRejectReason.RequiredTagMissing:
          return 1;
        case SessionRejectReason.TagNotDefined:
          return 2;
        case SessionRejectReason.UndefinedTag:
          return 3;
        case SessionRejectReason.TagSpecifiedWithoutAValue:
          return 4;
        case SessionRejectReason.ValueIsIncorrect:
          return 5;
        case SessionRejectReason.IncorrectDataFormat:
          return 6;
        case SessionRejectReason.DecryptionProblem:
          return 7;
        case SessionRejectReason.SignatureProblem:
          return 8;
        case SessionRejectReason.CompIDProblem:
          return 9;
        case SessionRejectReason.SendingTimeAccuracyProblem:
          return 10;
        case SessionRejectReason.InvalidMsgType:
          return 11;
        default:
          throw new ArgumentException(string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(38614), (object) value));
      }
    }
  }
}

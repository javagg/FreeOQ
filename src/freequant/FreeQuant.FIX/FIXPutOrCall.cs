using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXPutOrCall : FIXIntField
  {
    public const int Put = 0;
    public const int Call = 1;

    public FIXPutOrCall(int val):base(201, val)
    {
    }

    public static string ToString(int i)
    {
      switch (i)
      {
        case 0:
					return "Put";
        case 1:
					return "Call";
        default:
					return "[invalid]";
      }
    }

    public static PutOrCall FromFIX(int value)
    {
      switch (value)
      {
        case 0:
          return PutOrCall.Put;
        case 1:
          return PutOrCall.Call;
        default:
					throw new ArgumentException(string.Format("err: ", (object) value));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int ToFIX(PutOrCall value)
    {
      switch (value)
      {
        case PutOrCall.Put:
          return 0;
        case PutOrCall.Call:
          return 1;
        default:
					throw new ArgumentException(string.Format("err: ", (object) value));
      }
    }
  }
}

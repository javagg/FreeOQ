using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXFaMethod : FIXStringField
  {
    public const string PctChange = "PctChange";
    public const string AvailableEquity = "AvailableEquity";
    public const string NetLiq = "NetLiq";
    public const string EqualQuantity = "EqualQuantity";

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXFaMethod(string value)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector(10710, value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ToFIX(FaMethod value)
    {
      switch (value)
      {
        case FaMethod.PctChange:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(2038);
        case FaMethod.AvailableEquity:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1958);
        case FaMethod.NetLiq:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(2022);
        case FaMethod.EqualQuantity:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1992);
        default:
          throw new ArgumentException(string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(2060), (object) value));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static FaMethod FromFIX(string value)
    {
      string str;
      if ((str = value) != null)
      {
        if (str == Ugjylcah9mCMM4kO7N.tLah92SpBQ(2126))
          return FaMethod.AvailableEquity;
        if (str == Ugjylcah9mCMM4kO7N.tLah92SpBQ(2160))
          return FaMethod.EqualQuantity;
        if (str == Ugjylcah9mCMM4kO7N.tLah92SpBQ(2190))
          return FaMethod.NetLiq;
        if (str == Ugjylcah9mCMM4kO7N.tLah92SpBQ(2206))
          return FaMethod.PctChange;
      }
      return FaMethod.Undefined;
    }
  }
}

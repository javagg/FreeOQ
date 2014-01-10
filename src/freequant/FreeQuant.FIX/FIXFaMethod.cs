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


    public FIXFaMethod(string value):base(10710, value)
    {

    }

    public static string ToFIX(FaMethod value)
    {
      switch (value)
      {
        case FaMethod.PctChange:
					return "PctChange";
        case FaMethod.AvailableEquity:
					return "AvailableEquity";
        case FaMethod.NetLiq:
					return "NetLiq";
        case FaMethod.EqualQuantity:
					return "EqualQuantity";
        default:
					throw new ArgumentException(string.Format("Error: ", (object) value));
      }
    }

    public static FaMethod FromFIX(string value)
    {
      string str;
      if ((str = value) != null)
      {
				if (str == "PctChange")
          return FaMethod.AvailableEquity;
				if (str == "AvailableEquity")
          return FaMethod.EqualQuantity;
				if (str == "NetLiq")
          return FaMethod.NetLiq;
				if (str == "EqualQuantity")
          return FaMethod.PctChange;
      }
      return FaMethod.Undefined;
    }
  }
}

using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXCommType : FIXCharField
  {
    public const char PerShare = '1';
    public const char Percent = '2';
    public const char Absolute = '3';
    public const char PctWaivedCshDisc = '4';
    public const char PctWaivedEnUnits = '5';
    public const char PerBond = '6';


    public FIXCommType(char val):  base(13, val)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static char ToFIX(CommType value)
    {
      switch (value)
      {
        case CommType.PerShare:
          return '1';
        case CommType.Percent:
          return '2';
        case CommType.Absolute:
          return '3';
        case CommType.PctWaivedCshDisc:
          return '4';
        case CommType.PctWaivedEnUnits:
          return '5';
        case CommType.PerBond:
          return '6';
        default:
          throw new ArgumentException(string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(40108), (object) value));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CommType FromFIX(char value)
    {
      switch (value)
      {
        case '1':
          return CommType.PerShare;
        case '2':
          return CommType.Percent;
        case '3':
          return CommType.Absolute;
        case '4':
          return CommType.PctWaivedCshDisc;
        case '5':
          return CommType.PctWaivedEnUnits;
        case '6':
          return CommType.PerBond;
        default:
          return CommType.Absolute;
      }
    }
  }
}

// Type: SmartQuant.FIX.FIXCommType
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using iL6jh33hEcPk05eVIF;
using QjaKfQ9Jr3AV8F2T87;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXCommType : FIXCharField
  {
    public const char PerShare = '1';
    public const char Percent = '2';
    public const char Absolute = '3';
    public const char PctWaivedCshDisc = '4';
    public const char PctWaivedEnUnits = '5';
    public const char PerBond = '6';

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXCommType(char val)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector(13, val);
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

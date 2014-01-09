using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXExecTransType : FIXCharField
  {
    public const char New = '0';
    public const char Cancel = '1';
    public const char Correct = '2';
    public const char Status = '3';

    public FIXExecTransType(char value) : base(20, value)
    {
    }

    public static ExecTransType FromFIX(char value)
    {
      switch (value)
      {
        case '0':
          return ExecTransType.New;
        case '1':
          return ExecTransType.Cancel;
        case '2':
          return ExecTransType.Correct;
        case '3':
          return ExecTransType.Status;
        default:
          throw new ArgumentException(string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(39458), (object) value));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static char ToFIX(ExecTransType value)
    {
      switch (value)
      {
        case ExecTransType.New:
          return '0';
        case ExecTransType.Cancel:
          return '1';
        case ExecTransType.Correct:
          return '2';
        case ExecTransType.Status:
          return '3';
        default:
          throw new ArgumentException(string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(39520), (object) value));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ToString(char c)
    {
      switch (c)
      {
        case '0':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39582);
        case '1':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39592);
        case '2':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39608);
        case '3':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39626);
        default:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(39642);
      }
    }
  }
}

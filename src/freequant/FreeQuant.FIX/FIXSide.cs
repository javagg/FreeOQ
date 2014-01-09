using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSide : FIXCharField
  {
    public const char Buy = '1';
    public const char Sell = '2';
    public const char BuyMinus = '3';
    public const char SellPlus = '4';
    public const char SellShort = '5';
    public const char SellShortExempt = '6';
    public const char Undisclosed = '7';
    public const char Cross = '8';
    public const char CrossShort = '9';
    public const char CrossShortExempt = 'A';
    public const char AsDefined = 'B';
    public const char Opposite = 'C';

    public FIXSide(char val):base(54, val)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static char Value(string Name)
    {
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(4526))
        return '1';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(4536))
        return '2';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(4548))
        return '3';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(4568))
        return '4';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(4588))
        return '5';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(4610))
        return '6';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(4644))
        return '7';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(4670))
        return '8';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(4684))
        return '9';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(4708))
        return 'A';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(4744))
        return 'B';
      return Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(4766) ? 'C' : char.MinValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ToString(char c)
    {
      switch (c)
      {
        case '1':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4786);
        case '2':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4796);
        case '3':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4808);
        case '4':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4828);
        case '5':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4848);
        case '6':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4870);
        case '7':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4904);
        case '8':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4930);
        case '9':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4944);
        case 'A':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(4968);
        case 'B':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(5004);
        case 'C':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(5026);
        default:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(5046);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Side FromFIX(char side)
    {
      switch (side)
      {
        case '1':
          return Side.Buy;
        case '2':
          return Side.Sell;
        case '3':
          return Side.BuyMinus;
        case '4':
          return Side.SellPlus;
        case '5':
          return Side.SellShort;
        case '6':
          return Side.SellShortExempt;
        case '7':
          return Side.Undisclosed;
        case '8':
          return Side.Cross;
        case '9':
          return Side.CrossShort;
        case 'A':
          return Side.CrossShortExempt;
        case 'B':
          return Side.AsDefined;
        case 'C':
          return Side.Opposite;
        default:
          throw new Exception(Ugjylcah9mCMM4kO7N.tLah92SpBQ(5064) + (object) side);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static char ToFIX(Side side)
    {
      switch (side)
      {
        case Side.Buy:
          return '1';
        case Side.Sell:
          return '2';
        case Side.BuyMinus:
          return '3';
        case Side.SellPlus:
          return '4';
        case Side.SellShort:
          return '5';
        case Side.SellShortExempt:
          return '6';
        case Side.Undisclosed:
          return '7';
        case Side.Cross:
          return '8';
        case Side.CrossShort:
          return '9';
        case Side.CrossShortExempt:
          return 'A';
        case Side.AsDefined:
          return 'B';
        case Side.Opposite:
          return 'C';
        default:
          throw new Exception(Ugjylcah9mCMM4kO7N.tLah92SpBQ(5098) + ((object) side).ToString());
      }
    }
  }
}

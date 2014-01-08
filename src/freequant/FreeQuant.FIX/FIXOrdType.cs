using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXOrdType : FIXCharField
  {
    public const char Market = '1';
    public const char Limit = '2';
    public const char Stop = '3';
    public const char StopLimit = '4';
    public const char MarketOnClose = '5';
    public const char WithOrWithout = '6';
    public const char LimitOrBetter = '7';
    public const char LimitWithOrWithout = '8';
    public const char OnBasis = '9';
    public const char OnClose = 'A';
    public const char LimitOnClose = 'B';
    public const char ForexMarket = 'C';
    public const char PreviouslyQuoted = 'D';
    public const char PreviouslyIndicated = 'E';
    public const char ForexLimit = 'F';
    public const char ForexSwap = 'G';
    public const char ForexPreviouslyQuoted = 'H';
    public const char Funari = 'I';
    public const char MIT = 'J';
    public const char MarketWithLeftoverAsLimit = 'K';
    public const char PreviousFundValuationPoint = 'L';
    public const char NextFundValuationPoint = 'M';
    public const char Pegged = 'P';
    public const char TrailingStop = 'T';
    public const char TrailingStopLimit = 'S';

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXOrdType(char val)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector(40, val);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static char Value(string Name)
    {
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(540))
        return '1';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(556))
        return '2';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(570))
        return '3';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(582))
        return '4';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(604))
        return '5';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(634))
        return '6';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(664))
        return '7';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(694))
        return '8';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(734))
        return '9';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(752))
        return 'A';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(770))
        return 'B';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(798))
        return 'C';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(824))
        return 'D';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(860))
        return 'E';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(902))
        return 'F';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(926))
        return 'G';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(948))
        return 'H';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(994))
        return 'I';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(1010))
        return 'J';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(1020))
        return 'K';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(1074))
        return 'L';
      if (Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(1130))
        return 'M';
      return Name == Ugjylcah9mCMM4kO7N.tLah92SpBQ(1178) ? 'P' : char.MinValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ToString(char c)
    {
      switch (c)
      {
        case '1':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1194);
        case '2':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1210);
        case '3':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1224);
        case '4':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1236);
        case '5':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1258);
        case '6':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1288);
        case '7':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1318);
        case '8':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1348);
        case '9':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1388);
        case 'A':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1406);
        case 'B':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1424);
        case 'C':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1452);
        case 'D':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1478);
        case 'E':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1514);
        case 'F':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1556);
        case 'G':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1580);
        case 'H':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1602);
        case 'I':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1648);
        case 'J':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1664);
        case 'K':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1674);
        case 'L':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1728);
        case 'M':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1784);
        case 'P':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1832);
        default:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(1848);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static OrdType FromFIX(char ordType)
    {
      switch (ordType)
      {
        case '1':
          return OrdType.Market;
        case '2':
          return OrdType.Limit;
        case '3':
          return OrdType.Stop;
        case '4':
          return OrdType.StopLimit;
        case '5':
          return OrdType.MarketOnClose;
        case '6':
          return OrdType.WithOrWithout;
        case '7':
          return OrdType.LimitOrBetter;
        case '8':
          return OrdType.LimitWithOrWithout;
        case '9':
          return OrdType.OnBasis;
        case 'A':
          return OrdType.OnClose;
        case 'B':
          return OrdType.LimitOnClose;
        case 'C':
          return OrdType.ForexMarket;
        case 'D':
          return OrdType.PreviouslyQuoted;
        case 'E':
          return OrdType.PreviouslyIndicated;
        case 'F':
          return OrdType.ForexLimit;
        case 'G':
          return OrdType.ForexSwap;
        case 'H':
          return OrdType.ForexPreviouslyQuoted;
        case 'I':
          return OrdType.Funari;
        case 'J':
          return OrdType.MIT;
        case 'K':
          return OrdType.MarketWithLeftoverAsLimit;
        case 'L':
          return OrdType.PreviousFundValuationPoint;
        case 'M':
          return OrdType.NextFundValuationPoint;
        case 'P':
          return OrdType.Pegged;
        case 'S':
          return OrdType.TrailingStopLimit;
        case 'T':
          return OrdType.TrailingStop;
        default:
          throw new ArgumentException(Ugjylcah9mCMM4kO7N.tLah92SpBQ(1866) + (object) ordType);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static char ToFIX(OrdType ordType)
    {
      switch (ordType)
      {
        case OrdType.Market:
          return '1';
        case OrdType.Limit:
          return '2';
        case OrdType.Stop:
          return '3';
        case OrdType.StopLimit:
          return '4';
        case OrdType.MarketOnClose:
          return '5';
        case OrdType.WithOrWithout:
          return '6';
        case OrdType.LimitOrBetter:
          return '7';
        case OrdType.LimitWithOrWithout:
          return '8';
        case OrdType.OnBasis:
          return '9';
        case OrdType.OnClose:
          return 'A';
        case OrdType.LimitOnClose:
          return 'B';
        case OrdType.ForexMarket:
          return 'C';
        case OrdType.PreviouslyQuoted:
          return 'D';
        case OrdType.PreviouslyIndicated:
          return 'E';
        case OrdType.ForexLimit:
          return 'F';
        case OrdType.ForexSwap:
          return 'G';
        case OrdType.ForexPreviouslyQuoted:
          return 'H';
        case OrdType.Funari:
          return 'I';
        case OrdType.MIT:
          return 'J';
        case OrdType.MarketWithLeftoverAsLimit:
          return 'K';
        case OrdType.PreviousFundValuationPoint:
          return 'L';
        case OrdType.NextFundValuationPoint:
          return 'M';
        case OrdType.Pegged:
          return 'P';
        case OrdType.TrailingStop:
          return 'T';
        case OrdType.TrailingStopLimit:
          return 'S';
        default:
          throw new Exception(Ugjylcah9mCMM4kO7N.tLah92SpBQ(1912) + ((object) ordType).ToString());
      }
    }
  }
}

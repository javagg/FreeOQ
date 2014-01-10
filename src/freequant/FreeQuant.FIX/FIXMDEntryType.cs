using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXMDEntryType : FIXCharField
  {
    public const char Bid = '0';
    public const char Offer = '1';
    public const char Trade = '2';
    public const char Index = '3';
    public const char Open = '4';
    public const char Close = '5';
    public const char Settlement = '6';
    public const char High = '7';
    public const char Low = '8';
    public const char VWAP = '9';
    public const char Imbalance = 'A';

    public FIXMDEntryType(char val) : base(269, val)
    {
    }

    public static string ToString(char c)
    {
      switch (c)
      {
        case '0':
					return "Bid";
        case '1':
					return "Offer";
        case '2':
					return "Trade";
        case '3':
					return "Index";
        case '4':
					return "Open";
        case '5':
					return "Close";
        case '6':
					return "Settlement";
        case '7':
					return "High";
        case '8':
					return "Low";
        case '9':
					return "VWAP";
        case 'A':
					return "Imbalance";
        default:
					throw new ArgumentException("error: " + (object) c);
      }
    }
  }
}

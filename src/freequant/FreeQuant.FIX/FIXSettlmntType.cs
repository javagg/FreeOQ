using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSettlmntType : FIXCharField
  {
    public const char Regular = '0';
    public const char Cash = '1';
    public const char NextDay = '2';
    public const char Tplus2 = '3';
    public const char Tplus3 = '4';
    public const char Tplus4 = '5';
    public const char Future = '6';
    public const char WhenAndIfIssued = '7';
    public const char SellersOption = '8';
    public const char Tplus5 = '9';
    public const char Tplus1 = 'A';

    public FIXSettlmntType(char val):base(63, val)
    {
 
    }

    public static char Value(string Name)
    {
			if (Name == "Regular")
        return '0';
			if (Name == "Cash")
        return '1';
			if (Name == "NextDay")
        return '2';
			if (Name == "Tplus1" || Name == "T+1")
        return 'A';
			if (Name == "Tplus2" || Name == "T+2")
        return '3';
			if (Name == "Tplus3" || Name == "T+3")
        return '4';
			if (Name == "Tplus4" || Name == "T+4")
        return '5';
			if (Name == "Tplus5" || Name == "T+5")
        return '9';
			if (Name == "Future")
        return '6';
			if (Name == "WhenAndIfIssued")
        return '7';

			return Name == "SellersOption" ? '8' : char.MinValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ToString(char c)
    {
      switch (c)
      {
        case '0':
					return "Regular";
        case '1':
					return "Cash";
        case '2':
					return "NextDay";
        case '3':
					return "Tplus2";
        case '4':
					return "Tplus3";
        case '5':
					return "Tplus4";
        case '6':
					return "Future";
        case '7':
					return "WhenAndIfIssued";
        case '8':
					return "SellersOption";
        case '9':
					return "Tplus5";
        case 'A':
					return "Tplus1";
        default:
					return "invalid";
      }
    }
  }
}

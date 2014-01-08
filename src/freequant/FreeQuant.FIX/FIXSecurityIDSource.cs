using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSecurityIDSource : FIXCharField
  {
    public const char CUSIP = '1';
    public const char SEDOL = '2';
    public const char QUICK = '3';
    public const char ISIN = '4';
    public const char RIC = '5';
    public const char ISOCurrencyCode = '6';
    public const char ISOCountryCode = '7';
    public const char ExchangeSymbol = '8';
    public const char CTA = '9';
    public const char BloomberSymbol = 'A';
    public const char Wertpapier = 'B';
    public const char Dutch = 'C';
    public const char Valoren = 'D';
    public const char Sicovam = 'E';
    public const char Belgian = 'F';
    public const char Common = 'G';

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSecurityIDSource(char val)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector(22, val);
    }
  }
}

using FreeQuant;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
  public class CurrencyManager : MarshalByRefObject
  {
    private static CurrencyList Y9aWDcxadZ;

    public static CurrencyList Currencies
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return CurrencyManager.Y9aWDcxadZ;
      }
    }

    public static Currency DefaultCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return CurrencyManager.Y9aWDcxadZ[Framework.Configuration.DefaultCurrency];
      }
    }

    static CurrencyManager()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      CurrencyManager.Y9aWDcxadZ = new CurrencyList();
      Currency.vTnE26EIAD();
    }
  }
}

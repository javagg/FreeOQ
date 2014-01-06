// Type: SmartQuant.Instruments.CurrencyManager
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using SmartQuant;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Instruments
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    static CurrencyManager()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      CurrencyManager.Y9aWDcxadZ = new CurrencyList();
      Currency.vTnE26EIAD();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CurrencyManager()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}

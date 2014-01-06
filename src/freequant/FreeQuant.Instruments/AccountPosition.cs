// Type: SmartQuant.Instruments.AccountPosition
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using System;
using System.Runtime.CompilerServices;
using VFUvY5knK01pUIalDo;

namespace SmartQuant.Instruments
{
  [Serializable]
  public class AccountPosition
  {
    internal Currency XCdsDviLja;
    internal double y1ms0plk33;

    public Currency Currency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.XCdsDviLja;
      }
    }

    public double Value
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.y1ms0plk33;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AccountPosition(Currency currency)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.XCdsDviLja = currency;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return (string) (object) this.y1ms0plk33 + (object) gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(10918) + this.XCdsDviLja.Code;
    }
  }
}

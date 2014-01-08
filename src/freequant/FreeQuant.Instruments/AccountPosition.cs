using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
  [Serializable]
  public class AccountPosition
  {
    internal Currency XCdsDviLja;
    internal double y1ms0plk33;

    public Currency Currency
    {
       get
      {
        return this.XCdsDviLja;
      }
    }

    public double Value
    {
       get
      {
        return this.y1ms0plk33;
      }
    }

    public AccountPosition(Currency currency)
    {
      this.XCdsDviLja = currency;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return (string) (object) this.y1ms0plk33 + (object) gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(10918) + this.XCdsDviLja.Code;
    }
  }
}

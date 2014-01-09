using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXDatesGroup : FIXGroup
  {
    [FIXField("75", EFieldOption.Optional)]
    public DateTime TradeDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(75).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(75, value);
      }
    }

    [FIXField("60", EFieldOption.Optional)]
    public DateTime TransactTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(60).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(60, value);
      }
    }

   }
}

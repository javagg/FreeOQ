using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXTradesGroup : FIXGroup
  {
    [FIXField("571", EFieldOption.Optional)]
    public string TradeReportID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(571).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(571, value);
      }
    }

    [FIXField("818", EFieldOption.Optional)]
    public string SecondaryTradeReportID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(818).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(818, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXTradesGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}

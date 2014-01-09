using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXTradingSessionsGroup : FIXGroup
  {
    [FIXField("336", EFieldOption.Optional)]
    public string TradingSessionID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(336).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(336, value);
      }
    }

    [FIXField("625", EFieldOption.Optional)]
    public string TradingSessionSubID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(625).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(625, value);
      }
    }

  }
}

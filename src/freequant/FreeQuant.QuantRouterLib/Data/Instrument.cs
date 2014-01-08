using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Data
{
  public class Instrument
  {
    public string Symbol { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public string InstrumentType { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public string Exchange { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public string Currency { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public Instrument()
    {
      this.Symbol = string.Empty;
      this.InstrumentType = string.Empty;
      this.Exchange = string.Empty;
      this.Currency = string.Empty;
    }
  }
}

using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Data
{
  public class Subscription
  {
    public int RequestId { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public string Symbol { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public string Formula { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public Subscription()
    {
      this.RequestId = 0;
      this.Symbol = string.Empty;
      this.Formula = string.Empty;
    }
  }
}

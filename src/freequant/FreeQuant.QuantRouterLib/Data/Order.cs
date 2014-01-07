// Type: SmartQuant.QuantRouterLib.Data.Order
// Assembly: SmartQuant.QuantRouterLib, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: FDF277D6-C8FB-45C3-A0BD-1C1035F3B027
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.QuantRouterLib.dll

using NI8YCE6tH4BIeIEcEy;
using System.Runtime.CompilerServices;

namespace SmartQuant.QuantRouterLib.Data
{
  public class Order
  {
    public char OrdType { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public char Side { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public char TimeInForce { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public double Qty { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public double Price { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public double StopPx { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public string Account { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public string ClientId { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Order()
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrdType = char.MinValue;
      this.Side = char.MinValue;
      this.TimeInForce = char.MinValue;
      this.Qty = 0.0;
      this.Price = 0.0;
      this.StopPx = 0.0;
      this.Account = string.Empty;
      this.ClientId = string.Empty;
    }
  }
}

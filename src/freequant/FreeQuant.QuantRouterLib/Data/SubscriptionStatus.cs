using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Data
{
  public class SubscriptionStatus
  {
    public const byte Undefined = (byte) 0;
    public const byte Accepted = (byte) 1;
    public const byte Rejected = (byte) 2;
    public const byte Stopped = (byte) 3;

    public byte Status { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public string Text { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public SubscriptionStatus()
    {
      this.Status = (byte) 0;
      this.Text = string.Empty;
    }
  }
}

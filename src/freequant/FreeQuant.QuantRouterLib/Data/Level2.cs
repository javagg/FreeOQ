using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Data
{
  public class Level2 : Tick
  {
    public byte Side { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public byte Action { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public int Position { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

  }
}

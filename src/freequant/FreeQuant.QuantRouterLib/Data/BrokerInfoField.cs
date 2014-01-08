using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Data
{
  public class BrokerInfoField
  {
    public string Name { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public string Value { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    protected BrokerInfoField(string name, string value)
    {
      this.Name = name;
      this.Value = value;
    }
  }
}

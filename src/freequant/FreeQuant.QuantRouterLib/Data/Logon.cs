using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Data
{
  public class Logon
  {
    public string Username { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public string Password { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public Logon()
    {
      this.Username = string.Empty;
      this.Password = string.Empty;
    }
  }
}

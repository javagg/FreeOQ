using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Data
{
  public class LogonStatus
  {
    public bool IsLoggedIn { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public string Text { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public LogonStatus()
    {
      this.IsLoggedIn = false;
      this.Text = string.Empty;
    }
  }
}

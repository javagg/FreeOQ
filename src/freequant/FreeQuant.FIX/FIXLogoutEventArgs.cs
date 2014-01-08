using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXLogoutEventArgs : EventArgs
  {
    private FIXLogout IDW8P0TxWj;

    public FIXLogout Logout
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.IDW8P0TxWj;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.IDW8P0TxWj = value;
      }
    }

    public FIXLogoutEventArgs(FIXLogout Logout)
    {
      this.IDW8P0TxWj = Logout;
    }
  }
}

using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXLogonEventArgs : EventArgs
  {
    private FIXLogon mL6UplOUc8;

    public FIXLogon Logon
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.mL6UplOUc8;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.mL6UplOUc8 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXLogonEventArgs(FIXLogon Logon)
    {
      this.mL6UplOUc8 = Logon;
    }
  }
}

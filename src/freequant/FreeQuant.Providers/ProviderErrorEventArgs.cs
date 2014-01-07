using dW79p7NPlS6ZxObcx3;
using Obgh2s3A3GOOarwj6c;
using FreeQuant;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  public class ProviderErrorEventArgs : EventArgs
  {
    private ProviderError U6MLup0lIb;

    public ProviderError Error
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.U6MLup0lIb;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProviderErrorEventArgs(ProviderError error)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.U6MLup0lIb = error;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProviderErrorEventArgs(DateTime datetime, IProvider provider, int id, int code, string message)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      this.\u002Ector(new ProviderError(datetime, provider, id, code, message));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProviderErrorEventArgs(IProvider provider, int id, int code, string message)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      this.\u002Ector(new ProviderError(Clock.Now, provider, id, code, message));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return GojrKtfk5NMi1fou68.a17L2Y7Wnd(1188) + this.U6MLup0lIb.Provider.Name + Environment.NewLine + GojrKtfk5NMi1fou68.a17L2Y7Wnd(1212) + this.U6MLup0lIb.Id.ToString() + Environment.NewLine + GojrKtfk5NMi1fou68.a17L2Y7Wnd(1224) + this.U6MLup0lIb.Code.ToString() + Environment.NewLine + GojrKtfk5NMi1fou68.a17L2Y7Wnd(1240) + this.U6MLup0lIb.Message;
    }
  }
}

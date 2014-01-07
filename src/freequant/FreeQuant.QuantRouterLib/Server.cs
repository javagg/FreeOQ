// Type: SmartQuant.QuantRouterLib.Server
// Assembly: SmartQuant.QuantRouterLib, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: FDF277D6-C8FB-45C3-A0BD-1C1035F3B027
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.QuantRouterLib.dll

using NI8YCE6tH4BIeIEcEy;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SmartQuant.QuantRouterLib
{
  public class Server
  {
    private IConnectionAcceptor hpehZXQdk6;

    public ConnectionAcceptorState AcceptorState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.hpehZXQdk6.State;
      }
    }

    public event EventHandler AcceptorStateChanged;

    public event EventHandler<ConnectionEventArgs> ConnectionAccepted;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Server(IConnectionAcceptor acceptor)
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.hpehZXQdk6 = acceptor;
      acceptor.StateChanged += new EventHandler(this.vPChQclbed);
      acceptor.ConnectionAccepted += new EventHandler<ConnectionEventArgs>(this.eakhiQJEUE);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start(string connectionString)
    {
      this.hpehZXQdk6.Start(connectionString);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Stop()
    {
      this.hpehZXQdk6.Stop();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void vPChQclbed([In] object obj0, [In] EventArgs obj1)
    {
      if (this.sTPhXSa4kI == null)
        return;
      this.sTPhXSa4kI((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void eakhiQJEUE([In] object obj0, [In] ConnectionEventArgs obj1)
    {
      if (this.LonhJIL5Gh == null)
        return;
      this.LonhJIL5Gh((object) this, obj1);
    }
  }
}

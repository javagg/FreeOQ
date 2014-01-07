// Type: SmartQuant.QuantRouterLib.Tcp.TcpConnectionAcceptor
// Assembly: SmartQuant.QuantRouterLib, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: FDF277D6-C8FB-45C3-A0BD-1C1035F3B027
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.QuantRouterLib.dll

using gc3CLjxQUQtGJeILmm;
using NI8YCE6tH4BIeIEcEy;
using SmartQuant.QuantRouterLib;
using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SmartQuant.QuantRouterLib.Tcp
{
  public class TcpConnectionAcceptor : ConnectionAcceptor
  {
    public const int DEFAULT_PORT = 8883;
    private TcpListener CqSpavGFs;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TcpConnectionAcceptor()
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Start(string connectionString)
    {
      int port;
      if (!new ConnectionStringParser(connectionString).TryGetValue(Jqmkr5Pw3rRZ2LrRQr.KP3MGNG1bS(66), out port))
        port = 8883;
      this.CqSpavGFs = new TcpListener(IPAddress.Any, port);
      try
      {
        this.SetState(ConnectionAcceptorState.Starting);
        this.CqSpavGFs.Start();
        this.KauryJhJr();
        this.SetState(ConnectionAcceptorState.Started);
      }
      catch (Exception ex)
      {
        this.CqSpavGFs = (TcpListener) null;
        this.SetState(ConnectionAcceptorState.Stopped);
        throw ex;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Stop()
    {
      this.CqSpavGFs.Stop();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void KauryJhJr()
    {
      this.CqSpavGFs.BeginAcceptTcpClient(new AsyncCallback(this.c2Q2JKuqw), (object) this.CqSpavGFs);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void c2Q2JKuqw([In] IAsyncResult obj0)
    {
      TcpListener tcpListener = (TcpListener) obj0.AsyncState;
      try
      {
        TcpClient tcpClient = tcpListener.EndAcceptTcpClient(obj0);
        TcpConnection tcpConnection = new TcpConnection();
        tcpConnection.AOfaXfDTg(tcpClient);
        this.OnConnectionAccepted((IConnection) tcpConnection);
        this.KauryJhJr();
      }
      catch (Exception ex)
      {
      }
    }
  }
}

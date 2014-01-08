using FreeQuant.QuantRouterLib;
using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.QuantRouterLib.Tcp
{
  public class TcpConnectionAcceptor : ConnectionAcceptor
  {
    public const int DEFAULT_PORT = 8883;
    private TcpListener CqSpavGFs;

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

    public override void Stop()
    {
      this.CqSpavGFs.Stop();
    }

    private void KauryJhJr()
    {
      this.CqSpavGFs.BeginAcceptTcpClient(new AsyncCallback(this.c2Q2JKuqw), (object) this.CqSpavGFs);
    }

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

// Type: SmartQuant.QuantRouterLib.Tcp.TcpConnection
// Assembly: SmartQuant.QuantRouterLib, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: FDF277D6-C8FB-45C3-A0BD-1C1035F3B027
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.QuantRouterLib.dll

using gc3CLjxQUQtGJeILmm;
using NI8YCE6tH4BIeIEcEy;
using SmartQuant.QuantRouterLib;
using SmartQuant.QuantRouterLib.Messages;
using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace SmartQuant.QuantRouterLib.Tcp
{
  public class TcpConnection : Connection
  {
    private TcpClient RNl3aLUdD;
    private NetworkStream SlIRVIT0r;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TcpConnection()
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TcpConnection(string connectionString)
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      this.\u002Ector();
      this.ConnectionString = connectionString;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Open()
    {
      ConnectionStringParser connectionStringParser = new ConnectionStringParser(this.ConnectionString);
      string hostname = string.Empty;
      connectionStringParser.TryGetValue(Jqmkr5Pw3rRZ2LrRQr.KP3MGNG1bS(0), out hostname);
      int port = 0;
      connectionStringParser.TryGetValue(Jqmkr5Pw3rRZ2LrRQr.KP3MGNG1bS(12), out port);
      TcpClient tcpClient = new TcpClient();
      try
      {
        tcpClient.Connect(hostname, port);
        this.AOfaXfDTg(tcpClient);
      }
      catch (Exception ex)
      {
        this.SlIRVIT0r = (NetworkStream) null;
        throw ex;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Close()
    {
      try
      {
        byte[] bytes = BitConverter.GetBytes(-1);
        this.SlIRVIT0r.Write(bytes, 0, bytes.Length);
        this.SlIRVIT0r.Flush();
        ((Stream) this.SlIRVIT0r).Close();
        this.RNl3aLUdD.Close();
      }
      finally
      {
        this.SlIRVIT0r = (NetworkStream) null;
        this.RNl3aLUdD = (TcpClient) null;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Send(Message message)
    {
      this.Send(new Message[1]
      {
        message
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Send(Message[] messages)
    {
      try
      {
        lock (this)
        {
          MemoryStream local_0 = new MemoryStream();
          BinaryWriter local_1 = new BinaryWriter((Stream) local_0);
          foreach (Message item_0 in messages)
          {
            local_1.Write(item_0.Type);
            item_0.GetData(local_1);
          }
          local_1.Flush();
          byte[] local_3 = BitConverter.GetBytes((int) local_0.Length);
          this.SlIRVIT0r.Write(local_3, 0, local_3.Length);
          local_0.Position = 0L;
          local_0.CopyTo((Stream) this.SlIRVIT0r);
        }
      }
      catch (Exception ex)
      {
        this.Close();
        throw ex;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void AOfaXfDTg([In] TcpClient obj0)
    {
      this.RNl3aLUdD = obj0;
      this.SlIRVIT0r = obj0.GetStream();
      ManualResetEventSlim manualResetEventSlim = new ManualResetEventSlim(false);
      new Thread(new ParameterizedThreadStart(this.u6dkJQEvy))
      {
        Name = Jqmkr5Pw3rRZ2LrRQr.KP3MGNG1bS(24),
        IsBackground = true
      }.Start((object) manualResetEventSlim);
      manualResetEventSlim.Wait();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Yj7GgARTd([In] byte[] obj0)
    {
      MemoryStream memoryStream = new MemoryStream(obj0);
      memoryStream.Position = 0L;
      BinaryReader reader = new BinaryReader((Stream) memoryStream);
      while (reader.BaseStream.Position < reader.BaseStream.Length)
      {
        int type = reader.ReadInt32();
        if (type == -1)
          break;
        Message message = this.CreateMessage(type);
        message.SetData(reader);
        this.OnMessageReceived(message);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void u6dkJQEvy([In] object obj0)
    {
      ((ManualResetEventSlim) obj0).Set();
      try
      {
        BinaryReader binaryReader = new BinaryReader((Stream) this.SlIRVIT0r);
        while (true)
        {
          int count = binaryReader.ReadInt32();
          this.Yj7GgARTd(binaryReader.ReadBytes(count));
        }
      }
      catch (Exception ex)
      {
        if (ex.InnerException is SocketException && ((SocketException) ex.InnerException).SocketErrorCode == SocketError.Interrupted)
          return;
        this.OnError(ex);
      }
      finally
      {
        this.RNl3aLUdD = (TcpClient) null;
        this.SlIRVIT0r = (NetworkStream) null;
        this.OnClosed();
      }
    }
  }
}

// Type: SmartQuant.QuantRouterLib.Messages.MsgLogonStatus
// Assembly: SmartQuant.QuantRouterLib, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: FDF277D6-C8FB-45C3-A0BD-1C1035F3B027
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.QuantRouterLib.dll

using NI8YCE6tH4BIeIEcEy;
using SmartQuant.QuantRouterLib.Data;
using System.IO;
using System.Runtime.CompilerServices;

namespace SmartQuant.QuantRouterLib.Messages
{
  public class MsgLogonStatus : Message
  {
    public LogonStatus Data { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MsgLogonStatus()
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      base.\u002Ector(2);
      this.Data = new LogonStatus();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnGetData(BinaryWriter writer)
    {
      writer.Write(this.Data.IsLoggedIn);
      writer.Write(this.Data.Text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnSetData(BinaryReader reader)
    {
      this.Data.IsLoggedIn = reader.ReadBoolean();
      this.Data.Text = reader.ReadString();
    }
  }
}

// Type: SmartQuant.QuantRouterLib.Messages.MsgHeartbeat
// Assembly: SmartQuant.QuantRouterLib, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: FDF277D6-C8FB-45C3-A0BD-1C1035F3B027
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.QuantRouterLib.dll

using NI8YCE6tH4BIeIEcEy;
using SmartQuant.QuantRouterLib.Data;
using System.IO;
using System.Runtime.CompilerServices;

namespace SmartQuant.QuantRouterLib.Messages
{
  public class MsgHeartbeat : Message
  {
    public Heartbeat Data { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MsgHeartbeat()
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      this.\u002Ector(new Heartbeat());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MsgHeartbeat(Heartbeat hearbeat)
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      base.\u002Ector(3);
      this.Data = hearbeat;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnGetData(BinaryWriter writer)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnSetData(BinaryReader reader)
    {
    }
  }
}

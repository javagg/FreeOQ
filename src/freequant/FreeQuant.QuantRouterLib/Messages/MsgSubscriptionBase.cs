// Type: SmartQuant.QuantRouterLib.Messages.MsgSubscriptionBase
// Assembly: SmartQuant.QuantRouterLib, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: FDF277D6-C8FB-45C3-A0BD-1C1035F3B027
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.QuantRouterLib.dll

using NI8YCE6tH4BIeIEcEy;
using SmartQuant.QuantRouterLib.Data;
using System.IO;
using System.Runtime.CompilerServices;

namespace SmartQuant.QuantRouterLib.Messages
{
  public class MsgSubscriptionBase : Message
  {
    public Subscription Data { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected MsgSubscriptionBase(int type)
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      base.\u002Ector(type);
      this.Data = new Subscription();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnGetData(BinaryWriter writer)
    {
      writer.Write(this.Data.RequestId);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnSetData(BinaryReader reader)
    {
      this.Data.RequestId = reader.ReadInt32();
    }
  }
}

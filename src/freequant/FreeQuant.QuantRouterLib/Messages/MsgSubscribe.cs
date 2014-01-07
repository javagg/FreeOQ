// Type: SmartQuant.QuantRouterLib.Messages.MsgSubscribe
// Assembly: SmartQuant.QuantRouterLib, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: FDF277D6-C8FB-45C3-A0BD-1C1035F3B027
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.QuantRouterLib.dll

using NI8YCE6tH4BIeIEcEy;
using System.IO;
using System.Runtime.CompilerServices;

namespace SmartQuant.QuantRouterLib.Messages
{
  public class MsgSubscribe : MsgSubscriptionBase
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MsgSubscribe()
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      base.\u002Ector(10);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnGetData(BinaryWriter writer)
    {
      base.OnGetData(writer);
      writer.Write(this.Data.Symbol);
      writer.Write(this.Data.Formula);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnSetData(BinaryReader reader)
    {
      base.OnSetData(reader);
      this.Data.Symbol = reader.ReadString();
      this.Data.Formula = reader.ReadString();
    }
  }
}

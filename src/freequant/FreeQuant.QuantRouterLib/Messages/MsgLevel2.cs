// Type: SmartQuant.QuantRouterLib.Messages.MsgLevel2
// Assembly: SmartQuant.QuantRouterLib, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: FDF277D6-C8FB-45C3-A0BD-1C1035F3B027
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.QuantRouterLib.dll

using NI8YCE6tH4BIeIEcEy;
using SmartQuant.QuantRouterLib.Data;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace SmartQuant.QuantRouterLib.Messages
{
  public class MsgLevel2 : Message
  {
    public Level2 Data { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MsgLevel2(Level2 level2)
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      base.\u002Ector(1001);
      this.Data = level2;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MsgLevel2()
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      base.\u002Ector(1001);
      this.Data = new Level2();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnGetData(BinaryWriter writer)
    {
      writer.Write(this.Data.RequestId);
      writer.Write(this.Data.SourceId);
      writer.Write((byte) this.Data.TickType);
      writer.Write(this.Data.DateTime.Ticks);
      writer.Write(this.Data.Price);
      writer.Write(this.Data.Size);
      writer.Write(this.Data.Action);
      writer.Write(this.Data.Side);
      writer.Write(this.Data.Position);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnSetData(BinaryReader reader)
    {
      this.Data.RequestId = reader.ReadInt32();
      this.Data.SourceId = reader.ReadInt32();
      this.Data.TickType = (TickType) reader.ReadByte();
      this.Data.DateTime = new DateTime(reader.ReadInt64());
      this.Data.Price = reader.ReadDouble();
      this.Data.Size = reader.ReadInt32();
      this.Data.Action = reader.ReadByte();
      this.Data.Side = reader.ReadByte();
      this.Data.Position = reader.ReadInt32();
    }
  }
}

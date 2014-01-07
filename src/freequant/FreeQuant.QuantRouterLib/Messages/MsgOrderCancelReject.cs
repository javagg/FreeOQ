// Type: SmartQuant.QuantRouterLib.Messages.MsgOrderCancelReject
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
  public class MsgOrderCancelReject : Message
  {
    public OrderCancelReject Data { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MsgOrderCancelReject()
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      this.\u002Ector(new OrderCancelReject());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MsgOrderCancelReject(OrderCancelReject orderCancelReject)
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      base.\u002Ector(1102);
      this.Data = orderCancelReject;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnGetData(BinaryWriter writer)
    {
      writer.Write(this.Data.CommandId);
      writer.Write(this.Data.Text);
      writer.Write(this.Data.TransactTime.Ticks);
      writer.Write(this.Data.CxlRejReason);
      writer.Write(this.Data.CxlRejResponseTo);
      writer.Write(this.Data.OrderID);
      writer.Write(this.Data.OrdStatus);
      writer.Write(this.Data.OrigClOrdID);
      writer.Write(this.Data.ClOrdID);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnSetData(BinaryReader reader)
    {
      this.Data.CommandId = reader.ReadInt32();
      this.Data.Text = reader.ReadString();
      this.Data.TransactTime = new DateTime(reader.ReadInt64());
      this.Data.CxlRejReason = reader.ReadInt32();
      this.Data.CxlRejResponseTo = reader.ReadChar();
      this.Data.OrderID = reader.ReadString();
      this.Data.OrdStatus = reader.ReadChar();
      this.Data.OrigClOrdID = reader.ReadString();
      this.Data.ClOrdID = reader.ReadString();
    }
  }
}

// Type: SmartQuant.QuantRouterLib.Messages.MsgReport
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
  public class MsgReport : Message
  {
    public ExecutionReport Data { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MsgReport()
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      this.\u002Ector(new ExecutionReport());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MsgReport(ExecutionReport report)
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      base.\u002Ector(1101);
      this.Data = report;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnGetData(BinaryWriter writer)
    {
      writer.Write(this.Data.CommandId);
      writer.Write(this.Data.ExecType);
      writer.Write(this.Data.Text);
      writer.Write(this.Data.TransactTime.Ticks);
      writer.Write(this.Data.Order.Account);
      writer.Write(this.Data.Order.ClientId);
      writer.Write(this.Data.AvgPx);
      writer.Write(this.Data.Commission);
      writer.Write(this.Data.CommType);
      writer.Write(this.Data.CumQty);
      writer.Write(this.Data.LastPx);
      writer.Write(this.Data.LastQty);
      writer.Write(this.Data.LeavesQty);
      writer.Write(this.Data.Order.Side);
      writer.Write(this.Data.Order.OrdType);
      writer.Write(this.Data.OrdStatus);
      writer.Write(this.Data.Order.Price);
      writer.Write(this.Data.Order.Qty);
      writer.Write(this.Data.Order.StopPx);
      writer.Write(this.Data.Order.TimeInForce);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnSetData(BinaryReader reader)
    {
      this.Data.CommandId = reader.ReadInt32();
      this.Data.ExecType = reader.ReadChar();
      this.Data.Text = reader.ReadString();
      this.Data.TransactTime = new DateTime(reader.ReadInt64());
      this.Data.Order.Account = reader.ReadString();
      this.Data.Order.ClientId = reader.ReadString();
      this.Data.AvgPx = reader.ReadDouble();
      this.Data.Commission = reader.ReadDouble();
      this.Data.CommType = reader.ReadChar();
      this.Data.CumQty = reader.ReadDouble();
      this.Data.LastPx = reader.ReadDouble();
      this.Data.LastQty = reader.ReadDouble();
      this.Data.LeavesQty = reader.ReadDouble();
      this.Data.Order.Side = reader.ReadChar();
      this.Data.Order.OrdType = reader.ReadChar();
      this.Data.OrdStatus = reader.ReadChar();
      this.Data.Order.Price = reader.ReadDouble();
      this.Data.Order.Qty = reader.ReadDouble();
      this.Data.Order.StopPx = reader.ReadDouble();
      this.Data.Order.TimeInForce = reader.ReadChar();
    }
  }
}

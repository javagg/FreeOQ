using FreeQuant.QuantRouterLib.Data;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Messages
{
  public class MsgReport : Message
  {
    public ExecutionReport Data { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

	public MsgReport() : base(1101)
    {
    }

	public MsgReport(ExecutionReport report) : base(1101)
    {

      this.Data = report;
    }

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
